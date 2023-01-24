using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace WindowsFormsApp
{
    public partial class UserInfoFrame : Form
    {
        string timeString = "yy/MM/dd HH:mm:ss";
        string timeStringNoformat = "yyMMddHHmmss";


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

            // TODO: This line of code loads data into the 'demodbDataSet.demotb' table. You can move, or remove it, as needed.
            //this.demotbTableAdapter.Fill(this.demodbDataSet.demotb);
            this.textBox4.Text = DateTime.Now.ToString(timeString);


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //TextBox textBox1 = sender as TextBox;
            //if (textBox1 != null)
            //{
            //    string theText = textBox1.Text;
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
            sql = "SELECT * FROM demotb Order by UserTime DESC " +
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
                $"values({textBox1.Text}, '{textBox2.Text}', '{textBox3.Text}', '{DateTime.Now.ToString(timeStringNoformat)}', '{textBox5.Text}')"; //SQL insert command VB.Net

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
            new UpdateFrame().Show();

        }
        private void button4_deletValues(object sender, EventArgs e)
        {
            //SqlConnection cnn;
            //SqlDataAdapter adaptor = new SqlDataAdapter();
            //string sql;

            DialogResult result = MessageBox.Show("  Do you ant to delete User ID?", "Warning", 
                MessageBoxButtons.OKCancel, MessageBoxIcon.None);

            if (result == DialogResult.OK)
            {                
                new DeleteFram().Show();         
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

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection cnn;
            SqlDataAdapter adaptor = new SqlDataAdapter();
            string sql = null;

            cnn = getConnection(); // adding connection
            sql = $"Insert into demotb (UserID,UserBasicInfo,UserStatus,UserTime,UserContent) " +
                  $"values(1, 'C#', 'L', '{DateTime.Now.ToString(timeStringNoformat)}', 'testing');" +
                  $"Insert into demotb (UserID,UserBasicInfo,UserStatus,UserTime,UserContent) " +
                  $"values(2, 'ASP.NET', 'LM', '{DateTime.Now.ToString(timeStringNoformat)+1}', 'testing2');" +
                  $"Insert into demotb (UserID,UserBasicInfo,UserStatus,UserTime,UserContent) " +
                  $"values(3, 'VB', 'L', '{DateTime.Now.ToString(timeStringNoformat)+2}', 'testing3');";//SQL insert command VB.Net

            //MessageBox.Show("Some text", "Some title", MessageBoxButtons.OK, MessageBoxIcon.Error);
            try
            {
                using (adaptor.InsertCommand = new SqlCommand(sql, cnn))
                {
                    cnn.Open();
                    adaptor.InsertCommand.ExecuteNonQuery();
                    adaptor.Dispose();
                }
            }
            catch (Exception ex)
            {
               
            }

        }
    }
}
