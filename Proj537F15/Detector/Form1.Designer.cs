namespace Detector
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Run = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.imb_Segment = new Emgu.CV.UI.ImageBox();
            this.imb_Temperature = new Emgu.CV.UI.ImageBox();
            this.imb_OrginalImage = new Emgu.CV.UI.ImageBox();
            this.lb_Threshold = new System.Windows.Forms.Label();
            this.hsb_Threshold = new System.Windows.Forms.HScrollBar();
            this.lb_Segment = new System.Windows.Forms.Label();
            this.lb_Temperature = new System.Windows.Forms.Label();
            this.lb_OrignalImage = new System.Windows.Forms.Label();
            this.btn_InputNNBrowse = new System.Windows.Forms.Button();
            this.btn_InputFileBrowse = new System.Windows.Forms.Button();
            this.lb_InputNN = new System.Windows.Forms.Label();
            this.lb_InputFile = new System.Windows.Forms.Label();
            this.txb_InputNN = new System.Windows.Forms.TextBox();
            this.txb_InputFile = new System.Windows.Forms.TextBox();
            this.ckb_ApplyThreshold = new System.Windows.Forms.CheckBox();
            this.tbx_TrainSamplePath_Interesting = new System.Windows.Forms.TextBox();
            this.tbx_NNOutputFile = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Detector = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Learner = new System.Windows.Forms.TabPage();
            this.txb_NumberOfNode = new System.Windows.Forms.TextBox();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rtbx_learningInfo = new System.Windows.Forms.RichTextBox();
            this.btn_Train = new System.Windows.Forms.Button();
            this.btn_BoringPathBrowse = new System.Windows.Forms.Button();
            this.btn_InterestingPathBrowse = new System.Windows.Forms.Button();
            this.btn_NNOutputPathBrowse = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_TrainSamplePath_Boring = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.imb_Segment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imb_Temperature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imb_OrginalImage)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.Detector.SuspendLayout();
            this.Learner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(285, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 55;
            this.label1.Text = "Features:";
            // 
            // btn_Run
            // 
            this.btn_Run.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Run.Location = new System.Drawing.Point(342, 287);
            this.btn_Run.Name = "btn_Run";
            this.btn_Run.Size = new System.Drawing.Size(320, 64);
            this.btn_Run.TabIndex = 54;
            this.btn_Run.Text = "Run";
            this.btn_Run.UseVisualStyleBackColor = true;
            this.btn_Run.Click += new System.EventHandler(this.btn_Run_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(16, 287);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(320, 64);
            this.richTextBox1.TabIndex = 53;
            this.richTextBox1.Text = "";
            // 
            // imb_Segment
            // 
            this.imb_Segment.BackColor = System.Drawing.SystemColors.Window;
            this.imb_Segment.Location = new System.Drawing.Point(993, 27);
            this.imb_Segment.Name = "imb_Segment";
            this.imb_Segment.Size = new System.Drawing.Size(480, 240);
            this.imb_Segment.TabIndex = 52;
            this.imb_Segment.TabStop = false;
            // 
            // imb_Temperature
            // 
            this.imb_Temperature.BackColor = System.Drawing.SystemColors.Window;
            this.imb_Temperature.Location = new System.Drawing.Point(507, 27);
            this.imb_Temperature.Name = "imb_Temperature";
            this.imb_Temperature.Size = new System.Drawing.Size(480, 240);
            this.imb_Temperature.TabIndex = 51;
            this.imb_Temperature.TabStop = false;
            // 
            // imb_OrginalImage
            // 
            this.imb_OrginalImage.BackColor = System.Drawing.SystemColors.Window;
            this.imb_OrginalImage.Location = new System.Drawing.Point(16, 27);
            this.imb_OrginalImage.Name = "imb_OrginalImage";
            this.imb_OrginalImage.Size = new System.Drawing.Size(480, 240);
            this.imb_OrginalImage.TabIndex = 39;
            this.imb_OrginalImage.TabStop = false;
            // 
            // lb_Threshold
            // 
            this.lb_Threshold.AutoSize = true;
            this.lb_Threshold.BackColor = System.Drawing.SystemColors.WindowText;
            this.lb_Threshold.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Threshold.ForeColor = System.Drawing.SystemColors.Window;
            this.lb_Threshold.Location = new System.Drawing.Point(969, 290);
            this.lb_Threshold.Name = "lb_Threshold";
            this.lb_Threshold.Size = new System.Drawing.Size(16, 17);
            this.lb_Threshold.TabIndex = 50;
            this.lb_Threshold.Text = "0";
            // 
            // hsb_Threshold
            // 
            this.hsb_Threshold.Location = new System.Drawing.Point(668, 287);
            this.hsb_Threshold.Maximum = 255;
            this.hsb_Threshold.Name = "hsb_Threshold";
            this.hsb_Threshold.Size = new System.Drawing.Size(296, 20);
            this.hsb_Threshold.TabIndex = 49;
            this.hsb_Threshold.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hsb_Threshold_Scroll);
            // 
            // lb_Segment
            // 
            this.lb_Segment.AutoSize = true;
            this.lb_Segment.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Segment.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lb_Segment.Location = new System.Drawing.Point(1161, 7);
            this.lb_Segment.Name = "lb_Segment";
            this.lb_Segment.Size = new System.Drawing.Size(142, 17);
            this.lb_Segment.TabIndex = 48;
            this.lb_Segment.Text = "Interesting Segment";
            // 
            // lb_Temperature
            // 
            this.lb_Temperature.AutoSize = true;
            this.lb_Temperature.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Temperature.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lb_Temperature.Location = new System.Drawing.Point(677, 7);
            this.lb_Temperature.Name = "lb_Temperature";
            this.lb_Temperature.Size = new System.Drawing.Size(139, 17);
            this.lb_Temperature.TabIndex = 47;
            this.lb_Temperature.Text = "Interest Heat Photo";
            // 
            // lb_OrignalImage
            // 
            this.lb_OrignalImage.AutoSize = true;
            this.lb_OrignalImage.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_OrignalImage.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lb_OrignalImage.Location = new System.Drawing.Point(190, 7);
            this.lb_OrignalImage.Name = "lb_OrignalImage";
            this.lb_OrignalImage.Size = new System.Drawing.Size(102, 17);
            this.lb_OrignalImage.TabIndex = 46;
            this.lb_OrignalImage.Text = "Orignal Image";
            // 
            // btn_InputNNBrowse
            // 
            this.btn_InputNNBrowse.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_InputNNBrowse.Location = new System.Drawing.Point(913, 390);
            this.btn_InputNNBrowse.Name = "btn_InputNNBrowse";
            this.btn_InputNNBrowse.Size = new System.Drawing.Size(72, 24);
            this.btn_InputNNBrowse.TabIndex = 45;
            this.btn_InputNNBrowse.Text = "Browse...";
            this.btn_InputNNBrowse.UseVisualStyleBackColor = true;
            this.btn_InputNNBrowse.Click += new System.EventHandler(this.btn_InputNNBrowse_Click);
            // 
            // btn_InputFileBrowse
            // 
            this.btn_InputFileBrowse.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_InputFileBrowse.Location = new System.Drawing.Point(913, 360);
            this.btn_InputFileBrowse.Name = "btn_InputFileBrowse";
            this.btn_InputFileBrowse.Size = new System.Drawing.Size(72, 24);
            this.btn_InputFileBrowse.TabIndex = 44;
            this.btn_InputFileBrowse.Text = "Browse...";
            this.btn_InputFileBrowse.UseVisualStyleBackColor = true;
            this.btn_InputFileBrowse.Click += new System.EventHandler(this.btn_InputFileBrowse_Click);
            // 
            // lb_InputNN
            // 
            this.lb_InputNN.AutoSize = true;
            this.lb_InputNN.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_InputNN.ForeColor = System.Drawing.SystemColors.Window;
            this.lb_InputNN.Location = new System.Drawing.Point(13, 389);
            this.lb_InputNN.Name = "lb_InputNN";
            this.lb_InputNN.Size = new System.Drawing.Size(74, 17);
            this.lb_InputNN.TabIndex = 43;
            this.lb_InputNN.Text = "Input NN:";
            // 
            // lb_InputFile
            // 
            this.lb_InputFile.AutoSize = true;
            this.lb_InputFile.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_InputFile.ForeColor = System.Drawing.SystemColors.Window;
            this.lb_InputFile.Location = new System.Drawing.Point(13, 363);
            this.lb_InputFile.Name = "lb_InputFile";
            this.lb_InputFile.Size = new System.Drawing.Size(77, 17);
            this.lb_InputFile.TabIndex = 42;
            this.lb_InputFile.Text = "Input File:";
            // 
            // txb_InputNN
            // 
            this.txb_InputNN.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txb_InputNN.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txb_InputNN.ForeColor = System.Drawing.SystemColors.Window;
            this.txb_InputNN.Location = new System.Drawing.Point(109, 389);
            this.txb_InputNN.Name = "txb_InputNN";
            this.txb_InputNN.Size = new System.Drawing.Size(797, 22);
            this.txb_InputNN.TabIndex = 41;
            // 
            // txb_InputFile
            // 
            this.txb_InputFile.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txb_InputFile.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txb_InputFile.ForeColor = System.Drawing.SystemColors.Window;
            this.txb_InputFile.Location = new System.Drawing.Point(109, 363);
            this.txb_InputFile.Name = "txb_InputFile";
            this.txb_InputFile.Size = new System.Drawing.Size(797, 22);
            this.txb_InputFile.TabIndex = 40;
            // 
            // ckb_ApplyThreshold
            // 
            this.ckb_ApplyThreshold.AutoSize = true;
            this.ckb_ApplyThreshold.Location = new System.Drawing.Point(668, 312);
            this.ckb_ApplyThreshold.Name = "ckb_ApplyThreshold";
            this.ckb_ApplyThreshold.Size = new System.Drawing.Size(102, 17);
            this.ckb_ApplyThreshold.TabIndex = 56;
            this.ckb_ApplyThreshold.Text = "Apply Threshold";
            this.ckb_ApplyThreshold.UseVisualStyleBackColor = true;
            this.ckb_ApplyThreshold.CheckedChanged += new System.EventHandler(this.ckb_ApplyThreshold_CheckedChanged);
            // 
            // tbx_TrainSamplePath_Interesting
            // 
            this.tbx_TrainSamplePath_Interesting.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tbx_TrainSamplePath_Interesting.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbx_TrainSamplePath_Interesting.ForeColor = System.Drawing.SystemColors.Window;
            this.tbx_TrainSamplePath_Interesting.Location = new System.Drawing.Point(137, 39);
            this.tbx_TrainSamplePath_Interesting.Name = "tbx_TrainSamplePath_Interesting";
            this.tbx_TrainSamplePath_Interesting.Size = new System.Drawing.Size(758, 22);
            this.tbx_TrainSamplePath_Interesting.TabIndex = 58;
            // 
            // tbx_NNOutputFile
            // 
            this.tbx_NNOutputFile.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tbx_NNOutputFile.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbx_NNOutputFile.ForeColor = System.Drawing.SystemColors.Window;
            this.tbx_NNOutputFile.Location = new System.Drawing.Point(137, 13);
            this.tbx_NNOutputFile.Name = "tbx_NNOutputFile";
            this.tbx_NNOutputFile.Size = new System.Drawing.Size(758, 22);
            this.tbx_NNOutputFile.TabIndex = 57;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Detector);
            this.tabControl1.Controls.Add(this.Learner);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1510, 447);
            this.tabControl1.TabIndex = 59;
            // 
            // Detector
            // 
            this.Detector.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Detector.Controls.Add(this.label5);
            this.Detector.Controls.Add(this.textBox1);
            this.Detector.Controls.Add(this.imb_OrginalImage);
            this.Detector.Controls.Add(this.txb_InputFile);
            this.Detector.Controls.Add(this.txb_InputNN);
            this.Detector.Controls.Add(this.ckb_ApplyThreshold);
            this.Detector.Controls.Add(this.lb_InputFile);
            this.Detector.Controls.Add(this.label1);
            this.Detector.Controls.Add(this.lb_InputNN);
            this.Detector.Controls.Add(this.btn_Run);
            this.Detector.Controls.Add(this.btn_InputFileBrowse);
            this.Detector.Controls.Add(this.richTextBox1);
            this.Detector.Controls.Add(this.btn_InputNNBrowse);
            this.Detector.Controls.Add(this.imb_Segment);
            this.Detector.Controls.Add(this.lb_OrignalImage);
            this.Detector.Controls.Add(this.imb_Temperature);
            this.Detector.Controls.Add(this.lb_Temperature);
            this.Detector.Controls.Add(this.lb_Segment);
            this.Detector.Controls.Add(this.lb_Threshold);
            this.Detector.Controls.Add(this.hsb_Threshold);
            this.Detector.Location = new System.Drawing.Point(4, 22);
            this.Detector.Name = "Detector";
            this.Detector.Padding = new System.Windows.Forms.Padding(3);
            this.Detector.Size = new System.Drawing.Size(1502, 421);
            this.Detector.TabIndex = 0;
            this.Detector.Text = "Detector";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(912, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 58;
            this.label5.Text = "Scale:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(955, 326);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(30, 20);
            this.textBox1.TabIndex = 57;
            this.textBox1.Text = "10";
            // 
            // Learner
            // 
            this.Learner.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Learner.Controls.Add(this.txb_NumberOfNode);
            this.Learner.Controls.Add(this.imageBox1);
            this.Learner.Controls.Add(this.dataGridView1);
            this.Learner.Controls.Add(this.rtbx_learningInfo);
            this.Learner.Controls.Add(this.btn_Train);
            this.Learner.Controls.Add(this.btn_BoringPathBrowse);
            this.Learner.Controls.Add(this.btn_InterestingPathBrowse);
            this.Learner.Controls.Add(this.btn_NNOutputPathBrowse);
            this.Learner.Controls.Add(this.label4);
            this.Learner.Controls.Add(this.label3);
            this.Learner.Controls.Add(this.label2);
            this.Learner.Controls.Add(this.tbx_TrainSamplePath_Boring);
            this.Learner.Controls.Add(this.tbx_NNOutputFile);
            this.Learner.Controls.Add(this.tbx_TrainSamplePath_Interesting);
            this.Learner.Location = new System.Drawing.Point(4, 22);
            this.Learner.Name = "Learner";
            this.Learner.Padding = new System.Windows.Forms.Padding(3);
            this.Learner.Size = new System.Drawing.Size(1000, 421);
            this.Learner.TabIndex = 1;
            this.Learner.Text = "Learner";
            // 
            // txb_NumberOfNode
            // 
            this.txb_NumberOfNode.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txb_NumberOfNode.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txb_NumberOfNode.ForeColor = System.Drawing.SystemColors.Window;
            this.txb_NumberOfNode.Location = new System.Drawing.Point(926, 163);
            this.txb_NumberOfNode.Name = "txb_NumberOfNode";
            this.txb_NumberOfNode.Size = new System.Drawing.Size(47, 22);
            this.txb_NumberOfNode.TabIndex = 69;
            this.txb_NumberOfNode.Text = "5";
            // 
            // imageBox1
            // 
            this.imageBox1.Location = new System.Drawing.Point(476, 163);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(241, 252);
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 164);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(461, 251);
            this.dataGridView1.TabIndex = 68;
            // 
            // rtbx_learningInfo
            // 
            this.rtbx_learningInfo.Location = new System.Drawing.Point(9, 97);
            this.rtbx_learningInfo.Name = "rtbx_learningInfo";
            this.rtbx_learningInfo.Size = new System.Drawing.Size(791, 60);
            this.rtbx_learningInfo.TabIndex = 67;
            this.rtbx_learningInfo.Text = "";
            // 
            // btn_Train
            // 
            this.btn_Train.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Train.Location = new System.Drawing.Point(806, 97);
            this.btn_Train.Name = "btn_Train";
            this.btn_Train.Size = new System.Drawing.Size(167, 60);
            this.btn_Train.TabIndex = 66;
            this.btn_Train.Text = "Train";
            this.btn_Train.UseVisualStyleBackColor = true;
            this.btn_Train.Click += new System.EventHandler(this.btn_Train_Click);
            // 
            // btn_BoringPathBrowse
            // 
            this.btn_BoringPathBrowse.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BoringPathBrowse.Location = new System.Drawing.Point(901, 67);
            this.btn_BoringPathBrowse.Name = "btn_BoringPathBrowse";
            this.btn_BoringPathBrowse.Size = new System.Drawing.Size(72, 24);
            this.btn_BoringPathBrowse.TabIndex = 65;
            this.btn_BoringPathBrowse.Text = "Browse...";
            this.btn_BoringPathBrowse.UseVisualStyleBackColor = true;
            this.btn_BoringPathBrowse.Click += new System.EventHandler(this.btn_BoringPathBrowse_Click);
            // 
            // btn_InterestingPathBrowse
            // 
            this.btn_InterestingPathBrowse.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_InterestingPathBrowse.Location = new System.Drawing.Point(901, 36);
            this.btn_InterestingPathBrowse.Name = "btn_InterestingPathBrowse";
            this.btn_InterestingPathBrowse.Size = new System.Drawing.Size(72, 24);
            this.btn_InterestingPathBrowse.TabIndex = 64;
            this.btn_InterestingPathBrowse.Text = "Browse...";
            this.btn_InterestingPathBrowse.UseVisualStyleBackColor = true;
            this.btn_InterestingPathBrowse.Click += new System.EventHandler(this.btn_InterestingPathBrowse_Click);
            // 
            // btn_NNOutputPathBrowse
            // 
            this.btn_NNOutputPathBrowse.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NNOutputPathBrowse.Location = new System.Drawing.Point(901, 11);
            this.btn_NNOutputPathBrowse.Name = "btn_NNOutputPathBrowse";
            this.btn_NNOutputPathBrowse.Size = new System.Drawing.Size(72, 24);
            this.btn_NNOutputPathBrowse.TabIndex = 63;
            this.btn_NNOutputPathBrowse.Text = "Browse...";
            this.btn_NNOutputPathBrowse.UseVisualStyleBackColor = true;
            this.btn_NNOutputPathBrowse.Click += new System.EventHandler(this.btn_NNOutputPathBrowse_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(6, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 62;
            this.label4.Text = "Boring Path:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(6, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 17);
            this.label3.TabIndex = 61;
            this.label3.Text = "Interesting Path:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(6, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 17);
            this.label2.TabIndex = 60;
            this.label2.Text = "NN Output File:";
            // 
            // tbx_TrainSamplePath_Boring
            // 
            this.tbx_TrainSamplePath_Boring.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tbx_TrainSamplePath_Boring.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbx_TrainSamplePath_Boring.ForeColor = System.Drawing.SystemColors.Window;
            this.tbx_TrainSamplePath_Boring.Location = new System.Drawing.Point(137, 67);
            this.tbx_TrainSamplePath_Boring.Name = "tbx_TrainSamplePath_Boring";
            this.tbx_TrainSamplePath_Boring.Size = new System.Drawing.Size(758, 22);
            this.tbx_TrainSamplePath_Boring.TabIndex = 59;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1774, 468);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "InterestDetector V2.2.3";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imb_Segment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imb_Temperature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imb_OrginalImage)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.Detector.ResumeLayout(false);
            this.Detector.PerformLayout();
            this.Learner.ResumeLayout(false);
            this.Learner.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Run;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private Emgu.CV.UI.ImageBox imb_Segment;
        private Emgu.CV.UI.ImageBox imb_Temperature;
        private Emgu.CV.UI.ImageBox imb_OrginalImage;
        private System.Windows.Forms.Label lb_Threshold;
        private System.Windows.Forms.HScrollBar hsb_Threshold;
        private System.Windows.Forms.Label lb_Segment;
        private System.Windows.Forms.Label lb_Temperature;
        private System.Windows.Forms.Label lb_OrignalImage;
        private System.Windows.Forms.Button btn_InputNNBrowse;
        private System.Windows.Forms.Button btn_InputFileBrowse;
        private System.Windows.Forms.Label lb_InputNN;
        private System.Windows.Forms.Label lb_InputFile;
        private System.Windows.Forms.TextBox txb_InputNN;
        private System.Windows.Forms.TextBox txb_InputFile;
        private System.Windows.Forms.CheckBox ckb_ApplyThreshold;
        private System.Windows.Forms.TextBox tbx_TrainSamplePath_Interesting;
        private System.Windows.Forms.TextBox tbx_NNOutputFile;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Detector;
        private System.Windows.Forms.TabPage Learner;
        private System.Windows.Forms.TextBox tbx_TrainSamplePath_Boring;
        private System.Windows.Forms.Button btn_BoringPathBrowse;
        private System.Windows.Forms.Button btn_InterestingPathBrowse;
        private System.Windows.Forms.Button btn_NNOutputPathBrowse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtbx_learningInfo;
        private System.Windows.Forms.Button btn_Train;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Emgu.CV.UI.ImageBox imageBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txb_NumberOfNode;
        private System.Windows.Forms.Label label5;
    }
}

