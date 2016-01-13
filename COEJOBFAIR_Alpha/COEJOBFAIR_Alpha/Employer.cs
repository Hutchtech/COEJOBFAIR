using DYMO.Label.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COEJOBFAIR_Alpha
{
    public partial class Employer : Form
    {
        public Employer()
        {
            InitializeComponent();
        }

        private void submit_click(object sender, EventArgs e)
        {
            string name_first = txt_name_first.Text;
            string name_last = txt_name_last.Text;
            string name_org = txt_organization.Text;

            print_employer(name_first, name_last, name_org);
        }

        private void print_employer(string first, string last, string organization)
        {
            // get a reference to first connected printer
            ILabelWriterPrinter printer = Framework.GetLabelWriterPrinters().First(p => p.IsConnected) as ILabelWriterPrinter; //from dymo-label demo

            // create print job with default params
            IPrintJob printJob = printer.CreatePrintJob(null);

            // open first label layout
            ILabel label = DYMO.Label.Framework.Label.Open("C:\\Users\\ryan\\Source\\Repos\\COEJOBFAIR\\COEJOBFAIR_Alpha\\COEJOBFAIR_Alpha\\TextLabel.label");
            label.SetObjectText("NAME", first + " " + last);
            
            label.SetObjectText("MAJOR",organization); // For testing purposes only need new label and change this whole function

            printJob.AddLabel(label);

            // send labels to print spooler
            printJob.Print();
        }
    }
}
