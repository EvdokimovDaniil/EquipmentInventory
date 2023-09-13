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

namespace EquipmentInventory.WorkingModels.Edit
{
    /// <summary>
    /// Логика взаимодействия для User_edit.xaml
    /// </summary>
    public partial class User_edit : Page
    {
        MainWindow mainWindow;
        public User_edit(MainWindow _mainWindow)
        {
            InitializeComponent();
            mainWindow = _mainWindow;
        }
        private void Click_Exit(object sender, RoutedEventArgs e)
        {
            mainWindow.frame.Navigate(new WorkingModels.MainBody.MainAdm.MainAdm(mainWindow));
        }
        private void Click_Edit(object sender, RoutedEventArgs e)
        {

        }
    }
}
