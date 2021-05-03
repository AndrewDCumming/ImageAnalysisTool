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
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            currentNumber++;
            image = Image.FromFile(filepaths[currentNumber]);
            imgNameLabel.Text = "Current Image: " + filepaths[currentNumber];
            image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            this.imgBox.Image = image;

            PropertyItem propItem = image.GetPropertyItem(36867);
            string dateTaken = Encoding.UTF8.GetString(propItem.Value);
            fileInfoLabel.Text = "Date and Time Taken: \n" + dateTaken;
            Debug.WriteLine(dateTaken);
            //Debug.WriteLine(propItem.ToString());


            //This works for pulling metadata need to narrow it down for relevant info
            /**
            fileInfoLabel.Text = "";
            PropertyItem[] propItems = image.PropertyItems;
            int count = 0;
            foreach (PropertyItem propItem in propItems)
            {
                fileInfoLabel.Text += "\nProperty Item " + count.ToString();
                fileInfoLabel.Text += "\nID: 0x" + propItem.Id.ToString("x");
                fileInfoLabel.Text += "\nType: " + propItem.Type.ToString();
                fileInfoLabel.Text += "\n Length: " + propItem.Len.ToString() + " bytes";
                count += 1;
            }
            */



        }

        private void prevButton_Click(object sender, EventArgs e)
        {
            currentNumber--;
            image = Image.FromFile(filepaths[currentNumber]);
            imgNameLabel.Text = "Current Image: " + filepaths[currentNumber];
            image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            this.imgBox.Image = image;
        }
    }
}
