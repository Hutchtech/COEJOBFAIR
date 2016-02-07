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
            string[] data_employe = new string[7];
            data_employe[0] = txt_name_first.Text + " " + txt_name_last.Text;
            data_employe[1] = txt_organization.Text;
            data_employe[2] = txt_title.Text;
            data_employe[3] = cmb_hotels.SelectedItem.ToString();
            data_employe[4] = txt_other.Text;
            data_employe[5] = cmb_nights.SelectedItem.ToString();
            data_employe[6] = chck_box_alumni.CheckState.ToString(); //MAKE SURE THIS OUTPUTS TO "TRUE" or "FALSE" REF : 2A

            print_employer(data_employe[0], data_employe[1]);
           
            Data_cnct.Employe_calls main_call = new Data_cnct.Employe_calls(data_employe);
            reset();
        }


        /// <summary>
        /// Prints the employers information
        /// used by imported and inputed
        /// </summary>
        /// <param name="name">name of employe</param>
        /// <param name="organization">name of organization</param>
        private void print_employer(string name, string organization)
        {
            try
            {
                // get a reference to first connected printer
                ILabelWriterPrinter printer = Framework.GetLabelWriterPrinters().First(p => p.IsConnected) as ILabelWriterPrinter;

                // create print job with default params
                IPrintJob printJob = printer.CreatePrintJob(null);

                // open first label layout
                ILabel label1 = DYMO.Label.Framework.Label.Open("Employe.label");

                // print three labels using label from TextLabel1.label

                label1.SetObjectText("NAME", txt_name_first.Text.ToString() + " " + txt_name_last.Text.ToString());
                label1.SetObjectText("ORGANIZATION", txt_organization.Text.ToString());
                label1.SetObjectText("TITLE", txt_title.Text.ToString());
                //  label1.SetObjectText("MAJOR", txt_major.Text.ToString());


                printJob.AddLabel(label1);

                // send labels to print spooler

                printJob.Print();
                MessageBox.Show("Complete. Good Luck!");
                reset();
            }
            catch
            {
                MessageBox.Show("Please Ask for help (Printer Error)");
            }
        }
        private void reset()
        {
            this.txt_name_last.Text = "Last Name";
            this.txt_name_first.Text = "First Name";
            this.txt_organization.Text = "Organization";
            this.txt_other.Text = "";
            this.txt_other.Visible = false;
            this.txt_title.Text = "Title";
            this.cmb_hotels.SelectedItem = "";
            this.cmb_nights.SelectedItem = "";
            this.chck_box_alumni.Checked = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmb_hotels.SelectedText == "Other")
            {
                this.txt_other.Visible = true;
            }
        }

    }
}
