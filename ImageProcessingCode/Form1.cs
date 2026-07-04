using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using openCV;
using System.IO;

namespace ImageProcessing
{
    public partial class Form1 : Form
    {
        Image sourceImage;
        public Form1()
        {
            InitializeComponent();
        }

        private void filtersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grpBoxFilters.Visible = true;
            btnLoadImage.Visible = true;
        }

        private void btnApplyFilter_Click(object sender, EventArgs e)
        {
            Bitmap bmpImg = new Bitmap(sourceImage);
            int width = bmpImg.Width;
            int height = bmpImg.Height;
            Bitmap newImage = new Bitmap(width, height);

            if (radbtnAverageFilter.Checked)
            {
                for (int i = 1; i < width - 1; i++)
                {
                    for (int j = 1; j < height - 1; j++)
                    {
                        int r = 0, g = 0, b = 0;

                        for (int x = -1; x <= 1; x++)
                        {
                            for (int y = -1; y <= 1; y++)
                            {
                                Color pixel = bmpImg.GetPixel(i + x, j + y);
                                r += pixel.R;
                                g += pixel.G;
                                b += pixel.B;
                            }
                        }

                        r /= 9;
                        g /= 9;
                        b /= 9;

                        newImage.SetPixel(i, j, Color.FromArgb(r, g, b));
                    }
                }
            }
            else if (radbtnSharpFilter.Checked)
            {
                int[,] kernel = {
                    { 0, -1, 0 },
                    { -1, 4, -1 },
                    { 0, -1, 0 }
                };

                for (int i = 1; i < width - 1; i++)
                {
                    for (int j = 1; j < height - 1; j++)
                    {
                        int r = 0, g = 0, b = 0;

                        for (int x = -1; x <= 1; x++)
                        {
                            for (int y = -1; y <= 1; y++)
                            {
                                Color pixel = bmpImg.GetPixel(i + x, j + y);
                                r += pixel.R * kernel[x + 1, y + 1];
                                g += pixel.G * kernel[x + 1, y + 1];
                                b += pixel.B * kernel[x + 1, y + 1];
                            }
                        }

                        r = Math.Min(Math.Max(r, 0), 255);
                        g = Math.Min(Math.Max(g, 0), 255);
                        b = Math.Min(Math.Max(b, 0), 255);

                        newImage.SetPixel(i, j, Color.FromArgb(r, g, b));
                    }
                }
            }
            else if (radbtnGaussianBlurFilter.Checked)
            {
                double[,] gaussian = {
                    { 1, 2, 1 },
                    { 2, 4, 2 },
                    { 1, 2, 1 }
                };

                for (int i = 1; i < width - 1; i++)
                {
                    for (int j = 1; j < height - 1; j++)
                    {
                        double r = 0, g = 0, b = 0;
                        double weightSum = 0;

                        for (int x = -1; x <= 1; x++)
                        {
                            for (int y = -1; y <= 1; y++)
                            {
                                double weight = gaussian[x + 1, y + 1];
                                Color pixel = bmpImg.GetPixel(i + x, j + y);

                                r += pixel.R * weight;
                                g += pixel.G * weight;
                                b += pixel.B * weight;
                                weightSum += weight;
                            }
                        }

                        r = r / weightSum;
                        g = g / weightSum;
                        b = b / weightSum;

                        newImage.SetPixel(i, j, Color.FromArgb((int)r, (int)g, (int)b));
                    }
                }
            }
            else if (radbtnSobelEdgedetectionFilter.Checked)
            {
                int[,] gx = {
                    { -1, 0, 1 },
                    { -2, 0, 2 },
                    { -1, 0, 1 }
                };
                int[,] gy = {
                    { -1, -2, -1 },
                    {  0,  0,  0 },
                    {  1,  2,  1 }
                };

                for (int i = 1; i < width - 1; i++)
                {
                    for (int j = 1; j < height - 1; j++)
                    {
                        int gxR = 0, gxG = 0, gxB = 0;
                        int gyR = 0, gyG = 0, gyB = 0;

                        for (int x = -1; x <= 1; x++)
                        {
                            for (int y = -1; y <= 1; y++)
                            {
                                Color pixel = bmpImg.GetPixel(i + x, j + y);
                                gxR += pixel.R * gx[x + 1, y + 1];
                                gyR += pixel.R * gy[x + 1, y + 1];
                                gxG += pixel.G * gx[x + 1, y + 1];
                                gyG += pixel.G * gy[x + 1, y + 1];
                                gxB += pixel.B * gx[x + 1, y + 1];
                                gyB += pixel.B * gy[x + 1, y + 1];
                            }
                        }

                        int r = Math.Min(Math.Abs(gxR) + Math.Abs(gyR), 255);
                        int g = Math.Min(Math.Abs(gxG) + Math.Abs(gyG), 255);
                        int b = Math.Min(Math.Abs(gxB) + Math.Abs(gyB), 255);

                        newImage.SetPixel(i, j, Color.FromArgb(r, g, b));
                    }
                }
            }
            else if (radbtnBrightnessAdjustmentFilter.Checked)
            {
                int brightnessIncrease = 40;
                for (int i = 0; i < width; i++)
                {
                    for (int j = 0; j < height; j++)
                    {
                        Color pixel = bmpImg.GetPixel(i, j);
                        int r = Math.Min(pixel.R + brightnessIncrease, 255);
                        int g = Math.Min(pixel.G + brightnessIncrease, 255);
                        int b = Math.Min(pixel.B + brightnessIncrease, 255);

                        newImage.SetPixel(i, j, Color.FromArgb(r, g, b));
                    }
                }
            }
            else if (radbtnNegativeFilter.Checked)
            {
                for (int i = 0; i < width; i++)
                {
                    for (int j = 0; j < height; j++)
                    {
                        Color pixel = bmpImg.GetPixel(i, j);
                        int r = 255 - pixel.R;
                        int g = 255 - pixel.G;
                        int b = 255 - pixel.B;

                        newImage.SetPixel(i, j, Color.FromArgb(r, g, b));
                    }
                }
            }
            else if (radbtnUnsharpFilter.Checked)
            {
                Bitmap blurred = new Bitmap(width, height);
                double[,] gaussian = {
                    { 1, 2, 1 },
                    { 2, 4, 2 },
                    { 1, 2, 1 }
                };

                for (int x = 1; x < width - 1; x++)
                {
                    for (int y = 1; y < height - 1; y++)
                    {
                        double r = 0, g = 0, b = 0;
                        double weightSum = 0;

                        for (int fx = -1; fx <= 1; fx++)
                        {
                            for (int fy = -1; fy <= 1; fy++)
                            {
                                Color temp = bmpImg.GetPixel(x + fx, y + fy);
                                double weight = gaussian[fx + 1, fy + 1];
                                r += temp.R * weight;
                                g += temp.G * weight;
                                b += temp.B * weight;
                                weightSum += weight;
                            }
                        }

                        r = r / weightSum;
                        g = g / weightSum;
                        b = b / weightSum;

                        blurred.SetPixel(x, y, Color.FromArgb((int)r, (int)g, (int)b));
                    }
                }

                for (int x = 0; x < width; x++)
                {
                    for (int y = 0; y < height; y++)
                    {
                        Color orig = bmpImg.GetPixel(x, y);
                        Color blur = blurred.GetPixel(x, y);

                        int r = orig.R + (orig.R - blur.R);
                        int g = orig.G + (orig.G - blur.G);
                        int b = orig.B + (orig.B - blur.B);

                        r = Math.Min(Math.Max(r, 0), 255);
                        g = Math.Min(Math.Max(g, 0), 255);
                        b = Math.Min(Math.Max(b, 0), 255);

                        newImage.SetPixel(x, y, Color.FromArgb(r, g, b));
                    }
                }
            }

            picBoxFilterdImage.Image = newImage;
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "JPEG Files|*.jpg;*.jpeg|PNG Files|*.png|Bitmap Files|*.bmp|GIF Files|*.gif|TIFF Files|*.tiff;*.tif|WebP Files|*.webp|HEIC Files|*.heic|All Files|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    sourceImage = Image.FromFile(openFileDialog1.FileName);
                    picBoxSource.Image = sourceImage;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void histogramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormHistogram().Show();
        }

        private void rGBSeperationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormRGB().Show();
        }

        private void grayScaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormGrayscale().Show();
        }

        private void radbtnAverageFilter_CheckedChanged(object sender, EventArgs e) { }

        private void radbtnGaussianBlurFilter_CheckedChanged(object sender, EventArgs e) { }
    }
}
