using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

using Emgu.CV;
using Emgu.CV.Structure;
using System.Diagnostics;

namespace Detector
{
    public class FeatureDetector
    {
        // Define Feature
        public double[] ft_bgr = new double[3];// continous feature, 0~1 of [b, g, r percentage]
        public double[] ft_shape = new double[3]; // binary feature [circle, triangle, rectangle]
        public double[] ft_edge = new double[2];// continous feature 0~1, [NumOfEdge/Pixl totalLengthOfEdge/Pixel]
        public double[] ft_light = new double[2];//continous feature 0~1,[shadeArea/totoalArea highlight/totoalArea]
        public double[] ft_face = new double[1]; //continous feature 0~1,[probability of detecting face in a image]
        
        public double[] features = new double[10];

        public int DetectFeature(Image<Bgr, byte> img)
        {
            double[] ftr = new double[100];
            int c = 0;
            DetectBGR(img);
            for (int i = 0; i < ft_bgr.Length; i++) { ftr[c] = ft_bgr[i]; c++; }
            DetectShape(img);
            for (int i = 0; i < ft_shape.Length; i++) { ftr[c] = ft_shape[i]; c++; }
            for (int i = 0; i < ft_edge.Length; i++) { ftr[c] = ft_edge[i]; c++; }
            DetectLight(img);
            for (int i = 0; i < ft_light.Length; i++) { ftr[c] = ft_light[i]; c++; }
            DetectFace(img);
            for (int i = 0; i < ft_face.Length; i++) { ftr[c] = ft_face[i]; c++; }

            features = new double[c];
            for (int i = 0; i < c; i++) { features[i] = ftr[i]; }
            return c;
        }


        public void DetectBGR(Image<Bgr,byte> img)
        {
            int W = img.Size.Width;
            int H = img.Size.Height;

           
            double[] bgr = new double[] { 0, 0, 0 };
            

            for(int x=0;x<W;x++)
            {
                for(int y = 0; y< H;y++)
                {
                    bgr[0] += Convert.ToDouble(img[y,x].Blue);
                    bgr[1] += Convert.ToDouble(img[y, x].Green);
                    bgr[2] += Convert.ToDouble(img[y, x].Red);
                }
            }
            double sum = bgr[0] + bgr[1] + bgr[2];
            ft_bgr[0] = bgr[0] / sum;
            ft_bgr[1] = bgr[1] / sum;
            ft_bgr[2] = bgr[2] / sum;
        }

        public void DetectShape(Image<Bgr, byte> img)
        {
            StringBuilder msgBuilder = new StringBuilder("Performance: ");

            //Convert the image to grayscale and filter out the noise
            Image<Gray, Byte> gray = img.Convert<Gray, Byte>().PyrDown().PyrUp();

            #region circle detection
            Stopwatch watch = Stopwatch.StartNew();
            double cannyThreshold = 180.0;
            double circleAccumulatorThreshold = 120;
            CircleF[] circles = gray.HoughCircles(
                new Gray(cannyThreshold),
                new Gray(circleAccumulatorThreshold),
                2.0, //Resolution of the accumulator used to detect centers of the circles
                20.0, //min distance 
                5, //min radius
                0 //max radius
                )[0]; //Get the circles from the first channel
            watch.Stop();
            msgBuilder.Append(String.Format("Hough circles - {0} ms; ", watch.ElapsedMilliseconds));
            #endregion

            #region Canny and edge detection
            watch.Reset(); watch.Start();
            double cannyThresholdLinking = 120.0;
            Image<Gray, Byte> cannyEdges = gray.Canny(cannyThreshold, cannyThresholdLinking);
            LineSegment2D[] lines = cannyEdges.HoughLinesBinary(
                1, //Distance resolution in pixel-related units
                Math.PI / 45.0, //Angle resolution measured in radians.
                20, //threshold
                30, //min Line width
                10 //gap between lines
                )[0]; //Get the lines from the first channel
            watch.Stop();
            msgBuilder.Append(String.Format("Canny & Hough lines - {0} ms; ", watch.ElapsedMilliseconds));
            #endregion

            #region Find triangles and rectangles
            watch.Reset(); watch.Start();
            List<Triangle2DF> triangleList = new List<Triangle2DF>();
            List<MCvBox2D> boxList = new List<MCvBox2D>(); //a box is a rotated rectangle
            using (MemStorage storage = new MemStorage()) //allocate storage for contour approximation
                for (
                   Contour<Point> contours = cannyEdges.FindContours(
                      Emgu.CV.CvEnum.CHAIN_APPROX_METHOD.CV_CHAIN_APPROX_SIMPLE,
                      Emgu.CV.CvEnum.RETR_TYPE.CV_RETR_LIST,
                      storage);
                   contours != null;
                   contours = contours.HNext)
                {
                    Contour<Point> currentContour = contours.ApproxPoly(contours.Perimeter * 0.05, storage);

                    if (currentContour.Area > 250) //only consider contours with area greater than 250
                    {
                        if (currentContour.Total == 3) //The contour has 3 vertices, it is a triangle
                        {
                            Point[] pts = currentContour.ToArray();
                            triangleList.Add(new Triangle2DF(
                               pts[0],
                               pts[1],
                               pts[2]
                               ));
                        }
                        else if (currentContour.Total == 4) //The contour has 4 vertices.
                        {
                            #region determine if all the angles in the contour are within [80, 100] degree
                            bool isRectangle = true;
                            Point[] pts = currentContour.ToArray();
                            LineSegment2D[] edges = PointCollection.PolyLine(pts, true);

                            for (int i = 0; i < edges.Length; i++)
                            {
                                double angle = Math.Abs(
                                   edges[(i + 1) % edges.Length].GetExteriorAngleDegree(edges[i]));
                                if (angle < 80 || angle > 100)
                                {
                                    isRectangle = false;
                                    break;
                                }
                            }
                            #endregion

                            if (isRectangle) boxList.Add(currentContour.GetMinAreaRect());
                        }
                    }
                }
            watch.Stop();
            msgBuilder.Append(String.Format("Triangles & Rectangles - {0} ms; ", watch.ElapsedMilliseconds));
            #endregion


            if (circles.Length > 0) ft_shape[0] = 1;
            else ft_shape[0] = 0;

            if (triangleList.Count > 0) ft_shape[1] = 1;
            else ft_shape[1] = 0;

            if (boxList.Count > 0) ft_shape[2] = 1;
            else ft_shape[2] = 0;

            double A = Convert.ToDouble(img.Width) * Convert.ToDouble(img.Width);
            double len_Length = 0;
            foreach (LineSegment2D line in lines)
            {
                len_Length += line.Length;
            }
            ft_edge[0] =(Convert.ToDouble(lines.Length) / A )*1000;
            if (ft_edge[0] > 1) ft_edge[0] = 1;

            ft_edge[1] =(len_Length / A) * 10;
            if (ft_edge[1] > 1) ft_edge[1] = 1;
        }

        public void DetectEdge(Image<Bgr, byte> img)
        {
        }
        public void DetectLight(Image<Bgr, byte> img)
        {
        }
        public void DetectFace(Image<Bgr, byte> img)
        {
        }

    }
}
