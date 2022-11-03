using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersClassLibrary.Controllers;

namespace UsersWpf.ViewModels
{
    class NuovoUtenteViewModel : BaseViewModel
    {
        public NuovoUtenteViewModel()
        {
            ListaSessi = Users.GetGenders();
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


    }
}
