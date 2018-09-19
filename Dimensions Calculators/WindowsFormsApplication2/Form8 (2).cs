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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void btnBck_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void btnClr_Click(object sender, EventArgs e)
        {
            txtAnswers.Text = "";
            txtInterest.Text = "";
            txtInvestment.Text = "";
            txtYears.Text = "";
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double InterestRate, Years, Interest1, Interest2, Answer, Investment;
            InterestRate = double.Parse(txtInterest.Text);
            Years = (Math.Sqrt(double.Parse(txtYears.Text)));
            Investment = double.Parse(txtInvestment.Text);
            Interest1 = 1 + InterestRate;
            Interest2 = Investment * Interest1;
            Answer = Interest2 * Years;
            txtAnswers.Text = Answer.ToString();
        }
    }
}
