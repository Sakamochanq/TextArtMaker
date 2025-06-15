using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.IO;
using System;

namespace TextArtMaker.lib
{
    internal class ASCII
    {
        // 輝度に応じたASCII文字（陰影のグラデーション）
        private static readonly string asciiChars = "@%#*+=-:. ";

        public string Convert(Image image, int scalePercent)
        {
            if (scalePercent < 1 || scalePercent > 100)
                throw new ArgumentOutOfRangeException(nameof(scalePercent), "Scale must be between 1 and 100");

            int width = image.Width * scalePercent / 100;
            int height = image.Height * scalePercent / 100;

            // 文字の縦横比に補正（文字は縦に長いので補正をかける）
            double charAspect = 0.5;

            height = (int)(height * charAspect);

            using (Bitmap bitmap = new Bitmap(image, new Size(width, height)))
            {
                StringBuilder sb = new StringBuilder();

                for (int y = 0; y < bitmap.Height; y++)
                {
                    for (int x = 0; x < bitmap.Width; x++)
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
                // 子フォルダであるarchiveフォルダを指定
                string archiveDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "archive");

                // archiveフォルダがない場合は作成
                if (!Directory.Exists(archiveDir))
                {
                    Directory.CreateDirectory(archiveDir);
                }

                // 乱数（GUID）を割り当て、UTF8でエンコードして保存
                string filePath = Path.Combine(archiveDir, $"ascii_{Guid.NewGuid()}.txt");
                File.WriteAllText(filePath, text, Encoding.UTF8);

                // 標準のメモ帳アプリで、保存したテキストファイルを開く
                Process.Start("notepad.exe", filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Text Art Maker", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
