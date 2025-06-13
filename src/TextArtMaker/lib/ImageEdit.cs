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

        public Bitmap SepiaTone(Image image)
        {
            Bitmap bmp = new Bitmap(image);

            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    Color original = bmp.GetPixel(x, y);

                    int tr = (int)(0.393 * original.R + 0.769 * original.G + 0.189 * original.B);
                    int tg = (int)(0.349 * original.R + 0.686 * original.G + 0.168 * original.B);
                    int tb = (int)(0.272 * original.R + 0.534 * original.G + 0.131 * original.B);

                    // 値が255を超えないように調整
                    int r = Math.Min(255, tr);
                    int g = Math.Min(255, tg);
                    int b = Math.Min(255, tb);

                    bmp.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
            }
            return bmp;
        }
    }
}
