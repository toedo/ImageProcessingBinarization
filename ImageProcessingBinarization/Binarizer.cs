using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessingBinarization
{
    internal class Binarizer
    {
        public Binarizer() { }

        public Bitmap EdgeDetector(Bitmap bitmap) //Bruges til at tegne en rød outline om alle sorte objekter
        {
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
                        if (ColorIntensity(c) < 150 && c.R < 10) //Hvis en Pixel på listen er sort, sættes farven af midterpixel til rød
                        {

                            bitmap.SetPixel(i, j, Color.Red);
                            colors.Clear();
                            break;
                        }
                    }

                }
            }
            //Koden her er nestet noget mere end jeg normalt kan lide, men metoden er simpel nok til at det nok går
            return bitmap;

        }

        public List<Color> AdjPixelColors(int x, int y, Bitmap bitmap)
        {
            List<Color> colors = new List<Color>();
            colors.Clear();
            bool isBlack = false;
            for (int j = -1; j <= 1; j++)
            {
                if (isBlack == true) { colors.Clear(); break; } //Hvis Pixelen i midten er sort, bliver listen clearet og loopet sluttes
                for (int i = -1; i <= 1; i++)
                {
                    int xi = x - i;
                    int yj = y - i;
                    if (xi == x && yj == y)
                    {
                        Color colorTest = bitmap.GetPixel(xi, yj);
                        if (ColorIntensity(colorTest) < 100) { isBlack = true; break; } //Tjekker om Pixelen i midten er sort
                    }
                    else if (xi >= 0 && xi < bitmap.Width && yj >= 0 && yj < bitmap.Height)
                    {
                        colors.Add(bitmap.GetPixel(xi, yj));
                    }
                }
            }
            return colors;
        }

        public int ColorIntensity(Color color) //Returner den gennemsnitlige lysintensitet for en pixel
        {
            byte r = color.R;
            byte g = color.G;
            byte b = color.B;
            int avg = Convert.ToInt16(r + g + b) / 3;

            return avg;
        }

    }
}
