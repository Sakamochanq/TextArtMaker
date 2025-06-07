using System;
using System.Drawing;

namespace TextArtMaker
{
    internal class ImageEdit
    {
        public Bitmap GrayScale(Image image)
        {
            Bitmap bmp = new Bitmap(image);

            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    Color pixelColor = bmp.GetPixel(x, y);
                    int grayValue = (int)(pixelColor.R * 0.3 + pixelColor.G * 0.59 + pixelColor.B * 0.11);
                    Color grayColor = Color.FromArgb(grayValue, grayValue, grayValue);
                    bmp.SetPixel(x, y, grayColor);
                }
            }
            return bmp;
        }

        public Bitmap Reverse(Image image)
        {
            Bitmap bmp = new Bitmap(image);

            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    Color pixelColor = bmp.GetPixel(x, y);
                    Color reversedColor = Color.FromArgb(255 - pixelColor.R, 255 - pixelColor.G, 255 - pixelColor.B);
                    bmp.SetPixel(x, y, reversedColor);
                }
            }
            return bmp;
        }
    }
}
