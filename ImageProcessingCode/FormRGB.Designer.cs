namespace ImageProcessing
{
    partial class FormRGB
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picSourceImage = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBlue = new System.Windows.Forms.Button();
            this.btnGreen = new System.Windows.Forms.Button();
            this.btnRed = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picBoxBlue = new System.Windows.Forms.PictureBox();
            this.picBoxGreen = new System.Windows.Forms.PictureBox();
            this.picBoxRed = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSourceImage)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxRed)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1263, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.openToolStripMenuItem.Text = "open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // picSourceImage
            // 
            this.picSourceImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picSourceImage.Location = new System.Drawing.Point(408, 64);
            this.picSourceImage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picSourceImage.Name = "picSourceImage";
            this.picSourceImage.Size = new System.Drawing.Size(445, 263);
            this.picSourceImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSourceImage.TabIndex = 4;
            this.picSourceImage.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnBlue);
            this.groupBox1.Controls.Add(this.btnGreen);
            this.groupBox1.Controls.Add(this.btnRed);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.picBoxBlue);
            this.groupBox1.Controls.Add(this.picBoxGreen);
            this.groupBox1.Controls.Add(this.picBoxRed);
            this.groupBox1.Location = new System.Drawing.Point(16, 335);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1195, 343);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(979, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Blue";
            // 
            // btnBlue
            // 
            this.btnBlue.BackColor = System.Drawing.Color.LightCoral;
            this.btnBlue.Location = new System.Drawing.Point(812, 297);
            this.btnBlue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Size = new System.Drawing.Size(363, 28);
            this.btnBlue.TabIndex = 2;
            this.btnBlue.Text = "Blue";
            this.btnBlue.UseVisualStyleBackColor = false;
            this.btnBlue.Click += new System.EventHandler(this.btnBlue_Click);
            // 
            // btnGreen
            // 
            this.btnGreen.BackColor = System.Drawing.Color.LightCoral;
            this.btnGreen.Location = new System.Drawing.Point(413, 297);
            this.btnGreen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGreen.Name = "btnGreen";
            this.btnGreen.Size = new System.Drawing.Size(363, 28);
            this.btnGreen.TabIndex = 2;
            this.btnGreen.Text = "Green";
            this.btnGreen.UseVisualStyleBackColor = false;
            this.btnGreen.Click += new System.EventHandler(this.btnGreen_Click);
            // 
            // btnRed
            // 
            this.btnRed.BackColor = System.Drawing.Color.LightCoral;
            this.btnRed.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRed.Location = new System.Drawing.Point(8, 297);
            this.btnRed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(363, 28);
            this.btnRed.TabIndex = 2;
            this.btnRed.Text = "Red";
            this.btnRed.UseVisualStyleBackColor = false;
            this.btnRed.Click += new System.EventHandler(this.btnRed_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(569, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Green";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Red";
            // 
            // picBoxBlue
            // 
            this.picBoxBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxBlue.Location = new System.Drawing.Point(812, 47);
            this.picBoxBlue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picBoxBlue.Name = "picBoxBlue";
            this.picBoxBlue.Size = new System.Drawing.Size(363, 242);
            this.picBoxBlue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxBlue.TabIndex = 0;
            this.picBoxBlue.TabStop = false;
            // 
            // picBoxGreen
            // 
            this.picBoxGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxGreen.Location = new System.Drawing.Point(413, 47);
            this.picBoxGreen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picBoxGreen.Name = "picBoxGreen";
            this.picBoxGreen.Size = new System.Drawing.Size(363, 242);
            this.picBoxGreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxGreen.TabIndex = 0;
            this.picBoxGreen.TabStop = false;
            // 
            // picBoxRed
            // 
            this.picBoxRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxRed.Location = new System.Drawing.Point(8, 47);
            this.picBoxRed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picBoxRed.Name = "picBoxRed";
            this.picBoxRed.Size = new System.Drawing.Size(363, 242);
            this.picBoxRed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxRed.TabIndex = 0;
            this.picBoxRed.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(602, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Original";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // FormRGB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1263, 683);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.picSourceImage);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormRGB";
            this.Text = "FormRGBcs";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSourceImage)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxRed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.PictureBox picSourceImage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBlue;
        private System.Windows.Forms.Button btnGreen;
        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picBoxBlue;
        private System.Windows.Forms.PictureBox picBoxGreen;
        private System.Windows.Forms.PictureBox picBoxRed;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label4;
    }
}