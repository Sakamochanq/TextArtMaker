using System.Drawing;
using System.Text;

namespace TextArtMaker.lib
{
    internal class ASCII
    {
        // 輝度に応じたASCII文字（陰影のグラデーション）
        private static readonly string asciiChars = "@%#*+=-:. ";

        public static string Convert(Image image)
        {
            int width = 100;
            double revision = 0.5;

            // アスペクト比を考慮して高さを決定（文字の縦横比の補正）
            double aspectRatio = (double)image.Height / image.Width;
            int height = (int)(aspectRatio * width * revision);

            using (Bitmap resized = new Bitmap(image, new Size(width, height)))
            {
                StringBuilder sb = new StringBuilder();

                for (int y = 0; y < resized.Height; y++)
                {
                    for (int x = 0; x < resized.Width; x++)
                    {
                        Color pixel = resized.GetPixel(x, y);
                        int gray = (pixel.R + pixel.G + pixel.B) / 3;
                        int index = gray * (asciiChars.Length - 1) / 255;
                        sb.Append(asciiChars[index]);
                    }
                    sb.AppendLine();
                }

                return sb.ToString();
            }
        }
    }
}
