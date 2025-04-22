using Emgu.CV;
using Emgu.CV.Structure;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Text;

namespace ImageProcessingBinarization
{
    public partial class Form1 : Form
    {
        Binarizer processor = new Binarizer();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void BinarizeButton(object sender, EventArgs e)
        {
            var threshold = 85; //Grænsen for farveintensitet
            Color color;
            Color binarize;

            Bitmap bitmap = new Bitmap(OriginalImage.Image); //Image som skal binariseres
            int h = bitmap.Height;
            int w = bitmap.Width;

            for (int j = 0; j < h; j++) //Tjekker hver pixel i OriginalImage og tager gennemsnittet af
                                        //intensiteten af deres RBG-farver og gør pixel hhv. hvide og sorte.
            {
                for (int i = 0; i < w; i++)
                {
                    color = bitmap.GetPixel(i, j);
                    int avg = processor.ColorIntensity(color);
                    if (avg > threshold)
                    {
                        binarize = Color.White;
                    }
                    else
                    {
                        binarize = Color.Black;
                    }

                    bitmap.SetPixel(i, j, binarize);
                }
            }
            BinarizedImage.Image = bitmap; //Tilføjer det nye bitmap til BinarizedImage
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void EdgeDetectButton(object sender, EventArgs e)
        {

            Bitmap bitmap = processor.EdgeDetector(new Bitmap(BinarizedImage.Image));
            EdgeMap.Image = bitmap; //Tilføjer det nye bitmap til EdgeMap
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            BarcodeDecoder barcodeDetector = new BarcodeDecoder();
            Bitmap bitmap = new Bitmap(BinarizedImage.Image);


            Image<Bgr, float> newImage = bitmap.ToImage<Bgr, float>();
            newImage = barcodeDetector.SobelFilter(newImage);
            BarcodeDetect.Image = newImage.AsBitmap<Bgr, float>();
        }   
    }
}
