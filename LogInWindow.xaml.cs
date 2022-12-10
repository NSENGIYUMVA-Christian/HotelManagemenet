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
    /// Interaction logic for LogInWindow.xaml
    /// </summary>
    public partial class LogInWindow : Window
    {
        public LogInWindow()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (username.Text == "nobilis" && pword.Password == "NOBILIS")
                {
                    ChooseWorkWindow f = new ChooseWorkWindow();
                    f.Show();
                    this.Visibility = Visibility.Collapsed;

                }
                else
                    MessageBox.Show("incorect details");
            }

            catch(Exception l)
            {
                MessageBox.Show("Invalid input, please try again \n",l.Message); 
            }
        }

        private void forgotDetails_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Please contact Admin or Manager for Help!");
        }
    }
}
