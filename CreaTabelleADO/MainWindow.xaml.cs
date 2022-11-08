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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CreaTabelleADO
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainWindowViewModel vm;
        public MainWindow()
        {
            InitializeComponent();
            vm = new MainWindowViewModel();
            DataContext = vm;
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            vm.DropTables();
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            vm.CreateTables();
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            vm.DeleteTables();
        }

        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            vm.InsertInto();
        }
    }
}
