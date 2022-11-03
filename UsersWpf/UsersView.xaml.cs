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
using UsersWpf.ViewModels;

namespace UsersWpf
{
    /// <summary>
    /// Logica di interazione per UsersView.xaml
    /// </summary>
    public partial class UsersView : Page
    {
        private UsersViewModel vm;
        public UsersView()
        {
            InitializeComponent();
            vm = new UsersViewModel();
            this.DataContext = vm;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            vm.AzzeraFiltri();
        }

        private void Button_Click_NuovoUtente(object sender, RoutedEventArgs e)
        {
            vm.NewUser();
        }

        private void DataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            vm.EditUser();//DA IMPLEMENTARE
        }
    }
}
