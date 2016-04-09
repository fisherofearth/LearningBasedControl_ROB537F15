using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.UI;

using ReadWriteCsv;

namespace NeuralNetworks
{
    public class NNs
    {
        public int I, J, K; // parameters of the NN
        public Matrix<double> Vij, Vj, Wkj, Wk; // contants of NN
        //public string filename = "NeuralNetworks.csv";
        public int len_Info = 5;
        

        public void InitializeContants()
        {
            Vij = new Matrix<double>(I, J);
            Vj = new Matrix<double>(1, J);
            Wkj = new Matrix<double>(K,J);
            Wk = new Matrix<double>(K, 1);
        }
/*
        private void ReadInfo()
        {
            int[] info = new int[len_Info];
            using (CsvFileReader reader = new CsvFileReader(filename))
            {
               
                CsvRow row = new CsvRow();
                for (int n = 0; n < len_Info; n++)
                {
                    reader.ReadRow(row);
                    foreach (string s in row)
                    {
                        info[n] = Convert.ToInt32(s);
                        break;
                    }
                }
            }
            I = info[0];
            J = info[1];
            K = info[2];
        }
        */
        public void ReadNN(string file)
        {
            using (CsvFileReader reader = new CsvFileReader(file))
            {
                CsvRow row = new CsvRow();

                // Read the info block
                int[] info = new int[len_Info];
                for (int n = 0; n < len_Info; n++)
                {
                    reader.ReadRow(row);
                    info[n] = Convert.ToInt32(row[0]);
                }
                I = info[0];
                J = info[1];
                K = info[2];

                InitializeContants();

                // read Vij
                for (int i = 0; i < I; i++)
                {
                    if (reader.ReadRow(row))
                    {
                        for (int j = 0; j < J; j++)
                            Vij[i, j] = Convert.ToDouble(row[j]);
                    }
                    else
                        break;
                }

                // read Vj
                if (reader.ReadRow(row))
                {
                    for (int j = 0; j < J; j++)
                        Vj[0, j] = Convert.ToDouble(row[j]);
                }

                // read Wkj
                for (int k = 0; k < K; k++)
                {
                    if (reader.ReadRow(row))
                    {
                        for (int j = 0; j < J; j++)
                            Wkj[k, j] = Convert.ToDouble(row[j]);
                    }
                    else
                        break;
                }

                // read Wk
                for (int k = 0; k < K; k++)
                {
                    if (reader.ReadRow(row))
                    {
                        Wk[k, 0] = Convert.ToDouble(row[0]);
                    }
                    else
                        break;
                }
            }
        }

        public void WriteNN(string file)
        {
            using (CsvFileWriter writer = new CsvFileWriter(file))
            {
                CsvRow row;

                // Write the info
                int[] info = new int[len_Info];
                info[0] = I;
                info[1] = J;
                info[2] = K;
                info[3] = 0;
                info[4] = 0;
                for (int n = 0; n < len_Info; n++)
                {
                    row = new CsvRow();
                    row.Add(info[n].ToString());
                    writer.WriteRow(row);
                }

               
                // Write Vij
                for (int i = 0; i < I; i++)
                {
                    row = new CsvRow();
                    for (int j = 0; j < J; j++)
                        row.Add(Vij[i, j].ToString());
                    writer.WriteRow(row);
                }

                // Write Vj
                row = new CsvRow();
                for (int j = 0; j < J; j++)
                    row.Add(Vj[0, j].ToString());
                writer.WriteRow(row);

                // Write Wkj
                for (int k = 0; k < K; k++)
                {
                    row = new CsvRow();
                    for (int j = 0; j < J; j++)
                        row.Add(Wkj[k, j].ToString());
                    writer.WriteRow(row);
                }

                // Write Wk
                for (int k = 0; k < K; k++)
                {
                    row = new CsvRow();
                    row.Add(Wk[k, 0].ToString());
                    writer.WriteRow(row);
                }
                
            }
        }

        public Matrix<double> PredictY(Matrix<double> X)
        {
            Matrix<double> A = Vij.Transpose() * X;
            A = SigmoidVec(A);
            A[0, 0] = 1; //set bias term  = 1

            return SigmoidVec(Wkj * A);
        }

        public double Sigmoid(double x)
        {
            return 1 / (1 + Math.Exp(-x));
        }
        public Matrix<double> SigmoidVec(Matrix<double> v)
        {
            Matrix<double> result = v.CopyBlank(); ;
            for (int i = 0; i < v.Rows; i++)
            {
                result[i, 0] = Sigmoid(v[i,0]);
            }
            return result;
        }

        } //end of class
}//end of namespace
