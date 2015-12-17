using System;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;
using System.Threading;
using DYMO.Label.Framework;
using System.Linq;

namespace COEJOBFAIR_Alpha
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void mainDBCall()
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
                lbl_test3.Text = reader[3].ToString();
                lbl_test4.Text = reader[4].ToString();
                lbl_test5.Text = reader[5].ToString();
                

            }

            // Call Close when done reading.
            reader.Close();
            cnn.Close();
        }
        public string getfilename()
        {
            return openFileDialog1.FileName;
        } 

        private void txt_id_TextChanged(object sender, EventArgs e)
        {
            string cur = txt_id.Text;
            int length = cur.Length;
            bool complete = false;
            if (length == 15)
            {
                txt_id.Text = cur.Substring(1, 8);
                complete = true;
            }
            if (complete)
            {
                mainDBCall();
                PrintLabelUsingPrintJob();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
        public void PrintLabelUsingPrintJob()
        {
            // get a reference to first connected printer
            ILabelWriterPrinter printer = Framework.GetLabelWriterPrinters().First(p => p.IsConnected) as ILabelWriterPrinter;

            // create print job with default params
            IPrintJob printJob = printer.CreatePrintJob(null);

            // open first label layout
            ILabel label1 = DYMO.Label.Framework.Label.Open("C:\\Users\\ryan\\Source\\Repos\\COEJOBFAIR\\COEJOBFAIR_Alpha\\COEJOBFAIR_Alpha\\TextLabel.label");

            // print three labels using label from TextLabel1.label
            label1.SetObjectText("NAME", string.Format(lbl_test.Text +" "+ lbl_test2.Text));
            label1.SetObjectText("GRAD_DATE", string.Format(lbl_test4.Text.ToString()));
            label1.SetObjectText("MAJOR", string.Format(lbl_test3.Text));


            printJob.AddLabel(label1);

            // send labels to print spooler
            printJob.Print();
        }
    }
}

        
