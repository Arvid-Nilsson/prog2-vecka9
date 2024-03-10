using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift7._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int results = rnd.Next(1,7);
            if (results != int.Parse(tbxPoints.Text))
            { 
                MessageBox.Show(results.ToString(), "Medelande", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Grattis!", "Medelande", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
