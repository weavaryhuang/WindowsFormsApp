using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class UpdateFrame : Form
    {
        public UpdateFrame()
        {
            InitializeComponent();
        }

        private void UpdateFrame_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'demodbDataSet.demotb' table. You can move, or remove it, as needed.
            this.demotbTableAdapter.Fill(this.demodbDataSet.demotb);

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string timeString = "yy/MM/dd HH:mm:ss";
            string timeStringNoformat = "yyMMddHHmmss";
            SqlConnection cnn;
            SqlDataAdapter adaptor = new SqlDataAdapter();
            SqlDataReader dataReader;
            SqlCommand command;
            bool ckeckMatch, statusCheck = false;

            string sql;

            //SqlConnection cnn;
            //SqlDataAdapter adaptor = new SqlDataAdapter();
            //string sql;

            cnn = UserInfoFrame.getConnection(); // adding connection
            sql = $"Update demotb set UserBasicInfo='{textBox2.Text}', UserStatus='{textBox3.Text}', " +
                $"UserTime='{DateTime.Now.ToString(timeStringNoformat)}', UserContent='{textBox5.Text}' " +
                $"where UserID ={textBox1.Text}"; //SQL update command


            try
            {
                using (command = new SqlCommand(sql, cnn))
                {
                    cnn.Open();
                    command.ExecuteNonQuery();

                    MessageBox.Show("OK");
                    this.Close();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Please check SQL syntax", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

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

        public void button2_Click(object sender, EventArgs e)
        {
            SqlConnection cnn;
            SqlDataAdapter adaptor = new SqlDataAdapter();
            SqlDataReader dataReader;
            SqlCommand command;
            bool checkMatch1, checkMatch2, statusCheck = false;

            int count = 0;

            string sql, findoutspecItem1, findoutspecItem2;
            string outputLineCheck = "";

            string inputStringIDandInfo1 = textBox1.Text;
            //string inputStringIDandInfo2 = textBox1.Text + "  -  " + textBox6.Text; // User ID - User Time

            cnn = UserInfoFrame.getConnection(); // adding connection

            sql = "SELECT * FROM demotb Order by UserTime DESC " +
                 "Select UserID, UserBasicInfo, UserStatus, UserTime, UserContent from demotb"; //SQL command

            try
            {
                using (command = new SqlCommand(sql, cnn))
                {
                    cnn.Open();
                    dataReader = command.ExecuteReader(); //Make table can be readable

                    while (dataReader.Read())
                    {
                        findoutspecItem1 = dataReader.GetValue(0).ToString(); // user ID
                        findoutspecItem2 = dataReader.GetValue(3).ToString(); // User time

                        checkMatch1 = findoutspecItem1.Contains(inputStringIDandInfo1); // check string wheter include
                        //checkMatch2 = inputStringIDandInfo2.Contains(findoutspecItem2);

                        outputLineCheck += count.ToString() + "  -  " +
                            dataReader.GetValue(0) + "  -  " +
                            dataReader.GetValue(1) + "  -  " +
                            dataReader.GetValue(2) + "  -  " +
                            dataReader.GetValue(3) + "  -  " +
                            dataReader.GetValue(4) + "\n\n";      //Read table
                        

                        if (checkMatch1 == true) // double check what the User column want to update
                        {
                            cnn.Close();

                            textBox2.Enabled = true;  // make an authorition when check is availible
                            textBox3.Enabled = true;
                            textBox5.Enabled = true;
                            button1.Visible = true;  // show confirm button
                            button3.Visible = true;  // show cancel button


                            MessageBox.Show("OK");

                            statusCheck = false;
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
            this.Close();
        }
    }
}
