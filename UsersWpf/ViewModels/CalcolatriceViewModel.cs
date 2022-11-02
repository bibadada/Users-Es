using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UsersWpf.ViewModels
{
    class CalcolatriceViewModel : BaseViewModel
    {
        #region ViewModel


        private string _display = "0";
        public string Display
        {
            get { return _display; }
            set
            {
                _display = value;
                NotifyPropretyChanged("Display");
            }
        }


        #endregion
 

        public void ButtonPressed(string s)
        {
            Display += s;
        }


    }
}
