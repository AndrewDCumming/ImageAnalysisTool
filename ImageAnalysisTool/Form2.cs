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
        Image image;
        ImageInfoRetrieve retriever = new ImageInfoRetrieve();
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
                Debug.WriteLine(files);
            }
            listBox.Text = directoryList;

            image = Image.FromFile(filepaths[0]);
            imgNameLabel.Text= "Current Image: " + filepaths[0];
            image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            this.imgBox.Image = image;
            fileInfoLabel.Text = retriever.GetAllInformation(image);
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            currentNumber++;
            image = Image.FromFile(filepaths[currentNumber]);
            imgNameLabel.Text = "Current Image: " + filepaths[currentNumber];
            image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            this.imgBox.Image = image;

            fileInfoLabel.Text = retriever.GetAllInformation(image);
            /**
            //36867 - Date and time
            PropertyItem propItem = image.GetPropertyItem(36867);
            string dateTaken = Encoding.UTF8.GetString(propItem.Value);
            fileInfoLabel.Text = "Date and Time Taken: \n" + dateTaken;
            //305 device information
            //271 Device manufacturer
            //272 Device model
            propItem = image.GetPropertyItem(272);
            dateTaken = Encoding.UTF8.GetString(propItem.Value);
            fileInfoLabel.Text += "Device: \n" + dateTaken;
            Debug.WriteLine(dateTaken);
            //Debug.WriteLine(propItem.ToString());
            */




        }

        private void prevButton_Click(object sender, EventArgs e)
        {
            currentNumber--;
            image = Image.FromFile(filepaths[currentNumber]);
            imgNameLabel.Text = "Current Image: " + filepaths[currentNumber];
            image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            this.imgBox.Image = image;
            fileInfoLabel.Text = retriever.GetAllInformation(image);
        }
    }
}
