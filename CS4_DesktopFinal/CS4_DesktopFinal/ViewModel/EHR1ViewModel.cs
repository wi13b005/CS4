using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS4_DesktopFinal.ViewModel

{
    public class EHR1ViewModel:ViewModelBase
    {

        public EHR1ViewModel()
        {

        }

        public EHR1ViewModel(String f, String l, int ssn, String a, String h, String all, String prev, String dur, String plan, String phys)
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
            set { firstname = value; }
        }

        private String lastname;

        public String Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }

        private int ssn;

        public int SSN
        {
            get { return ssn; }
            set { ssn = value; }
        }

        private String address;

        public String Address
        {
            get { return address; }
            set { address = value; }
        }

        private String history;

        public String History
        {
            get { return history; }
            set { history = value; }
        }

        private String allergies;

        public String Allergies
        {
            get { return allergies; }
            set { allergies = value; }
        }
        private String prevMedication;

        public String PrevMedication
        {
            get { return prevMedication; }
            set { prevMedication = value; }
        }

        private String duringMedication;

        public String DuringMedication
        {
            get { return duringMedication; }
            set { duringMedication = value; }
        }

        private String planOfCare;

        public String PlanOfCare
        {
            get { return planOfCare; }
            set { planOfCare = value; }
        }

        private String physicalExam;

        public String PhysicalExam
        {
            get { return physicalExam; }
            set { physicalExam = value; }
        }


        
    }
}
