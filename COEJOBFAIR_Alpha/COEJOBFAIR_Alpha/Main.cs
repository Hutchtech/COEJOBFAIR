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

    }
}

        
