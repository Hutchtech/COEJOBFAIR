using DYMO.Label.Framework;
using SurveyMonkey;
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
            string[] data_employe = new string[7];
            data_employe[0] = txt_name_first.Text + " " + txt_name_last.Text;
            data_employe[1] = txt_organization.Text;
            data_employe[2] = txt_title.Text;
            data_employe[3] = txt_hotel.Text;
            data_employe[4] = txt_other.Text;
            data_employe[5] = txt_nights.Text;
            data_employe[6] = chck_box_alumni.CheckState.ToString(); //MAKE SURE THIS OUTPUTS TO "TRUE" or "FALSE" REF : 2A

            print_employer(data_employe[0], data_employe[1]);
        }

        private void survey_Import()
        {
            string apiKey = "KEY";
            string token = "TOKEN";
            var sm = new SurveyMonkeyApi(apiKey, token);  // PICK UP HERE 
            
        }

        /// <summary>
        /// Prints the employers information
        /// used by imported and inputed
        /// </summary>
        /// <param name="name">name of employe</param>
        /// <param name="organization">name of organization</param>
        private void print_employer(string name, string organization)
        {
            // get a reference to first connected printer
            ILabelWriterPrinter printer = Framework.GetLabelWriterPrinters().First(p => p.IsConnected) as ILabelWriterPrinter; //from dymo-label demo

            // create print job with default params
            IPrintJob printJob = printer.CreatePrintJob(null);

            // open first label layout
            ILabel label = DYMO.Label.Framework.Label.Open("C:\\Users\\ryan\\Source\\Repos\\COEJOBFAIR\\COEJOBFAIR_Alpha\\COEJOBFAIR_Alpha\\TextLabel.label");
            label.SetObjectText("NAME",name);
            
            label.SetObjectText("MAJOR",organization); // For testing purposes only need new label and change this whole function

            printJob.AddLabel(label);

            // send labels to print spooler
            printJob.Print();
        }
    }
}
