﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using System.Data.SqlClient;

namespace WindowsFormsApp
{
    public partial class MainFrame : Form
    {
        private Button button1;
        int height = Screen.PrimaryScreen.Bounds.Height;
        private Button button2;
        private Button button3;
        int width = Screen.PrimaryScreen.Bounds.Width;

        public MainFrame()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            UserInfoFrame frameT = new UserInfoFrame();

            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(142, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(233, 61);
            this.button1.TabIndex = 0;
            this.button1.Text = "Update User Info";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(142, 234);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(233, 61);
            this.button2.TabIndex = 1;
            this.button2.Text = "Out";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button3.Location = new System.Drawing.Point(144, 63);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(234, 61);
            this.button3.TabIndex = 2;
            this.button3.Text = "Check Users List";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // MainFrame
            // 
            this.ClientSize = new System.Drawing.Size(497, 363);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "MainFrame";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.MainFrame_Load);
            this.ResumeLayout(false);

        }

        private void MainFrame_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            new UserInfoFrame().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //SqlConnection cnn;
            //SqlCommand command;
            //SqlDataReader dataReader;
            //string sql;
            //string Output = "";


            //cnn = UserInfoFrame.getConnection(); // adding connection
            //sql = "SELECT * FROM demotb Order by UserID " +
            //     "Select UserID, UserBasicInfo, UserStatus, UserTime, UserContent from demotb"; //SQL command

            //using (command = new SqlCommand(sql, cnn))
            //{
            //    cnn.Open();
            //    dataReader = command.ExecuteReader(); //Make table can be readable

            //    while (dataReader.Read())
            //    {
            //        Output = Output +
            //            dataReader.GetValue(0) + "  -  " +
            //            dataReader.GetValue(1) + "  -  " +
            //            dataReader.GetValue(2) + "  -  " +
            //            dataReader.GetValue(3) + "  -  " +
            //            dataReader.GetValue(4) + "\n\n";      //Read table
            //    }

            //    MessageBox.Show(Output);
            //    dataReader.Close();
            //}
            MessageBox.Show(UserInfoFrame.getShowlist());
        }

        private void frameT_Load(object sender, EventArgs e)
        {

        }
    }
}