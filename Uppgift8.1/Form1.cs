using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift
{
    public partial class Form1 : Form
    {
        int amountGuesses;
        int computerNum;
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
            lbxStörstaTalet.Items.Add(10);
            lbxStörstaTalet.Items.Add(20);
        }

        private void btnStartaSpelet_Click(object sender, EventArgs e)
        {
            int biggestNumber = int.Parse(lbxStörstaTalet.SelectedItem.ToString());
            amountGuesses = 0;
            computerNum = rnd.Next(1, biggestNumber + 1);

            btnStartaSpelet.Enabled = false;
            gbxSpelet.Enabled = true;
            gbxSpeldata.Enabled = false;
            lblDatornsTal.Text = "??";
        }

        private void btnGissa_Click(object sender, EventArgs e)
        {
            amountGuesses++;
            int guess = int.Parse(tbxGissa.Text);

            if (guess == computerNum) {
                lblResultat.Text = $"Korekt efter {amountGuesses} Försök";
                lblDatornsTal.Text = computerNum.ToString();
                tbxMinaResultat.AppendText(amountGuesses + " Försök");
                tbxMinaResultat.AppendText(Environment.NewLine);
                gbxSpelet.Enabled = false;
                gbxSpeldata.Enabled = true;
                btnSpelaIgen.Enabled = true;

            }
            else if (guess < computerNum) {
                lblResultat.Text = "För lågt, försök igen";
            }
            else
            {
                lblResultat.Text = "För högt, försök igen";
            }



        }

        private void btnSpelaIgen_Click(object sender, EventArgs e)
        {
            int biggestNumber = int.Parse(lbxStörstaTalet.SelectedItem.ToString());
            amountGuesses = 0;
            computerNum = rnd.Next(1, biggestNumber + 1);
            gbxSpelet.Enabled = true;
            gbxSpeldata.Enabled = false;
            btnSpelaIgen.Enabled = false;
            lblDatornsTal.Text = "??";
            lblResultat.Text = "";
        }
    }
}
