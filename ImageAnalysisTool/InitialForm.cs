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
    public partial class InitialForm : Form
    {
        public InitialForm()
        {
            InitializeComponent();
        }

        //Open a new window 
        private void newButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            MainForm form2 = new MainForm();
            form2.FormClosed += form2_FormClosed;
            form2.Show();
        }

        void form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = true;
        }



    }
}
