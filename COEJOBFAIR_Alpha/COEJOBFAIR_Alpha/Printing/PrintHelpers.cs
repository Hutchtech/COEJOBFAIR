using System.Windows.Forms;

namespace COEJOBFAIR_Alpha.Printing
{
    public class PrintHelpers
    {
        private const string GoodLuck = "Complete. Good Luck!";
        private const string PrinterError = "Please Ask for help (Printer Error)";

        public static void print_employer(string name, string organization)
        {
            try
            {


                // get a reference to first connected printer
                ILabelWriterPrinter printer = Framework.GetLabelWriterPrinters().First(p => p.IsConnected) as ILabelWriterPrinter;

                // create print job with default params
                IPrintJob printJob = printer.CreatePrintJob(null);

                // open first label layout
                ILabel lbl = DYMO.Label.Framework.Label.Open("Employe.label");

                // print three labels using label from TextLabel1.label

                lbl.SetObjectText("NAME", name);
                lbl.SetObjectText("ORGANIZATION", organization);
                //label1.SetObjectText("TITLE", txt_title.Text.ToString());
                //  label1.SetObjectText("MAJOR", txt_major.Text.ToString());


                printJob.AddLabel(lbl);

                // send labels to print spooler

                printJob.Print();
                MessageBox.Show(GoodLuck);

            }
            catch
            {
                MessageBox.Show(PrinterError);
            }
        }
        public static void PrintLabelUsingPrintJob(string name)
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

                //  label1.SetObjectText("MAJOR", txt_major.Text.ToString());

                printJob.AddLabel(label1);

                // send labels to print spooler

                printJob.Print();
                MessageBox.Show(_goodLuck);
                Reset();
            }
            catch(Exception e)
            {
                MessageBox.Show(_printerError);
                MessageBox.Show(e.ToString());
            }
        }
    }