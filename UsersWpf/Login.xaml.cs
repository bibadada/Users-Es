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
    /// Logica di interazione per Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        private LoginViewModel vm;
        public Login()
        {
            InitializeComponent();
            vm = new LoginViewModel();
            this.DataContext = vm;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (vm.Login())
                NavigationService.Navigate(new UsersView());
            else
                MessageBox.Show("Login errato");
        }

        private void TextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                
                Button_Click(sender, null);
            }
                
        }
    }
}
