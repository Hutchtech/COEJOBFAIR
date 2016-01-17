using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace COEJOBFAIR_Alpha
{
    class Data_cnct : Main
    {
        ///SQL Constants
        const string REF_TABLE = "Main_tbl";
        const string JOB_FAIR_TABLE = "JobFair_Sring_16";
        const string column_name = "id, name, major, grad_date, jobfair_year, time";
      


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
            OdbcConnection cnn;

            public odbc_cnn()
            {
                cnn = new OdbcConnection("DSN=COEJOBFAIR;UID=coe_ponos_admin;PWD = T~E95UeocGg_;");  
            }

            public OdbcConnection getcnn() { return cnn; }
        }

        public class calls
        {
            string[] data_name_crd = new string[4];
            string Rnum;
           
            public calls(string s)
            {
                Rnum = s;
                mainDBCall();
            }

            public calls()
            {
                connection_chck();
            }
            public string[] get_crd_data()
            {
                return data_name_crd;
            }

           //************* Database calls+++++++++++++++++++++

                /// <summary>
                /// First Main Db call get R-number and refrences it getting all data to put in array so that the printer can access the data.
                /// This call gets the TABLE const which will have the correct database table to refrence
                /// Rnum is given from main.cs call read from the usb scanner.
                /// </summary>
            public void mainDBCall()
            {
                odbc_cnn connection_1 = new odbc_cnn();
                odbc_comand command_1 = new odbc_comand("SELECT * FROM " + REF_TABLE + " WHERE id = " + Rnum);

                command_1.getcmd().Connection = connection_1.getcnn();
                connection_1.getcnn().Open();
                OdbcDataReader reader = command_1.getcmd().ExecuteReader();
                while (reader.Read())
                {
                    data_name_crd[0]= reader[1].ToString();
                    data_name_crd[1] = reader[2].ToString();
                    data_name_crd[2] = reader[3].ToString();
                    data_name_crd[3] = reader[4].ToString();
                }

               
                DBLOGCall(connection_1, Rnum);

                reader.Close();
                connection_1.getcnn().Close();
                 
            }


            /// <summary>
            /// This is the function that adds the student to a diffrent database that logs the time and what jobfair the student attended.
            /// It will log all the students data need for data extraction because of lack of consistency in main reference database.
            /// </summary>
            /// <param name="connection">sends the connection that is already open so that this command can use it before it closes</param>
            /// <param name="rnum">sends the Rnum for logging</param>
            private void DBLOGCall(odbc_cnn connection, string rnum)
            {
                DateTime localDate = DateTime.Now;
                                                                                                                                    //name first + last                            \\      //major            \\     //Graduation date \\   //jobfair\\  //date and time\\
                odbc_comand command_2 = new odbc_comand("INSERT INTO " + JOB_FAIR_TABLE + "("+column_name+") VALUES ('"+ Rnum + "','"+ data_name_crd[0] + " " + data_name_crd[1] + "', '" + data_name_crd[2] + "', '"+data_name_crd[3] +"', '2016S', '" + localDate.Kind + "'");
                
                command_2.getcmd().Connection = connection.getcnn();
                command_2.getcmd().ExecuteNonQuery();
            }

         

            //************* Database calls*****************************************---------------



            //************Connection Checks*******************************************************++++++++++++++
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
                        odbc_comand command_1 = new odbc_comand("SELECT * FROM Main_tbl");

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
            //**************** Connection Check End*******************************************************----------------------------
                

            }
        }
    }

