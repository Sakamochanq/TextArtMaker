using System;
using System.Drawing;
using System.Windows.Forms;
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
                    PathBox.Text = ofd.FileName;
                    Application.DoEvents();

                    // 画像を明示的に読み込む
                    Image loadedImage = Image.FromFile(ofd.FileName);
                    OriginPictureBox.Image = loadedImage;

                    // 進捗状況のラベル
                    StatusLabel.Text = "Converting Image ...";
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

                    StatusLabel.Text = "Converted Successfully";
                    Application.DoEvents();
                }
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            PathBox.Text = string.Empty;
            OriginPictureBox.Image = null;
            ResultPictureBox.Image = null;
            ScaleTrackBar.Value = 20;
            ScaleLabel.Text = "Scale: 20";

        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            if(ResultPictureBox.Image == null)
            {
                MessageBox.Show("画像を読み込んでください。", "Text Art Maker", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            ScaleLabel.Text = $"Scale: {ScaleTrackBar.Value.ToString()}";
        }
    }
}
