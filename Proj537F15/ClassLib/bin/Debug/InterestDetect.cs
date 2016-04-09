using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV;
using Emgu.CV.Structure;
using System.Drawing;

using NeuralNetworks;

namespace Detector
{
    public class InterestDetect
    {
        public Image<Bgr, byte> orignalImage;
        public List<Rectangle> ROIList;
        public List<double> InterestList;
        public Matrix<byte> temperature;
        public double scale = 10;

        private FeatureDetector FD = new FeatureDetector();
        
        private double DetectInterest_unit(Rectangle rect_ROI, NNs nns)
        {
            Image<Bgr, byte> img = orignalImage.Copy(rect_ROI);
            FD.DetectFeature(img);
            Matrix<double> y_hat = nns.PredictY(FD.features);
            return y_hat[0, 0]; 
        }

        public void DetectInterest(Image<Bgr, byte> image, NNs nns)
        {
            orignalImage = image;

            int H = orignalImage.Size.Height;
            int W = orignalImage.Size.Width;
            int CX = W / 2;
            int CY = H / 2;

            #region Set ROI list
            ROIList = new List<Rectangle>();
            Size rectSize;
            int unit;
            /*
            int T = ((H / 50) + (W / 50)) ;
            for (int s = 1; s < T; s++)
            {
                unit = 25 * s;
                rectSize = new Size(50 * s, 50 * s);
                if (rectSize.Height <= H && rectSize.Width <= W)
                {
                    int Hs = ((H - rectSize.Height) / unit) ;
                    int Ws = ((W - rectSize.Width) / unit);
                    for (int x = 0; x < Ws; x++)
                        for (int y = 0; y < Hs; y++)
                            ROIList.Add(new Rectangle(x * unit, y * unit, rectSize.Width, rectSize.Height));
                }
            }
            */

            rectSize = new Size(50, 50);
            
            int u = 30;
            Point loc;
            Size whSize;
            while (rectSize.Width < (W- u) && rectSize.Height<(H- u))
            {
                loc = new Point(CX - (rectSize.Width / 2), CY - (rectSize.Height / 2));
                whSize = rectSize;
                ROIList.Add(new Rectangle(loc, whSize));

                
                ROIList.Add(new Rectangle(0,        0,              loc.X,          loc.Y ));
                ROIList.Add(new Rectangle(loc.X,    0,              whSize.Width,   loc.Y ));
                ROIList.Add(new Rectangle(loc.X+whSize.Width,   
                                                    0,              loc.X - 2,      loc.Y ));

                ROIList.Add(new Rectangle(0,        loc.Y,          loc.X,          whSize.Height));
                ROIList.Add(new Rectangle(loc.X+whSize.Width,   
                                                    loc.Y,          loc.X - 2,      whSize.Height));

                ROIList.Add(new Rectangle(0,        loc.Y+whSize.Height,    
                                                                    loc.X,          loc.Y - 2));
                ROIList.Add(new Rectangle(loc.X,    loc.Y + whSize.Height,
                                                                    whSize.Width,   loc.Y - 2));
                ROIList.Add(new Rectangle(loc.X + whSize.Width, 
                                                    loc.Y + whSize.Height,   
                                                                    loc.X - 2,      loc.Y - 2));

                rectSize.Width += u;
                rectSize.Height += u;
            }
            

            #endregion

            #region Compute interest list
            InterestList = new List<double>();
            foreach (Rectangle RoI in ROIList)
            {
                InterestList.Add(DetectInterest_unit(RoI, nns));
            }
            #endregion
        }

        public Matrix<byte> ComputeHeatPhoto()
        {
            Matrix<double> TMap = new Matrix<double>(orignalImage.Size);
            temperature = new Matrix<byte>(orignalImage.Size);

            int i = 0;
            foreach (Rectangle RoI in ROIList)
            {
                for (int x = 0; x < RoI.Width; x++)
                {
                    for (int y = 0; y < RoI.Height; y++)
                    { TMap[RoI.Y + y, RoI.X + x] += InterestList[i]; }
                    
                }
                i++;
            }
            double min, max;
            Point minPoint, maxPoint;
            /*
            TMap.MinMax(out min,out max,out minPoint, out maxPoint);
            TMap = TMap - min;
            TMap.MinMax(out min, out max, out minPoint, out maxPoint);
            TMap = (TMap / max)* 255;
            */
            max = 0.01;
            for (int r = 0; r < TMap.Rows; r++)
            {
                for (int c = 0; c < TMap.Cols; c++)
                {
                    if (TMap[r, c] > max) max = TMap[r, c];
                }
            }
            //TMap = (TMap / max) * 255;
            TMap = (TMap / scale) * 255;

            for (int r = 0; r < TMap.Rows; r++)
            {
                for (int c = 0; c < TMap.Cols; c++)
                {
                    if (TMap[r, c] <= 255)
                    {
                        temperature[r, c] = Convert.ToByte(TMap[r, c]);
                    }
                    else
                        temperature[r, c] = 255;
                }
            }
            return temperature;
        }
    }
}
