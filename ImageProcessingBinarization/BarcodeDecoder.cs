using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV;
using Emgu.CV.Structure;
using ZXing;
using ZXing.EmguCV;

namespace ImageProcessingBinarization
{
    public class BarcodeDecoder
    {
        public BarcodeDecoder() { }

        public Image<Bgr, float> SobelFilter(Image<Bgr, float> image)
        {
            image = image.Sobel(1, 0, 3); //Påfører et Sobel-filter, som gør kanter mere tydelige.
            return image;
        }
        public Image<Bgr, float> BarcodeRect(Image<Bgr, float> image, out string BarcodeCode)
        {
            var detector = new BarcodeReader
            {
                Options = new ZXing.Common.DecodingOptions
                {
                    PossibleFormats = new List<BarcodeFormat> { BarcodeFormat.UPC_A, BarcodeFormat.CODE_128, BarcodeFormat.UPC_E },
                    TryHarder = true
                }
            };
            Bitmap bitmap = image.ToBitmap();
            Image<Bgr,byte> imageByte = bitmap.ToImage<Bgr, byte>();

            Result result = detector.Decode(imageByte);
            if(result == null)
            {
                throw new Exception(result.Text);
            }
            float minX = result.ResultPoints.Min(p => p.X);
            float minY = result.ResultPoints.Min(p => p.Y);
            float maxX = result.ResultPoints.Max(p => p.X);
            float maxY = result.ResultPoints.Max(p => p.Y);
            Rectangle rect = Rectangle.Round(new RectangleF(minX, minY, maxX - minX, maxY - minY));
            image.Draw(rect, new Bgr(Color.Red), thickness: 2);
            BarcodeCode = result.Text;
            return image;
        }
    }
}
