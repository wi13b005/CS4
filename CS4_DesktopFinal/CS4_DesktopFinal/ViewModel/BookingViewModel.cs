using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS4_DesktopFinal.ViewModel
{
    public class BookingViewModel:ViewModelBase
    {

        public BookingViewModel()
        {

        }

        public BookingViewModel(String n, int from, int till, String t)
        {
            Name = n;
            From = from;
            Till = till;
            Treatment = t;
        }


        private String name;

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        private int from;

        public int From
        {
            get { return from; }
            set { from = value; }
        }

        private int till;

        public int Till
        {
            get { return till; }
            set { till = value; }
        }

        private String treatment;

        public String Treatment
        {
            get { return treatment; }
            set { treatment = value; }
        }
        
        
    }
}
