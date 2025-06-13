using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using TextArtMaker.lib;

namespace TextArtMaker
{
    public partial class Source : Form
    {
        private ImageEdit ImageEdit;
        private ASCII ASCII;

        public Source()
        {
            InitializeComponent();

            StyleSelectBox.Items.Add("GrayScale");
            StyleSelectBox.Items.Add("Reverse");
            StyleSelectBox.SelectedIndex = 0;
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
                    Image loadedImage = Image.FromFile(ofd.FileName);
                    OriginPictureBox.Image = loadedImage;



                    Application.DoEvents();

                    ImageEdit = new ImageEdit();

                    switch (StyleSelectBox.SelectedIndex)
                    {
                        case 0:
                            ResultPictureBox.Image = ImageEdit.GrayScale(loadedImage);
                            break;
                        case 1:
                            ResultPictureBox.Image = ImageEdit.Reverse(loadedImage);
                            break;
                        default:
                            return;
                    }
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
            ScaleTrackBar.Value = 20;
            ScaleLabel.Text = $"ASCI I の全体サイズ： {20} %";
            stripScaleLabel.Text = $"Scale：{20} %";
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
                string ASCII_ART = ASCII.Convert(ResultPictureBox.Image, ScaleTrackBar.Value);
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
            stripStyleLabel.Text = $"Scale：{StyleSelectBox.SelectedItem.ToString()}";
        }
    }
}
