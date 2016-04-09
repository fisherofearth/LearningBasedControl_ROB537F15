namespace Proj537F15
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
            ((System.ComponentModel.ISupportInitialize)(this.imb_Segment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imb_Temperature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imb_OrginalImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 55;
            this.label1.Text = "Features:";
            // 
            // btn_Run
            // 
            this.btn_Run.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Run.Location = new System.Drawing.Point(540, 336);
            this.btn_Run.Name = "btn_Run";
            this.btn_Run.Size = new System.Drawing.Size(104, 42);
            this.btn_Run.TabIndex = 54;
            this.btn_Run.Text = "Run";
            this.btn_Run.UseVisualStyleBackColor = true;
            this.btn_Run.Click += new System.EventHandler(this.btn_Run_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 289);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(183, 185);
            this.richTextBox1.TabIndex = 53;
            this.richTextBox1.Text = "";
            // 
            // imb_Segment
            // 
            this.imb_Segment.BackColor = System.Drawing.SystemColors.WindowText;
            this.imb_Segment.Location = new System.Drawing.Point(664, 26);
            this.imb_Segment.Name = "imb_Segment";
            this.imb_Segment.Size = new System.Drawing.Size(320, 240);
            this.imb_Segment.TabIndex = 52;
            this.imb_Segment.TabStop = false;
            // 
            // imb_Temperature
            // 
            this.imb_Temperature.BackColor = System.Drawing.SystemColors.WindowText;
            this.imb_Temperature.Location = new System.Drawing.Point(338, 26);
            this.imb_Temperature.Name = "imb_Temperature";
            this.imb_Temperature.Size = new System.Drawing.Size(320, 240);
            this.imb_Temperature.TabIndex = 51;
            this.imb_Temperature.TabStop = false;
            // 
            // imb_OrginalImage
            // 
            this.imb_OrginalImage.BackColor = System.Drawing.SystemColors.WindowText;
            this.imb_OrginalImage.Location = new System.Drawing.Point(12, 26);
            this.imb_OrginalImage.Name = "imb_OrginalImage";
            this.imb_OrginalImage.Size = new System.Drawing.Size(320, 240);
            this.imb_OrginalImage.TabIndex = 39;
            this.imb_OrginalImage.TabStop = false;
            // 
            // lb_Threshold
            // 
            this.lb_Threshold.AutoSize = true;
            this.lb_Threshold.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Threshold.ForeColor = System.Drawing.SystemColors.Window;
            this.lb_Threshold.Location = new System.Drawing.Point(949, 269);
            this.lb_Threshold.Name = "lb_Threshold";
            this.lb_Threshold.Size = new System.Drawing.Size(16, 17);
            this.lb_Threshold.TabIndex = 50;
            this.lb_Threshold.Text = "0";
            // 
            // hsb_Threshold
            // 
            this.hsb_Threshold.Location = new System.Drawing.Point(664, 269);
            this.hsb_Threshold.Maximum = 255;
            this.hsb_Threshold.Name = "hsb_Threshold";
            this.hsb_Threshold.Size = new System.Drawing.Size(277, 17);
            this.hsb_Threshold.TabIndex = 49;
            this.hsb_Threshold.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hsb_Threshold_Scroll);
            // 
            // lb_Segment
            // 
            this.lb_Segment.AutoSize = true;
            this.lb_Segment.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Segment.ForeColor = System.Drawing.SystemColors.Window;
            this.lb_Segment.Location = new System.Drawing.Point(783, 6);
            this.lb_Segment.Name = "lb_Segment";
            this.lb_Segment.Size = new System.Drawing.Size(122, 17);
            this.lb_Segment.TabIndex = 48;
            this.lb_Segment.Text = "Interest Segment";
            // 
            // lb_Temperature
            // 
            this.lb_Temperature.AutoSize = true;
            this.lb_Temperature.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Temperature.ForeColor = System.Drawing.SystemColors.Window;
            this.lb_Temperature.Location = new System.Drawing.Point(439, 6);
            this.lb_Temperature.Name = "lb_Temperature";
            this.lb_Temperature.Size = new System.Drawing.Size(150, 17);
            this.lb_Temperature.TabIndex = 47;
            this.lb_Temperature.Text = "Interest Temperature";
            // 
            // lb_OrignalImage
            // 
            this.lb_OrignalImage.AutoSize = true;
            this.lb_OrignalImage.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_OrignalImage.ForeColor = System.Drawing.SystemColors.Window;
            this.lb_OrignalImage.Location = new System.Drawing.Point(110, 6);
            this.lb_OrignalImage.Name = "lb_OrignalImage";
            this.lb_OrignalImage.Size = new System.Drawing.Size(102, 17);
            this.lb_OrignalImage.TabIndex = 46;
            this.lb_OrignalImage.Text = "Orignal Image";
            // 
            // btn_InputNNBrowse
            // 
            this.btn_InputNNBrowse.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_InputNNBrowse.Location = new System.Drawing.Point(909, 507);
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
            this.btn_InputFileBrowse.Location = new System.Drawing.Point(909, 477);
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
            this.lb_InputNN.Location = new System.Drawing.Point(9, 506);
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
            this.lb_InputFile.Location = new System.Drawing.Point(9, 480);
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
            this.txb_InputNN.Location = new System.Drawing.Point(105, 506);
            this.txb_InputNN.Name = "txb_InputNN";
            this.txb_InputNN.Size = new System.Drawing.Size(797, 22);
            this.txb_InputNN.TabIndex = 41;
            // 
            // txb_InputFile
            // 
            this.txb_InputFile.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txb_InputFile.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txb_InputFile.ForeColor = System.Drawing.SystemColors.Window;
            this.txb_InputFile.Location = new System.Drawing.Point(105, 480);
            this.txb_InputFile.Name = "txb_InputFile";
            this.txb_InputFile.Size = new System.Drawing.Size(797, 22);
            this.txb_InputFile.TabIndex = 40;
            // 
            // ckb_ApplyThreshold
            // 
            this.ckb_ApplyThreshold.AutoSize = true;
            this.ckb_ApplyThreshold.Location = new System.Drawing.Point(664, 291);
            this.ckb_ApplyThreshold.Name = "ckb_ApplyThreshold";
            this.ckb_ApplyThreshold.Size = new System.Drawing.Size(80, 17);
            this.ckb_ApplyThreshold.TabIndex = 56;
            this.ckb_ApplyThreshold.Text = "checkBox1";
            this.ckb_ApplyThreshold.UseVisualStyleBackColor = true;
            this.ckb_ApplyThreshold.CheckedChanged += new System.EventHandler(this.ckb_ApplyThreshold_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1043, 592);
            this.Controls.Add(this.ckb_ApplyThreshold);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Run);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.imb_Segment);
            this.Controls.Add(this.imb_Temperature);
            this.Controls.Add(this.imb_OrginalImage);
            this.Controls.Add(this.lb_Threshold);
            this.Controls.Add(this.hsb_Threshold);
            this.Controls.Add(this.lb_Segment);
            this.Controls.Add(this.lb_Temperature);
            this.Controls.Add(this.lb_OrignalImage);
            this.Controls.Add(this.btn_InputNNBrowse);
            this.Controls.Add(this.btn_InputFileBrowse);
            this.Controls.Add(this.lb_InputNN);
            this.Controls.Add(this.lb_InputFile);
            this.Controls.Add(this.txb_InputNN);
            this.Controls.Add(this.txb_InputFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imb_Segment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imb_Temperature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imb_OrginalImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

