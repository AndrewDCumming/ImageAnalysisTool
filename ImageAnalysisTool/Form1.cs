using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace ImageAnalysisTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Open a new window 
        private void newButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Loading Feature Not Here");
        }
    }
}
