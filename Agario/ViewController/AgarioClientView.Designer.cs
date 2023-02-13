/// <summary> 
/// Author:    Samuel Hancock 
/// Partner:   Hyrum Schenk 
/// Date:      April 1, 2020 
/// Course:    CS 3500, University of Utah, School of Computing 
/// Copyright: CS 3500, Samuel Hancock and Hyrum Schenk - This work may not be copied for use in Academic Coursework. 
/// 
/// I, Samuel Hancock and Hyrum Schenk, certify that I wrote this code from scratch and did not copy it in part or whole from  
/// another source.  All references used in the completion of the assignment are cited in my README file. 
/// 
/// File Contents 
/// 
///    This file contains the code for the Windows Form. Players will enter their username and desired server IPAddress here.
///    Other game information will be displayed on the side of the screen.
/// </summary>

using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;

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
            this.ClientSize = new System.Drawing.Size(1000, 1000);
            this.Text = "Bargain Bin Agario";          

            this.Connect_Button = new System.Windows.Forms.Button();
            this.Connect_Button.Location = new Point(50, 50);
            this.Connect_Button.Size = new Size(100, 50);
            this.Connect_Button.Name = "Connect Button";
            this.Connect_Button.Text = "Connect";
            this.Connect_Button.Click += Connect;

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
            this.IPAddress_Label.Size = new Size(100, 50);
            this.IPAddress_Label.Name = "IPAddress Label";
            this.IPAddress_Label.Text = "IP Address:";

            this.Size = new Size(1300, 1000);

            this.Recieved_Player_Name_Label = new System.Windows.Forms.Label();
            this.Recieved_Player_Name_Label.Location = new Point(900, 100);
            this.Recieved_Player_Name_Label.Size = new Size(150, 30);
            this.Recieved_Player_Name_Label.Name = "Recieved Player Name Label";
            this.Recieved_Player_Name_Label.Text = "";

            this.Food_Label = new System.Windows.Forms.Label();
            this.Food_Label.Location = new Point(820, 140);
            this.Food_Label.Size = new Size(50, 20);
            this.Food_Label.Name = "Food Label";
            this.Food_Label.Text = "Food:";

            this.Recieved_Food_Label = new System.Windows.Forms.Label();
            this.Recieved_Food_Label.Location = new Point(900, 140);
            this.Recieved_Food_Label.Size = new Size(150, 30);
            this.Recieved_Food_Label.Name = "Food Label";
            this.Recieved_Food_Label.Text = "";

            this.Position_Label = new System.Windows.Forms.Label();
            this.Position_Label.Location = new Point(820, 180);
            this.Position_Label.Size = new Size(85, 30);
            this.Position_Label.Name = "Position Label";
            this.Position_Label.Text = "Position:";

            this.Recieved_Position_Label = new System.Windows.Forms.Label();
            this.Recieved_Position_Label.Location = new Point(900, 180);
            this.Recieved_Position_Label.Size = new Size(150, 30);
            this.Recieved_Position_Label.Name = "Recieved Position Label";
            this.Recieved_Position_Label.Text = "";

            this.Player_Name_Label_2 = new System.Windows.Forms.Label();
            this.Player_Name_Label_2.Location = new Point(820, 100);
            this.Player_Name_Label_2.Size = new Size(60, 30);
            this.Player_Name_Label_2.Name = "Player Name Label 2";
            this.Player_Name_Label_2.Text = "Name:";

            this.Player_ID_Label = new System.Windows.Forms.Label();
            this.Player_ID_Label.Location = new Point(820, 220);
            this.Player_ID_Label.Size = new Size(80, 30);
            this.Player_ID_Label.Name = "Player ID Label";
            this.Player_ID_Label.Text = "Player ID:";

            this.Recieved_Player_ID_Label = new System.Windows.Forms.Label();
            this.Recieved_Player_ID_Label.Location = new Point(900, 220);
            this.Recieved_Player_ID_Label.Size = new Size(200, 30);
            this.Recieved_Player_ID_Label.Name = "Recieved Player ID Label";
            this.Recieved_Player_ID_Label.Text = "";

            this.Controls.Add(Connect_Button);
            this.Controls.Add(Player_Name_Textbox);
            this.Controls.Add(Player_Name_Label);
            this.Controls.Add(IPAddress_Textbox);
            this.Controls.Add(IPAddress_Label);
            this.Controls.Add(Recieved_Player_Name_Label);
            this.Controls.Add(Food_Label);
            this.Controls.Add(Recieved_Food_Label);
            this.Controls.Add(Position_Label);
            this.Controls.Add(Recieved_Position_Label);
            this.Controls.Add(Player_Name_Label_2);
            this.Controls.Add(Player_ID_Label);
            this.Controls.Add(Recieved_Player_ID_Label);


            this.DoubleBuffered = true;

        }

        #endregion

        private Button Connect_Button;

        private TextBox Player_Name_Textbox;
        private Label Player_Name_Label;
        private TextBox IPAddress_Textbox;
        private Label IPAddress_Label;
        private Label Recieved_Player_Name_Label;
        private Label Food_Label;
        private Label Recieved_Food_Label;
        private Label Position_Label;
        private Label Recieved_Position_Label;
        private Label Player_Name_Label_2;
        private Label Player_ID_Label;
        private Label Recieved_Player_ID_Label;
    }
}
