using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersClassLibrary.Controllers;
using UsersClassLibrary.Models;

namespace UsersWpf.ViewModels
{
    class UsersViewModel : BaseViewModel
    {
        public UsersViewModel()
        {
            ListaSessi = Users.GetGenders();
            DatiUtenti = Users.GetAll();

        }


        private string _filtroNome;

        public string FiltroNome
        {
            get { return _filtroNome; }
            set
            {
               _filtroNome = value;
                NotifyPropretyChanged("FiltroNome");
                LoadData();
            }
        }

        private List<string> _listaSessi;

        public List<string> ListaSessi
        {
            get { return _listaSessi; }
            set
            {
                _listaSessi = value;
                NotifyPropretyChanged("ListaSessi");
            }
        }

        public void NewUser()
        {
            NuovoUtenteView nu = new NuovoUtenteView();
            nu.ShowDialog();
            LoadData();
        }

        public void EditUser(object selezionato)
        {
            User userSelezionato = (User)selezionato;
            if (selezionato == null) return;
            NuovoUtenteView nu = new NuovoUtenteView(userSelezionato);
            nu.ShowDialog();
            LoadData();

        }

        private string _filtroSesso;

        public string FiltroSesso
        {
            get { return _filtroSesso; }
            set
            {
                _filtroSesso = value;
                NotifyPropretyChanged("FiltroSesso");
                LoadData();
            }
        }

        private List<User> _datiUtenti;

        public List<User> DatiUtenti
        {
            get { return _datiUtenti; }
            set
            {
                _datiUtenti = value;
                NotifyPropretyChanged("DatiUtenti");
            }
        }

        private User _utenteSelezionato;

        public User UtenteSelezionato
        {
            get { return _utenteSelezionato; }
            set
            { 
                _utenteSelezionato = value;
                NotifyPropretyChanged("UtenteSelezionato");
            }
        }


        private void LoadData()
        {
            DatiUtenti = Users.FindAll(FiltroNome, FiltroSesso);
                /*(u =>
                (string.IsNullOrEmpty(FiltroNome) || u.FirstName.ToLower().Contains(FiltroNome.ToLower()) || 
                 u.LastName.ToLower().Contains(FiltroNome.ToLower())) &&
                (string.IsNullOrEmpty(FiltroSesso) || u.Gender == FiltroSesso));*/
        }

        public void AzzeraFiltri()
        {
            FiltroNome = null;
            FiltroSesso = null;
            //LoadData();
        }






    }
}
