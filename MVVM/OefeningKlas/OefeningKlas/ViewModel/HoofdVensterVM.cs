using OefeningKlas.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Input;
using OefeningKlas.View;

namespace OefeningKlas.ViewModel
{
    public class HoofdVensterVM : BasisVM
    {
        public HoofdVensterVM()
        {
            _Gebruikers = new ObservableCollection<Gebruiker>();

            DetailsCmd = new RelayCommand(OnDetails);

            Gebruiker g = new Gebruiker();
            g.Uid = 1;
            g.GebruikersNaam = "Grote Smurf";
            g.Les = "smurfen";
            _Gebruikers.Add(g);

            g = new Gebruiker();
            g.Uid = 2;
            g.GebruikersNaam = "Spiderman";
            g.Les = "weven";
            _Gebruikers.Add(g);

            g = new Gebruiker();
            g.Uid = 3;
            g.GebruikersNaam = "Superman";
            g.Les = "Vliegen";
            _Gebruikers.Add(g);

        }

        public RelayCommand DetailsCmd { get; private set; }

        private Gebruiker _GeselecteerdeGebruiker;

        public Gebruiker GeselecteerdeGebruiker
        {
            get { return _GeselecteerdeGebruiker; }
            set { 
                    _GeselecteerdeGebruiker = value;
                    OnPropertyChanged("GeselecteerdeGebruiker");
                }
        }


        private ObservableCollection<Gebruiker> _Gebruikers;

        public ObservableCollection<Gebruiker> Gebruikers
        {
            get { return _Gebruikers; }
            set { _Gebruikers = value; }
        }

        private void OnDetails()
        {
            Detail detail = new Detail();
            DetailsVM vm = new DetailsVM();
            vm.GeselecteerdeGebruiker = GeselecteerdeGebruiker;
            detail.DataContext = vm;
            detail.ShowDialog();
        }

    }
}
