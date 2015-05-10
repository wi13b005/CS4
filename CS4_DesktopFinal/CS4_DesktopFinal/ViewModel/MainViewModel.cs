using GalaSoft.MvvmLight;
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
        private ObservableCollection<BookingViewModel> bookings;

        public ObservableCollection<BookingViewModel> Bookings
        {
            get { return bookings; }
            set { bookings = value; }
        }
        
        
        public MainViewModel()
        {
            Bookings = new ObservableCollection<BookingViewModel>();
            generateTestData();
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
        }
    }
}