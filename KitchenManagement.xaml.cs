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
    /// Interaction logic for KitchenManagement.xaml
    /// </summary>
    public partial class KitchenManagement : Window
    {
        public KitchenManagement()
        {
            InitializeComponent();
        }

        private void KitchenBackBtn_Click(object sender, RoutedEventArgs e)
        {
            ChooseWorkWindow b = new ChooseWorkWindow();
            b.Show();

            this.Visibility = Visibility.Collapsed;
        }

        private void KitchenSaveBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void PlriceLitem_Selected(object sender, RoutedEventArgs e)
        {
            KitchenTblc.Text = PlriceLitem.Content.ToString();
        }

    }
}
