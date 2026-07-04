using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace ImageProcessing
{
    public partial class FormRGB : Form
    {
        Image sourceImage;

        public FormRGB()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "JPEG Files|*.jpg;*.jpeg|PNG Files|*.png|Bitmap Files|*.bmp|GIF Files|*.gif|TIFF Files|*.tiff;*.tif|WebP Files|*.webp|HEIC Files|*.heic|All Files|*.*";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    sourceImage = Image.FromFile(openFileDialog1.FileName);
                    picSourceImage.Image = new Bitmap(sourceImage);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image: " + ex.Message);
                }
            }
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            if (picSourceImage.Image == null)
            {
                MessageBox.Show("Please open an image first.");
                return;
            }

            Bitmap source = new Bitmap(picSourceImage.Image);
            Bitmap redImage = new Bitmap(source.Width, source.Height, PixelFormat.Format24bppRgb);

            Rectangle rect = new Rectangle(0, 0, source.Width, source.Height);
            BitmapData srcData = source.LockBits(rect, ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            BitmapData redData = redImage.LockBits(rect, ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);

            int stride = srcData.Stride;

            unsafe
            {
                byte* srcPtr = (byte*)srcData.Scan0.ToPointer();
                byte* redPtr = (byte*)redData.Scan0.ToPointer();

                for (int y = 0; y < source.Height; y++)
                {
                    for (int x = 0; x < source.Width; x++)
                    {
                        int index = y * stride + x * 3;
                        byte r = srcPtr[index + 2];

                        redPtr[index] = 0;
                        redPtr[index + 1] = 0;
                        redPtr[index + 2] = r;
                    }
                }
            }

            source.UnlockBits(srcData);
            redImage.UnlockBits(redData);

            picBoxRed.Image = redImage;
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            if (picSourceImage.Image == null)
            {
                MessageBox.Show("Please open an image first.");
                return;
            }

            Bitmap source = new Bitmap(picSourceImage.Image);
            Bitmap greenImage = new Bitmap(source.Width, source.Height, PixelFormat.Format24bppRgb);

            Rectangle rect = new Rectangle(0, 0, source.Width, source.Height);
            BitmapData srcData = source.LockBits(rect, ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            BitmapData greenData = greenImage.LockBits(rect, ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);

            int stride = srcData.Stride;

            unsafe
            {
                byte* srcPtr = (byte*)srcData.Scan0.ToPointer();
                byte* greenPtr = (byte*)greenData.Scan0.ToPointer();

                for (int y = 0; y < source.Height; y++)
                {
                    for (int x = 0; x < source.Width; x++)
                    {
                        int index = y * stride + x * 3;
                        byte g = srcPtr[index + 1];

                        greenPtr[index] = 0;
                        greenPtr[index + 1] = g;
                        greenPtr[index + 2] = 0;
                    }
                }
            }

            source.UnlockBits(srcData);
            greenImage.UnlockBits(greenData);

            picBoxGreen.Image = greenImage;
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            if (picSourceImage.Image == null)
            {
                MessageBox.Show("Please open an image first.");
                return;
            }

            Bitmap source = new Bitmap(picSourceImage.Image);
            Bitmap blueImage = new Bitmap(source.Width, source.Height, PixelFormat.Format24bppRgb);

            Rectangle rect = new Rectangle(0, 0, source.Width, source.Height);
            BitmapData srcData = source.LockBits(rect, ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            BitmapData blueData = blueImage.LockBits(rect, ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);

            int stride = srcData.Stride;

            unsafe
            {
                byte* srcPtr = (byte*)srcData.Scan0.ToPointer();
                byte* bluePtr = (byte*)blueData.Scan0.ToPointer();

                for (int y = 0; y < source.Height; y++)
                {
                    for (int x = 0; x < source.Width; x++)
                    {
                        int index = y * stride + x * 3;
                        byte b = srcPtr[index];

                        bluePtr[index] = b;
                        bluePtr[index + 1] = 0;
                        bluePtr[index + 2] = 0;
                    }
                }
            }

            source.UnlockBits(srcData);
            blueImage.UnlockBits(blueData);

            picBoxBlue.Image = blueImage;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
