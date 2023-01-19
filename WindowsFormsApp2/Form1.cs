﻿using System;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
                string theText = textBox.Text;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
                string theText = textBox.Text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            SqlConnection cnn;
            SqlCommand command;
            SqlDataReader dataReader;  
            string sql, Output = "";
            string textC1 = textBox1.Text;
            string textC2 = textBox2.Text;

            //MessageBox.Show(textB1 + textB2);

            cnn = getConnection(); // adding connection
            sql = "Select TutorialID, TutorialName from demotb"; //SQL command

            using (command = new SqlCommand(sql, cnn)) 
            {
                cnn.Open();
                dataReader = command.ExecuteReader(); //Make table can be readable

                while (dataReader.Read())
                {
                    Output = Output + dataReader.GetValue(0) + " - " + dataReader.GetValue(1) + "\n"; //Read table
                }

                MessageBox.Show(Output);
                dataReader.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'demodbDataSet.demotb' table. You can move, or remove it, as needed.
            this.demotbTableAdapter.Fill(this.demodbDataSet.demotb);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            SqlConnection cnn;
            SqlDataAdapter adaptor = new SqlDataAdapter();
            string sql;
            string textC1 = textBox1.Text;
            string textC2 = textBox2.Text;

            cnn = getConnection(); // adding connection
            sql = "Update demotb set TutorialName='"+"VB.Net Complete"+$"' where TutorialID ={textC1}"; //SQL update command


            using (adaptor.UpdateCommand = new SqlCommand(sql, cnn))
            {
                cnn.Open();

                adaptor.UpdateCommand.ExecuteNonQuery();
                adaptor.Dispose();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection cnn;
            SqlDataAdapter adaptor = new SqlDataAdapter();
            string sql = null;
            string textC1 = textBox1.Text;
            string textC2 = textBox2.Text;

            cnn = getConnection(); // adding connection
            sql = $"Insert into demotb (TutorialID,TutorialName) values({textC1}, '{textC2}')"; //SQL insert command VB.Net

            using (adaptor.InsertCommand = new SqlCommand(sql, cnn))
            {
                cnn.Open();

                adaptor.InsertCommand.ExecuteNonQuery();
                adaptor.Dispose();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection cnn;
            SqlDataAdapter adaptor = new SqlDataAdapter();
            string sql;
            string textC1 = textBox1.Text;

            cnn = getConnection(); // adding connection
            sql = $"Delete demotb where TutorialID={textC1}"; //SQL delete command


            using (adaptor.DeleteCommand = new SqlCommand(sql, cnn))
            {
                cnn.Open();

                adaptor.DeleteCommand.ExecuteNonQuery();
                adaptor.Dispose();
            }
        }
    }
}
