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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        //declare variables
        decimal Num1, Num2;
        string Operation;

        //method to keep data in the textbox
        private void input(string a)
        {
            if (txtdisply.Text == "0")
                txtdisply.Text = a;
            else
                txtdisply.Text += a;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtdisply.Text = "";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            input("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            input("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            input("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            input("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            input("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            input("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            input("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            input("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            input("9");
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            input("0");
        }

        private void btnDot_Click(object sender, EventArgs e)
        {

        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            Num2 = decimal.Parse(txtdisply.Text);
            switch (Operation)
            {
                case "+":
                    txtdisply.Text = (Num1 + Num2).ToString();
                    break;
                case "-":
                    txtdisply.Text = (Num1 - Num2).ToString();
                    break;
                case "x":
                    txtdisply.Text = (Num1 * Num2).ToString();
                    break;
                case "/":
                    txtdisply.Text = (Num1 / Num2).ToString();
                    break;
                case "^":
                    txtdisply.Text = (int.Parse(Num1.ToString()) ^ int.Parse(Num2.ToString())).ToString();
                    break;
                case "%":
                    txtdisply.Text = (Num1 % Num2).ToString();
                    break;
            }
            }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            Num1 = decimal.Parse(txtdisply.Text);
            Operation = "+";
            txtdisply.Text = "0";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            Num1 = decimal.Parse(txtdisply.Text);
            Operation = "-";
            txtdisply.Text = "0";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            Num1 = decimal.Parse(txtdisply.Text);
            Operation = "/";
            txtdisply.Text = "0";
        }

        private void btnTimes_Click(object sender, EventArgs e)
        {
            Num1 = decimal.Parse(txtdisply.Text);
            Operation = "x";
            txtdisply.Text = "0";
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            txtdisply.Text = (Math.Sin(double.Parse(txtdisply.Text))).ToString();
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            txtdisply.Text = (Math.Cos(double.Parse(txtdisply.Text))).ToString();
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            txtdisply.Text = (Math.Tan(double.Parse(txtdisply.Text))).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Num1 = decimal.Parse(txtdisply.Text);
            Operation = "^";
            txtdisply.Text = "0";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtdisply.Text = (Math.Sqrt(double.Parse(txtdisply.Text))).ToString();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            txtdisply.Text = (Math.Log(double.Parse(txtdisply.Text))).ToString();
        }

        private void btnPer_Click(object sender, EventArgs e)
        {
            Num1 = decimal.Parse(txtdisply.Text);
            Operation = "%";
            txtdisply.Text = "0";
        }

        private void btnLong_Click(object sender, EventArgs e)
        {
            long f = 1;
            for (long i = 1; i <= long.Parse(txtdisply.Text); i++)
            {
                f = f * i;
            }
            txtdisply.Text = f.ToString();
        }

        private void btnBck_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
