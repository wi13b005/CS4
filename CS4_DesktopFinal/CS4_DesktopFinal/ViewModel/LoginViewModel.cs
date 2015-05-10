using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;

namespace CS4_DesktopFinal.ViewModel
{
    public class LoginViewModel:ViewModelBase
    {



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

     

        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; RaisePropertyChanged();}
        }


    }
}
