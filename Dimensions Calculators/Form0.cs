//Project               :   C# FA1 Dimension Calculator
//Date Created          :   08/03/2018
//Ctreated              :   Jones Modjadji
//Version               :   V001
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
    public partial class Form0 : Form
    {
        public Form0()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeleft > 0)
            {
                timeleft = timeleft - 1;
            }
            else
            {
                timer1.Stop();
                new Form1().Show();
                this.Hide();
            }
        }
        public int timeleft { get; set; }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form0_Load(object sender, EventArgs e)
        {
            //start the timer
            timeleft = 20;
            timer1.Start();
        }
    }
}
