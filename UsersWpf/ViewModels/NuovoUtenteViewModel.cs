using System;
using System.Collections.Generic;
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
            ListaSessi = Users.GetGenders();
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

        public void Salva()
        {
            SelectedUser.Age = (int)((DateTime.Today - SelectedUser.BirthDate).TotalDays / 365.25);
            Users.Add(SelectedUser);
        }
    }
}
