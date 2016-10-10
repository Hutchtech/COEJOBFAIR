using System;
using System.Data.Odbc;
using System.Data;
using System.Windows.Forms;

namespace COEJOBFAIR_Alpha.Database
{
    public class DataCnct : Main
    {
        public class odbcCommand
        {
            private readonly OdbcCommand _cmd;
            public odbcCommand(string v)
            {
                _cmd = new OdbcCommand
                {
                    CommandText = v,
                    CommandType = CommandType.Text
                };
            }
            public OdbcCommand Getcmd() { return _cmd; }

        }
        public class OdbcCnn
        {
            private const string CnnError = "Please Ask for Help (Connection Error)"
            private readonly OdbcConnection _cnn = null;

            public OdbcCnn()
            {
                try
                {
                    _cnn = new OdbcConnection("DSN=COEJOBFAIR;UID=ttu\\coe_ponos_admin;PWD = T~E95UeocGg_;");
                }
                catch
                {
                    MessageBox.Show(CnnError);
                }

            }

            public OdbcConnection Getcnn() { if (_cnn != null) return _cnn; else { MessageBox.Show("Error"); return _cnn; } }
        }

        public class Calls
        {
            private string _dbError = "Please Ask for help (Database Error)"
            private readonly string[] _dataNameCrd = new string[10];
            private readonly string _rnum;
            private readonly bool _isPrereg;

            
            public Calls(string s, bool preReg)
            {
                this._isPrereg = preReg;
                _rnum = s;
                mainDBCall();
            }

            public Calls()
            {
                connection_chck();
            }
            public Calls(string first, string last, string rnum,bool isPrereg)
            {
                this._isPrereg = isPrereg;
                AppendCall(first, last, rnum);
            }
            public string[] get_crd_data()
            {
                return _dataNameCrd;
            }
            public void AppendCall(string first, string last, string rnum)
            {
                try
                {
                    var connection1 = new OdbcCnn();
                    var command = new OdbcCommand {CommandType = CommandType.Text};

                    if (_isPrereg)
                    {
                        command.CommandText = "INSERT INTO Job_Fair_Fall_2016 (ID, LastName, FirstName, Pre_Reg) VALUES ('" + rnum + "', '" + last + "', '" + first + "', '1')";
                    }
                    else
                    {
                        command.CommandText = "INSERT INTO Job_Fair_Fall_2016 (ID, LastName, FirstName, Pre_Reg) VALUES ('" + rnum + "', '" + last + "', '" + first + "','0')";
                    }
                    command.Connection = connection1.Getcnn();
                    command.Connection.Open();
                    command.ExecuteNonQuery();

                    command.Connection.Close();
                }
                catch(Exception error)
                {

                    MessageBox.Show(_dbError);
                    MessageBox.Show(error.ToString());
                }
                
            }
            public void mainDBCall()
            {
                try
                {
                    OdbcCnn connection_1 = new OdbcCnn();
                    odbcCommand command_1 = new odbcCommand("SELECT * FROM Job_Fair_Fall_2016 WHERE ID = 'R" + _rnum + "';");

                    command_1.Getcmd().Connection = connection_1.Getcnn();
                    connection_1.Getcnn().Open();
                    OdbcDataReader reader = command_1.Getcmd().ExecuteReader();
                    while (reader.Read())
                    {
                        _dataNameCrd[2] = reader[2].ToString(); //First
                        _dataNameCrd[1] = reader[1].ToString(); //Last
                        _dataNameCrd[0] = reader[0].ToString(); //Id
                        _dataNameCrd[5] = reader[5].ToString(); //Pre
                        
                    }

                    reader.Close();
                    connection_1.Getcnn().Close();
                }
                catch(Exception error)
                {
                    MessageBox.Show(_dbError);
                    MessageBox.Show(error.ToString());
                }
                try
                {
                    var connection1 = new OdbcCnn();
                    var command = new OdbcCommand();

                    command.CommandType = CommandType.Text;
                    if (_isPrereg)
                    {
                        command.CommandText = "UPDATE Job_Fair_Fall_2016 SET  Pre_Reg = '1' WHERE ID = 'R" + _rnum + "';";
                    }
                    else
                    {
                        command.CommandText = "UPDATE Job_Fair_Fall_2016 SET  Pre_Reg = '0' WHERE ID = 'R" + _rnum + "';";
                    }

                    command.Connection = connection1.Getcnn();
                    command.Connection.Open();
                    command.ExecuteNonQuery();

                    command.Connection.Close();
                }
                catch
                {
                    MessageBox.Show("Please Input your information");
                }
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
                    OdbcCnn connection_1 = new OdbcCnn();
                    OdbcCommand command = new OdbcCommand();

                    command.CommandType = CommandType.Text;
                    command.CommandText = "INSERT into " + employe_db + " (name, organization, title, hotel, other, nights, alumni) VALUES ('" + employe_data[0] + "', '" + employe_data[1] + "', '" + employe_data[2] + "', '" + employe_data[3] + "', '" + employe_data[4] + "', '" + employe_data[5] + "', '" + employe_data[6] + "')";


                    command.Connection = connection_1.Getcnn();
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

