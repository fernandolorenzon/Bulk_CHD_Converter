using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ISO_To_CHD_Converter
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonOpenSourceDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            var result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                textBoxSource.Text = dialog.SelectedPath;
            }
        }

        private void buttonOutput_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            var result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                textBoxOutput.Text = dialog.SelectedPath;
            }
        }

        private void buttonImport_Click(object sender, EventArgs e)
        {
            if (textBoxSource.Text == "")
            {
                MessageBox.Show("Select bin/cue folder first");
                return;
            }

            if (!Directory.Exists(textBoxSource.Text))
            {
                MessageBox.Show("Invalid bin/cue folder");
                return;
            }

            checkedListBoxImages.Items.Clear();

            var searchOptions = checkBoxIncludeSubfolders.Checked ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;

            var files = Directory.GetFiles(textBoxSource.Text, "*.cue", searchOptions);

            checkedListBoxImages.Items.AddRange(files);

            for (int i = 0; i < checkedListBoxImages.Items.Count; i++)
            {
                checkedListBoxImages.SetItemChecked(i, true);
            }
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            if (textBoxOutput.Text == "")
            {
                MessageBox.Show("Select an output folder first");
                return;
            }

            if (!Directory.Exists(textBoxOutput.Text))
            {
                MessageBox.Show("Invalid output folder");
                return;
            }

            var chdman = Environment.CurrentDirectory + "\\" + "chdman.exe";

            if (!File.Exists(chdman))
            {
                MessageBox.Show("chdman.exe not found. Please put chdman.exe inside the CHD_Converter folder");
                return;
            }

            int count = 0;

            foreach (var item in checkedListBoxImages.CheckedItems)
            {
                var input = item.ToString();
                var output = textBoxOutput.Text + input.Substring(input.LastIndexOf("\\"));
                output = output.Replace(".cue", ".chd");
                var command = "\"" + chdman + "\" createcd -i \"" + input + "\" -o \"" + output + "\"";

                labelCurrent.Text = input.Substring(input.LastIndexOf("\\") + 1);

                ExecuteCMD(command);
                count++;
            }

            labelCurrent.Text = "Completed";
            MessageBox.Show(count.ToString() + " Images converted");
        }

        private void Convert(string cuepath, string output)
        {
            var chdman = Environment.CurrentDirectory + "\\" + "chdman.exe";
            var command = "\"" + chdman + "\" createcd -i \"" + cuepath + "\" -o \"" + output + "\"";

            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();

            cmd.StandardInput.WriteLine(command);
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();
        }

        private void ExecuteCMD(string comm)
        {
            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();

            cmd.StandardInput.WriteLine(comm);
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();
        }

        private void checkBoxAll_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBoxImages.Items.Count; i++)
            {
                checkedListBoxImages.SetItemChecked(i, checkBoxAll.Checked);
            }
        }
    }
}
