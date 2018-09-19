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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btnStr_Click(object sender, EventArgs e)
        {
            //Declare Variables

            Random rand = new Random();
            int[] array1 = new int[20];
            //For Loop
            for (int i = 0; i < 20; i++)
            {
                array1[i] = int.Parse(rand.Next(0, 20).ToString());
                richTextBox1.Text = richTextBox1.Text + array1[i] + "\n";

            }
            richTextBox1.Clear();
            richTextBox1.Focus();
        }

        private void btnClr_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void btnBck_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
