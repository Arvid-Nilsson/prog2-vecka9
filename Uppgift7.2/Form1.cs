using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift7._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKör_Click(object sender, EventArgs e)
        {
            int age = int.Parse(tbxÅlder.Text);
            if (age >= 18 && age <= 65)
            {
                lblResults.Text = "Resan kostar 20 kr";
            }
            else
            {
                lblResults.Text = "Resan kostar 10 kr";
            }
        }
    }
}
