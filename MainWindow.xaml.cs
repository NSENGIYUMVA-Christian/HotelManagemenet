using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Spire.Doc;
using Spire.Doc.Documents;

namespace Nobilis_Apartment__Receipts_Maker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
           
        }
       

        private void execute_Click(object sender, RoutedEventArgs e)
        {
            try
            {
            double PricePerNight, b,AmountToBePaid;
            string clientName;
            // determining Tax
            double vat,income;
           
            clientName = name.Text;
            PricePerNight = Double.Parse(price.Text);
            b = (checkOut.SelectedDate - checkIn.SelectedDate).Value.TotalDays;
            // picked date string value
            string comein = checkIn.SelectedDate.Value.ToShortDateString();
            string goout = checkOut.SelectedDate.Value.ToShortDateString();
            AmountToBePaid = PricePerNight * b;
            vat = AmountToBePaid * 18 / 100;
            income = AmountToBePaid-vat;


               

                //displaying output
                if (male.IsChecked==true)
            {
               
                   
                MessageBox.Show("Mr " + clientName + ", is supposed to pay " + AmountToBePaid + "$" +
                    " \n Please check in invoice directory to view a full report  ");
                   
                    // storing invoice info
                    string report = "FULL NAME                    " + clientName + "\n" +
                                "GENDER                       " + "Male"+ "\n" +
                                "CHECK IN DATE                " +comein +"\n" +
                                "CHECK OUT DATE               " +goout+ "\n" +
                               "ROOM NUMBER                   " + Texcobox.Text + "\n" +
                                "PRICE PER NIGHT              " +PricePerNight+ "$\n" +
                                "TOTAL AMOUNT TO BE PAID      " +AmountToBePaid+ "$\n" +
                                "VALUE ADDED TAX              "+vat + "$\n" +
                                "INCOME                       "+income + "$\n" +
                                 "CLIENT SIGNATURE                           \n" +
                                "         NOBILIS HOTEL AND APARTMENT      " + "\n" +
                                "Done on     " + DateTime.Now
                               ;
                File.WriteAllText(@"C:\Users\Cococe Ltd\Desktop\mine\missions\ALL LEARNINGS\COMPUTER\C#\Final Apps\WPF\Nobilis_Apartment_ Receipts_Maker\Invoice.txt", report);

                    
                             // create  a word document
                               Document docy = new Document();

                               // add document section
                               Spire.Doc.Section section = docy.AddSection();

                               // using section to add a paraagraph
                               Spire.Doc.Documents.Paragraph par = section.AddParagraph();

                               // writing content in the paragraph
                               par.AppendText(report);

                               // Save the document
                               docy.SaveToFile("InvoiceWord.docx",FileFormat.Docx);

                            

                }
                else
            {
                MessageBox.Show("Mrs " + clientName + ", is supposed to pay " + AmountToBePaid + "$"+
                    " \n Please check in invoice directory to view a full report");

                    // storing invoice info
                    string report = "FULL NAME                    " + clientName + "\n" +
                                    "GENDER                       " + "Female" + "\n" +
                                    "CHECK IN DATE                " + comein + "\n" +
                                    "CHECK OUT DATE               " + goout + "\n" +
                                    "ROOM NUMBER                  " + Texcobox.Text + "\n" +
                                    "PRICE PER NIGHT              " + PricePerNight + "$\n" +
                                    "TOTAL AMOUNT TO BE PAID      " + AmountToBePaid + "$\n" +
                                    "VALUE ADDED TAX              " + vat + "$\n" +
                                    "INCOME                       " + income + "$\n\n" +

                                    "CLIENT SIGNATURE                           \n" +
                                    "         NOBILIS HOTEL AND APARTMENT      " + "\n" +
                                    "Done on      " + DateTime.Now;
                               ;
                File.WriteAllText(@"OtherFolder\Invoice.txt", report);


                    // create  a word document
                    Document docy = new Document();

                    // add document section
                    Spire.Doc.Section section = docy.AddSection();

                    // using section to add a paraagraph
                    Spire.Doc.Documents.Paragraph par = section.AddParagraph();

                    // writing content in the paragraph
                    par.AppendText(report);

                    // Save the document
                    docy.SaveToFile("InvoiceWord.docx", FileFormat.Docx);
                }
            }
            catch (Exception b)
            {

                MessageBox.Show("Please fill all the fields correctly \n", b.Message);
            }

        }
        // load time and date when app starts
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //  DateTime a = new DateTime();
            string a = DateTime.Now.ToString();
            todayDate.Content = a;
        }
        // updating date and time every time mouse moves
        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
            // DateTime a = new DateTime();
            string a = DateTime.Now.ToString();
            todayDate.Content = a;
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            ChooseWorkWindow b = new ChooseWorkWindow();
            b.Show();
           
            this.Visibility = Visibility.Collapsed;
        }


        private void RoomCobox_MouseEnter(object sender, MouseEventArgs e)
        {
            RoomCobox.ToolTip = "Click here to select room number";
        }

        private void RoomCobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if (Texcobox != null)
            {
                var senda = ((ComboBox)sender);
                var item = (ComboBoxItem)senda.SelectedValue;
                Texcobox.Text = item.Content.ToString();
            }
        }
    }
}
