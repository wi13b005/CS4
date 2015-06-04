using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using GalaSoft.MvvmLight.Ioc;

namespace CS4_DesktopFinal.ViewModel
{
    public class LoginViewModel:ViewModelBase
    {
        //Commands
        public RelayCommand Login { get; set; }
        private void DoLogin()
        {
            //Check login data
            //If correct --> Set ViewModel to MainVM
            SimpleIoc.Default.GetInstance<MainViewModel>().ViewModelBinding = SimpleIoc.Default.GetInstance<MainVM>();
        }
        private bool Able()
        {
            return true;
        }


        public LoginViewModel()
        {

        }

        public LoginViewModel(String u, String p)
        {

            User = u;
            Password = p;

        }

        private string user;

        public string User
        {
            get { return user; }
            set { user = value; RaisePropertyChanged(); }
        }



        //Passwordbox can't be bound to a string --> google it
        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public LoginViewModel()
        {
            //Commands
            Login = new RelayCommand(DoLogin, Able);
        }

    }
}
