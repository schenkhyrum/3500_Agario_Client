using System;
using System.Drawing;
using System.Windows.Forms;

namespace ViewController
{
    partial class AgarioClientView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Bargain Bin Agario";

            this.Connect_Button = new System.Windows.Forms.Button();
            this.Connect_Button.Location = new Point(50, 50);
            this.Connect_Button.Size = new Size(100, 50);
            this.Connect_Button.Name = "Connect Button";
            this.Connect_Button.Text = "Connect";
            //this.Connect_Button.Click += Connect_to_Server;

            this.Player_Name_Textbox = new System.Windows.Forms.TextBox();
            this.Player_Name_Textbox.Location = new Point(200, 200);
            this.Player_Name_Textbox.Size = new Size(250, 150);
            this.Player_Name_Textbox.Name = "Player Name Textbox";
            this.Player_Name_Textbox.Text = "Enter player name here";

            this.Player_Name_Label = new System.Windows.Forms.Label();
            this.Player_Name_Label.Location = new Point(50, 200);
            this.Player_Name_Label.Size = new Size(150, 50);
            this.Player_Name_Label.Name = "Player Name Label";
            this.Player_Name_Label.Text = "Enter player name:";

            this.IPAddress_Textbox = new System.Windows.Forms.TextBox();
            this.IPAddress_Textbox.Location = new Point(200, 300);
            this.IPAddress_Textbox.Size = new Size(250, 150);
            this.IPAddress_Textbox.Name = "IPAddress Textbox";
            this.IPAddress_Textbox.Text = "localhost";

            this.IPAddress_Label = new System.Windows.Forms.Label();
            this.IPAddress_Label.Location = new Point(50, 300);
            this.IPAddress_Label.Size = new Size(150, 50);
            this.IPAddress_Label.Name = "IPAddress Label";
            this.IPAddress_Label.Text = "IP Address:";

            this.Size = new Size(1000, 1000);

            //this.Paint += new PaintEventHandler(Draw_Scene2);

            this.Controls.Add(Connect_Button);
            this.Controls.Add(Player_Name_Textbox);
            this.Controls.Add(Player_Name_Label);
            this.Controls.Add(IPAddress_Textbox);
            this.Controls.Add(IPAddress_Label);
        }

        #endregion

        private Button Connect_Button;

        private TextBox Player_Name_Textbox;
        private Label Player_Name_Label;
        private TextBox IPAddress_Textbox;
        private Label IPAddress_Label;
    }
}

