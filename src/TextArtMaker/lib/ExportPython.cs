using System.IO;
using System.Text;
using System.Windows.Forms;

namespace TextArtMaker.lib
{
    internal class ExportPython
    {
        public void ToConsole(string text)
        {
            using (var saveFileDialog = new SaveFileDialog() { Filter = "Python(*.py) | *.py" })
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var pythonCode = $"print(\"\"\"{text}\"\"\")";
                    File.WriteAllText(saveFileDialog.FileName, pythonCode, Encoding.UTF8);
                }
            }
        }
    }
}
