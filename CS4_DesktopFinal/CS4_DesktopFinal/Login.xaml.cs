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

        public SqlConnection con;
        public string constr;

        protected void LoginBTN(object sender, EventArgs e)
        {


            if (usernameTB.Text != "" && PasswordBoxPB.Password != "")
            {
                DBconnection objconn = new DBconnection();
                objconn.connection(); //calling connection   

                SqlCommand com = new SqlCommand("user_Sp_Login", objconn.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@username", usernameTB.Text);
                com.Parameters.AddWithValue("@password", PasswordBoxPB.Password);

                int IsValidUser = Convert.ToInt32(com.ExecuteScalar());
                if (IsValidUser == 1) //if user found it returns 1  
                {
                    this.Hide(); //hide the login page
                    MainWindow NewWindow = new MainWindow();
                    NewWindow.Show();

                }
                else
                {

                    MessageBox.Show("Invalid Username or password");

                }
            }
            else
            {

                MessageBox.Show("Username and Password are required!");

            }


        }


        // private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        // {

        //   }


    }
}