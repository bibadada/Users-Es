using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace UsersWpf
{
    /// <summary>
    /// Logica di interazione per NuovoUtenteView.xaml
    /// </summary>
    public partial class NuovoUtenteViewModel : Window
    {
        private NuovoUtenteViewModel vm;
        public NuovoUtenteViewModel()
        {
            InitializeComponent();
            vm = new NuovoUtenteViewModel();
            this.DataContext = vm;
        }
    }
}
