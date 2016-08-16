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
        /// <summary>Function watches text change in the RNum box.
        /// <para>When the RNum is the correct length, it is cut to the correct characters then sent to fill info. </para>
        /// </summary>
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
                
                fill_info();
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

        /// <summary>Takes RNum and populates if in JobGrid
        /// <para>Uses the txt_id field to get Rnum and uses that to check and make sure that the RNUM exists in Job Grid
        /// if it is then send to Data_cnct.calls(RNUM) if not then send to different page. </para>
        /// </summary>
        public void fill_info()
        {
            Data_cnct.calls main_call = new Data_cnct.calls(txt_id.Text);  //This is where issue #8's solution will begin.
            txt_first_name.Text = main_call.get_crd_data()[0];
            txt_last_name.Text = main_call.get_crd_data()[1];
            txt_Grad_Month.Text = main_call.get_crd_data()[2];
            txt_Grad_Year.Text = main_call.get_crd_data()[3];
       
                this.grp_1.Visible = true;  
          
            }

        public void PrintLabelUsingPrintJob()
        {
            try {
            // get a reference to first connected printer
            ILabelWriterPrinter printer = Framework.GetLabelWriterPrinters().First(p => p.IsConnected) as ILabelWriterPrinter;

            // create print job with default params
            IPrintJob printJob = printer.CreatePrintJob(null);

            // open first label layout
                ILabel label1 = DYMO.Label.Framework.Label.Open("NO_MAJOR.label");

            // print three labels using label from TextLabel1.label
            
                label1.SetObjectText("name", txt_first_name.Text.ToString() + " " + txt_last_name.Text.ToString());
                label1.SetObjectText("Grad", txt_Grad_Month.Text.ToString() + " " + txt_Grad_Year.Text.ToString());
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

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            status_db.Hide();
            status_db.BackColor = System.Drawing.Color.DarkGreen;
            status_cnn.Hide();
            status_cnn.BackColor = System.Drawing.Color.DarkGreen;
            grp_1.Visible = false;
            groupBox1.Visible = false;
            pBar1.Hide();
            txt_id.Focus();
            reset();
        }
        private void reset()
        {
            this.txt_first_name.Text = "";
         //   this.txt_major.Text = "";
            this.txt_last_name.Text = "";
            this.txt_Grad_Month.Text = "";
            this.groupBox1.Visible = false;
            this.grp_1.Visible = false;
            this.txt_id.Text = "";
            this.txt_id.Focus();
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            PrintLabelUsingPrintJob();
        }

        private void manualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.grp_1.Visible = true;
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void inputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employer form = new Employer();
            this.Visible = false;
            form.Show();
           
        }
    }
}

        
