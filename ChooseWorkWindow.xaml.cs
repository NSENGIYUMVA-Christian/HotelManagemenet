using System;
using System.Collections.Generic;
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
    /// Interaction logic for ChooseWorkWindow.xaml
    /// </summary>
    public partial class ChooseWorkWindow : Window
    {
        public ChooseWorkWindow()
        {
            InitializeComponent();
        }

        private void continue_Click(object sender, RoutedEventArgs e)
        {
            if (InvoiceDecl.IsChecked == true)
            {
                MainWindow d = new MainWindow();
                d.Show();
                this.Visibility = Visibility.Collapsed;
            }
            else if (RoomsMan.IsChecked == true)
            {
                RoomsManagement a = new RoomsManagement();
                a.Show();
                this.Visibility = Visibility.Collapsed;

            }
            else if (KitchenMan.IsChecked == true)
            {
                KitchenManagement a = new KitchenManagement();
                a.Show();
                this.Visibility = Visibility.Collapsed;
            }
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            LogInWindow b = new LogInWindow();
            b.Show();

            this.Visibility = Visibility.Collapsed;
        }
    }
}
