using System.Diagnostics;
using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace TextArtMaker.lib
{
    internal class ASCII
    {
        // 輝度に応じたASCII文字（陰影のグラデーション）
        private static readonly string asciiChars = "@%#*+=-:. ";

        public string Convert(Image image)
        {
            int width = image.Width;
            int height = image.Height;

            using (Bitmap bitmap = new Bitmap(image, new Size(width, height)))
            {
                StringBuilder sb = new StringBuilder();

                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        Color pixel = bitmap.GetPixel(x, y);
                        int gray = (pixel.R + pixel.G + pixel.B) / 3;
                        int index = gray * (asciiChars.Length - 1) / 255;
                        sb.Append(asciiChars[index]);
                    }
                    sb.AppendLine();
                }

                string ASCII_ART = sb.ToString();
                Notepad(ASCII_ART);
                return ASCII_ART;
            }
        }

        private static void Notepad(string text)
        {
            try
            {
                string archiveDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "archive");
                if (!Directory.Exists(archiveDir))
                {
                    Directory.CreateDirectory(archiveDir);
                }

                string filePath = Path.Combine(archiveDir, $"ascii_{Guid.NewGuid()}.txt");
                File.WriteAllText(filePath, text, Encoding.UTF8);

                Process.Start("notepad.exe", filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Text Art Maker", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
