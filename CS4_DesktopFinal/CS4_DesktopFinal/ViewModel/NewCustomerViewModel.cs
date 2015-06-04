using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS4_DesktopFinal.ViewModel

{
    public class NewCustomerViewModel:ViewModelBase
    {

        public NewCustomerViewModel()
        {

        }

        public NewCustomerViewModel(String f, String l, int ssn, String a, String h, String all, String prev, String dur, String plan, String phys)
        {
            Firstname = f;
            Lastname = l;
            SSN = ssn;
            Allergies = all;
            PrevMedication = prev;
            DuringMedication = dur;
            PlanOfCare = plan;
            PhysicalExam = phys;
        }

        private String firstname;

        public String Firstname
        {
            get { return firstname; }
            set { firstname = value; RaisePropertyChanged(); }
        }

        private String lastname;

        public String Lastname
        {
            get { return lastname; }
            set { lastname = value; RaisePropertyChanged(); }
        }

        private int ssn;

        public int SSN
        {
            get { return ssn; }
            set { ssn = value; RaisePropertyChanged(); }
        }

        private String address;

        public String Address
        {
            get { return address; }
            set { address = value; RaisePropertyChanged(); }
        }

        private String history;

        public String History
        {
            get { return history; }
            set { history = value; RaisePropertyChanged(); }
        }

        private String allergies;

        public String Allergies
        {
            get { return allergies; }
            set { allergies = value; RaisePropertyChanged(); }
        }
        private String prevMedication;

        public String PrevMedication
        {
            get { return prevMedication; }
            set { prevMedication = value; RaisePropertyChanged(); }
        }

        private String duringMedication;

        public String DuringMedication
        {
            get { return duringMedication; }
            set { duringMedication = value; RaisePropertyChanged(); }
        }

        private String planOfCare;

        public String PlanOfCare
        {
            get { return planOfCare; }
            set { planOfCare = value; RaisePropertyChanged(); }
        }

        private String physicalExam;

        public String PhysicalExam
        {
            get { return physicalExam; }
            set { physicalExam = value; RaisePropertyChanged(); }
        }


        
    }
}
