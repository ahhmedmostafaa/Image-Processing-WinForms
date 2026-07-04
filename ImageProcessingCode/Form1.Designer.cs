namespace ImageProcessing
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.operationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rGBSeperationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grayScaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpBoxFilters = new System.Windows.Forms.GroupBox();
            this.radbtnNegativeFilter = new System.Windows.Forms.RadioButton();
            this.radbtnBrightnessAdjustmentFilter = new System.Windows.Forms.RadioButton();
            this.radbtnSobelEdgedetectionFilter = new System.Windows.Forms.RadioButton();
            this.radbtnGaussianBlurFilter = new System.Windows.Forms.RadioButton();
            this.btnApplyFilter = new System.Windows.Forms.Button();
            this.radbtnUnsharpFilter = new System.Windows.Forms.RadioButton();
            this.radbtnSharpFilter = new System.Windows.Forms.RadioButton();
            this.radbtnAverageFilter = new System.Windows.Forms.RadioButton();
            this.btnLoadImage = new System.Windows.Forms.Button();
            this.picBoxFilterdImage = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.picBoxSource = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.grpBoxFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFilterdImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operationsToolStripMenuItem,
            this.filtersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1331, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // operationsToolStripMenuItem
            // 
            this.operationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.histogramToolStripMenuItem,
            this.rGBSeperationToolStripMenuItem,
            this.grayScaleToolStripMenuItem});
            this.operationsToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.operationsToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White;
            this.operationsToolStripMenuItem.Name = "operationsToolStripMenuItem";
            this.operationsToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.operationsToolStripMenuItem.Text = "Operations";
            // 
            // histogramToolStripMenuItem
            // 
            this.histogramToolStripMenuItem.Name = "histogramToolStripMenuItem";
            this.histogramToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.histogramToolStripMenuItem.Text = "Histogram";
            this.histogramToolStripMenuItem.Click += new System.EventHandler(this.histogramToolStripMenuItem_Click);
            // 
            // rGBSeperationToolStripMenuItem
            // 
            this.rGBSeperationToolStripMenuItem.Name = "rGBSeperationToolStripMenuItem";
            this.rGBSeperationToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.rGBSeperationToolStripMenuItem.Text = "RGB seperation";
            this.rGBSeperationToolStripMenuItem.Click += new System.EventHandler(this.rGBSeperationToolStripMenuItem_Click);
            // 
            // grayScaleToolStripMenuItem
            // 
            this.grayScaleToolStripMenuItem.Name = "grayScaleToolStripMenuItem";
            this.grayScaleToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.grayScaleToolStripMenuItem.Text = "Gray scale";
            this.grayScaleToolStripMenuItem.Click += new System.EventHandler(this.grayScaleToolStripMenuItem_Click);
            // 
            // filtersToolStripMenuItem
            // 
            this.filtersToolStripMenuItem.Name = "filtersToolStripMenuItem";
            this.filtersToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.filtersToolStripMenuItem.Text = "Filters";
            this.filtersToolStripMenuItem.Click += new System.EventHandler(this.filtersToolStripMenuItem_Click);
            // 
            // grpBoxFilters
            // 
            this.grpBoxFilters.Controls.Add(this.radbtnNegativeFilter);
            this.grpBoxFilters.Controls.Add(this.radbtnBrightnessAdjustmentFilter);
            this.grpBoxFilters.Controls.Add(this.radbtnSobelEdgedetectionFilter);
            this.grpBoxFilters.Controls.Add(this.radbtnGaussianBlurFilter);
            this.grpBoxFilters.Controls.Add(this.btnApplyFilter);
            this.grpBoxFilters.Controls.Add(this.radbtnUnsharpFilter);
            this.grpBoxFilters.Controls.Add(this.radbtnSharpFilter);
            this.grpBoxFilters.Controls.Add(this.radbtnAverageFilter);
            this.grpBoxFilters.Location = new System.Drawing.Point(485, 54);
            this.grpBoxFilters.Margin = new System.Windows.Forms.Padding(4);
            this.grpBoxFilters.Name = "grpBoxFilters";
            this.grpBoxFilters.Padding = new System.Windows.Forms.Padding(4);
            this.grpBoxFilters.Size = new System.Drawing.Size(456, 214);
            this.grpBoxFilters.TabIndex = 3;
            this.grpBoxFilters.TabStop = false;
            this.grpBoxFilters.Visible = false;
            // 
            // radbtnNegativeFilter
            // 
            this.radbtnNegativeFilter.AutoSize = true;
            this.radbtnNegativeFilter.Location = new System.Drawing.Point(9, 179);
            this.radbtnNegativeFilter.Name = "radbtnNegativeFilter";
            this.radbtnNegativeFilter.Size = new System.Drawing.Size(115, 20);
            this.radbtnNegativeFilter.TabIndex = 5;
            this.radbtnNegativeFilter.TabStop = true;
            this.radbtnNegativeFilter.Text = "Negative Filter";
            this.radbtnNegativeFilter.UseVisualStyleBackColor = true;
            // 
            // radbtnBrightnessAdjustmentFilter
            // 
            this.radbtnBrightnessAdjustmentFilter.AutoSize = true;
            this.radbtnBrightnessAdjustmentFilter.Location = new System.Drawing.Point(9, 152);
            this.radbtnBrightnessAdjustmentFilter.Name = "radbtnBrightnessAdjustmentFilter";
            this.radbtnBrightnessAdjustmentFilter.Size = new System.Drawing.Size(192, 20);
            this.radbtnBrightnessAdjustmentFilter.TabIndex = 4;
            this.radbtnBrightnessAdjustmentFilter.TabStop = true;
            this.radbtnBrightnessAdjustmentFilter.Text = "Brightness Adjustment Filter";
            this.radbtnBrightnessAdjustmentFilter.UseVisualStyleBackColor = true;
            // 
            // radbtnSobelEdgedetectionFilter
            // 
            this.radbtnSobelEdgedetectionFilter.AutoSize = true;
            this.radbtnSobelEdgedetectionFilter.Location = new System.Drawing.Point(9, 125);
            this.radbtnSobelEdgedetectionFilter.Name = "radbtnSobelEdgedetectionFilter";
            this.radbtnSobelEdgedetectionFilter.Size = new System.Drawing.Size(190, 20);
            this.radbtnSobelEdgedetectionFilter.TabIndex = 3;
            this.radbtnSobelEdgedetectionFilter.TabStop = true;
            this.radbtnSobelEdgedetectionFilter.Text = "Sobel Edge detection Filter";
            this.radbtnSobelEdgedetectionFilter.UseVisualStyleBackColor = true;
            // 
            // radbtnGaussianBlurFilter
            // 
            this.radbtnGaussianBlurFilter.AutoSize = true;
            this.radbtnGaussianBlurFilter.Location = new System.Drawing.Point(8, 98);
            this.radbtnGaussianBlurFilter.Name = "radbtnGaussianBlurFilter";
            this.radbtnGaussianBlurFilter.Size = new System.Drawing.Size(143, 20);
            this.radbtnGaussianBlurFilter.TabIndex = 2;
            this.radbtnGaussianBlurFilter.TabStop = true;
            this.radbtnGaussianBlurFilter.Text = "Gaussian Blur Filter";
            this.radbtnGaussianBlurFilter.UseVisualStyleBackColor = false;
            this.radbtnGaussianBlurFilter.CheckedChanged += new System.EventHandler(this.radbtnGaussianBlurFilter_CheckedChanged);
            // 
            // btnApplyFilter
            // 
            this.btnApplyFilter.BackColor = System.Drawing.Color.LightCoral;
            this.btnApplyFilter.Location = new System.Drawing.Point(348, 17);
            this.btnApplyFilter.Margin = new System.Windows.Forms.Padding(4);
            this.btnApplyFilter.Name = "btnApplyFilter";
            this.btnApplyFilter.Size = new System.Drawing.Size(100, 78);
            this.btnApplyFilter.TabIndex = 1;
            this.btnApplyFilter.Text = "Apply Filter";
            this.btnApplyFilter.UseVisualStyleBackColor = false;
            this.btnApplyFilter.Click += new System.EventHandler(this.btnApplyFilter_Click);
            // 
            // radbtnUnsharpFilter
            // 
            this.radbtnUnsharpFilter.AutoSize = true;
            this.radbtnUnsharpFilter.Location = new System.Drawing.Point(8, 70);
            this.radbtnUnsharpFilter.Margin = new System.Windows.Forms.Padding(4);
            this.radbtnUnsharpFilter.Name = "radbtnUnsharpFilter";
            this.radbtnUnsharpFilter.Size = new System.Drawing.Size(111, 20);
            this.radbtnUnsharpFilter.TabIndex = 0;
            this.radbtnUnsharpFilter.TabStop = true;
            this.radbtnUnsharpFilter.Text = "Unsharp Filter";
            this.radbtnUnsharpFilter.UseVisualStyleBackColor = true;
            // 
            // radbtnSharpFilter
            // 
            this.radbtnSharpFilter.AutoSize = true;
            this.radbtnSharpFilter.Location = new System.Drawing.Point(8, 42);
            this.radbtnSharpFilter.Margin = new System.Windows.Forms.Padding(4);
            this.radbtnSharpFilter.Name = "radbtnSharpFilter";
            this.radbtnSharpFilter.Size = new System.Drawing.Size(129, 20);
            this.radbtnSharpFilter.TabIndex = 0;
            this.radbtnSharpFilter.TabStop = true;
            this.radbtnSharpFilter.Text = "Sharpening Filter";
            this.radbtnSharpFilter.UseVisualStyleBackColor = true;
            // 
            // radbtnAverageFilter
            // 
            this.radbtnAverageFilter.AutoSize = true;
            this.radbtnAverageFilter.Location = new System.Drawing.Point(9, 14);
            this.radbtnAverageFilter.Margin = new System.Windows.Forms.Padding(4);
            this.radbtnAverageFilter.Name = "radbtnAverageFilter";
            this.radbtnAverageFilter.Size = new System.Drawing.Size(112, 20);
            this.radbtnAverageFilter.TabIndex = 0;
            this.radbtnAverageFilter.TabStop = true;
            this.radbtnAverageFilter.Text = "Average Filter";
            this.radbtnAverageFilter.UseVisualStyleBackColor = true;
            this.radbtnAverageFilter.CheckedChanged += new System.EventHandler(this.radbtnAverageFilter_CheckedChanged);
            // 
            // btnLoadImage
            // 
            this.btnLoadImage.BackColor = System.Drawing.Color.LightCoral;
            this.btnLoadImage.Location = new System.Drawing.Point(485, 275);
            this.btnLoadImage.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.Size = new System.Drawing.Size(456, 28);
            this.btnLoadImage.TabIndex = 4;
            this.btnLoadImage.Text = "Load Image";
            this.btnLoadImage.UseVisualStyleBackColor = false;
            this.btnLoadImage.Visible = false;
            this.btnLoadImage.Click += new System.EventHandler(this.btnLoadImage_Click);
            // 
            // picBoxFilterdImage
            // 
            this.picBoxFilterdImage.Location = new System.Drawing.Point(688, 333);
            this.picBoxFilterdImage.Margin = new System.Windows.Forms.Padding(4);
            this.picBoxFilterdImage.Name = "picBoxFilterdImage";
            this.picBoxFilterdImage.Size = new System.Drawing.Size(613, 340);
            this.picBoxFilterdImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxFilterdImage.TabIndex = 6;
            this.picBoxFilterdImage.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // picBoxSource
            // 
            this.picBoxSource.Location = new System.Drawing.Point(33, 333);
            this.picBoxSource.Margin = new System.Windows.Forms.Padding(4);
            this.picBoxSource.Name = "picBoxSource";
            this.picBoxSource.Size = new System.Drawing.Size(613, 340);
            this.picBoxSource.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxSource.TabIndex = 5;
            this.picBoxSource.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1331, 703);
            this.Controls.Add(this.picBoxFilterdImage);
            this.Controls.Add(this.picBoxSource);
            this.Controls.Add(this.btnLoadImage);
            this.Controls.Add(this.grpBoxFilters);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "FormHome";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpBoxFilters.ResumeLayout(false);
            this.grpBoxFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFilterdImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem operationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem histogramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rGBSeperationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtersToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpBoxFilters;
        private System.Windows.Forms.Button btnApplyFilter;
        private System.Windows.Forms.RadioButton radbtnUnsharpFilter;
        private System.Windows.Forms.RadioButton radbtnSharpFilter;
        private System.Windows.Forms.RadioButton radbtnAverageFilter;
        private System.Windows.Forms.Button btnLoadImage;
        private System.Windows.Forms.PictureBox picBoxFilterdImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem grayScaleToolStripMenuItem;
        private System.Windows.Forms.PictureBox picBoxSource;
        private System.Windows.Forms.RadioButton radbtnGaussianBlurFilter;
        private System.Windows.Forms.RadioButton radbtnSobelEdgedetectionFilter;
        private System.Windows.Forms.RadioButton radbtnNegativeFilter;
        private System.Windows.Forms.RadioButton radbtnBrightnessAdjustmentFilter;
    }
}

