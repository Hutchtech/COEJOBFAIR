using System;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;

namespace COEJOBFAIR_Alpha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            
            OdbcConnection cnn;
            OdbcCommand cmd;
            cnn = new OdbcConnection("DSN=COEJOBFAIR;UID=ttu\ryhutchi;PWD = Frixon1!!;");
            
            cmd = new OdbcCommand();
            cmd.CommandText = "SELECT * FROM Main_tbl WHERE id = " + txt_id.Text;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cnn.Open();

            OdbcDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lbl_test.Text = reader[1].ToString();
                lbl_test2.Text = reader[2].ToString();

            }

            // Call Close when done reading.
            reader.Close();
            cnn.Close();
        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {
            string cur = txt_id.Text;
            int length = cur.Length;
            if(length == 15)
            {
                txt_id.Text = cur.Substring(1, 8);
            }
        }
    }
}
