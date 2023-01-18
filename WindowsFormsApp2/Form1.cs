using System;
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

        private void button1_Click(object sender, EventArgs e)
        {
            
            SqlConnection cnn;
            SqlCommand command;
            SqlDataReader dataReader;  
            string sql, Output = "";

            cnn = getConnection(); 
            sql = "Select TutorialID, TutorialName from demotb";
            

            using (command = new SqlCommand(sql, cnn)) 
            {
                cnn.Open();
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    Output = Output + dataReader.GetValue(0) + " - " + dataReader.GetValue(1) + "\n";
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
