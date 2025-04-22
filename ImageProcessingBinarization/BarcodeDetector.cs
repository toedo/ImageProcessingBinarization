using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV;
using Emgu.CV.Structure;

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
    }
}
