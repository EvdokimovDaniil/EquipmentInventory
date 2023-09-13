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

namespace EquipmentInventory.WorkingModels.Add
{
    /// <summary>
    /// Логика взаимодействия для Room_add.xaml
    /// </summary>
    public partial class Room_add : Page
    {
        MainWindow mainWindow;
        public Room_add(MainWindow _mainWindow)
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
