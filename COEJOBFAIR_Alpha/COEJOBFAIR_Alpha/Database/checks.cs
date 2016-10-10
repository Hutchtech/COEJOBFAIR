


using System.Data.Odbc;

namespace COEJOBFAIR_Alpha.Database
{
    public class Checks
    {
        public static bool connection_chck()
        {
            var bol = true;
            var testCnn = new DataCnct.OdbcCnn();
            testCnn.Getcnn().ConnectionTimeout = 7;
            try
            {

                testCnn.Getcnn().Open();
            }
            catch (OdbcException error) //use error in future for error logging
            {

                bol = false;
            }
            return bol;
        }
        public static bool db_chck()
        {
            var val = true;
            var mainCall = new DataCnct.Calls();
            if (connection_chck())
            {
                try
                {
                    var connection1 = new DataCnct.OdbcCnn();
                    var command1 = new DataCnct.odbcCommand("SELECT TOP 10 FROM Main_tbl");

                    command1.Getcmd().Connection = connection1.Getcnn();
                    connection1.Getcnn().Open();
                    var reader = command1.Getcmd().ExecuteReader();
                    var test = "";
                    var test1 = false;
                    while (reader.Read())
                    {
                        test = reader[0].ToString();
                    }
                    if (test != "")
                    {
                        test1 = true;
                    }
                    reader.Close();
                    connection1.Getcnn().Close();
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