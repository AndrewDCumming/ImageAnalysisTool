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


        public SortingForm()
        {
            InitializeComponent();
        }

        public void AddCategories(List<Categories> catList)
        {
            categoriesToSort = catList;
            Debug.WriteLine(categoriesToSort.Count);
        }


        private void sortButton_Click(object sender, EventArgs e)
        {
            if (manufacturerBox.Checked)
            {
                //Get the images to go in categories by manufacturer
                MessageBox.Show("Hello");
            }
            if (modelBox.Checked)
            {

            }
            if (yearBox.Checked)
            {

            }
            if (monthBox.Checked)
            {

            }
            if (dayBox.Checked)
            {

            }
            if (locationBox.Checked)
            {

            }
            this.Hide();
        }
    }
}
