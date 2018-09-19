using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dimensions_Calculator
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        //declare variables
        decimal Rate2;
        decimal amount1, amount2;

        private void btnClr_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void btnBck_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            amount1 = decimal.Parse(textBox1.Text);
            if (cboxRand.Checked && cboxEuro1.Checked)
            { Rate2 = 20 / 100; }
            if (cboxRand.Checked && cboxPound1.Checked)
            { Rate2 = 16 / 100; }
            if (cboxRand.Checked && cboxDollar1.Checked)
            { Rate2 = 11 / 100; }
            if (cboxRand.Checked && cboxRand1.Checked)
            { Rate2 = 1; }
            //
            if (cboxEuro.Checked && cboxRand1.Checked)
            { Rate2 = 20; }
            if (cboxEuro.Checked && cboxEuro1.Checked)
            { Rate2 = 1; }
            if (cboxEuro.Checked && cboxPound1.Checked)
            { Rate2 = 4; }
            if (cboxEuro.Checked && cboxDollar1.Checked)
            { Rate2 = 9; }
            //
            if (cboxPound.Checked && cboxRand1.Checked)
            { Rate2 = 16; }
            if (cboxPound.Checked && cboxEuro1.Checked)
            { Rate2 = 4 / 100; }
            if (cboxPound.Checked && cboxPound1.Checked)
            { Rate2 = 1; }
            if (cboxPound.Checked && cboxDollar1.Checked)
            { Rate2 = 5; }
            //
            if (cboxDollar.Checked && cboxRand1.Checked)
            { Rate2 = 12; }
            if (cboxDollar.Checked && cboxEuro1.Checked)
            { Rate2 = 9 / 100; }
            if (cboxDollar.Checked && cboxPound1.Checked)
            { Rate2 = 5 / 100; }
            if (cboxDollar.Checked && cboxDollar1.Checked)
            { Rate2 = 1; }
            amount2 = amount1 * Rate2;
            textBox2.Text = amount2.ToString();

        }
    }
}
