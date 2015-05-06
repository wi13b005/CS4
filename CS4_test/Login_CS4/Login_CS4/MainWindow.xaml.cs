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

namespace Login_CS4
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

        private void LoginBTN_Click(object sender, RoutedEventArgs e)
        {
            if (!usernameTB.Text.Equals("") && !PasswordBoxPB.Password.Equals(""))
            {
                if (usernameTB.Text.Equals("1") && PasswordBoxPB.Password.Equals("1"))
                {
                   

                    LoginBTN.Visibility = Visibility.Collapsed;
                    logoutBTN.Visibility = Visibility.Visible;
                }
                else
                    MessageBox.Show("Wrong Password");
            }
            else
                MessageBox.Show("Wrong Username");
        }

        private void logoutBTN_Click(object sender, RoutedEventArgs e)
        {
           
            LoginBTN.Visibility = Visibility.Visible;
            logoutBTN.Visibility = Visibility.Collapsed;
        }


    }
}
