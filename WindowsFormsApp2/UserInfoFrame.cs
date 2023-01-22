﻿using System;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace WindowsFormsApp
{
    public partial class UserInfoFrame : Form
    {
        string timeS = "yyyy/MM/dd HH:mm:ss";

        public UserInfoFrame()
        {
            InitializeComponent();

        }

        public static SqlConnection getConnection()  //Creating a sqlConnection method
        {
            string conn = "Data Source=127.0.0.1;Initial Catalog=Demodb;User ID=sa;Password=asdfghjkl";
            SqlConnection myConn = new SqlConnection(conn);
            return myConn;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'demodbDataSet1.demotb' table. You can move, or remove it, as needed.
            this.demotbTableAdapter1.Fill(this.demodbDataSet.demotb);


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //TextBox textBox = sender as TextBox;
            //if (textBox != null)
            //{
            //    string theText = textBox.Text;
            //}
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        public static string getShowlist()  //Creating a sqlConnection method
        {
            SqlConnection cnn;
            SqlCommand command;
            SqlDataReader dataReader;
            string sql;
            string Output = "";


            cnn = getConnection(); // adding connection
            sql = "SELECT * FROM demotb Order by UserID " +
                 "Select UserID, UserBasicInfo, UserStatus, UserTime, UserContent from demotb"; //SQL command

            using (command = new SqlCommand(sql, cnn))
            {
                cnn.Open();
                dataReader = command.ExecuteReader(); //Make table can be readable

                while (dataReader.Read())
                {
                    Output = Output +
                        dataReader.GetValue(0) + "  -  " +
                        dataReader.GetValue(1) + "  -  " +
                        dataReader.GetValue(2) + "  -  " +
                        dataReader.GetValue(3) + "  -  " +
                        dataReader.GetValue(4) + "\n\n";      //Read table
                }
                dataReader.Close();
                return Output;
            }
        }

        private void button_showResult(object sender, EventArgs e) => MessageBox.Show(getShowlist()); // using method to show user list

        private void button_insertValues(object sender, EventArgs e)
        {
            SqlConnection cnn;
            SqlDataAdapter adaptor = new SqlDataAdapter();
            string sql = null;

            cnn = getConnection(); // adding connection
            sql = $"Insert into demotb (UserID,UserBasicInfo,UserStatus,UserTime,UserContent) " +
                $"values({textBox1.Text}, '{textBox2.Text}', '{textBox3.Text}', '{DateTime.Now.ToString(timeS)}', '{textBox5.Text}')"; //SQL insert command VB.Net

            


            //MessageBox.Show("Some text", "Some title", MessageBoxButtons.OK, MessageBoxIcon.Error);
            try {
                using (adaptor.InsertCommand = new SqlCommand(sql, cnn))
                {
                    cnn.Open();
                    adaptor.InsertCommand.ExecuteNonQuery();
                    adaptor.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wrong using syntax, please delete the char( ' )\n or adding double char( ' ) instead in your sentence", "Wrong Input characters ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_updateValues(object sender, EventArgs e)
        {
            SqlConnection cnn;
            SqlDataAdapter adaptor = new SqlDataAdapter();
            string sql;

            cnn = getConnection(); // adding connection
            sql = $"Update demotb set UserBasicInfo='{textBox2.Text}', UserStatus='{textBox3.Text}', " +
                $"UserTime='{DateTime.Now.ToString(timeS)}', UserContent='{textBox5.Text}' where UserID ={textBox1.Text}"; //SQL update command

            try 
            {
                using (adaptor.UpdateCommand = new SqlCommand(sql, cnn))
                {
                    cnn.Open();

                    adaptor.UpdateCommand.ExecuteNonQuery();
                    adaptor.Dispose();
                    MessageBox.Show("Success", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please check SQL syntax", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        private void button4_deletValues(object sender, EventArgs e)
        {
            SqlConnection cnn;
            SqlDataAdapter adaptor = new SqlDataAdapter();
            string sql;

            cnn = getConnection(); // adding connection
            sql = $"Delete demotb where UserID={textBox1.Text}"; //SQL delete command

            try
            {
                using (adaptor.DeleteCommand = new SqlCommand(sql, cnn))
                {
                    cnn.Open();

                    adaptor.DeleteCommand.ExecuteNonQuery();
                    adaptor.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please check SQL syntax", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
