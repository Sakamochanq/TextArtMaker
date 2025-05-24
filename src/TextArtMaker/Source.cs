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


                    ImageEdit = new ImageEdit();
                    GrayScalePictureBox.Image = ImageEdit.GrayScale(loadedImage);
                }
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            PathBox.Text = string.Empty;
            OriginPictureBox.Image = null;
            GrayScalePictureBox.Image = null;
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            try
            {
                ASCII = new ASCII();
                string ASCII_ART = ASCII.Convert(GrayScalePictureBox.Image);
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
