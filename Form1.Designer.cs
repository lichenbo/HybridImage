namespace LowPassFilter
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
            this.txtLowPath = new System.Windows.Forms.TextBox();
            this.btnLowBrowse = new System.Windows.Forms.Button();
            this.picLowpass = new System.Windows.Forms.PictureBox();
            this.dialog = new System.Windows.Forms.OpenFileDialog();
            this.btnLowPass = new System.Windows.Forms.Button();
            this.picHighPass = new System.Windows.Forms.PictureBox();
            this.btnHighPass = new System.Windows.Forms.Button();
            this.btnHighBrowse = new System.Windows.Forms.Button();
            this.txtHighPath = new System.Windows.Forms.TextBox();
            this.picHybrid = new System.Windows.Forms.PictureBox();
            this.btnHybrid = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.saveDialog = new System.Windows.Forms.SaveFileDialog();
            this.blurRange = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picLowpass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHighPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHybrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blurRange)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLowPath
            // 
            this.txtLowPath.Location = new System.Drawing.Point(37, 59);
            this.txtLowPath.Name = "txtLowPath";
            this.txtLowPath.Size = new System.Drawing.Size(192, 21);
            this.txtLowPath.TabIndex = 0;
            // 
            // btnLowBrowse
            // 
            this.btnLowBrowse.Location = new System.Drawing.Point(235, 57);
            this.btnLowBrowse.Name = "btnLowBrowse";
            this.btnLowBrowse.Size = new System.Drawing.Size(29, 23);
            this.btnLowBrowse.TabIndex = 1;
            this.btnLowBrowse.Text = "...";
            this.btnLowBrowse.UseVisualStyleBackColor = true;
            this.btnLowBrowse.Click += new System.EventHandler(this.btnLowBrowse_Click);
            // 
            // picLowpass
            // 
            this.picLowpass.Location = new System.Drawing.Point(0, 0);
            this.picLowpass.Name = "picLowpass";
            this.picLowpass.Size = new System.Drawing.Size(100, 55);
            this.picLowpass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picLowpass.TabIndex = 3;
            this.picLowpass.TabStop = false;
            // 
            // btnLowPass
            // 
            this.btnLowPass.Location = new System.Drawing.Point(270, 57);
            this.btnLowPass.Name = "btnLowPass";
            this.btnLowPass.Size = new System.Drawing.Size(75, 23);
            this.btnLowPass.TabIndex = 4;
            this.btnLowPass.Text = "LowPass";
            this.btnLowPass.UseVisualStyleBackColor = true;
            this.btnLowPass.Click += new System.EventHandler(this.btnLowPass_Click);
            // 
            // picHighPass
            // 
            this.picHighPass.Location = new System.Drawing.Point(0, 0);
            this.picHighPass.Name = "picHighPass";
            this.picHighPass.Size = new System.Drawing.Size(125, 49);
            this.picHighPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picHighPass.TabIndex = 5;
            this.picHighPass.TabStop = false;
            // 
            // btnHighPass
            // 
            this.btnHighPass.Location = new System.Drawing.Point(633, 57);
            this.btnHighPass.Name = "btnHighPass";
            this.btnHighPass.Size = new System.Drawing.Size(75, 23);
            this.btnHighPass.TabIndex = 8;
            this.btnHighPass.Text = "HighPass";
            this.btnHighPass.UseVisualStyleBackColor = true;
            this.btnHighPass.Click += new System.EventHandler(this.btnHighPass_Click);
            // 
            // btnHighBrowse
            // 
            this.btnHighBrowse.Location = new System.Drawing.Point(598, 57);
            this.btnHighBrowse.Name = "btnHighBrowse";
            this.btnHighBrowse.Size = new System.Drawing.Size(29, 23);
            this.btnHighBrowse.TabIndex = 7;
            this.btnHighBrowse.Text = "...";
            this.btnHighBrowse.UseVisualStyleBackColor = true;
            this.btnHighBrowse.Click += new System.EventHandler(this.btnHighBrowse_Click);
            // 
            // txtHighPath
            // 
            this.txtHighPath.Location = new System.Drawing.Point(400, 59);
            this.txtHighPath.Name = "txtHighPath";
            this.txtHighPath.Size = new System.Drawing.Size(192, 21);
            this.txtHighPath.TabIndex = 6;
            // 
            // picHybrid
            // 
            this.picHybrid.Location = new System.Drawing.Point(0, 0);
            this.picHybrid.Name = "picHybrid";
            this.picHybrid.Size = new System.Drawing.Size(151, 66);
            this.picHybrid.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picHybrid.TabIndex = 9;
            this.picHybrid.TabStop = false;
            // 
            // btnHybrid
            // 
            this.btnHybrid.Location = new System.Drawing.Point(909, 57);
            this.btnHybrid.Name = "btnHybrid";
            this.btnHybrid.Size = new System.Drawing.Size(75, 23);
            this.btnHybrid.TabIndex = 10;
            this.btnHybrid.Text = "Hybrid";
            this.btnHybrid.UseVisualStyleBackColor = true;
            this.btnHybrid.Click += new System.EventHandler(this.btnHybrid_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.picLowpass);
            this.panel1.Location = new System.Drawing.Point(37, 134);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(323, 261);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.picHighPass);
            this.panel2.Location = new System.Drawing.Point(400, 134);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(308, 261);
            this.panel2.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.picHybrid);
            this.panel3.Location = new System.Drawing.Point(752, 134);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(323, 261);
            this.panel3.TabIndex = 12;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(990, 57);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // saveDialog
            // 
            this.saveDialog.Filter = "Bitmap Image|*.bmp";
            this.saveDialog.Title = "Save";
            // 
            // blurRange
            // 
            this.blurRange.Location = new System.Drawing.Point(114, 22);
            this.blurRange.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.blurRange.Name = "blurRange";
            this.blurRange.Size = new System.Drawing.Size(47, 21);
            this.blurRange.TabIndex = 15;
            this.blurRange.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 16;
            this.label1.Text = "BlurDegree";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 400);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.blurRange);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnHybrid);
            this.Controls.Add(this.btnHighPass);
            this.Controls.Add(this.btnHighBrowse);
            this.Controls.Add(this.txtHighPath);
            this.Controls.Add(this.btnLowPass);
            this.Controls.Add(this.btnLowBrowse);
            this.Controls.Add(this.txtLowPath);
            this.Name = "Form1";
            this.Text = "HybridImage";
            ((System.ComponentModel.ISupportInitialize)(this.picLowpass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHighPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHybrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blurRange)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLowPath;
        private System.Windows.Forms.Button btnLowBrowse;
        private System.Windows.Forms.PictureBox picLowpass;
        private System.Windows.Forms.OpenFileDialog dialog;
        private System.Windows.Forms.Button btnLowPass;
        private System.Windows.Forms.PictureBox picHighPass;
        private System.Windows.Forms.Button btnHighPass;
        private System.Windows.Forms.Button btnHighBrowse;
        private System.Windows.Forms.TextBox txtHighPath;
        private System.Windows.Forms.PictureBox picHybrid;
        private System.Windows.Forms.Button btnHybrid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.SaveFileDialog saveDialog;
        private System.Windows.Forms.NumericUpDown blurRange;
        private System.Windows.Forms.Label label1;
    }
}

