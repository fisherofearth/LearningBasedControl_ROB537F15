using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.UI;

using Detector;
using NeuralNetworks;

namespace Detector
{
    public class Learner
    {
        public NNs nns = new NNs();
        private string iPath, bPath;
        public int TrainTimes = 200;
        public double learningRate = 0.3;
        
        public Matrix<double> XX;
        public Matrix<double> YY;
        private FeatureDetector FD = new FeatureDetector();

        public Image<Rgb, byte> testImg;

        public void Train(string NNsFilenale, string IPath, string BPath, int num_node)
        {
            iPath = IPath;
            bPath = BPath;

            #region initial the neural networks
            InitializeNN(0.1, num_node);
            #endregion

            GetTranSamples();
            List<int> order = new List<int>();
            for (int i = 0; i < XX.Cols; i++) { order.Add(i); }

            #region training
            Matrix<double> Y = new Matrix<double>(nns.K, 1);
            Matrix<double> Y_hat = new Matrix<double>(nns.K,1);
            Matrix<double> A = new Matrix<double>(nns.J,1);
            Matrix<double> X = new Matrix<double>(nns.I,1);
            Matrix<double> deltaW = new Matrix<double>(nns.K, 1);
            Matrix<double> deltaV = new Matrix<double>(nns.J, 1);

            A[0,0] = 1;//bias term

            for (int t = 0; t < TrainTimes; t++)
            {
                //randomly sort samples
                Random rnd = new Random();
                order = order.OrderBy(i => rnd.Next()).ToList();
                foreach (int ord in order)
                {
                    XX.GetCol(ord).CopyTo(X);
                    YY.GetCol(ord).CopyTo(Y);
                    Y_hat = nns.PredictY(X);

                    #region compute delta
                    deltaW = ((Y_hat - Y) * Y_hat) * (1 - Y_hat);
                    A = nns.SigmoidVec( nns.Vij.Transpose() * X);
                    A[0, 0] = 1; //set bias term  = 1
                    deltaV[0, 0] = 1;
                    for (int j = 1; j < nns.J; j++)
                    {
                        deltaV[j, 0] = 0;
                        for (int k = 0; k < nns.K; k++) { deltaV[j, 0] += deltaW[k, 0] * nns.Wkj[k, j] * A[j, 0] * (1 - A[j, 0]); }
                    }
                    #endregion

                    #region update weights
                    for(int k = 0; k < nns.K; k++)
                    {
                        for(int j = 0; j < nns.J; j++)
                        {
                            nns.Wkj[k, j] = nns.Wkj[k, j] - (learningRate * deltaW[k, 0] * A[j,0]);
                        }
                    }

                    for (int j = 1; j < nns.J; j++)
                    {
                        for(int i = 0; i < nns.I; i++)
                        {
                            nns.Vij[i, j] = nns.Vij[i, j] - (learningRate * deltaV[j, 0]*X[i,0]);
                        }
                    }
                    #endregion
                }
            }
            #endregion


        }

        private void GetTranSamples()
        {
            FileInfo[] iFiles;
            FileInfo[] bFiles;
            DirectoryInfo foldername;

            foldername = new DirectoryInfo(iPath);
            iFiles = foldername.GetFiles();
            foldername = new DirectoryInfo(bPath);
            bFiles = foldername.GetFiles();
            XX = new Matrix<double>(nns.I,iFiles.Length+bFiles.Length);

            for (int c = 0; c < iFiles.Length; c++)
            {
                FD.DetectFeature(new Image<Bgr, byte>(iFiles[c].FullName));

                for (int r = 0; r < XX.Rows; r++)
                {
                    XX[r, c] = FD.features[r, 0];
                }
            }
            for (int c = 0; c < bFiles.Length; c++)
            {
                FD.DetectFeature(new Image<Bgr, byte>(bFiles[c].FullName));
                for (int r = 0; r < XX.Rows; r++)
                {
                    XX[r, c + iFiles.Length] = FD.features[r, 0];
                }
            }

            YY = new Matrix<double>(nns.K, iFiles.Length + bFiles.Length);
            double[] il = { 1d };
            double[] bl = { 0d };
            for (int i = 0; i < iFiles.Length; i++) { YY[0,i] = 1d;  }
            for (int i = iFiles.Length; i < XX.Cols; i++) { YY[0,i] = 0d; }
        }

        public void InitializeNN(double initValue, int num_node)
        {
            nns.I = 8+1;
            nns.J = num_node + 1;
            nns.K = 1;
            nns.InitializeContants();//set to be zero

            for(int j = 0;j< nns.J;j++)
            {
                for(int k = 0;k< nns.K; k++)
                {
                    nns.Wkj[k,j] = initValue;
                }
                for(int i= 0;i< nns.I; i++)
                {
                    nns.Vij[i, j] = initValue;
                }

            }
        }



    }
}
