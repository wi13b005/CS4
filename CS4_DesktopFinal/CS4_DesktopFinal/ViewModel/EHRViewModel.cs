using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS4_DesktopFinal.ViewModel
{
    public class EHRViewModel:ViewModelBase
    {


        public EHRViewModel()
        {

        }

        public EHRViewModel(String sN)
        {
            SearchName = sN;
        }
        private String searchName;

        public String SearchName
        {
            get { return searchName; }
            set { searchName = value; RaisePropertyChanged(); }
        }

    }
}
