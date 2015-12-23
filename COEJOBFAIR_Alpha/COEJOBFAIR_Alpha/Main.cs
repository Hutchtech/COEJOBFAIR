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
                
                PrintLabelUsingPrintJob();
            }
        }
        private void debug_connection(object sender, EventArgs e)
        {
            pBar1.Show();
            pBar1.Value = 0;
            pBar1.PerformStep();
            Data_cnct.calls test_call = new Data_cnct.calls();
            pBar1.PerformStep();
            bool test = test_call.connection_chck();
            if (!test)
            {
                status_cnn.Show();
                status_cnn.BackColor = System.Drawing.Color.DarkRed;
            }
            else
            {
                status_cnn.Show();
            }
            pBar1.Value = 100;


        }
        private void debug_database(object sender, EventArgs e)
        {
            pBar1.Show();
            pBar1.Value = 0;
            pBar1.PerformStep();
            Data_cnct.calls test_call = new Data_cnct.calls();
            pBar1.PerformStep();
            bool test = test_call.db_chck();
            if (!test)
            {
                status_db.Show();
                status_db.BackColor = System.Drawing.Color.DarkRed;
            }
            else
            {
                status_db.Show();
                
            }
            pBar1.Value = 100;

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
            Data_cnct.calls main_call = new Data_cnct.calls(txt_id.Text);
            label1.SetObjectText("NAME", main_call.get_crd_data()[0] + " " + main_call.get_crd_data()[1]);
            label1.SetObjectText("GRAD_DATE", main_call.get_crd_data()[3]);
            label1.SetObjectText("MAJOR", main_call.get_crd_data()[2]);


            printJob.AddLabel(label1);

            // send labels to print spooler
            printJob.Print();
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            status_db.Hide();
            status_cnn.Hide();
            pBar1.Hide();
            txt_id.Focus();
        }
    }
}

        
