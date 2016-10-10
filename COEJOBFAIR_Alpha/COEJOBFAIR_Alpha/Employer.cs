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
using COEJOBFAIR_Alpha.Database;

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
            var dataEmploye = new string[7];
            dataEmploye[0] = txt_name_first.Text + " " + txt_name_last.Text;
            dataEmploye[1] = txt_organization.Text;
            dataEmploye[2] = txt_title.Text;
            dataEmploye[3] = txt_nights.Text.ToString();
            dataEmploye[4] = txt_other.Text;
            dataEmploye[5] = txt_nights.Text.ToString();
            dataEmploye[6] = chck_box_alumni.CheckState.ToString(); //MAKE SURE THIS OUTPUTS TO "TRUE" or "FALSE" REF : 2A

            Printing.PrintHelpers.print_employer(dataEmploye[0], dataEmploye[1]);
           
            var mainCall = new DataCnct.Employe_calls(dataEmploye);
            Reset();
        }



        private void Reset()
        {
            this.txt_name_last.Text = "Last Name";
            this.txt_name_first.Text = "First Name";
            this.txt_organization.Text = "Organization";
            this.txt_other.Text = "";
            this.txt_other.Visible = false;
            this.txt_title.Text = "Title";
            this.lst_box.SelectedItem = "";
            this.txt_nights.Text = "";
            this.chck_box_alumni.Checked = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lst_box.SelectedItem.ToString() == "Other")
            {
                this.txt_other.Visible = true;
            }
        }


    }
}
