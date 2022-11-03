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
using MahApps.Metro.Controls;
using UsersWpf.ViewModels;

namespace UsersWpf
{
    /// <summary>
    /// Logica di interazione per NuovoUtenteView.xaml
    /// </summary>
    public partial class NuovoUtenteView : MetroWindow
    {
        private NuovoUtenteViewModel vm;
        public NuovoUtenteView()
        {
            InitializeComponent();
            vm = new NuovoUtenteViewModel();
            this.DataContext = vm;
        }

        private void Button_ClickAnnulla(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Salva_Click(object sender, RoutedEventArgs e)
        {
            vm.Salva();
            this.Close();
        }
    }
}
