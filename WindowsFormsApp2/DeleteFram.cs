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
    public partial class DeleteFram : Form
    {
        public DeleteFram()
        {
            InitializeComponent();
        }

        private void DeleteFram_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'demodbDataSet.demotb' table. You can move, or remove it, as needed.
            //this.demotbTableAdapter.Fill(this.demodbDataSet.demotb);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cnn;
            SqlDataAdapter adaptor = new SqlDataAdapter();
            SqlDataReader dataReader;
            SqlCommand command;
            SqlCommand command2;
            bool ckeckMatch, statusCheck = false;

            string sql, sql2, findoutspecItem;
            string inputStringIDandInfo = textBox1.Text + "  -  " + textBox2.Text;

            

            cnn = UserInfoFrame.getConnection(); // adding connection
            sql = $"DELETE FROM demotb WHERE UserID = {textBox1.Text} AND UserBasicInfo = '{textBox2.Text}'"; //SQL delete command

            sql2 = "SELECT * FROM demotb Order by UserTime DESC " +
                 "Select UserID, UserBasicInfo, UserStatus, UserTime, UserContent from demotb"; //SQL command

            try
            {
                using (command = new SqlCommand(sql2, cnn))
                {
                    cnn.Open();
                    dataReader = command.ExecuteReader(); //Make table can be readable
                    while (dataReader.Read())
                    {
                        findoutspecItem = dataReader.GetValue(0) + "  -  " + dataReader.GetValue(1);

                        ckeckMatch = inputStringIDandInfo.Contains(findoutspecItem);

                        if (ckeckMatch == true)
                        {
                            cnn.Close();

                            cnn.Open();
                            command2 = new SqlCommand(sql, cnn);
                            command2.ExecuteNonQuery();

                            MessageBox.Show("OK");
                            this.Close();

                            statusCheck = false;
                            break;
                        }

                        else if (ckeckMatch == false)
                        {
                            statusCheck = true;
                        }
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

            //try
            //{

            //    using (adaptor.DeleteCommand = new SqlCommand(sql, cnn))
            //    {
            //        cnn.Open();
            //        command.ExecuteNonQuery();
            //        adaptor.Dispose();
            //        this.Close();
            //    }
            //}


        }
    }
}
