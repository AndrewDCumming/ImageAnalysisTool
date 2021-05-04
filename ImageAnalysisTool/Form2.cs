using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
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
        int currentNumber = 0;
        ImageInfoRetrieve retriever = new ImageInfoRetrieve();
        List<TheImage> imageList = new List<TheImage>();
        Image image;


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
                filepaths = Directory.GetFiles(browser.SelectedPath, "*.jpg");
            }
            directoryList = "Files:\n";
            
            foreach(string files in filepaths)
            {
                directoryList += files + "\n";
                TheImage theImage = new TheImage(Path.GetFileName(files), Image.FromFile(files));
                imageList.Add(theImage);
            }
            listBox.Text = directoryList;

            this.imgBox.Image = imageList[0].GetTheImage();
            this.imgNameLabel.Text = "Current Image: " + imageList[0].TheImageName();

            //fileInfoLabel.Text = retriever.GetAllInformation(image);
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            currentNumber++;
            imgNameLabel.Text = "Current Image: " + imageList[currentNumber].TheImageName();
            this.imgBox.Image = imageList[currentNumber].GetTheImage();


        }

        private void prevButton_Click(object sender, EventArgs e)
        {
            currentNumber--;
            imgNameLabel.Text = "Current Image: " + imageList[currentNumber].TheImageName();
            this.imgBox.Image = imageList[currentNumber].GetTheImage();
        }


    }
}
