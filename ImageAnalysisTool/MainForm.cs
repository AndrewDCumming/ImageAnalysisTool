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
    public partial class MainForm : Form
    {
        String[] filepaths;
        String directoryList;
        int currentNumber = 0;
        Categories uncategorised;
        ImageInfoRetrieve retriever = new ImageInfoRetrieve();
        private List<TheImage> imageList = new List<TheImage>();

        List<Categories> allCategories = new List<Categories>();


        public MainForm()
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


            uncategorised = new Categories("All Images");
            foreach (string files in filepaths)
            {
                directoryList += files + "\n";
                TheImage theImage = new TheImage(Path.GetFileName(files), Image.FromFile(files));
                imageList.Add(theImage);

                //Add all to category unlisted

                uncategorised.AddImageToCategory(Path.GetFileName(files),Image.FromFile(files));

            }

            allCategories.Add(uncategorised);
            foreach (var cat in allCategories)
            {
                catLabel.Text = catLabel.Text + $"{cat.Name} ({cat.ReturnNumberOfImages()}) \n ";
            }


            listBox.Text = directoryList;

            this.imgBox.Image = uncategorised.ImageToReturn(currentNumber);
            this.imgNameLabel.Text = $"Current Image: {imageList[currentNumber].TheImageName()}";

            fileInfoLabel.Text = imageList[currentNumber].GetAllInfo();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (currentNumber < uncategorised.ReturnNumberOfImages()-1)
            {
                currentNumber++;
            }
            else
            {
                currentNumber = 0;
            }
            this.UpdateDisplay();

        }

        private void prevButton_Click(object sender, EventArgs e)
        {
            if (currentNumber >0 )
            {
                currentNumber--;
            }
            else
            {
                currentNumber = uncategorised.ReturnNumberOfImages()-1;
            }
            this.UpdateDisplay();
        }

        private void UpdateDisplay()
        {
            TheImage image = new TheImage();
            image = imageList[currentNumber];

            imgNameLabel.Text = $"Current Image: {image.TheImageName()}";
            this.imgBox.Image = imageList[currentNumber].GetTheImage();
            
            fileInfoLabel.Text = imageList[currentNumber].GetAllInfo();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            Boolean found = false;
            for (int i = 0; i < allCategories.Count; i++)
            {
                if (allCategories[i].Name == categoryBox.Text)
                {
                    found = true;
                    allCategories[i].AddImageToCategory(imageList[currentNumber].TheImageName(), imageList[currentNumber].GetTheImage());
                    Debug.WriteLine("Adding image to cat" + catLabel.Text);
                }
                else { }
            }
            if (found == false)
            {
                Categories newCat = new Categories(categoryBox.Text);
                newCat.AddImageToCategory(imageList[currentNumber].TheImageName(), imageList[currentNumber].GetTheImage());
                allCategories.Add(newCat);
                Debug.WriteLine("Creating new category");
            }

            catLabel.Text = "Categories: \n ";
            foreach (var cat in allCategories)
            {
                catLabel.Text = catLabel.Text + $"{cat.Name} ({cat.ReturnNumberOfImages()}) \n ";
            }

        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            SortingForm sortSelection = new SortingForm();           
            sortSelection.AddCategories(allCategories);
            sortSelection.ShowDialog();


            allCategories = sortSelection.returnList();

            foreach (var cat in allCategories)
            {
                catLabel.Text = catLabel.Text + $"{cat.Name} ({cat.ReturnNumberOfImages()}) \n ";
            }
        }

        private void reportButton_Click(object sender, EventArgs e)
        {

            DocumentCreator newDoc = new DocumentCreator();
            newDoc.AddCategories(allCategories);
            newDoc.GenerateDocumentation();

        }
    }
}
