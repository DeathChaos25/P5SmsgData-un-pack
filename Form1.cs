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

namespace P5SmsgData
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private msgDataFile currentmsgData;
        public ushort numOfmsgDataPointers { get; set; }
        public uint msgDataPointer { get; set; }
        public List<String> msgDataStrings { get; private set; }
        public string[] readText { get; private set; }
        public string filePath { get; set; }
        public string nameOfFile { get; set; }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "0.bin/0.txt (*.bin, *.txt)|*.bin;*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;
                openFileDialog.Title = "open msgData.bin (0.bin) or a converted text file";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;
                    nameOfFile = Path.GetFileName(filePath);
                    var fileExtension = Path.GetExtension(filePath);

                    if (fileExtension == ".bin" || fileExtension == ".BIN")
                    {
                        savebinToolStripMenuItem.Visible = false;
                        savebinToolStripMenuItem.Enabled = false;

                        savetxtToolStripMenuItem.Visible = true;
                        savetxtToolStripMenuItem.Enabled = true;

                        //Read the contents of the file into a stream
                        var fileStream = openFileDialog.OpenFile();
                        currentmsgData = new msgDataFile();
                        currentmsgData.ReadmsgData(fileStream);

                        txtArrayListBox.Items.Clear();
                        txtArrayListBox.Enabled = false;
                        txtArrayListBox.Visible = false;

                        stringsListBox.Enabled = true;
                        stringsListBox.Visible = true;

                        int k = 0;
                        foreach (var entry in currentmsgData.msgDataMessages)
                        {
                            stringsListBox.Items.Add("String #" + k);
                            k++;
                        }
                    }
                    else if (fileExtension == ".txt" || fileExtension == ".TXT")
                    {
                        savebinToolStripMenuItem.Visible = true;
                        savebinToolStripMenuItem.Enabled = true;

                        savetxtToolStripMenuItem.Visible = false;
                        savetxtToolStripMenuItem.Enabled = false;

                        string[] readText = File.ReadAllLines(filePath, Encoding.UTF8);
                        stringsListBox.Items.Clear();
                        stringsListBox.Enabled = false;
                        stringsListBox.Visible = false;

                        txtArrayListBox.Enabled = true;
                        txtArrayListBox.Visible = true;

                        msgDataStrings = new List<String>();

                        int k = 0;
                        foreach (string s in readText)
                        {
                            msgDataStrings.Add(readText[k]);
                            txtArrayListBox.Items.Add("String #" + k);
                            k++;
                        }
                    }
                    else MessageBox.Show("This file is not a valid message binary or text file", "Invalid file");
                }
            }
        }

        private void StringsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            msgDataLabel.Text = currentmsgData.msgDataMessages[stringsListBox.SelectedIndex];
        }

        private void SavetxtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog1 = new SaveFileDialog())
            {

                saveFileDialog1.Filter = "text file (*.txt)|*.txt|All files (*.*)|*.*";
                saveFileDialog1.FilterIndex = 1;
                saveFileDialog1.RestoreDirectory = true;

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    var savePath = saveFileDialog1.FileName;
                    File.WriteAllLines(savePath, currentmsgData.msgDataMessages, Encoding.UTF8);
                    MessageBox.Show("File saved to: " + savePath, "File saved");
                }
            }
        }

        private void TxtArrayListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            msgDataLabel.Text = msgDataStrings[txtArrayListBox.SelectedIndex];
        }

        private void savebinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog1 = new SaveFileDialog())
            {
                saveFileDialog1.Filter = "0.bin (*.bin)|*.bin|All files (*.*)|*.*";
                saveFileDialog1.FilterIndex = 1;
                saveFileDialog1.RestoreDirectory = true;

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    var savePath = saveFileDialog1.FileName;
                    using (EndianBinaryWriter newMsgData = new EndianBinaryWriter(File.Open(savePath, FileMode.Create, FileAccess.Write), Encoding.GetEncoding(65001), true, Endianness.Little))
                    {
                        filePath = savePath; //now the Save File option writes here too
                        currentmsgData = new msgDataFile();
                        currentmsgData.WritemsgData(newMsgData, msgDataStrings);
                        MessageBox.Show("File saved to: " + savePath, "File saved");
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            savebinToolStripMenuItem.Visible = false;
            savebinToolStripMenuItem.Enabled = false;
            savetxtToolStripMenuItem.Visible = false;
            savetxtToolStripMenuItem.Enabled = false;
        }
    }
}
