using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp
{
    public partial class LoginFrame : Form
    {
        public static int checkPoint;
        public static int highestPermissions = 0;
        public LoginFrame()
        {
            InitializeComponent();
        }

        private void LoginFrame_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'demodbDataSet2.membersys' table. You can move, or remove it, as needed.
            //this.membersysTableAdapter.Fill(this.demodbDataSet2.membersys);

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
            SqlConnection cnn;
            SqlDataAdapter adaptor = new SqlDataAdapter();
            SqlDataReader dataReader;
            SqlCommand command;

            bool checkMatch1, checkMatch2, statusCheck = false;

            int count = 0;
            checkPoint = 0;

            string sql, sql1, findoutspecItem1, findoutspecItem2;
            string outputLineCheck = "";

            string inputStringIDandInfo1 = textBox1.Text;
            string inputStringIDandInfo2 = textBox2.Text; // User Name - User Password

            cnn = UserInfoFrame.getConnection(); // adding connection

            sql = "SELECT * FROM membersys Order by id DESC " +
                 "Select username, password from membersys"; //SQL command

            //sql1 = "Delete from membersys where id= 7";

            try
            {
                using (command = new SqlCommand(sql, cnn))
                {
                    cnn.Open();
                    dataReader = command.ExecuteReader(); //Make table can be readable

                    while (dataReader.Read())
                    {
                        findoutspecItem1 = dataReader.GetValue(1).ToString(); // user Name
                        findoutspecItem2 = dataReader.GetValue(2).ToString(); // User Password

                        checkMatch1 = inputStringIDandInfo1.Contains(findoutspecItem1); // check string wheter include
                        checkMatch2 = inputStringIDandInfo2.Contains(findoutspecItem2); 

                        outputLineCheck += count.ToString() + "  -  " +
                            dataReader.GetValue(1) + "  -  " +
                            dataReader.GetValue(2) + "\n\n";      //Read table with lines


                        if (checkMatch1 == true && checkMatch2 == true) // double check what the User column want to update
                        {
                            cnn.Close();
                            statusCheck = false;

                            checkPoint = 1; // log in success

                            MessageBox.Show("OK");


                            this.Close();
                            break; // when check is accepted, break the while loop
                        }

                        else
                        {
                            statusCheck = true;
                        }
                        count++; //Line counter
                    }
                    

                    if (statusCheck == true)
                    {
                        checkPoint = 0; // log in fail

                        MessageBox.Show("Not found matched data");
                    }


                    dataReader.Close();
                    adaptor.Dispose();
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show("Please check SQL syntax", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (highestPermissions == 1)
                MessageBox.Show(getShowlist());         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection cnn;
            SqlDataAdapter adaptor = new SqlDataAdapter();
            SqlDataReader dataReader;
            SqlCommand command, command1;
            string sql1, sql = null;

            bool checkMatch1, checkMatch2, statusCheck = false;
            int count = 0;
            string findoutspecItem1, findoutspecItem2;
            string outputLineCheck = "";

            string inputStringIDandInfo1 = textBox1.Text;
            string inputStringIDandInfo2 = textBox2.Text; // User Name - User Password

            cnn = UserInfoFrame.getConnection(); // adding connection
            
            sql = $"Insert into membersys (username, password) " +
                $"values('{textBox1.Text}', '{textBox2.Text}')"; //SQL insert command VB.Net

            sql1 = "SELECT * FROM membersys Order by id DESC " +
                 "Select username, password from membersys"; //SQL command


            try
            {
                using (command = new SqlCommand(sql1, cnn))
                {
                    cnn.Open();
                    dataReader = command.ExecuteReader(); //Make table can be readable

                    while (dataReader.Read())
                    {
                        findoutspecItem1 = dataReader.GetValue(1).ToString(); // user Name

                        checkMatch1 = inputStringIDandInfo1.Contains(findoutspecItem1); // check string wheter include

                        outputLineCheck += count.ToString() + "  -  " +
                            dataReader.GetValue(1) + "  -  " +
                            dataReader.GetValue(2) + "\n\n";      //Read table


                        if (checkMatch1 == true) // double check what the User column want to update
                        {
                            cnn.Close();
                            statusCheck = false;
                            MessageBox.Show("Used username, please change one");

                            break; // when check is accepted, break the while loop
                        }

                        else
                        {
                            statusCheck = true;
                        }
                        count++; //Line counter
                    }

                    cnn.Close() ; //due to two connection in one method it needs to open and close twice

                    dataReader.Close();
                    adaptor.Dispose();

                    if (statusCheck == true)
                    {
                        MessageBox.Show("OK");

                        try
                        {

                            adaptor.InsertCommand = new SqlCommand(sql, cnn);
                            cnn.Open();
                            
                            adaptor.InsertCommand.ExecuteNonQuery();
                            adaptor.Dispose();

                            cnn.Close() ;
                            
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Wrong using syntax, please delete the char( ' )\n or adding double char( ' ) instead in your sentence", "Wrong Input characters ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show("Please check SQL syntax", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }
    }
}
