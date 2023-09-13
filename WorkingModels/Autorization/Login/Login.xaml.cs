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

namespace EquipmentInventory.WorkingModels.Autorization.Login
{
    /// <summary>
    /// Логика взаимодействия для Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        MainWindow mainWindow;
        public Login(MainWindow _mainWindow)
        {
            InitializeComponent();
            mainWindow = _mainWindow;
        }
        private void Click_Login(object sender, RoutedEventArgs e)
        {

            mainWindow.frame.Navigate(new WorkingModels.MainBody.MainAdm.MainAdm(mainWindow));
        }
        private void Click_Exit(object sender, RoutedEventArgs e)
        {
            mainWindow.Close();
        }
        private void For_Registration(object sender, RoutedEventArgs e)
        {
            mainWindow.frame.Navigate(new WorkingModels.Autorization.Registation.Registration(mainWindow));
        }
    }
}
