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
        bool turn = true;

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
            btn1.Enabled = false;
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
            btn2.Enabled = false;
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
            btn3.Enabled = false;
            Check_winner();
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
            btn4.Enabled = false;
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
            btn5.Enabled = false;
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
            btn6.Enabled = false;
            Check_winner();
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
            btn7.Enabled = false;
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
            btn8.Enabled = false;
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
            btn9.Enabled = false;
            Check_winner();
        }
        
        private void Check_winner()
        {
            bool winner = false;

            if((btn1.Text == btn2.Text) && (btn2.Text == btn3.Text) && btn1.Enabled == false)
            {
                winner = true;
            }
            if ((btn4.Text == btn5.Text) && (btn5.Text == btn6.Text) && btn4.Enabled == false)
            {
                winner = true;
            }
            if ((btn7.Text == btn8.Text) && (btn8.Text == btn9.Text) && btn7.Enabled == false)
            {
                winner = true;
            }

            if (winner)
            {
                if (turn)
                {
                    MessageBox.Show("Player 2 WINS");
                }
                else
                {
                    MessageBox.Show("Player 1 WINS");
                }
            }
        }
    }
}
