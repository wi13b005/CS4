using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CS4_DesktopFinal
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LoginBTN(object sender, RoutedEventArgs e)
        {
            this.Hide(); //hide the login page
            MainWindow NewWindow = new MainWindow();
            NewWindow.Show();

        }
        //    if (usernameTB.Text.Length == 0)
        //   {

        //    errormessage.Text = "Enter an email.";
        // 
        //       usernameTB.Focus();

        //    }

        //    else if (!Regex.IsMatch(usernameTB.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
        //     {

        //    errormessage.Text = "Enter a valid email.";

        //    usernameTB.Select(0, usernameTB.Text.Length);

        //     usernameTB.Focus();

        //   }

        //   else
        //   {

        //   string email = usernameTB.Text;

        //   string password = PasswordBoxPB.Password;

        //   SqlConnection con = new SqlConnection("Data Source=Database;Initial Catalog=Data;User ID=tcmexpert;Password=testone");

        //    con.Open();

        //    SqlCommand cmd = new SqlCommand("Select * from Registration where Email='" + email + "'  and password='" + password + "'", con);

        //    cmd.CommandType = CommandType.Text;

        //    SqlDataAdapter adapter = new SqlDataAdapter();

        //     adapter.SelectCommand = cmd;

        //    DataSet dataSet = new DataSet();

        //    adapter.Fill(dataSet);

        //    if (dataSet.Tables[0].Rows.Count > 0)
        //    {


        //    Close();

        //   }

        //   else
        //   {

        //    errormessage.Text = "Sorry! Please enter existing emailid/password.";

        //  }

        // con.Close();



        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }


    }
}