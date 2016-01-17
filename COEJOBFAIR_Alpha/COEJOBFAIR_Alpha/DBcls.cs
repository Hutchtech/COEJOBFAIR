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
            OdbcConnection cnn;

            public odbc_cnn()
            {
                cnn = new OdbcConnection("DSN=COEJOBFAIR;UID=ttu\ryhutchi;PWD = Frixon1!!;");  // get login from Remi that is not mine!
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

            public void mainDBCall()
            {
                odbc_cnn connection_1 = new odbc_cnn();
                odbc_comand command_1 = new odbc_comand("SELECT * FROM Main_tbl WHERE id = " + Rnum);

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

                reader.Close();
                connection_1.getcnn().Close();
                 
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
        public class Employe_calls
        {
            //SQL constants
            const string employe_db = "Employers_2016_S";
            const string column_names = "(name, organization, title, hotel, other, nights, alumni)";
            const string value_names = "(@name, @organization, @title, @hotel, @other, @nights, @alumni)";
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
            /// </param>
            public Employe_calls(string[] employe_data)
            {
                odbc_cnn connection_1 = new odbc_cnn();
                OdbcCommand command = new OdbcCommand();

                command.CommandType = CommandType.Text;
                command.CommandText = "INSERT into " + employe_db + " ("+column_names+") VALUES ("+value_names+")";
                int i = 0;
                while(i<7)
                {
                    command.Parameters.AddWithValue(value[i],employe_data[i]);  //STEP THROUGH THIS MAKE SURE IT IS DOING WHAT YOU WANT REF : 1A
                    i++;
                }

                command.Connection = connection_1.getcnn();
                command.ExecuteNonQuery();
            }
            /// <summary>
            /// For Mass Import from Survery Monkey Import
            /// </summary>
            /// <param name="employe_data"></param>
            /// <param name="table"></param>
            public Employe_calls(string[] employe_data,string table) 
            {
                odbc_cnn connection_1 = new odbc_cnn();
                OdbcCommand command = new OdbcCommand();

                command.CommandType = CommandType.Text;
                command.CommandText = "INSERT into " + table + " (" + column_names + ") VALUES (" + value_names + ")";

                int i = 0;
                while (i < 7)
                {
                    command.Parameters.AddWithValue(value[i], employe_data[i]);  //STEP THROUGH THIS MAKE SURE IT IS DOING WHAT YOU WANT REF : 1A
                    i++;
                }

                command.Connection = connection_1.getcnn();
                command.ExecuteNonQuery();
            }
        }
        }
    }

