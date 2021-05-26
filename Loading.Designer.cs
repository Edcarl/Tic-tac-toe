
namespace Tic_tac_toe
{
    partial class Loading
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loading));
            this.Player1box = new System.Windows.Forms.TextBox();
            this.Player2box = new System.Windows.Forms.TextBox();
            this.Player1lbl = new System.Windows.Forms.Label();
            this.Player2lbl = new System.Windows.Forms.Label();
            this.Loadingbar = new System.Windows.Forms.ProgressBar();
            this.Loadingtimer = new System.Windows.Forms.Timer(this.components);
            this.Startbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Player1box
            // 
            this.Player1box.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player1box.Location = new System.Drawing.Point(51, 66);
            this.Player1box.Name = "Player1box";
            this.Player1box.Size = new System.Drawing.Size(130, 30);
            this.Player1box.TabIndex = 0;
            // 
            // Player2box
            // 
            this.Player2box.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player2box.Location = new System.Drawing.Point(51, 126);
            this.Player2box.Name = "Player2box";
            this.Player2box.Size = new System.Drawing.Size(130, 30);
            this.Player2box.TabIndex = 1;
            // 
            // Player1lbl
            // 
            this.Player1lbl.AutoSize = true;
            this.Player1lbl.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player1lbl.ForeColor = System.Drawing.Color.Blue;
            this.Player1lbl.Location = new System.Drawing.Point(47, 45);
            this.Player1lbl.Name = "Player1lbl";
            this.Player1lbl.Size = new System.Drawing.Size(139, 20);
            this.Player1lbl.TabIndex = 2;
            this.Player1lbl.Text = "Enter Player 1 Name:";
            // 
            // Player2lbl
            // 
            this.Player2lbl.AutoSize = true;
            this.Player2lbl.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player2lbl.ForeColor = System.Drawing.Color.Blue;
            this.Player2lbl.Location = new System.Drawing.Point(47, 105);
            this.Player2lbl.Name = "Player2lbl";
            this.Player2lbl.Size = new System.Drawing.Size(141, 20);
            this.Player2lbl.TabIndex = 3;
            this.Player2lbl.Text = "Enter Player 2 Name:";
            // 
            // Loadingbar
            // 
            this.Loadingbar.Location = new System.Drawing.Point(12, 262);
            this.Loadingbar.Name = "Loadingbar";
            this.Loadingbar.Size = new System.Drawing.Size(222, 23);
            this.Loadingbar.TabIndex = 4;
            this.Loadingbar.Visible = false;
            this.Loadingbar.Click += new System.EventHandler(this.Loadingbar_Click);
            // 
            // Loadingtimer
            // 
            this.Loadingtimer.Tick += new System.EventHandler(this.Loadingtimer_Tick);
            // 
            // Startbtn
            // 
            this.Startbtn.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Startbtn.ForeColor = System.Drawing.Color.Blue;
            this.Startbtn.Location = new System.Drawing.Point(81, 180);
            this.Startbtn.Name = "Startbtn";
            this.Startbtn.Size = new System.Drawing.Size(75, 44);
            this.Startbtn.TabIndex = 5;
            this.Startbtn.Text = "Start";
            this.Startbtn.UseVisualStyleBackColor = true;
            this.Startbtn.Click += new System.EventHandler(this.Startbtn_Click);
            // 
            // Loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(246, 297);
            this.Controls.Add(this.Startbtn);
            this.Controls.Add(this.Loadingbar);
            this.Controls.Add(this.Player2lbl);
            this.Controls.Add(this.Player1lbl);
            this.Controls.Add(this.Player2box);
            this.Controls.Add(this.Player1box);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Loading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Player1box;
        private System.Windows.Forms.TextBox Player2box;
        private System.Windows.Forms.Label Player1lbl;
        private System.Windows.Forms.Label Player2lbl;
        private System.Windows.Forms.ProgressBar Loadingbar;
        private System.Windows.Forms.Timer Loadingtimer;
        private System.Windows.Forms.Button Startbtn;
    }
}