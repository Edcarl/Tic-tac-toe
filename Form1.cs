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
        myFunc func = new myFunc();

        public Form1()
        {
            InitializeComponent();    
        }
        public Form1(string Player_1, string Player_2)
        {
            func.PlayerName1 = Player_1;
            func.PlayerName2 = Player_2;;
            
            InitializeComponent();
        }


        private void btn1_Click(object sender, EventArgs e)
        {
            if (func.turn)
            {
                btn1.Text = "X";
                func.turn = false;
            }
            else
            {
                btn1.Text = "O";
                func.turn = true;
            }
            btn1.Enabled = false;
            Check_winner();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (func.turn)
            {
                btn2.Text = "X";
                func.turn = false;
            }
            else
            {
                btn2.Text = "O";
                func.turn = true;
            }
            btn2.Enabled = false;
            Check_winner();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (func.turn)
            {
                btn3.Text = "X";
                func.turn = false;
            }
            else
            {
                btn3.Text = "O";
                func.turn = true;
            }
            btn3.Enabled = false;
            Check_winner();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (func.turn)
            {
                btn4.Text = "X";
                func.turn = false;
            }
            else
            {
                btn4.Text = "O";
                func.turn = true;
            }
            btn4.Enabled = false;
            Check_winner();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (func.turn)
            {
                btn5.Text = "X";
                func.turn = false;
            }
            else
            {
                btn5.Text = "O";
               func.turn = true;
            }
            btn5.Enabled = false;
            Check_winner();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (func.turn)
            {
                btn6.Text = "X";
                func.turn = false;
            }
            else
            {
                btn6.Text = "O";
                func.turn = true;
            }
            btn6.Enabled = false;
            Check_winner();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (func.turn)
            {
                btn7.Text = "X";
                func.turn = false;
            }
            else
            {
                btn7.Text = "O";
                func.turn = true;
            }
            btn7.Enabled = false;
            Check_winner();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (func.turn)
            {
                btn8.Text = "X";
                func.turn = false;
            }
            else
            {
                btn8.Text = "O";
                func.turn = true;
            }
            btn8.Enabled = false;
            Check_winner();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (func.turn)
            {
                btn9.Text = "X";
                func.turn = false;
            }
            else
            {
                btn9.Text = "O";
                func.turn = true;
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
            if ((btn1.Text == btn4.Text) && (btn4.Text == btn7.Text) && btn1.Enabled == false)
            {
                winner = true;
            }
            if ((btn1.Text == btn5.Text) && (btn5.Text == btn9.Text) && btn1.Enabled == false)
            {
                winner = true;
            }
            if ((btn2.Text == btn5.Text) && (btn5.Text == btn8.Text) && btn2.Enabled == false)
            {
                winner = true;
            }
            if ((btn3.Text == btn6.Text) && (btn6.Text == btn9.Text) && btn3.Enabled == false)
            {
                winner = true;
            }
            if ((btn3.Text == btn5.Text) && (btn5.Text == btn7.Text) && btn3.Enabled == false)
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

            func.turn_count += 1;

            if ((winner) && func.turn_count < 10)
            {
                if (func.turn)
                {
                    MessageBox.Show(Player2.Text + " WINS");
                    Reset_buttons();
                    func.player2 += 1;
                    scorebox2.Text = func.player2.ToString();
                }
                else
                {
                    MessageBox.Show(Player1.Text + " WINS");
                    Reset_buttons();
                    func.player1 += 1;
                    scorebox1.Text = func.player1.ToString();
                }
            }
            else if (func.turn_count == 9)
            {
                MessageBox.Show("DRAW");
                Reset_buttons();
            }
        }

        private void exitGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Player1.Text = func.PlayerName1;
            Player2.Text = func.PlayerName2;
        }

        private void exitGameToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Reset_buttons()
        {
            btn1.Text = ""; btn1.Enabled = true;
            btn2.Text = ""; btn2.Enabled = true;
            btn3.Text = ""; btn3.Enabled = true;
            btn4.Text = ""; btn4.Enabled = true;
            btn5.Text = ""; btn5.Enabled = true;
            btn6.Text = ""; btn6.Enabled = true;
            btn7.Text = ""; btn7.Enabled = true;
            btn8.Text = ""; btn8.Enabled = true;
            btn9.Text = ""; btn9.Enabled = true;
            func.turn = !func.turn;
            func.turn_count = 0;
        }

    }
}
