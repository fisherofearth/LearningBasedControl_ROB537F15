using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.UI;

using NeuralNetworks;
using ClassLib;

namespace Detector
{
    public partial class Form1 : Form
    {
        // Initialize the variables
        Image<Bgr, byte> img_origianl;
        Matrix<Byte> temperature;
        Image<Bgr, byte> img_segment;
        double resizeScale;

        NNs NN = new NNs();

        // 
        FeatureDetector FD = new FeatureDetector();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            hsb_Threshold.Value = 128;
            lb_Threshold.Text = hsb_Threshold.Value.ToString();
            txb_InputNN.Text = "NeuralNetworks.csv";
            txb_InputFile.Text = "test.png";


            tbx_NNOutputFile.Text = "NeuralNetworks.csv";
            tbx_TrainSamplePath_Interesting.Text = AppDomain.CurrentDomain.BaseDirectory + "IMG_Intrstng";
            tbx_TrainSamplePath_Boring.Text = AppDomain.CurrentDomain.BaseDirectory + "IMG_Boring";

            Matrix<double> test = new Matrix<double>(2, 2);
            test[0, 0] = 1;
            test[0, 1] = 2;
            test[1, 0] = 3;
            test[1, 1] = 4;

            test = (3 - test) * 0.1;

            Matrix<double> test2 = new Matrix<double>(2,1) ;
             test.GetCol(1).CopyTo(test2);
        }

        private void btn_InputFileBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                txb_InputFile.Text = open.FileName;
            }
        }

        private void btn_InputNNBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                txb_InputNN.Text = open.FileName;
            }
        }

        private void hsb_Threshold_Scroll(object sender, ScrollEventArgs e)
        {
            lb_Threshold.Text = hsb_Threshold.Value.ToString();
            UpdateSegmentImage();
        }

        private void btn_Run_Click(object sender, EventArgs e)
        {
            try { NN.ReadNN(txb_InputNN.Text); }
            catch { MessageBox.Show("error"); }

            Detecting();
            //try { Detecting(); }
            //catch { MessageBox.Show("error"); }
        }



        /// <summary>
        /// Function to detect the interesting region
        /// </summary>
        private void Detecting()
        {
            // load the original image
            img_origianl = new Image<Bgr, byte>(txb_InputFile.Text);

            // Compute the temperature map
            temperature = new Matrix<byte>(img_origianl.Size);

            InterestDetect idetector = new InterestDetect();
            idetector.scale = Convert.ToDouble(textBox1.Text);
            idetector.DetectInterest(img_origianl,NN);
            temperature = idetector.ComputeHeatPhoto();

            //Matrix < double> y_hat=  NN.PredictY(FD.features);
            //richTextBox1.Text = y_hat[0, 0].ToString();

            /*
            // for testing
            int W = temperature.Width;
            int H = temperature.Height;
            for (int x = W / 2; x < W - 1; x++)
            {
                for (int y= H / 2; y < H - 1; y++)
                {
                    double dist = EuclideanDistance(new Point(W/2,H/2), new Point(x, y));
                    double value = Math.Exp((-dist) / (2 * 1000));
                    temperature[y, x] = (byte)(Math.Round(value * 255, 1));
                    temperature[H-y, W-x] = (byte)(Math.Round(value * 255, 1));
                    temperature[y, W - x] = (byte)(Math.Round(value * 255, 1));
                    temperature[H - y, x] = (byte)(Math.Round(value * 255, 1));
                }
            }
            */

            // Compute displaying scale
            resizeScale = Convert.ToDouble(imb_OrginalImage.Height) / Convert.ToDouble(img_origianl.Height);

            // Display the original image
            imb_OrginalImage.Image = img_origianl.Resize(resizeScale, INTER.CV_INTER_LINEAR);

            // Display the temperature map
            Image<Gray, byte> img_temperature = new Image<Gray, byte>(temperature.Size);
            temperature.CopyTo(img_temperature);
            imb_Temperature.Image = img_temperature.Resize(resizeScale, INTER.CV_INTER_LINEAR);

            // Display the segmentation result
            // Apply the temperature map to segment the original image
            UpdateSegmentImage();
        }

        /// <summary>
        /// Update and Display the segmentation results
        /// </summary>
        private void UpdateSegmentImage()
        {
            double weight;
            int W = temperature.Width;
            int H = temperature.Height;
            img_segment = img_origianl.CopyBlank();
            img_origianl.CopyTo(img_segment);



            for (int x = 0; x < W; x++)
            {
                for (int y = 0; y < H; y++)
                {

                    if (ckb_ApplyThreshold.Checked == false)
                    {
                        weight = Convert.ToDouble(temperature[y, x]) / 255f;
                    }
                    else
                    {
                        if (temperature[y, x] < hsb_Threshold.Value) // if temp. is too low
                        {
                            weight = 0.1;
                        }
                        else
                        {
                            weight = 1;
                        }
                    }
                    img_segment[y, x] = new Bgr(
                          img_segment[y, x].Blue * weight,
                          img_segment[y, x].Green * weight,
                          img_segment[y, x].Red * weight
                          );

                }
            }
            imb_Segment.Image = img_segment.Resize(resizeScale, INTER.CV_INTER_LINEAR);

        }

        double EuclideanDistance(Point p1, Point p2)
        {
            return Math.Pow(p1.X - p2.X, 2) + Math.Pow(p1.Y - p2.Y, 2);
        }

        private void ckb_ApplyThreshold_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSegmentImage();
        }



        #region Learner
        private void btn_NNOutputPathBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                tbx_NNOutputFile.Text = open.FileName;
            }
        }

        private void btn_InterestingPathBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            if (FBD.ShowDialog() == DialogResult.OK)
            {
                tbx_TrainSamplePath_Interesting.Text = FBD.SelectedPath;
            }
        }

        private void btn_BoringPathBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            if (FBD.ShowDialog() == DialogResult.OK)
            {
                tbx_TrainSamplePath_Boring.Text = FBD.SelectedPath;
            }
        }
        private void btn_Train_Click(object sender, EventArgs e)
        {
            Learner learner = new Learner();
            learner.Train(tbx_NNOutputFile.Text,
                tbx_TrainSamplePath_Interesting.Text,
                tbx_TrainSamplePath_Boring.Text,
                Convert.ToInt16(txb_NumberOfNode.Text)
                );
            learner.nns.WriteNN(tbx_NNOutputFile.Text);
        }

        #endregion
    }
}
