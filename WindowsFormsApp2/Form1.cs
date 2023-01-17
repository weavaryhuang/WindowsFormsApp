using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=127.0.0.1;Initial Catalog=Demodb;User ID=sa;Password=asdfghjkl";
            cnn = new SqlConnection(connetionString);
            cnn.Open();

            SqlCommand command;
            SqlDataReader dataReader;
            String sql, Output = "";

            sql = "Select TutorialID, TutorialName from demotb";

            command = new SqlCommand(sql, cnn);

            dataReader = command.ExecuteReader();

            //adaptor.DeleteCommand = new NpgsqlCommand(sql, cnn);
            //adaptor.DeleteCommand.ExecuteNonQuery();

            while (dataReader.Read())
            {
                Output = Output + dataReader.GetValue(0) + " - " + dataReader.GetValue(1) + "\n";
            }

            MessageBox.Show(Output);
            dataReader.Close();
            command.Dispose();
            cnn.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'demodbDataSet.demotb' table. You can move, or remove it, as needed.
            this.demotbTableAdapter.Fill(this.demodbDataSet.demotb);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
