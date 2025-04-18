using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Text;

namespace ImageProcessingBinarization
{
    public partial class Form1 : Form
    {
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

        private void button1_Click(object sender, EventArgs e)
        {
            var threshold = 85; //Intensity of color
            Color color;
            Color binarize;

            Bitmap bitmap = new Bitmap(OriginalImage.Image); //Image som skal binariseres
            Graphics graphics = BinarizedImage.CreateGraphics(); //Hvor det skal binariseres
            int h = bitmap.Height;
            int w = bitmap.Width;

            for (int j = 0; j < h; j++) //Tjekker hver pixel i OriginalImage og tager gennemsnittet af intensiteten af deres RBG-farver og gør pixel hhv. hvide og sorte.
            {
                for (int i = 0; i < w; i++)
                {
                    color = bitmap.GetPixel(i, j);
                    int avg = ColorIntensity(color);
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

        private void button3_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(BinarizedImage.Image); //Image til edge detection
            int h = bitmap.Height;
            int w = bitmap.Width;
            List<Color> colors = new List<Color>();
            for (int j = 0; j < h; j++)
            {
                for (int i = 0; i < w; i++)
                {
                    colors = AdjPixelColors(i, j, bitmap);
                    foreach (Color c in colors)
                    {
                        if (ColorIntensity(c) < 150 && c.R < 150)
                        {
  
                            bitmap.SetPixel(i,j,Color.Red);
                            colors.Clear();
                            break;
                        }
                    }
                    
                }
            }
            EdgeMap.Image = bitmap; //Tilføjer det nye bitmap til BinarizedImage
        }
        public List<Color> AdjPixelColors(int x, int y, Bitmap bitmap)
        {
            List<Color> colors = new List<Color>();
            colors.Clear();
            for (int j = -1; j <= 1; j++)
            {
                for (int i = -1; i <= 1; i++)
                {
                    int xi = x - i;
                    int yj = y - i;
                    if (xi == x && yj == y)
                    {
                        Color colorTest = bitmap.GetPixel(xi, yj);
                        if (ColorIntensity(colorTest) < 150 && colorTest.R > 150) { break; }
                    }
                    else if(xi >= 0 && xi < bitmap.Width && yj >= 0 && yj < bitmap.Height)
                    {
                        colors.Add(bitmap.GetPixel(xi, yj));
                    } 
                }
            }
            return colors;
        }
        public int ColorIntensity(Color color)
        {
            byte r = color.R;
            byte g = color.G;
            byte b = color.B;
            int avg = Convert.ToInt16(r + g + b) / 3;

            return avg;
        }
    }
}
