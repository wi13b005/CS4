using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageGUI.ViewModel
{
    public class CoreMessageViewModel
    {
        private CoreMessage cmsg = new CoreMessage();
        public int Menge
        {
            get { return cmsg.menge; }
            set { this.cmsg.menge = value; }
        }

        public string Bezeichnung
        {
            get { return cmsg.bezeichnung; }
            set { this.cmsg.bezeichnung = value; }
        }

        public String Beschreibung
        {
            get { return cmsg.beschreibung; }
            set { this.cmsg.beschreibung = value; }
        }



    }
}
