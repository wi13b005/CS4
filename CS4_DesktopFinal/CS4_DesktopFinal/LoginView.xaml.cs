
using CS4.Views;
using CS4_DesktopFinal.Views;
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
      


       SqlConnection con = new SqlConnection();  
        public Login()  
        {  
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=SS15-BDL4-FST-2\\DESKTOP;Initial Catalog=DesktopDB;Integrated Security=True";
           
            InitializeComponent();  
        }
  
        private void DBconn_Load(object sender, EventArgs e)  
        {  
             
            SqlConnection con = new SqlConnection("Data Source=SS15-BDL4-FST-2\\DESKTOP;Initial Catalog=DesktopDB;Integrated Security=True");  
            con.Open();  
  
            {  
            }  
        }  
  
        private void button1_Click(object sender, EventArgs e)  
        {  
            SqlConnection con = new SqlConnection();  
            con.ConnectionString = "Data Source=SS15-BDL4-FST-2\\DESKTOP;Initial Catalog=DesktopDB;Integrated Security=True";  
            con.Open();  
            string username = textBox1.Text;
            char password = textBox2.PasswordChar;  
            SqlCommand cmd = new SqlCommand("select username,password from User where username='" + textBox1.Text + "'and password='" + textBox2.PasswordChar + "'", con);  
            SqlDataAdapter da = new SqlDataAdapter(cmd);  
            DataTable dt = new DataTable();  
            da.Fill(dt);  
            if (dt.Rows.Count > 0)  
            {

                
            }  
            else  
            {  
                MessageBox.Show("Invalid Login please check username and password");  
            }  
            con.Close();  
        }

        private void login_button(object sender, EventArgs e)
        {
            this.Hide(); //hide the login page
            NewCustomer NewWindow = new NewCustomer();
            NewWindow.Show();
        }

        // private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        // {

        //   }


    }
}