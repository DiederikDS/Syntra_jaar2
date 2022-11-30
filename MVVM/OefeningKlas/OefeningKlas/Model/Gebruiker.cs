using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningKlas.Model
{
    public class Gebruiker : BasisClass
    {
        public Gebruiker()
        {
                
        }

        private string _GebruikersNaam;

        public string GebruikersNaam
        {
            get { return _GebruikersNaam; }
            set { 
                    _GebruikersNaam = value;
                    OnPropertyChanged("GebruikersNaam");
                }
        }

        private int _Uid;

        public int Uid
        {
            get { return _Uid; }
            set { 
                    _Uid = value;
                    OnPropertyChanged("Uid");
                }
        }

        private string _Les;

        public string Les
        {
            get { return _Les; }
            set { _Les = value; }
        }

    }
}
