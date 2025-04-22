using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace ImageProcessingBinarization
{
    public partial class Form2 : Form
    {
        public Form2(Image image)
        {
            InitializeComponent();
            if (image != null)
            {
                pictureBox1.Image = image; // Assuming Form2 has a PictureBox named pictureBox1
            }
        }

        private void BinarizedImage_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void BarcodeDetectButton_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("SobelFilterImage is not initialized.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Image originalImage = pictureBox1.Image;
            BarcodeDecoder decoder = new BarcodeDecoder();

            Bitmap bitmap = new Bitmap(originalImage);
            Image<Bgr, float> image = decoder.BarcodeRect(bitmap.ToImage<Bgr, float>(), out string BarcodeText);
            BarcodeCode.Text = BarcodeText; 
            BarcodeOutliner.Image = image.AsBitmap();           
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
