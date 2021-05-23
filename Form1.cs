using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_tac_toe
{
    public partial class Form1 : Form
    {
        bool turn;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (turn)
            {
                btn1.Text = "X";
                turn = false;
            }
            else
            {
                btn1.Text = "O";
                turn = true;
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (turn)
            {
                btn2.Text = "X";
                turn = false;
            }
            else
            {
                btn2.Text = "O";
                turn = true;
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (turn)
            {
                btn3.Text = "X";
                turn = false;
            }
            else
            {
                btn3.Text = "O";
                turn = true;
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (turn)
            {
                btn4.Text = "X";
                turn = false;
            }
            else
            {
                btn4.Text = "O";
                turn = true;
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (turn)
            {
                btn5.Text = "X";
                turn = false;
            }
            else
            {
                btn5.Text = "O";
                turn = true;
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (turn)
            {
                btn6.Text = "X";
                turn = false;
            }
            else
            {
                btn6.Text = "O";
                turn = true;
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (turn)
            {
                btn7.Text = "X";
                turn = false;
            }
            else
            {
                btn7.Text = "O";
                turn = true;
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (turn)
            {
                btn8.Text = "X";
                turn = false;
            }
            else
            {
                btn8.Text = "O";
                turn = true;
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (turn)
            {
                btn9.Text = "X";
                turn = false;
            }
            else
            {
                btn9.Text = "O";
                turn = true;
            }
        }
    }
}
