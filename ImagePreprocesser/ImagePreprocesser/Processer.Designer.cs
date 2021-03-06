﻿namespace ImagePreprocesser
{
    partial class Processer
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
            this.listBox_Input = new System.Windows.Forms.ListBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tbx_InputAddr = new System.Windows.Forms.TextBox();
            this.tbx_OutputAddr = new System.Windows.Forms.TextBox();
            this.lb_InputAddr = new System.Windows.Forms.Label();
            this.lb_OutputAddr = new System.Windows.Forms.Label();
            this.btn_InputBrowse = new System.Windows.Forms.Button();
            this.btn_OutputBrowse = new System.Windows.Forms.Button();
            this.gbx_Operation = new System.Windows.Forms.GroupBox();
            this.btn_Reload = new System.Windows.Forms.Button();
            this.btn_ClrOutputs = new System.Windows.Forms.Button();
            this.lbx_SaveAs = new System.Windows.Forms.Label();
            this.tbx_SaveAs = new System.Windows.Forms.TextBox();
            this.listBox_Output = new System.Windows.Forms.ListBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.tbx_ImgInfo = new System.Windows.Forms.TextBox();
            this.pbx_OutputView = new System.Windows.Forms.PictureBox();
            this.ibx_InputView = new Emgu.CV.UI.ImageBox();
            this.gbx_Operation.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_OutputView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibx_InputView)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_Input
            // 
            this.listBox_Input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.listBox_Input.ForeColor = System.Drawing.SystemColors.Window;
            this.listBox_Input.FormattingEnabled = true;
            this.listBox_Input.Location = new System.Drawing.Point(832, 17);
            this.listBox_Input.Name = "listBox_Input";
            this.listBox_Input.Size = new System.Drawing.Size(136, 589);
            this.listBox_Input.TabIndex = 0;
            this.listBox_Input.SelectedIndexChanged += new System.EventHandler(this.listBox_Input_SelectedIndexChanged);
            // 
            // tbx_InputAddr
            // 
            this.tbx_InputAddr.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tbx_InputAddr.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbx_InputAddr.ForeColor = System.Drawing.SystemColors.Window;
            this.tbx_InputAddr.Location = new System.Drawing.Point(112, 563);
            this.tbx_InputAddr.Name = "tbx_InputAddr";
            this.tbx_InputAddr.Size = new System.Drawing.Size(464, 22);
            this.tbx_InputAddr.TabIndex = 1;
            // 
            // tbx_OutputAddr
            // 
            this.tbx_OutputAddr.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tbx_OutputAddr.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbx_OutputAddr.ForeColor = System.Drawing.SystemColors.Window;
            this.tbx_OutputAddr.Location = new System.Drawing.Point(112, 589);
            this.tbx_OutputAddr.Name = "tbx_OutputAddr";
            this.tbx_OutputAddr.Size = new System.Drawing.Size(464, 22);
            this.tbx_OutputAddr.TabIndex = 2;
            // 
            // lb_InputAddr
            // 
            this.lb_InputAddr.AutoSize = true;
            this.lb_InputAddr.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_InputAddr.ForeColor = System.Drawing.SystemColors.Window;
            this.lb_InputAddr.Location = new System.Drawing.Point(16, 563);
            this.lb_InputAddr.Name = "lb_InputAddr";
            this.lb_InputAddr.Size = new System.Drawing.Size(81, 17);
            this.lb_InputAddr.TabIndex = 3;
            this.lb_InputAddr.Text = "Input Path:";
            // 
            // lb_OutputAddr
            // 
            this.lb_OutputAddr.AutoSize = true;
            this.lb_OutputAddr.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_OutputAddr.ForeColor = System.Drawing.SystemColors.Window;
            this.lb_OutputAddr.Location = new System.Drawing.Point(16, 589);
            this.lb_OutputAddr.Name = "lb_OutputAddr";
            this.lb_OutputAddr.Size = new System.Drawing.Size(92, 17);
            this.lb_OutputAddr.TabIndex = 4;
            this.lb_OutputAddr.Text = "Output Path:";
            // 
            // btn_InputBrowse
            // 
            this.btn_InputBrowse.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_InputBrowse.Location = new System.Drawing.Point(584, 563);
            this.btn_InputBrowse.Name = "btn_InputBrowse";
            this.btn_InputBrowse.Size = new System.Drawing.Size(72, 24);
            this.btn_InputBrowse.TabIndex = 5;
            this.btn_InputBrowse.Text = "Browse...";
            this.btn_InputBrowse.UseVisualStyleBackColor = true;
            this.btn_InputBrowse.Click += new System.EventHandler(this.btn_InputBrowse_Click);
            // 
            // btn_OutputBrowse
            // 
            this.btn_OutputBrowse.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OutputBrowse.Location = new System.Drawing.Point(584, 589);
            this.btn_OutputBrowse.Name = "btn_OutputBrowse";
            this.btn_OutputBrowse.Size = new System.Drawing.Size(72, 24);
            this.btn_OutputBrowse.TabIndex = 6;
            this.btn_OutputBrowse.Text = "Browse...";
            this.btn_OutputBrowse.UseVisualStyleBackColor = true;
            this.btn_OutputBrowse.Click += new System.EventHandler(this.btn_OutputBrowse_Click);
            // 
            // gbx_Operation
            // 
            this.gbx_Operation.Controls.Add(this.btn_Reload);
            this.gbx_Operation.Controls.Add(this.btn_ClrOutputs);
            this.gbx_Operation.Controls.Add(this.lbx_SaveAs);
            this.gbx_Operation.Controls.Add(this.tbx_SaveAs);
            this.gbx_Operation.ForeColor = System.Drawing.SystemColors.Window;
            this.gbx_Operation.Location = new System.Drawing.Point(664, 156);
            this.gbx_Operation.Name = "gbx_Operation";
            this.gbx_Operation.Size = new System.Drawing.Size(160, 459);
            this.gbx_Operation.TabIndex = 7;
            this.gbx_Operation.TabStop = false;
            this.gbx_Operation.Text = "Operation";
            // 
            // btn_Reload
            // 
            this.btn_Reload.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reload.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btn_Reload.Location = new System.Drawing.Point(8, 87);
            this.btn_Reload.Name = "btn_Reload";
            this.btn_Reload.Size = new System.Drawing.Size(136, 35);
            this.btn_Reload.TabIndex = 14;
            this.btn_Reload.Text = "Reload";
            this.btn_Reload.UseVisualStyleBackColor = true;
            this.btn_Reload.Click += new System.EventHandler(this.btn_Reload_Click);
            // 
            // btn_ClrOutputs
            // 
            this.btn_ClrOutputs.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ClrOutputs.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btn_ClrOutputs.Location = new System.Drawing.Point(8, 139);
            this.btn_ClrOutputs.Name = "btn_ClrOutputs";
            this.btn_ClrOutputs.Size = new System.Drawing.Size(136, 35);
            this.btn_ClrOutputs.TabIndex = 13;
            this.btn_ClrOutputs.Text = "Clear Outputs";
            this.btn_ClrOutputs.UseVisualStyleBackColor = true;
            this.btn_ClrOutputs.Click += new System.EventHandler(this.btn_ClrOutputs_Click);
            // 
            // lbx_SaveAs
            // 
            this.lbx_SaveAs.AutoSize = true;
            this.lbx_SaveAs.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbx_SaveAs.ForeColor = System.Drawing.SystemColors.Window;
            this.lbx_SaveAs.Location = new System.Drawing.Point(8, 26);
            this.lbx_SaveAs.Name = "lbx_SaveAs";
            this.lbx_SaveAs.Size = new System.Drawing.Size(62, 17);
            this.lbx_SaveAs.TabIndex = 12;
            this.lbx_SaveAs.Text = "Save as:";
            // 
            // tbx_SaveAs
            // 
            this.tbx_SaveAs.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tbx_SaveAs.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbx_SaveAs.ForeColor = System.Drawing.SystemColors.Window;
            this.tbx_SaveAs.Location = new System.Drawing.Point(8, 52);
            this.tbx_SaveAs.Name = "tbx_SaveAs";
            this.tbx_SaveAs.Size = new System.Drawing.Size(144, 22);
            this.tbx_SaveAs.TabIndex = 12;
            this.tbx_SaveAs.Text = "obj_";
            // 
            // listBox_Output
            // 
            this.listBox_Output.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.listBox_Output.ForeColor = System.Drawing.SystemColors.Window;
            this.listBox_Output.FormattingEnabled = true;
            this.listBox_Output.Location = new System.Drawing.Point(976, 17);
            this.listBox_Output.Name = "listBox_Output";
            this.listBox_Output.Size = new System.Drawing.Size(136, 589);
            this.listBox_Output.TabIndex = 8;
            this.listBox_Output.SelectedIndexChanged += new System.EventHandler(this.listBox_Output_SelectedIndexChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 629);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1120, 23);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 17);
            // 
            // tbx_ImgInfo
            // 
            this.tbx_ImgInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbx_ImgInfo.Enabled = false;
            this.tbx_ImgInfo.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.tbx_ImgInfo.Location = new System.Drawing.Point(16, 537);
            this.tbx_ImgInfo.Name = "tbx_ImgInfo";
            this.tbx_ImgInfo.Size = new System.Drawing.Size(640, 20);
            this.tbx_ImgInfo.TabIndex = 10;
            // 
            // pbx_OutputView
            // 
            this.pbx_OutputView.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pbx_OutputView.Location = new System.Drawing.Point(664, 17);
            this.pbx_OutputView.Name = "pbx_OutputView";
            this.pbx_OutputView.Size = new System.Drawing.Size(160, 130);
            this.pbx_OutputView.TabIndex = 12;
            this.pbx_OutputView.TabStop = false;
            // 
            // ibx_InputView
            // 
            this.ibx_InputView.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ibx_InputView.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
            this.ibx_InputView.Location = new System.Drawing.Point(16, 17);
            this.ibx_InputView.Name = "ibx_InputView";
            this.ibx_InputView.Size = new System.Drawing.Size(640, 520);
            this.ibx_InputView.TabIndex = 2;
            this.ibx_InputView.TabStop = false;
            this.ibx_InputView.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ibx_InputView_MouseMove);
            this.ibx_InputView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ibx_InputView_MouseUp);
            // 
            // Processer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1120, 652);
            this.Controls.Add(this.ibx_InputView);
            this.Controls.Add(this.pbx_OutputView);
            this.Controls.Add(this.tbx_ImgInfo);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.listBox_Output);
            this.Controls.Add(this.gbx_Operation);
            this.Controls.Add(this.btn_OutputBrowse);
            this.Controls.Add(this.btn_InputBrowse);
            this.Controls.Add(this.lb_OutputAddr);
            this.Controls.Add(this.lb_InputAddr);
            this.Controls.Add(this.tbx_OutputAddr);
            this.Controls.Add(this.tbx_InputAddr);
            this.Controls.Add(this.listBox_Input);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Processer";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Image Pre-processer - v0.1.0";
            this.Load += new System.EventHandler(this.Processer_Load);
            this.gbx_Operation.ResumeLayout(false);
            this.gbx_Operation.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_OutputView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibx_InputView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Input;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox tbx_InputAddr;
        private System.Windows.Forms.TextBox tbx_OutputAddr;
        private System.Windows.Forms.Label lb_InputAddr;
        private System.Windows.Forms.Label lb_OutputAddr;
        private System.Windows.Forms.Button btn_InputBrowse;
        private System.Windows.Forms.Button btn_OutputBrowse;
        private System.Windows.Forms.GroupBox gbx_Operation;
        private System.Windows.Forms.ListBox listBox_Output;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.TextBox tbx_ImgInfo;
        private System.Windows.Forms.Label lbx_SaveAs;
        private System.Windows.Forms.TextBox tbx_SaveAs;
        private System.Windows.Forms.PictureBox pbx_OutputView;
        private Emgu.CV.UI.ImageBox ibx_InputView;
        private System.Windows.Forms.Button btn_ClrOutputs;
        private System.Windows.Forms.Button btn_Reload;
    }
}

