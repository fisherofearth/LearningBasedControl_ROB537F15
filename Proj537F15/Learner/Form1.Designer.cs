namespace Learner
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
            this.gbx_Operation = new System.Windows.Forms.GroupBox();
            this.btn_Reload = new System.Windows.Forms.Button();
            this.btn_ClrOutputs = new System.Windows.Forms.Button();
            this.lbx_SaveAs = new System.Windows.Forms.Label();
            this.tbx_SaveAs = new System.Windows.Forms.TextBox();
            this.btn_OutputBrowse = new System.Windows.Forms.Button();
            this.btn_InputBrowse = new System.Windows.Forms.Button();
            this.lb_OutputAddr = new System.Windows.Forms.Label();
            this.lb_InputAddr = new System.Windows.Forms.Label();
            this.tbx_OutputAddr = new System.Windows.Forms.TextBox();
            this.tbx_InputAddr = new System.Windows.Forms.TextBox();
            this.btn_Train = new System.Windows.Forms.Button();
            this.gbx_Operation.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbx_Operation
            // 
            this.gbx_Operation.Controls.Add(this.btn_Train);
            this.gbx_Operation.Controls.Add(this.btn_OutputBrowse);
            this.gbx_Operation.Controls.Add(this.btn_Reload);
            this.gbx_Operation.Controls.Add(this.btn_ClrOutputs);
            this.gbx_Operation.Controls.Add(this.tbx_InputAddr);
            this.gbx_Operation.Controls.Add(this.lb_InputAddr);
            this.gbx_Operation.Controls.Add(this.lbx_SaveAs);
            this.gbx_Operation.Controls.Add(this.btn_InputBrowse);
            this.gbx_Operation.Controls.Add(this.tbx_SaveAs);
            this.gbx_Operation.Controls.Add(this.tbx_OutputAddr);
            this.gbx_Operation.Controls.Add(this.lb_OutputAddr);
            this.gbx_Operation.ForeColor = System.Drawing.SystemColors.Window;
            this.gbx_Operation.Location = new System.Drawing.Point(120, 23);
            this.gbx_Operation.Name = "gbx_Operation";
            this.gbx_Operation.Size = new System.Drawing.Size(756, 459);
            this.gbx_Operation.TabIndex = 8;
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
            // btn_OutputBrowse
            // 
            this.btn_OutputBrowse.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OutputBrowse.Location = new System.Drawing.Point(615, 268);
            this.btn_OutputBrowse.Name = "btn_OutputBrowse";
            this.btn_OutputBrowse.Size = new System.Drawing.Size(72, 24);
            this.btn_OutputBrowse.TabIndex = 20;
            this.btn_OutputBrowse.Text = "Browse...";
            this.btn_OutputBrowse.UseVisualStyleBackColor = true;
            // 
            // btn_InputBrowse
            // 
            this.btn_InputBrowse.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_InputBrowse.Location = new System.Drawing.Point(615, 242);
            this.btn_InputBrowse.Name = "btn_InputBrowse";
            this.btn_InputBrowse.Size = new System.Drawing.Size(72, 24);
            this.btn_InputBrowse.TabIndex = 19;
            this.btn_InputBrowse.Text = "Browse...";
            this.btn_InputBrowse.UseVisualStyleBackColor = true;
            // 
            // lb_OutputAddr
            // 
            this.lb_OutputAddr.AutoSize = true;
            this.lb_OutputAddr.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_OutputAddr.ForeColor = System.Drawing.SystemColors.Window;
            this.lb_OutputAddr.Location = new System.Drawing.Point(47, 268);
            this.lb_OutputAddr.Name = "lb_OutputAddr";
            this.lb_OutputAddr.Size = new System.Drawing.Size(92, 17);
            this.lb_OutputAddr.TabIndex = 18;
            this.lb_OutputAddr.Text = "Output Path:";
            // 
            // lb_InputAddr
            // 
            this.lb_InputAddr.AutoSize = true;
            this.lb_InputAddr.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_InputAddr.ForeColor = System.Drawing.SystemColors.Window;
            this.lb_InputAddr.Location = new System.Drawing.Point(47, 242);
            this.lb_InputAddr.Name = "lb_InputAddr";
            this.lb_InputAddr.Size = new System.Drawing.Size(81, 17);
            this.lb_InputAddr.TabIndex = 17;
            this.lb_InputAddr.Text = "Input Path:";
            // 
            // tbx_OutputAddr
            // 
            this.tbx_OutputAddr.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tbx_OutputAddr.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbx_OutputAddr.ForeColor = System.Drawing.SystemColors.Window;
            this.tbx_OutputAddr.Location = new System.Drawing.Point(143, 268);
            this.tbx_OutputAddr.Name = "tbx_OutputAddr";
            this.tbx_OutputAddr.Size = new System.Drawing.Size(464, 22);
            this.tbx_OutputAddr.TabIndex = 16;
            // 
            // tbx_InputAddr
            // 
            this.tbx_InputAddr.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tbx_InputAddr.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbx_InputAddr.ForeColor = System.Drawing.SystemColors.Window;
            this.tbx_InputAddr.Location = new System.Drawing.Point(143, 242);
            this.tbx_InputAddr.Name = "tbx_InputAddr";
            this.tbx_InputAddr.Size = new System.Drawing.Size(464, 22);
            this.tbx_InputAddr.TabIndex = 15;
            // 
            // btn_Train
            // 
            this.btn_Train.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Train.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btn_Train.Location = new System.Drawing.Point(143, 323);
            this.btn_Train.Name = "btn_Train";
            this.btn_Train.Size = new System.Drawing.Size(136, 35);
            this.btn_Train.TabIndex = 21;
            this.btn_Train.Text = "Train";
            this.btn_Train.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(915, 515);
            this.Controls.Add(this.gbx_Operation);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbx_Operation.ResumeLayout(false);
            this.gbx_Operation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbx_Operation;
        private System.Windows.Forms.Button btn_Train;
        private System.Windows.Forms.Button btn_OutputBrowse;
        private System.Windows.Forms.Button btn_Reload;
        private System.Windows.Forms.Button btn_ClrOutputs;
        private System.Windows.Forms.TextBox tbx_InputAddr;
        private System.Windows.Forms.Label lb_InputAddr;
        private System.Windows.Forms.Label lbx_SaveAs;
        private System.Windows.Forms.Button btn_InputBrowse;
        private System.Windows.Forms.TextBox tbx_SaveAs;
        private System.Windows.Forms.TextBox tbx_OutputAddr;
        private System.Windows.Forms.Label lb_OutputAddr;
    }
}

