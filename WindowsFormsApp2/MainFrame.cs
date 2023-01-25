using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
using System.ComponentModel;

namespace WindowsFormsApp
{
    public partial class MainFrame 
    {
        private Button button1;
        private Button button2;
        private Button button4;
        private Button button5;
        private Label label1;
        private Button button6;
        private Button button3;

        public MainFrame()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(141, 220);
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
            this.button2.Location = new System.Drawing.Point(169, 304);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(176, 61);
            this.button2.TabIndex = 1;
            this.button2.Text = "Out";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button3.Location = new System.Drawing.Point(143, 135);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(234, 61);
            this.button3.TabIndex = 2;
            this.button3.Text = "Check Users List";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("PMingLiU", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button4.Location = new System.Drawing.Point(105, 36);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(135, 55);
            this.button4.TabIndex = 3;
            this.button4.Text = "Log In";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("PMingLiU", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button5.Location = new System.Drawing.Point(278, 36);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(135, 55);
            this.button5.TabIndex = 4;
            this.button5.Text = "Log Out";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "_______________________________________________________________";
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.SystemColors.Control;
            this.button6.Location = new System.Drawing.Point(447, 374);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(36, 21);
            this.button6.TabIndex = 6;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // MainFrame
            // 
            this.ClientSize = new System.Drawing.Size(497, 408);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "MainFrame";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.MainFrame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            new LoginFrame().Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LoginFrame.checkPoint = 0;
            LoginFrame.highestPermissions = 0;
            MessageBox.Show("Log out");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LoginFrame.highestPermissions = 1;
        }
    }

    public partial class MainFrame : Form
    {

        private void MainFrame_Load(object sender, EventArgs e) 
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            if (LoginFrame.checkPoint == 1 || LoginFrame.highestPermissions == 1)
                new UserInfoFrame().Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (LoginFrame.checkPoint == 1 || LoginFrame.highestPermissions == 1)
                MessageBox.Show(UserInfoFrame.getShowlist());
        }

        private void frameT_Load(object sender, EventArgs e)
        {

        }
    }
}
