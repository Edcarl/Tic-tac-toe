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
        int turn_count = 0;
        int player1 = 0, player2 = 0;
        string PlayerName1, PlayerName2;

        public Form1()
        {
            InitializeComponent();    
        }
        public Form1(string Player_1, string Player_2)
        {
            PlayerName1 = Player_1;
            PlayerName2 = Player_2;
            //Player1.Text = Player_1;
           // Player2.Text = Player_2;
            
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
            Check_winner();
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
            Check_winner();
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
            Check_winner();
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
            Check_winner();
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
            Check_winner();
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
            Check_winner();
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

            turn_count += 1;

            if ((winner) && turn_count < 10)
            {
                if (turn)
                {
                    MessageBox.Show(Player2.Text + " WINS");
                    Reset_buttons();
                    player2 += 1;
                    scorebox2.Text = player2.ToString();
                }
                else
                {
                    MessageBox.Show(Player1.Text + " WINS");
                    Reset_buttons();
                    player1 += 1;
                    scorebox1.Text = player1.ToString();
                }
            }
            else if (turn_count == 9)
            {
                MessageBox.Show("DRAW");
                Reset_buttons();
            }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Player1.Text = PlayerName1;
            Player2.Text = PlayerName2;
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
            turn = !turn;
            turn_count = 0;
        }
    }
}
