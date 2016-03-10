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
    /// Interaction logic for Soup.xaml
    /// </summary>
    public partial class Soup : UserControl
    {
        public Soup()
        {
            InitializeComponent();
            lblTableNum.Content = MainWindow.tableNum;
            popOverAllergies.Visibility = Visibility.Hidden;
        }

        private void showPopOverAllergies(object sender, MouseButtonEventArgs e)
        {
            popOverAllergies.Visibility = Visibility.Visible;
        }

        private void ShowAllergies(object sender, MouseEventArgs e)
        {
            popOverAllergies.Visibility = Visibility.Visible;
        }

        private void HideAllergies(object sender, MouseEventArgs e)
        {
            popOverAllergies.Visibility = Visibility.Hidden;



           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.switchToTableView();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow.switchToMenuCatagories();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            MainWindow.switchToAddNoteView();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MainWindow.FoodFromKitchen();
            MessageBox.Show("Sent to Kitchen");
            MainWindow.switchToTableView();
        
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MainWindow.switchToMenuCatagories();
        }

       
    }
}
