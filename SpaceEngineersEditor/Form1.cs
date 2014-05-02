using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SpaceEngineersEditor
{
    public partial class Form1 : Form
    {
        private XDocument xdoc;
        private const string BAKPostfix = "_SEEBAK";
        private string fullFilePath;
        private string fileName;

        private bool fileLoaded = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            var fd = new OpenFileDialog();

            fd.Filter = "Space Engineers data file (.sbc)|*.sbc";
            fd.FilterIndex = 0;

            var diagResult = fd.ShowDialog();

            if (diagResult == DialogResult.OK)
            {
                if (fd.SafeFileName == "CubeBlocks.sbc")
                {
                    xdoc = backupIfNeeded(fd);
                    fullFilePath = fd.FileName;
                    fileName = fd.SafeFileName;
                    fileLoadHandler();
                }
                else
                {
                    MessageBox.Show("Selected file is not CubeBlocks.sbc!", "Wrong file!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                
            }
            
        }

        private void performChanges(int divider)
        {
            foreach (var element in xdoc.Descendants("BuildTimeSeconds"))
            {
                element.Value = ((int)double.Parse(element.Value) / divider).ToString();
            }
            xdoc.Save(fullFilePath);
            MessageBox.Show("CubeBlocks.sbc has been updated with x" + divider + " faster build times.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private XDocument backupIfNeeded(OpenFileDialog fd){
            XDocument bak;
            if (!File.Exists(fd.SafeFileName + BAKPostfix))
            {
                bak = XDocument.Load(fd.FileName);
                bak.Save(fd.SafeFileName + BAKPostfix);
            }
            else
            {
                bak = XDocument.Load(fd.SafeFileName + BAKPostfix);
            }
            return bak;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XDocument bak = XDocument.Load(fileName + BAKPostfix);
            bak.Save(fullFilePath);
            MessageBox.Show("CubeBlocks.sbc has been reset to the saved backup.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void fileLoadHandler()
        {
            resetBtn.Enabled = true;
            x3Btn.Enabled = true;
            x10Btn.Enabled = true;
            fileLoaded = true;
            fileLoadedLabel.Text = "File Loaded";
            fileLoadedLabel.BackColor = Color.Green;
        }

        private void x3Btn_Click(object sender, EventArgs e)
        {
            performChanges(3);
        }

        private void x10Btn_Click(object sender, EventArgs e)
        {
            performChanges(10);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("This program takes the original CubeBlocks.sbc and makes a backup of this, this backup will be the 'control' and will be used for calculating build speeds and reverting back to the original file.");
        }
    }
}
