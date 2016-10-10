using System;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;
using System.Threading;
using DYMO.Label.Framework;
using System.Linq;
using System.Text.RegularExpressions;
using COEJOBFAIR_Alpha.Database;

namespace COEJOBFAIR_Alpha
{
    public partial class Main : Form
    {
        private bool _isPreRegister = false;

        public Main()
        {
            InitializeComponent();
        }
                
        public string Getfilename()
        {
            return openFileDialog1.FileName;
        }
        /// <summary>Function watches text change in the RNum box.
        /// <para>When the RNum is the correct length, it is cut to the correct characters then sent to fill info. </para>
        /// </summary>
        private void txt_id_TextChanged(object sender, EventArgs e)
        {
            var cur = txt_id.Text;
            var length = cur.Length;
            var complete = false;
            if (length == 15)
            {
                txt_id.Text = cur.Substring(1, 8);
                complete = true;
            }
            if (!complete) return;
            txt_id.Visible = false;
            fill_info();
        }


        
        #region Debug
        private void debug_connection(object sender, EventArgs e)
        {
            pBar1.Show();
            pBar1.Value = 0;
            pBar1.PerformStep();
            var testCall = new DataCnct.Calls();
            pBar1.PerformStep();
            var test = Database.Checks.connection_chck();
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
            var testCall = new DataCnct.Calls();
            pBar1.PerformStep();
            var test = Database.Checks.db_chck();
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
#endregion


        /// <summary>Takes RNum and populates if in JobGrid
        /// <para>Uses the txt_id field to get Rnum and uses that to check and make sure that the RNUM exists in Job Grid
        /// if it is then send to Data_cnct.calls(RNUM) if not then send to different page. </para>
        /// </summary>
        public void fill_info()
        {
            var mainCall = new Database.DataCnct.Calls(txt_id.Text,_isPreRegister);
            txt_first_name.Text = mainCall.get_crd_data()[2];
            txt_last_name.Text = mainCall.get_crd_data()[1];
            var firstName = txt_first_name.Text;
            Regex.Replace(firstName, @"\s+", "");
            if (firstName == "")
            {
                no_jobGrid();
            }
            
        
            this.grp_1.Visible = true;  
            }
        public void no_jobGrid()
        {
            btn_print.Visible = false;
            button1.Visible = true;
        }




        #region Resets
        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            status_db.Hide();
            status_db.BackColor = System.Drawing.Color.DarkGreen;
            status_cnn.Hide();
            status_cnn.BackColor = System.Drawing.Color.DarkGreen;
            grp_1.Visible = false;
            txt_id.Visible = true;
            pBar1.Hide();
            txt_id.Focus();
            ClearUI();
        }

        public void ClearUI()
        {
            this.txt_first_name.Text = "";
         //   this.txt_major.Text = "";
            this.txt_last_name.Text = "";
            
            
            this.grp_1.Visible = false;
            this.txt_id.Text = "";
            this.txt_id.Focus();
            txt_id.Visible = true;
        }
        #endregion


        private void btn_print_Click(object sender, EventArgs e)
        {
            Printing.PrintHelpers.PrintLabelUsingPrintJob(txt_first_name + " " + txt_last_name);
            ClearUI();
        }

        private void manualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.grp_1.Visible = true;
        }

        /// <summary>
        /// Opens employer window for use with unregistered employers.
        /// </summary>
        private void employerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new Employer();
            this.Visible = false;
            form.Show();
        }

        private void onToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _isPreRegister = true;
            this.btn_preregon.ForeColor = System.Drawing.Color.Green;
        }

        private void btn_preregoff_Click(object sender, EventArgs e)
        {
            _isPreRegister = false;
            this.btn_preregoff.ForeColor = System.Drawing.Color.Red;
        }

        private void Print_if_notfound(object sender, EventArgs e)
        {
            var mainCall = new DataCnct.Calls(txt_first_name.Text,txt_last_name.Text,txt_id.Text,_isPreRegister);
            Printing.PrintHelpers.PrintLabelUsingPrintJob(txt_first_name + " " + txt_last_name);
        }

        private void grp_1_Enter(object sender, EventArgs e)
        {

        }
    }
}

        
