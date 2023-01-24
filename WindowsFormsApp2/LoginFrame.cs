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

namespace WindowsFormsApp
{
    public partial class LoginFrame : Form
    {
        public LoginFrame()
        {
            InitializeComponent();
        }

        private void LoginFrame_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'demodbDataSet2.membersys' table. You can move, or remove it, as needed.
            this.membersysTableAdapter.Fill(this.demodbDataSet2.membersys);

        }

        private static string getShowlist()  //Creating a sqlConnection method
        {
            SqlConnection cnn;
            SqlCommand command;
            SqlDataReader dataReader;
            string sql;
            string Output = "";


            cnn = UserInfoFrame.getConnection(); // adding connection
            sql = "SELECT * FROM membersys Order by Id ASC " +
                 "Select username, password from membersys"; //SQL command

            using (command = new SqlCommand(sql, cnn))
            {
                cnn.Open();
                dataReader = command.ExecuteReader(); //Make table can be readable

                while (dataReader.Read())
                {
                    Output = Output +
                        dataReader.GetValue(0) + "  -  " +
                        dataReader.GetValue(1) + "  -  " +
                        dataReader.GetValue(2) + "\n\n";      //Read table


                }
                dataReader.Close();

                return Output;
            }
        }

            private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(getShowlist());         
        }
    }
}
