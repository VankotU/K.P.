using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GasStation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string distance = txtBoxDistance.Text;
            double distance1 = double.Parse(distance);

            string consumption = txtBoxConsumption.Text;
            double consumption1 = double.Parse(consumption);

            double avgConsumption = consumption1 / 100;
            double litres = avgConsumption * distance1;

            if (rbBenzin.Checked) 
            {
                lblLitres.Text = litres+" ЛИТРА";
                lblPrice.Text = $"{(litres * 2.4)} ЛЕВА";
                if (chBoxWays.Checked) 
                {
                    lblPrice.Text = $"{(litres * 4.8)} ЛЕВА";
                }
            }

            if (rbDiesel.Checked)
            {
                lblLitres.Text = litres + " ЛИТРА";
                lblPrice.Text = $"{(litres * 2.5)} ЛЕВА";
                if (chBoxWays.Checked)
                {
                    lblPrice.Text = $"{(litres * 5)} ЛЕВА";
                }
            }

            if (rbGas.Checked)
            {
                lblLitres.Text = litres + " ЛИТРА";
                lblPrice.Text = $"{(litres * 1.3)} ЛЕВА";
                if (chBoxWays.Checked)
                {
                    lblPrice.Text = $"{(litres * 2.6)} ЛЕВА";
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBoxConsumption.Clear();
            txtBoxDistance.Clear();
        }
    }
}
