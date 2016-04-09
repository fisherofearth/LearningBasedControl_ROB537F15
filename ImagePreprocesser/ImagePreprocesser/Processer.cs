using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.UI;

namespace ImagePreprocesser
{
    public partial class Processer : Form
    {
 
        FileInfo[] inputFiles;
        FileInfo[] outputFiles;
        int num_saveImage = 0; // index of image saved

        bool flg_selectingRegion = false;

        Image<Bgr, Byte> inputImage;
        Bitmap outputImage;
        Rectangle selectedRegion;
        Point selectedRegionCenter;


        public Processer()
        {
            InitializeComponent();
            tbx_InputAddr.Text = AppDomain.CurrentDomain.BaseDirectory + "Input";
            tbx_OutputAddr.Text = AppDomain.CurrentDomain.BaseDirectory + "Output";
            LoadFiles(tbx_InputAddr.Text, "INPUT");
            LoadFiles(tbx_OutputAddr.Text, "OUTPUT");
    
        }


        private void listBox_Input_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayImage("INPUT");
        }

        private void listBox_Output_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayImage("OUTPUT");
        }

        private void btn_InputBrowse_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                tbx_InputAddr.Text = folderBrowserDialog1.SelectedPath;
            }
            LoadFiles(tbx_InputAddr.Text, "INPUT");
        }

        

        private void btn_OutputBrowse_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                tbx_OutputAddr.Text = folderBrowserDialog1.SelectedPath;
            }

            LoadFiles(tbx_OutputAddr.Text, "OUTPUT");
        }

        private void pbx_View_MouseUp(object sender, MouseEventArgs e)
        {
            tbx_ImgInfo.Text = e.Location.ToString();

        }



   
        void LoadFiles(string path, string directiong)
        {
            int i;
            int num;
            if (directiong == "INPUT")
            {
                try
                {
                    listBox_Input.Items.Clear();
                
                    DirectoryInfo foldername = new DirectoryInfo(path);
                    inputFiles = foldername.GetFiles();
                    num = inputFiles.Length;
                    if (num > 0)
                    {
                        for (i = 0; i < num; i++)
                        {
                            listBox_Input.Items.Add(inputFiles[i].Name);
                        }
                        listBox_Input.SelectedIndex = 0;
                    }
                }
                catch
                {
                   // MessageBox.Show("找不到文件目录", "Error");
                }
            }
            else{
                try
                {
                    listBox_Output.Items.Clear();
                
                    DirectoryInfo foldername = new DirectoryInfo(path);
                    outputFiles = foldername.GetFiles();
                    num = outputFiles.Length;
                    if (num > 0)
                    {
                        for (i = 0; i < num; i++)
                        {
                            listBox_Output.Items.Add(outputFiles[i].Name);
                        }
                            listBox_Output.SelectedIndex = 0;
                    }
                }
                catch
                {
                   // MessageBox.Show("找不到文件目录", "Error");
                }
            }



        }



        public void DisplayImage(string dirct)
        {
            if (dirct == "INPUT")
            {
                inputImage = new Image<Bgr, Byte>(new Bitmap(inputFiles[listBox_Input.SelectedIndex].FullName));
                ibx_InputView.Image = inputImage;
            }
            else
            {
                outputImage = new Bitmap(outputFiles[listBox_Output.SelectedIndex].FullName);
                pbx_OutputView.Image = outputImage;
            }
        }

        int fileNum = 1;
        void SaveImage(Bitmap MyBitmap)
        {
            //Bitmap MyBitmap = new Bitmap(inputFiles[listBox_Input.SelectedIndex].FullName);

            string fileName = "\\" + tbx_SaveAs.Text + fileNum.ToString() + ".bmp";
            try
            {
                MyBitmap.Save(tbx_OutputAddr.Text + fileName, System.Drawing.Imaging.ImageFormat.Bmp);
                fileNum++;
            }
            catch
            {
                
            }
                
        }

        
        void SelectRegion_Center(Point mouseLocation)
        {
            if (flg_selectingRegion == true)//2nd clicking
            {
                flg_selectingRegion = false;

                selectedRegion.X = selectedRegionCenter.X - Math.Abs(mouseLocation.X - selectedRegionCenter.X);
                selectedRegion.Y = selectedRegionCenter.Y - Math.Abs(mouseLocation.Y - selectedRegionCenter.Y);

                selectedRegion.Width = 2 * Math.Abs(mouseLocation.X - selectedRegionCenter.X);
                selectedRegion.Height = 2 * Math.Abs(mouseLocation.Y - selectedRegionCenter.Y);

                //if (mouseLocation.X > inputImage.Width) mouseLocation.X = inputImage.Width;
                //if (mouseLocation.Y > inputImage.Height) mouseLocation.Y = inputImage.Height;

                ibx_InputView.Image = inputImage;

                Image<Bgr, Byte> image = new Image<Bgr, Byte>(new Bitmap(inputFiles[listBox_Input.SelectedIndex].FullName));
                image.ROI = selectedRegion;
                SaveImage(image.ToBitmap());
                LoadFiles(tbx_OutputAddr.Text, "OUTPUT");
                //listBox_Output.SelectedIndex = fileNum-2;

            }
            else//1st clicking
            {
                flg_selectingRegion = true;
                selectedRegionCenter = mouseLocation;


            }
        }


        private void Processer_Load(object sender, EventArgs e)
        {

        }

        private void ibx_InputView_MouseUp(object sender, MouseEventArgs e)
        {
            tbx_ImgInfo.Text = e.Location.ToString();

            SelectRegion_Center(e.Location);
       
            //ibx_InputView.Image = inputImage;
            //SaveImage();
            //LoadFiles(tbx_OutputAddr.Text, "OUTPUT");
        }

        private void ibx_InputView_MouseMove(object sender, MouseEventArgs e)
        {
            if (flg_selectingRegion == true)//when selecting
            {

                Image<Bgr, Byte> image = new Image<Bgr, Byte>(new Bitmap(inputFiles[listBox_Input.SelectedIndex].FullName));

                selectedRegion.X = selectedRegionCenter.X - Math.Abs(e.X - selectedRegionCenter.X);
                selectedRegion.Y = selectedRegionCenter.Y - Math.Abs(e.Y - selectedRegionCenter.Y);

                selectedRegion.Width = 2 * Math.Abs(e.X - selectedRegionCenter.X);
                selectedRegion.Height = 2 * Math.Abs(e.Y - selectedRegionCenter.Y);

                image.Draw(selectedRegion, new Bgr(Color.Blue), 1);

                ibx_InputView.Image = image;
            }
            else
            {

            }
        }

        private void btn_ClrOutputs_Click(object sender, EventArgs e)
        {
            int i;
            int num;
        //    string a = tbx_OutputAddr.Text + "\\";
          //  a = a    + outputFiles[0].Name;
          //  File.Delete(a);
            try
            {
                //listBox_Output.Items.Clear();

                
                num = outputFiles.Length;
                if (num > 0)
                {
                    for (i = 0; i < num; i++)
                    {
                        outputFiles[i].Delete();
                        //File.Delete("@"+outputFiles[i].FullName);
                        //listBox_Output.Items.Add(outputFiles[i].Name);
                    }
                    //listBox_Output.SelectedIndex = 0;
                }
            }
            catch
            {

            }
        }

        private void btn_Reload_Click(object sender, EventArgs e)
        {
            LoadFiles(tbx_OutputAddr.Text, "OUTPUT");
        }


    }
}
