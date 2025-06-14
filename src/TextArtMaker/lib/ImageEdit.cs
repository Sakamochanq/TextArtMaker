using System;
using System.Drawing;

namespace TextArtMaker
{
    internal class ImageEdit
    {
        public Bitmap Default(Image image)
        {
            Bitmap bmp = new Bitmap(image);
            return bmp;
        }

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

        // GithubCopilot wrote
        // Thank you.
        public Bitmap HistogramEqualization(Image image)
        {
            Bitmap bmp = new Bitmap(image);
            int width = bmp.Width;
            int height = bmp.Height;

            // グレースケール化
            byte[,] gray = new byte[width, height];
            int[] histogram = new int[256];

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color pixel = bmp.GetPixel(x, y);
                    byte grayValue = (byte)(pixel.R * 0.3 + pixel.G * 0.59 + pixel.B * 0.11);
                    gray[x, y] = grayValue;
                    histogram[grayValue]++;
                }
            }

            // 累積ヒストグラム
            int[] cumulative = new int[256];
            cumulative[0] = histogram[0];
            for (int i = 1; i < 256; i++)
            {
                cumulative[i] = cumulative[i - 1] + histogram[i];
            }

            int totalPixels = width * height;
            byte[] equalizedMap = new byte[256];
            for (int i = 0; i < 256; i++)
            {
                equalizedMap[i] = (byte)(255.0 * cumulative[i] / totalPixels);
            }

            // 新しい画像を生成
            Bitmap result = new Bitmap(width, height);
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    byte newVal = equalizedMap[gray[x, y]];
                    result.SetPixel(x, y, Color.FromArgb(newVal, newVal, newVal));
                }
            }
            return result;
        }
    }
}
