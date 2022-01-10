using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ISO_To_CHD_Converter
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            comboBoxConditions.SelectedIndex = 0;
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
            Import("", "");
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

                if (File.Exists(output))
                {
                    File.Delete(output);
                }

                var command = "\"" + chdman + "\" createcd -i \"" + input + "\" -o \"" + output + "\"";

                labelCurrent.Text = input.Substring(input.LastIndexOf("\\") + 1);
                labelCurrent.Refresh();

                ExecuteCMD2(command);
                Thread.Sleep(60 * 1500);
                count++;
            }

            labelCurrent.Text = "Completed";
            MessageBox.Show(count.ToString() + " Images converted");
        }

        private void ExecuteCMD(string command)
        {
            //ProcessStartInfo startInfo = new ProcessStartInfo();
            ////startInfo.CreateNoWindow = true;
            ////startInfo.UseShellExecute = false;
            //startInfo.WindowStyle = ProcessWindowStyle.Normal;
            //startInfo.FileName = "cmd.exe";
            //startInfo.Arguments = command;

            //// Start the process with the info we specified.
            //// Call WaitForExit and then the using statement will close.
            //using (Process exeProcess = Process.Start(startInfo))
            //{
            //    exeProcess.WaitForExit();
            //}

            Process.Start("cmd.exe", command).WaitForExit();


            //ProcessStartInfo cmdsi = new ProcessStartInfo("cmd.exe");
            //cmdsi.Arguments = command;
            //Process cmd = Process.Start(cmdsi);
            //cmd.WaitForExit(); //wait indefinitely for the associated process to exit.
        }

        private void ExecuteCMD2(string comm)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo("CMD.exe");
            Process p = new Process();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            startInfo.RedirectStandardInput = true;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.RedirectStandardError = true;

            p = Process.Start(startInfo);
            string changeDir = "cd " + Environment.CurrentDirectory;

            p.StandardInput.WriteLine(changeDir);
            p.StandardInput.WriteLine(comm);
            p.StandardInput.WriteLine("exit");
        }

        private void checkBoxAll_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBoxImages.Items.Count; i++)
            {
                checkedListBoxImages.SetItemChecked(i, checkBoxAll.Checked);
            }
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            Import(textBoxFilter.Text, comboBoxConditions.Text);
        }

        private void Import(string filter, string condition)
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
            List<string> filtered = new List<string>();

            if (filter != "" && condition != "")
            {
                foreach (var file in files)
                {
                    var filename = file.Substring(file.LastIndexOf("\\") + 1);
                    if (condition == "Begins with" && filename.ToLower().StartsWith(filter.ToLower()))
                    {
                        filtered.Add(file);
                    }
                    else if (condition == "Contains" && filename.ToLower().Contains(filter.ToLower()))
                    {
                        filtered.Add(file);
                    }
                }

                checkedListBoxImages.Items.AddRange(filtered.ToArray());
            }
            else
            {

                foreach (var file in files)
                {
                    filtered.Add(file);
                }

                checkedListBoxImages.Items.AddRange(filtered.ToArray());
            }

            for (int i = 0; i < checkedListBoxImages.Items.Count; i++)
            {
                checkedListBoxImages.SetItemChecked(i, true);
            }
        }
    }
}
