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

namespace EquipmentInventory.WorkingModels.MainBody.MainAdm
{
    /// <summary>
    /// Логика взаимодействия для MainAdm.xaml
    /// </summary>
    public partial class MainAdm : Page
    {
        MainWindow mainWindow;
        public MainAdm(MainWindow _mainWindow)
        {
            InitializeComponent();
            mainWindow = _mainWindow;
        }

        private void Click_Exit(object sender, RoutedEventArgs e)
        {
            mainWindow.frame.Navigate(new WorkingModels.Autorization.Login.Login(mainWindow));
        }
        private void OpenPage1(object sender, RoutedEventArgs e)
        {

        }
        private void OpenPage2(object sender, RoutedEventArgs e)
        {

        }
        private void OpenPage3(object sender, RoutedEventArgs e)
        {

        }
        private void OpenPage4(object sender, RoutedEventArgs e)
        {

        }
        private void OpenPage5(object sender, RoutedEventArgs e)
        {

        }
        private void OpenPage6(object sender, RoutedEventArgs e)
        {

        }
    }
}
