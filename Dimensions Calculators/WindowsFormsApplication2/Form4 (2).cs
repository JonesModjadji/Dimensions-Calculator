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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        //declare variables
        double Weight1, Weight;
        double Value;

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

        private void btnCalc_Click(object sender, EventArgs e)
        {
            Value = double.Parse(textBox1.Text);
            //
            if (cboxKilo.Checked && cboxKilo1.Checked)
            { Weight = 1; }
            if (cboxKilo.Checked && cboxPound1.Checked)
            { Weight = 2.2; }
            if (cboxKilo.Checked && cboxStone1.Checked)
            { Weight = 1; }
            if (cboxKilo.Checked && cboxLitres1.Checked)
            { Weight = 1; }
            //
            if (cboxPound.Checked && cboxKilo1.Checked)
            { Weight = 2.2 / 100; }
            if (cboxPound.Checked && cboxPound1.Checked)
            { Weight = 1; }
            if (cboxPound.Checked && cboxStone1.Checked)
            { Weight = 1; }
            if (cboxPound.Checked && cboxLitres1.Checked)
            { Weight = 1; }
            //
            if (cboxStone.Checked && cboxKilo1.Checked)
            { Weight = 1; }
            if (cboxStone.Checked && cboxPound1.Checked)
            { Weight = 2.2; }
            if (cboxStone.Checked && cboxStone1.Checked)
            { Weight = 1; }
            if (cboxStone.Checked && cboxLitres1.Checked)
            { Weight = 1; }
            //
            if (cboxLitres.Checked && cboxKilo1.Checked)
            { Weight = 1; }
            if (cboxLitres.Checked && cboxPound1.Checked)
            { Weight = 2.2; }
            if (cboxLitres.Checked && cboxStone1.Checked)
            { Weight = 1; }
            if (cboxLitres.Checked && cboxLitres1.Checked)
            { Weight = 1; }
            Weight1 = Value * Weight;
            textBox2.Text = Weight1.ToString();
        }
    }
}
