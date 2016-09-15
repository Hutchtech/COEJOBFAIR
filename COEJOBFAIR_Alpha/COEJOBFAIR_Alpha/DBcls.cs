using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace COEJOBFAIR_Alpha
{
    class Data_cnct : Main
    {

        private class odbc_comand
        {
            OdbcCommand cmd;
            public odbc_comand(string v)
            {
                cmd = new OdbcCommand();
                cmd.CommandText = v;
                cmd.CommandType = CommandType.Text;
            }
            public OdbcCommand getcmd() { return cmd; }

        }
        private class odbc_cnn
        {
            OdbcConnection cnn = null;

            public odbc_cnn()
            {
                try
                {
                    cnn = new OdbcConnection("DSN=COEJOBFAIR;UID=ttu\\coe_ponos_admin;PWD = T~E95UeocGg_;");
                }
                catch
                {
                    MessageBox.Show("Please Ask for Help (Connection Error)");
                }

            }

            public OdbcConnection getcnn() { if (cnn != null) return cnn; else { MessageBox.Show("Error"); return cnn; } }
        }

        public class calls
        {
            string[] data_name_crd = new string[10];
            string Rnum;
            bool pre_reg;

            
            public calls(string s, bool pre_reg)
            {
                this.pre_reg = pre_reg;
                Rnum = s;
                mainDBCall();
            }

            public calls()
            {
                connection_chck();
            }
            public calls(String first, String last, String Rnum,bool pre_reg)
            {
                this.pre_reg = pre_reg;
                AppendCall(first, last, Rnum);
            }
            public string[] get_crd_data()
            {
                return data_name_crd;
            }
            public void AppendCall(String first, String last, String Rnum)
            {
                try
                {
                    odbc_cnn connection_1 = new odbc_cnn();
                    OdbcCommand command = new OdbcCommand();

                    command.CommandType = CommandType.Text;

                    
                    if (pre_reg)
                    {
                        command.CommandText = "INSERT INTO Job_Fair_Fall_2016 (ID, LastName, FirstName, Pre_Reg) VALUES ('" + Rnum + "', '" + last + "', '" + first + "', '1')";
                    }
                    else
                    {
                        command.CommandText = "INSERT INTO Job_Fair_Fall_2016 (ID, LastName, FirstName, Pre_Reg) VALUES ('" + Rnum + "', '" + last + "', '" + first + "','0')";
                    }
                    command.Connection = connection_1.getcnn();
                    command.Connection.Open();
                    command.ExecuteNonQuery();

                    command.Connection.Close();
                }
                catch(Exception error)
                {

                    MessageBox.Show("Please Ask for help (Database Error)");
                    MessageBox.Show(error.ToString());
                }
                
            }
            public void mainDBCall()
            {
                try
                {
                    odbc_cnn connection_1 = new odbc_cnn();
                    odbc_comand command_1 = new odbc_comand("SELECT * FROM Job_Fair_Fall_2016 WHERE ID = 'R" + Rnum + "';");

                    command_1.getcmd().Connection = connection_1.getcnn();
                    connection_1.getcnn().Open();
                    OdbcDataReader reader = command_1.getcmd().ExecuteReader();
                    while (reader.Read())
                    {
                        data_name_crd[2] = reader[2].ToString(); //First
                        data_name_crd[1] = reader[1].ToString(); //Last
                        data_name_crd[0] = reader[0].ToString(); //Id
                        data_name_crd[5] = reader[5].ToString(); //Pre
                        
                    }

                    reader.Close();
                    connection_1.getcnn().Close();
                }
                catch(Exception error)
                {
                    MessageBox.Show("Please Ask for Help (Database Error)");
                    MessageBox.Show(error.ToString());
                }
                try
                {
                    odbc_cnn connection_1 = new odbc_cnn();
                    OdbcCommand command = new OdbcCommand();

                    command.CommandType = CommandType.Text;
                    if (pre_reg)
                    {
                        command.CommandText = "UPDATE Job_Fair_Fall_2016 SET  Pre_Reg = '1' WHERE ID = 'R" + Rnum + "';";
                    }
                    else
                    {
                        command.CommandText = "UPDATE Job_Fair_Fall_2016 SET  Pre_Reg = '0' WHERE ID = 'R" + Rnum + "';";
                    }

                    command.Connection = connection_1.getcnn();
                    command.Connection.Open();
                    command.ExecuteNonQuery();

                    command.Connection.Close();
                }
                catch
                {
                    MessageBox.Show("Please Input your information");
                }
            }

      
         
            public bool connection_chck()
            {
                bool bol = true;
                odbc_cnn test_cnn = new odbc_cnn();
                test_cnn.getcnn().ConnectionTimeout = 7;
                try
                {
                    
                    test_cnn.getcnn().Open();
                }
                catch (OdbcException error) //use error in future for error logging
                {
                   
                    bol = false;
                }
                return bol;   
            }
            public bool db_chck()
            {
                bool val = true;
                Data_cnct.calls main_call = new Data_cnct.calls();
                if (main_call.connection_chck())
                {
                    try
                    {
                        odbc_cnn connection_1 = new odbc_cnn();
                        odbc_comand command_1 = new odbc_comand("SELECT TOP 10 FROM Main_tbl");

                        command_1.getcmd().Connection = connection_1.getcnn();
                        connection_1.getcnn().Open();
                        OdbcDataReader reader = command_1.getcmd().ExecuteReader();
                        string test = "";
                        bool test1 = false;
                        while (reader.Read())
                        {
                            test = reader[0].ToString();
                        }
                        if (test != "")
                        {
                            test1 = true;
                        }
                        reader.Close();
                        connection_1.getcnn().Close();
                        if (test1) { val = true; }

                    }
                    catch
                    {
                        val = false;
                    }
                    
                }
                else
                {
                    val = false;
                }
                return val;
            }
                


            }
        public class Employe_calls
        {
            //SQL constants
            const string employe_db = "Employers_2016_F";

            const string value_names = "('@name', '@organization', '@title', '@hotel', '@other', '@nights', '@alumni')";
            string[] value = new string[7] {"@name", "@organization", "@title", "@hotel", "@other", "@nights", "@alumni" };
            /// <summary>
            /// class for employe funcitons to the database.
            /// this constructor will get all the data for 
            /// an employe and submit it to the database
            /// </summary>
            /// <param name="employe_data">
            /// Refrence for employe data
            ///     0 - first + space + last
            ///     1 - organization
            ///     2 - title
            ///     3 - hotel
            ///     4 - other
            ///     5 - amount of nights
            ///     6 - alumni
            /// </param>
            public Employe_calls(string[] employe_data)
            {
                try {
                    odbc_cnn connection_1 = new odbc_cnn();
                    OdbcCommand command = new OdbcCommand();

                    command.CommandType = CommandType.Text;
                    command.CommandText = "INSERT into " + employe_db + " (name, organization, title, hotel, other, nights, alumni) VALUES ('" + employe_data[0] + "', '" + employe_data[1] + "', '" + employe_data[2] + "', '" + employe_data[3] + "', '" + employe_data[4] + "', '" + employe_data[5] + "', '" + employe_data[6] + "')";


                    command.Connection = connection_1.getcnn();
                    command.Connection.Open();
                    command.ExecuteNonQuery();

                    command.Connection.Close();
                }
                catch
                {
                    MessageBox.Show("Please Ask for help (Database Error)");                }
            }
           
           
            }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // status_cnn
            // 
            this.status_cnn.Size = new System.Drawing.Size(1418, 23);
            // 
            // status_db
            // 
            this.status_db.Size = new System.Drawing.Size(1418, 23);
            // 
            // pBar1
            // 
            this.pBar1.Size = new System.Drawing.Size(1418, 26);
            // 
            // Data_cnct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1418, 780);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Data_cnct";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
    }

