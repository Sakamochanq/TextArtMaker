using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using TextArtMaker.lib;

namespace TextArtMaker
{
    public partial class Source : Form
    {
        private ImageEdit ImageEdit;
        private Image loadedImage;
        private string ASCII_ART;
        private ASCII ASCII;

        public Source()
        {
            InitializeComponent();

            WaitingLabel.Visible = false;

            ScaleSelectBox.Items.Add("1x");
            ScaleSelectBox.Items.Add("2x");
            ScaleSelectBox.Items.Add("3x");
            ScaleSelectBox.Items.Add("4x");
            ScaleSelectBox.Items.Add("5x");
            ScaleSelectBox.SelectedIndex = 0;

            StyleSelectBox.Items.Add("Default");
            StyleSelectBox.Items.Add("GrayScale");
            StyleSelectBox.Items.Add("Reverse");
            StyleSelectBox.Items.Add("SepiaTone");
            StyleSelectBox.Items.Add("HistogramEqualization");
            StyleSelectBox.SelectedIndex = 1;
        }

        // 画像のラベルとスケールの値を更新するメソッド
        private void Sender(string label_text, int scale_value)
        {
            ScaleTrackBar.Value = scale_value;
            ScaleLabel.Text = $"ASCI I の全体サイズ： {scale_value} %";
            stripScaleLabel.Text = $"Scale：{scale_value} %";
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Windows画像形式（*.png; *.jpeg; *.bmp）|*.png; *.jpeg; *.jpg; *.bmp;" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string full_file_path = ofd.FileName;
                    string fileName = Path.GetFileName(full_file_path);
                    stripImageLabel.Text = $"Image：{fileName}";

                    // 画像を明示的に読み込む
                    loadedImage = Image.FromFile(ofd.FileName);
                    OriginPictureBox.Image = loadedImage;

                    ResultPictureBox.Image = null;
                    WaitingLabel.Visible = true;
                    Application.DoEvents();

                    ImageEdit = new ImageEdit();

                    switch (StyleSelectBox.SelectedIndex)
                    {
                        case 0:
                            ResultPictureBox.Image = ImageEdit.Default(loadedImage);
                            break;
                        case 1:
                            ResultPictureBox.Image = ImageEdit.GrayScale(loadedImage);
                            break;
                        case 2:
                            ResultPictureBox.Image = ImageEdit.Reverse(loadedImage);
                            break;
                        case 3:
                            ResultPictureBox.Image = ImageEdit.SepiaTone(loadedImage);
                            break;
                        case 4:
                            ResultPictureBox.Image = ImageEdit.HistogramEqualization(loadedImage);
                            break;
                        default:
                            return;
                    }

                    WaitingLabel.Visible = false;
                    Application.DoEvents();
                }
            }
        }

        private void OpenArchiveButton_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists("archive"))
            {
                return;
            }
            else
            {
                Process.Start("explorer.exe", Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "archive"));
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            OriginPictureBox.Image = null;
            ResultPictureBox.Image = null;
            loadedImage = null;
            ASCII_ART = null;

            Sender("20", 20);

            stripImageLabel.Text = "Image：null";

        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            if(ResultPictureBox.Image == null)
            {
                return;
            }

            try
            {
                ASCII = new ASCII();
                ASCII_ART = ASCII.Convert(ResultPictureBox.Image, ScaleTrackBar.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Text Art Maker", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ScaleTrackBar_Scroll(object sender, EventArgs e)
        {
            ScaleLabel.Text = $"ASCI I の全体サイズ： {ScaleTrackBar.Value.ToString()} %";
            stripScaleLabel.Text = $"Scale：{ScaleTrackBar.Value.ToString()} %";
        }

        private void StyleSelectBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            stripStyleLabel.Text = $"Style：{StyleSelectBox.SelectedItem.ToString()}";

            if (loadedImage != null)
            {
                //既存の画像をクリア
                ResultPictureBox.Image = null;
                WaitingLabel.Visible = true;
                Application.DoEvents();

                switch (StyleSelectBox.SelectedIndex)
                {
                    case 0:
                        ResultPictureBox.Image = ImageEdit.Default(loadedImage);
                        break;
                    case 1:
                        ResultPictureBox.Image = ImageEdit.GrayScale(loadedImage);
                        break;
                    case 2:
                        ResultPictureBox.Image = ImageEdit.Reverse(loadedImage);
                        break;
                    case 3:
                        ResultPictureBox.Image = ImageEdit.SepiaTone(loadedImage);
                        break;
                    case 4:
                        ResultPictureBox.Image = ImageEdit.HistogramEqualization(loadedImage);
                        break;
                    default:
                        return;
                }

                WaitingLabel.Visible = false;
                Application.DoEvents();
            }
        }

        private void ScaleSelectBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ScaleSelectBox.SelectedIndex)
            {
                case 0:
                    Sender("20", 20);
                    break;
                case 1:
                    Sender("40", 40);
                    break;
                case 2:
                    Sender("60", 60);
                    break;
                case 3:
                    Sender("80", 80);
                    break;
                case 4:
                    Sender("100", 100);
                    break;
                default:
                    return;
            }
        }

        private void ExportPythonButton_Click(object sender, EventArgs e)
        {
            //変数ASCII_ARTがnullの場合
            if (string.IsNullOrEmpty(ASCII_ART))
            {
                return;
            }
            ExportPython exportPython = new ExportPython();
            exportPython.ToConsole(ASCII_ART);
        }

        private void SaveAsButton_Click(object sender, EventArgs e)
        {
            if (ResultPictureBox.Image != null)
            {
                using (var sfd = new SaveFileDialog() { Filter = "BitMap形式(*.bmp) | *.bmp; | PNG形式(*.png) | *.png; | JPEG形式(*.jpg *.jpeg) | *.jpg; *.jpeg; | Windowsメタ形式(*.wmf) | *.wmf;" })
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            string FileName = sfd.FileName;

                            switch (Path.GetExtension(FileName).ToLower())
                            {
                                case ".bmp":
                                    ResultPictureBox.Image.Save(FileName, ImageFormat.Bmp);
                                    break;

                                case ".png":
                                    ResultPictureBox.Image.Save(FileName, ImageFormat.Png);
                                    break;

                                case ".jpg":
                                case ".jpeg":
                                    ResultPictureBox.Image.Save(FileName, ImageFormat.Jpeg);
                                    break;
                                case ".wmf":
                                    ResultPictureBox.Image.Save(FileName, ImageFormat.Wmf);
                                    break;
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                }
            }
        }
    }
}
