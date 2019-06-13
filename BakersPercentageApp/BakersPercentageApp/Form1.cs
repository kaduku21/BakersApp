using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BakersPercentageApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {   
            //Reading and displaying input for flour
            decimal flourweight = Convert.ToDecimal(txtFlourWeight.Text);
            txtFlourResult.Text = Convert.ToString(flourweight);
            
            //Reading, doing math, and displaying the output for water
            decimal waterweight = Convert.ToDecimal(txtWaterPercentage.Text);
            txtWaterResult.Text = Convert.ToString((waterweight / 100) * flourweight);
            
            //Reading, doing math, and displaying the output for salt
            decimal saltweight = Convert.ToDecimal(txtSaltPercentage.Text);
            txtSaltResult.Text = Convert.ToString((saltweight / 100) * flourweight);

            //Reading input, doing math, and displaying output for yeast/starter
            decimal starterweight = Convert.ToDecimal(txtStarterPercentage.Text);
            txtStarterResult.Text = Convert.ToString((starterweight / 100) * flourweight);
            
        }
    }
}
