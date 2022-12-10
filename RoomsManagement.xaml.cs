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
using System.Windows.Shapes;

namespace Nobilis_Apartment__Receipts_Maker
{
    /// <summary>
    /// Interaction logic for RoomsManagement.xaml
    /// </summary>
    /// 
    public partial class RoomsManagement : Window
       
    {
        public RoomsManagement()
            
        {
            InitializeComponent();

           
                //if (rm102.IsChecked == true)
                //{
                //    RoomsLbox.Items.Add(rm102.Content);
                //}
                //else if (rm102.IsChecked == false)
                //{
                //    RoomsLbox.Items.Remove(rm102.Content);
                //}
            
        }

        private void backToChoose_Click(object sender, RoutedEventArgs e)
        {
            ChooseWorkWindow b = new ChooseWorkWindow();
            b.Show();

            this.Visibility = Visibility.Collapsed;
        }

        private void RoomSave_Click(object sender, RoutedEventArgs e)
        {
            // MessageBox.Show("Reports Saved! Check Rooms Report Directory to access it");
            // string s =  RoomsLbox.SelectedItems.ToString();
              String R = "No room prepared";
            #region Saving room 102
            if (rm102.IsChecked == true)
                {
                 R = "            ROOM REPORT ON " + DateTime.Now + "\n \n" +
                    "AVAILABLE ROOMS" + "\n\n" +
                      rm102.Content;
            }
            else if (rm102.IsChecked == false)
            {
                rm102.Content = "";
                R = "            ROOM REPORT ON " + DateTime.Now + "\n \n" +
                                   "AVAILABLE ROOMS" + "\n\n" +
                                     rm102.Content;
            }
            
            File.WriteAllText(@"C:\Users\Cococe Ltd\Desktop\mine\missions\ALL LEARNINGS\COMPUTER\C#\Final Apps\WPF\Nobilis_Apartment_ Receipts_Maker\RoomsReport.txt", R);
            #endregion

            #region Saving room 105
            if (rm105.IsChecked == true)
            {
                R = "            ROOM REPORT ON " + DateTime.Now + "\n \n" +
                   "AVAILABLE ROOMS" + "\n\n" +
                     rm105.Content;
            }
            else if (rm105.IsChecked == false)
            {
                rm102.Content = "";
                R = "            ROOM REPORT ON " + DateTime.Now + "\n \n" +
                                   "AVAILABLE ROOMS" + "\n\n" +
                                     rm105.Content;
            }

            File.WriteAllText(@"C:\Users\Cococe Ltd\Desktop\mine\missions\ALL LEARNINGS\COMPUTER\C#\Final Apps\WPF\Nobilis_Apartment_ Receipts_Maker\RoomsReport.txt", R);
            #endregion
            MessageBox.Show("Rooms report saved! Please check in reports directory file");
        }


        private void rm102_Checked(object sender, RoutedEventArgs e)
        {
            RoomsLbox.Items.Add(rm102.Content);
        }

        private void rm102_Unchecked(object sender, RoutedEventArgs e)
        {
            RoomsLbox.Items.Remove(rm102.Content);
        }

        private void rm105_Checked(object sender, RoutedEventArgs e)
        {
            RoomsLbox.Items.Add(rm105.Content);
        }

        private void rm105_Unchecked(object sender, RoutedEventArgs e)
        {
            RoomsLbox.Items.Remove(rm105.Content);
        }
    }
}
