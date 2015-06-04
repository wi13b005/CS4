using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Ioc;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS4_DesktopFinal.ViewModel
{
    public class EditViewModel : ViewModelBase
    {
        //Properties
        private BookingViewModel editBooking;

        public BookingViewModel EditBooking
        {
            get { return editBooking; }
            set { editBooking = value; RaisePropertyChanged(); }
        }

        private ObservableCollection<string> allCustomers;

        public ObservableCollection<string> AllCustomers
        {
            get { return allCustomers; }
            set { allCustomers = value; RaisePropertyChanged(); }
        }

        private ObservableCollection<string> selectedCustomer;

        public ObservableCollection<string> SelectedCustomer
        {
            get { return selectedCustomer; }
            set { selectedCustomer = value; RaisePropertyChanged(); }
        }

        private DateTime editDate;

        public DateTime EditDate
        {
            get { return editDate; }
            set { editDate = value; RaisePropertyChanged(); }
        }

        private ObservableCollection<int> hoursFrom;

        public ObservableCollection<int> HoursFrom
        {
            get { return hoursFrom; }
            set { hoursFrom = value; RaisePropertyChanged(); }
        }

        private ObservableCollection<int> hoursTo;

        public ObservableCollection<int> HoursTo
        {
            get { return hoursTo; }
            set { hoursTo = value; RaisePropertyChanged(); }
        }

        private int selectedHourFrom;

        public int SelectedHourFrom
        {
            get { return selectedHourFrom; }
            set { selectedHourFrom = value; RaisePropertyChanged(); }
        }

        private int selectedHourTo;

        public int SelectedHourTo
        {
            get { return selectedHourTo; }
            set { selectedHourTo = value; RaisePropertyChanged(); }
        }

        //Commands
        public RelayCommand SaveChanges { get; set; }
        public RelayCommand Cancel { get; set; }


        public EditViewModel()
        {
            //Set date
            editDate = DateTime.Now;

            //Set hours & minutes
            HoursFrom = new ObservableCollection<int>();
            HoursTo = new ObservableCollection<int>();


            for (int i = 1; i <= 24; i++)
            {
                HoursFrom.Add(i);
                HoursTo.Add(i);
            }
            //Commands
            SaveChanges = new RelayCommand(Save, Able);
            Cancel = new RelayCommand(DoCancel, Able);
        }

        private void DoCancel()
        {
            //Go back to Main
            SimpleIoc.Default.GetInstance<MainViewModel>().ViewModelBinding = SimpleIoc.Default.GetInstance<MainViewModel>().PreviousVM;
        }

        private bool Able()
        {
            return true;
        }

        private void Save()
        {
            //Save Action

            //Go back to Main
            SimpleIoc.Default.GetInstance<MainViewModel>().ViewModelBinding = SimpleIoc.Default.GetInstance<MainViewModel>().PreviousVM;
        }

    }
}
