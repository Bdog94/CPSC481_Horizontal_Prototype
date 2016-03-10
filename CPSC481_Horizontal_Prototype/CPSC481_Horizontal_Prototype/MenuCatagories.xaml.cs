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

namespace CPSC481_Horizontal_Prototype
{
    /// <summary>
    /// Interaction logic for MenuCatagories.xaml
    /// </summary>
    public partial class MenuCatagories : UserControl
    {
        public MenuCatagories()
        {
            InitializeComponent();
            lblTable.Content = MainWindow.tableNum;
            //btnNextItem.IsEnabled = false;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow.switchToTableView();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MainWindow.switchToSoupSaladView();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {

        }

    }
}
