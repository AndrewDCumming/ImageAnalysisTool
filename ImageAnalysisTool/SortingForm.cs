using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ImageAnalysisTool
{
    public partial class SortingForm : Form
    {
        List<Categories> categoriesToSort = new List<Categories>();
        ImageInfoRetrieve retriever = new ImageInfoRetrieve();



        public SortingForm()
        {
            InitializeComponent();
        }

        public void AddCategories(List<Categories> catList)
        {
            categoriesToSort = catList;
        }


        public List<Categories> returnList()
        {
            return categoriesToSort;
        }


        private void sortButton_Click(object sender, EventArgs e)
        {
            if (manufacturerBox.Checked)
            {
                for (int i = 0; i < categoriesToSort[0].ReturnNumberOfImages(); i++)
                {
                    TheImage imageInUse = categoriesToSort[0].ImageActualReturn(i);
                    String manufacturer;
                    manufacturer = retriever.GetDeviceManufacturer(imageInUse.GetTheImage());
                    bool flag = false;

                    foreach(Categories cat in categoriesToSort)
                    {
                        if (cat.Name == manufacturer)
                        {
                            flag = true;
                            cat.AddImageToCategory(imageInUse.TheImageName(), imageInUse.GetTheImage());
                        }
                    }

                    if (flag == false)
                    {
                        Categories newCategory = new Categories(manufacturer);
                        newCategory.AddImageToCategory(imageInUse.TheImageName(), imageInUse.GetTheImage());
                        categoriesToSort.Add(newCategory);
                    }


                }
            }
            else if (modelBox.Checked)
            {
                for (int i = 0; i < categoriesToSort[0].ReturnNumberOfImages(); i++)
                {
                    TheImage imageInUse = categoriesToSort[0].ImageActualReturn(i);
                    String model;
                    model = retriever.GetDeviceManufacturer(imageInUse.GetTheImage());
                    bool flag = false;

                    foreach (Categories cat in categoriesToSort)
                    {
                        if (cat.Name == model)
                        {
                            flag = true;
                            cat.AddImageToCategory(imageInUse.TheImageName(), imageInUse.GetTheImage());
                        }
                    }

                    if (flag == false)
                    {
                        Categories newCategory = new Categories(model);
                        newCategory.AddImageToCategory(imageInUse.TheImageName(), imageInUse.GetTheImage());
                        categoriesToSort.Add(newCategory);
                    }

                }
            }
            else if (yearBox.Checked)
            {

                for (int i =0; i < categoriesToSort[0].ReturnNumberOfImages(); i++)
                {
                    TheImage imageInUse = categoriesToSort[0].ImageActualReturn(i);
                    String dateAndTime;
                    dateAndTime = retriever.GetTimeAndDate(imageInUse.GetTheImage());
                    String[] dateAndTimeBreakdown = dateAndTime.Split(':');
                    String year = dateAndTimeBreakdown[0];
                    bool flag = false;


                    foreach (Categories cat in categoriesToSort)
                    {
                        if (cat.Name == dateAndTimeBreakdown[0])
                        {
                            flag = true;
                            cat.AddImageToCategory(imageInUse.TheImageName(),imageInUse.GetTheImage());
                        }
                    }

                    if (flag == false)
                    {
                        Categories newCategory = new Categories(dateAndTimeBreakdown[0]);
                        newCategory.AddImageToCategory(imageInUse.TheImageName(), imageInUse.GetTheImage());
                        categoriesToSort.Add(newCategory);
                    }
              
                }


            }
            else if (faceBox.Checked)
            {
                FaceDetection detect = new FaceDetection();

                for (int i = 0; i < categoriesToSort[0].ReturnNumberOfImages(); i++)
                {
                    Debug.WriteLine("Working on image " + i);
                    bool match = false;
                    match = detect.LookForMatch(categoriesToSort[0].ImageToReturn(i));
                    if (match == true)
                    {
                        //Add image to matches
                        Debug.WriteLine("Match Found");
                    }
                    else
                    {
                        Debug.WriteLine("No Match");
                    }

                }
            }
            else
            {
                MessageBox.Show("No selections chosen");
            }
            this.Hide();
        }

        private void SortingForm_Load(object sender, EventArgs e)
        {

        }
    }
}
