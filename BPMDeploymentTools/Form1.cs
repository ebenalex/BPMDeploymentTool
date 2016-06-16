using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Threading;

namespace BPMDeploymentTools
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> changedFiles = new List<string>();
        #region Get Changed Files path
        private void getChangedFiles(string dir, DateTime d)
        {

            string[] files = Directory.GetFiles(dir);
            foreach (var file in files)
            {
                if(File.GetLastWriteTime(file)>d)
                {
                    changedFiles.Add(file);
                }
            }

            string[] directories =  Directory.GetDirectories(dir);
            foreach (string item in directories)
            {
                getChangedFiles(item, d);
            }
            
        }
        #endregion

        #region XCopy Files
        private void xCopyFiles(List<string> selectFiles,string destDirectory)
        {
            foreach (var item in selectFiles)
            {
                CopyFileIncludeFolder(item, destDirectory);
            }
            
        }

        private void CopyFileIncludeFolder(string filePath, string destDirectory)
        {
            string childDir = filePath.Replace(txtSourceDirectory.Text + "\\", "");
            string oldDir = childDir;
            childDir = childDir.Substring(0, childDir.LastIndexOf('\\'));
            string[] dirs = childDir.Split('\\');
        
            string preDir = "";
            for (int i = 0; i < dirs.Count(); i++)
            {

                if (i != 0)
                {
                    preDir += dirs[i-1] + "\\";
                }
                if (!Directory.Exists(destDirectory + "\\" + preDir + dirs[i]))
                {
                    Directory.CreateDirectory(destDirectory + "\\" + preDir + dirs[i]);
                }
                
            }
            //EVCommand.Execute("XCOPY \"" + filePath + "\"  \"" + destDirectory + "\\"+ oldDir + "\" " + "/S /E", 10);
            File.Copy(filePath, destDirectory + "\\" + oldDir,true);
            return;
        }


        #endregion

        private void btnSelectSourceDirectory_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if(fbd.ShowDialog() == DialogResult.OK)
            {
                txtSourceDirectory.Text = fbd.SelectedPath;
            }
            
        }

        private void btnSelectDestDirectory_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txtDestDirectory.Text = fbd.SelectedPath;
            }
        }

        Thread th = null;

        private void btnSearch_Click(object sender, EventArgs e)
        {

            th = new Thread(new ThreadStart(getChangedList));
            th.Start();
            //getChangedList();
            
        }

        private void getChangedList()
        {
            btnSearch.Enabled = false;
            List<string> directories = getDirectories();
            DateTime d =
                new DateTime(dtpDate.Value.Year,
                dtpDate.Value.Month,
                dtpDate.Value.Day,
                Convert.ToInt32(txtTime.Text.Split('.')[0]),
                Convert.ToInt32(txtTime.Text.Split('.')[1]), 0);
            changedFiles.Clear();
            lvResult.Items.Clear();
            foreach (string dir in directories)
            {
                getChangedFiles(dir, d);
            }

            foreach (var item in changedFiles)
            {
                lvResult.Items.Add(new ListViewItem(item));
            }
            btnSearch.Enabled = true;
        }

        private List<string> getDirectories()
        {
            List<string> directories = new List<string>();
            if(!chkProcess.Checked 
                && !chkWeb.Checked 
                && !chkService.Checked
                && !chkReports.Checked)
            {
                directories.Add(txtSourceDirectory.Text);
            }
            else if(chkProcess.Checked)
            {
                directories.Add(txtSourceDirectory.Text + "\\" + chkProcess.Text);
            }
            if (chkWeb.Checked)
            {
                directories.Add(txtSourceDirectory.Text + "\\" + chkWeb.Text);
            }
            if (chkService.Checked)
            {
                directories.Add(txtSourceDirectory.Text + "\\" + chkService.Text);
            }
            if (chkReports.Checked)
            {
                directories.Add(txtSourceDirectory.Text + "\\" + chkReports.Text);
            }
            return directories;
        }

        private void btnDeploy_Click(object sender, EventArgs e)
        {
            btnDeploy.Enabled = false;
            List<string> selectFiles = new List<string>();
            foreach (ListViewItem item in lvResult.CheckedItems)
            {
                selectFiles.Add(item.Text);
            }
            xCopyFiles(selectFiles,txtDestDirectory.Text);
            MessageBox.Show("They are Deployed.");
            btnDeploy.Enabled = true;
        }

        private void lvResult_ItemActivate(object sender, EventArgs e)
        {
            
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (th != null)
            {
                if(th.ThreadState == System.Threading.ThreadState.Running)
                {
                    th.Abort();
                }
            }
        }
    }
}
