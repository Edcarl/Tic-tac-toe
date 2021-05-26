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
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }

        private void Startbtn_Click(object sender, EventArgs e)
        {
            Player1lbl.Visible = false;
            Player2lbl.Visible = false;
            Player1box.Visible = false;
            Player2box.Visible = false;
            Startbtn.Visible = false;
            Loadingbar.Visible = true;
            Loadingtimer.Enabled = true;
        }

        private void Loadingtimer_Tick(object sender, EventArgs e)
        {
            Loadingbar.Value++;
            if(Loadingbar.Value == 100)
            {
                Loadingtimer.Enabled = false;
                Loadingbar.Visible = false;
                this.Hide();
                Form1 newMainForm = new Form1();
                newMainForm.Show();
            }
        }

        private void Loadingbar_Click(object sender, EventArgs e)
        {

        }
    }
}
