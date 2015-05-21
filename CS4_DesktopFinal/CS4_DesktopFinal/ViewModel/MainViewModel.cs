using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System.Collections.ObjectModel;

namespace CS4_DesktopFinal.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {

        //BookingViewModel Testdata
        private ObservableCollection<BookingViewModel> bookings;

        public ObservableCollection<BookingViewModel> Bookings
        {
            get { return bookings; }
            set { bookings = value; }
        }

        private ObservableCollection<EHRViewModel> ehr;

        public ObservableCollection<EHRViewModel> EHR
        {
            get { return ehr; }
            set { ehr = value; }
        }

        private ObservableCollection<EHR1ViewModel> ehr1;

        public ObservableCollection<EHR1ViewModel> EHR1
        {
            get { return ehr1; }
            set { ehr1 = value; }
        }

        private ObservableCollection<EHR2ViewModel> ehr2;

        public ObservableCollection<EHR2ViewModel> EHR2
        {
            get { return ehr2; }
            set { ehr2 = value; }
        }
        private ObservableCollection<LoginViewModel> login;

        public ObservableCollection<LoginViewModel> Login
        {
            get { return login; }
            set { login = value; }
        }

        
        public MainViewModel()
        {
            Bookings = new ObservableCollection<BookingViewModel>();
            EHR = new ObservableCollection<EHRViewModel>();
            EHR1 = new ObservableCollection<EHR1ViewModel>();
            EHR2 = new ObservableCollection<EHR2ViewModel>();
            Login = new ObservableCollection<LoginViewModel>();

            generateTestData();
        }



        private BookingViewModel selectedDate;

        public BookingViewModel SelectedDate
        {
            get { return selectedDate; }
            set { selectedDate = value; RaisePropertyChanged(); }
        }
        

        private void generateTestData()
        {
            Bookings.Add(new BookingViewModel() 
            {
                From=10,
                Name="Eierkuchen",
                Till=11,
                Treatment="chinatreatment"
            });

            Bookings.Add(new BookingViewModel()
            {
                From = 12,
                Name = "Palatschinke",
                Till = 13,
                Treatment = "asiatreatment"
            });

            EHR.Add(new EHRViewModel() 
            { 
                SearchName ="Eierkuchen"
            });

            EHR.Add(new EHRViewModel()
            {
                SearchName = "Palatschinke"
            });

            EHR1.Add(new EHR1ViewModel() 
            {
                Address = "Mainstreet 2, 3456 Auckland",
                Allergies = "nothing",
                DuringMedication = "syntoniestiona",
                Firstname="Guenther",
                Lastname ="Heinz",
                History ="a long long long one",
                PhysicalExam ="me don´t know",
                PlanOfCare ="something",
                PrevMedication ="nothing"
               
            });



            



           
        }
    }
}