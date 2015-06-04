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

        private ObservableCollection<NewCustomerViewModel> ehr1;

        public ObservableCollection<NewCustomerViewModel> EHR1
        {
            get { return ehr1; }
            set { ehr1 = value; }
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
            EHR1 = new ObservableCollection<NewCustomerViewModel>();
         
            Login = new ObservableCollection<LoginViewModel>();

            generateTestData();
        }



        private BookingViewModel selectedDate;

        public BookingViewModel SelectedDate
        {
            get { return selectedDate; }
            set { selectedDate = value; RaisePropertyChanged(); }
        }

        private ViewModelBase previousVM = null;
        public ViewModelBase PreviousVM
        {
            get { return previousVM; }
            set { previousVM = value; RaisePropertyChanged(); }
        }

        private ViewModelBase viewModelBinding = null;

        public ViewModelBase ViewModelBinding
        {
            get { return viewModelBinding; }
            set { viewModelBinding = value; RaisePropertyChanged(); }
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

            EHR1.Add(new NewCustomerViewModel() 
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