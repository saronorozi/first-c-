using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace games_play
{
    public partial class Form1 : Form
    { 

        bool start=false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            if (start == true)
            {
                timer1.Enabled = false;
                start = false;
            MessageBox.Show("شما بازنده شدید😒");
        } 
            }

        private void Btnstart_Click(object sender, EventArgs e)
        {
            start = true;








            
            timer1.Enabled = true;
            Lbltime.Text = "0";
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {

            if (start == true)

            {
                timer1.Enabled = false;
                start = false;
                MessageBox.Show("شما برنده شدید");

            } 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Lbltime.Text=((Convert.ToInt32 (Lbltime.Text)) + 1).ToString();
        }

        private void LblEnd_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            start = false;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
