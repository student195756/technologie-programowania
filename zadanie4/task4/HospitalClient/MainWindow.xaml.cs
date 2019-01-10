using HospitalClient.ViewModels;
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

namespace HospitalClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainViewModel mainView = new MainViewModel();

        public MainWindow()
        {
            InitializeComponent();
            DataContext = mainView;
        }

        private void employeesButtonClicked(object sender, RoutedEventArgs e)
        {
            mainView.SetElementsListWithEmployees();
        }

        private void pacjenciButtonClick(object sender, RoutedEventArgs e)
        {
            mainView.SetElementsListWithPatients();
        }

        private void oddzialyButtonClick(object sender, RoutedEventArgs e)
        {
            mainView.SetElementsListWithDepartments();
        }

        private void pokojeButtonClick(object sender, RoutedEventArgs e)
        {
            mainView.SetElementsListWithRooms();
        }
    }
}
