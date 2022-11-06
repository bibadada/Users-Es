using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersClassLibrary.Controllers;
using UsersClassLibrary.Models;

namespace UsersWpf.ViewModels
{
    class NuovoUtenteViewModel : BaseViewModel
    {
        public NuovoUtenteViewModel()
        {
            ListaSessi = new ObservableCollection<string>(Users.GetGenders());
            SelectedUser = new User();

        }

        private User _selectedUser;

        public User SelectedUser
        {
            get { return _selectedUser; }
            set
            {
                _selectedUser = value;
                NotifyPropretyChanged("SelectedUser");
            }
        }

        public User EditedUser;
        private bool editMode = false;

        private string _Titolo;

        public string Titolo
        {
            get { return _Titolo; }
            set
            {
                _Titolo = value;
                NotifyPropretyChanged("Titolo");
            }
        }

        private string _TitoloScheda;
        public string TitoloScheda
        {
            get { return _TitoloScheda; }
            set
            {
                _TitoloScheda = value;
                NotifyPropretyChanged("TitoloScheda");
            }
        }



        private ObservableCollection<string> _listaSessi;

        public ObservableCollection<string> ListaSessi
        {
            get { return _listaSessi; }
            set
            {
                _listaSessi = value;
                NotifyPropretyChanged("ListaSessi");
            }
        }

        internal void EditMode()
        {
            Titolo = "Modifica Utente";
            TitoloScheda = "Modifica Utente";
            
            editMode = true;
        }

        public void Salva()
        {
            if(editMode)
            {
                if ((!SelectedUser.Equals(EditedUser) && Users.Update(EditedUser.Id, SelectedUser)) == false)
                {
                    throw new Exception("Errore nell'aggiornamento");
                }
            }
            else
            {
                SelectedUser.Age = (int)((DateTime.Today - SelectedUser.BirthDate).TotalDays / 365.25);
                Users.Add(SelectedUser);
            }
            
        }
    }
}
