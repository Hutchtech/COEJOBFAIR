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

            public OdbcConnection getcnn() { if (cnn != null) return cnn; else { MessageBox.Show("Error");return cnn; } }
        }

        public class calls
        {
            string[] data_name_crd = new string[10];
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

            public void mainDBCall()
            {
                try {
                    odbc_cnn connection_1 = new odbc_cnn();
                    odbc_comand command_1 = new odbc_comand("SELECT * FROM Main_tbl WHERE id = " + Rnum);

                    command_1.getcmd().Connection = connection_1.getcnn();
                    connection_1.getcnn().Open();
                    OdbcDataReader reader = command_1.getcmd().ExecuteReader();
                    while (reader.Read())
                    {
                        data_name_crd[0] = reader[1].ToString();
                        data_name_crd[1] = reader[2].ToString();
                        data_name_crd[2] = reader[3].ToString();
                        data_name_crd[3] = reader[4].ToString();
                        data_name_crd[6] = reader[6].ToString();
                    }

                    reader.Close();
                    connection_1.getcnn().Close();
                }
                catch
                {
                    MessageBox.Show("Please Ask for Help (Database Error)");
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
                catch (OdbcException e)
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
                

            }
        }
    }

