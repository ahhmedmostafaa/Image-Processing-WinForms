using openCV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageProcessing
{
    public partial class FormGrayscale : Form
    {
        public FormGrayscale()
        {
            InitializeComponent();
        }

        IplImage image1;
        Bitmap bmp;

        private void FormGrayscale_Load(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "JPEG Files|*.jpg;*.jpeg|PNG Files|*.png|Bitmap Files|*.bmp|GIF Files|*.gif|TIFF Files|*.tiff;*.tif|WebP Files|*.webp|HEIC Files|*.heic|All Files|*.*";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    image1 = cvlib.CvLoadImage(openFileDialog1.FileName, cvlib.CV_LOAD_IMAGE_COLOR);
                    CvSize size = new CvSize(pictureBox1.Width, pictureBox1.Height);
                    IplImage resized_image = cvlib.CvCreateImage(size, image1.depth, image1.nChannels);
                    cvlib.CvResize(ref image1, ref resized_image, cvlib.CV_INTER_LINEAR);

                    // Convert to Bitmap
                    IntPtr ptr = resized_image.imageData;
                    bmp = new Bitmap(resized_image.width, resized_image.height, resized_image.widthStep,
                        PixelFormat.Format24bppRgb, ptr);

                    pictureBox1.Image = new Bitmap(bmp); // Display a copy to avoid locking
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void grayscaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bmp == null)
            {
                MessageBox.Show("Please load an image first.");
                return;
            }

            Bitmap grayBmp = new Bitmap(bmp); // Copy the original
            int width = grayBmp.Width;
            int height = grayBmp.Height;

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color p = grayBmp.GetPixel(x, y);
                    int a = p.A;
                    int r = p.R;
                    int g = p.G;
                    int b = p.B;
                    int avg = (r + g + b) / 3;
                    grayBmp.SetPixel(x, y, Color.FromArgb(a, avg, avg, avg));
                }
            }

            pictureBox2.Image = grayBmp;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FormGrayscale_Load_1(object sender, EventArgs e)
        {

        }
    }
}
