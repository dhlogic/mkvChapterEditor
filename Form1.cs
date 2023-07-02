using System.Diagnostics;
using System.Security.Cryptography.Xml;
using System.Xml.Linq;

namespace mkvChapterEditor
{
    
    public partial class Form1 : Form
    {
        public static class Globals
        {
            public static string TempFolderPath { get; } = Path.GetTempPath();
            public static string XMLFilePath { get; } = Path.Combine(TempFolderPath, "chapters.xml");
            public static string MKVPath { get; set; } = string.Empty;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select MKV";
            openFileDialog.InitialDirectory = @"C:\";
            openFileDialog.Filter = "MKV File (*.mkv)|*.mkv";
            openFileDialog.ShowDialog();

            if (openFileDialog.FileName != "")
            {
                tbMKVpath.Text = openFileDialog.FileName;

                Globals.MKVPath = tbMKVpath.Text;
                var mkvextractProcess = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = "mkvextract",
                        Arguments = $"\"{Globals.MKVPath}\" chapters {Globals.XMLFilePath}",
                        RedirectStandardOutput = true,
                        UseShellExecute = false,
                        CreateNoWindow = true,
                    }
                };
                mkvextractProcess.Start();
                mkvextractProcess.WaitForExit();

                XDocument mkvXML = XDocument.Load($"{Globals.XMLFilePath}");
                var chapterStrings = mkvXML.Descendants("ChapterString").Select(e => e.Value).ToArray();
                tbCurrent.Text = string.Join(Environment.NewLine, chapterStrings);

            }
            else
            { tbMKVpath.Text = ""; }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbNew.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string[] newChapterStrings = tbNew.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.None);

            XDocument mkvXML = XDocument.Load($"{Globals.XMLFilePath}");

            var chapterStringElements = mkvXML.Descendants("ChapterString").ToList();

            for (int i = 0; i < Math.Min(chapterStringElements.Count, newChapterStrings.Length); i++)
            {
                chapterStringElements[i].Value = newChapterStrings[i];
            }

            mkvXML.Save($"{Globals.XMLFilePath}");

            var mkvupdateProcess = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "mkvpropedit",
                    Arguments = $"\"{Globals.MKVPath}\" --chapters {Globals.XMLFilePath}",
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true,
                }
            };
            mkvupdateProcess.Start();
            mkvupdateProcess.WaitForExit();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            tbCurrent.Text = "";
            var mkvextractProcess = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "mkvextract",
                    Arguments = $"\"{Globals.MKVPath}\" chapters {Globals.XMLFilePath}",
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true,
                }
            };
            mkvextractProcess.Start();
            mkvextractProcess.WaitForExit();

            XDocument mkvXML = XDocument.Load($"{Globals.XMLFilePath}");
            var chapterStrings = mkvXML.Descendants("ChapterString").Select(e => e.Value).ToArray();
            tbCurrent.Text = string.Join(Environment.NewLine, chapterStrings);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            File.Delete($"{Globals.XMLFilePath}");
        }
    }

}