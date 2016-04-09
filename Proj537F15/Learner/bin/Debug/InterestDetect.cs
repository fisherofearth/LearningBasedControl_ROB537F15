using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV;
using Emgu.CV.Structure;
using System.Drawing;

namespace Detector
{
    public class InterestDetect
    {
        public Image<Bgr, byte> orignalImage;
        public List<Rectangle> ROIList;
        public List<double[]> InterestList;

        private FeatureDetector FD = new FeatureDetector();
        private Size rectSize = new Size( 100, 100);
        private int unit = 50;

        private double[] DetectInterest_unit(Rectangle rect_ROI)
        {
           
            
            return FD.features; 
        }
        
        public void DetectInterest(Image<Bgr,byte> image)
        {
            orignalImage = image;

            int H = orignalImage.Size.Height;
            int W = orignalImage.Size.Width;

            int Hs = ((H - rectSize.Height) / unit) + 1;
            int Ws = ((W - rectSize.Width) / unit) + 1;

            ROIList.Clear();
            for (int x = 0;x< Ws;x++)
                for(int y = 0;y< Hs;y++)
                    ROIList.Add(new Rectangle(x * unit, y * unit, rectSize.Width, rectSize.Height));
           

            InterestList.Clear();
            foreach (Rectangle rect in ROIList)
                InterestList.Add(DetectInterest_unit(rect));
        }

    }
}
