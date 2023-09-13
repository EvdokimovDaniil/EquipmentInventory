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

namespace EquipmentInventory.WorkingModels.Autorization.Registation
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Page
    {
        MainWindow mainWindow;
        public Registration(MainWindow _mainWindow)
        {
            InitializeComponent();
            mainWindow = _mainWindow;
        }
        private void Click_Exit(object sender, RoutedEventArgs e)
        {
            mainWindow.frame.Navigate(new WorkingModels.Autorization.Login.Login(mainWindow));
        }
        private void Click_Register(object sender, RoutedEventArgs e)
        {

        }
    }
}
