using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace ImageAnalysisTool
{
    public partial class Form2 : Form
    {
        String[] filepaths;
        String directoryList;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void toolStripAddDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog browser = new FolderBrowserDialog();

            if (browser.ShowDialog()== System.Windows.Forms.DialogResult.OK)
            {
                filepaths = Directory.GetFiles(browser.SelectedPath);
                
            }
            directoryList = "Files:\n";
            
            foreach(string files in filepaths)
            {
                directoryList += files + "\n";
                Debug.WriteLine(files);
            }
            listBox.Text = directoryList;


        }
    }
}
