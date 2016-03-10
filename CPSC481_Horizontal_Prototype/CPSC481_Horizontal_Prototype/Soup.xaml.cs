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
        string caesarSalad = "";
        bool showAllergies = false;
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
            Label l = e.Source as Label;

            if (l.Equals(lblAllergies))
            {
                showAllergies = true;
            }
            if (showAllergies)
            {
                popOverAllergies.Visibility = Visibility.Visible;
            }
            else
            {
                HideAllergies(sender, e);
            }
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

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            caesarSalad = caesarSalad + "Caesar Salad" + System.Environment.NewLine;
            CurrentOrder.Content = caesarSalad;

        }

        private void addGlutenFree(object sender, MouseButtonEventArgs e)
        {
            showAllergies = false;
            MainWindow.customizations += "Gluten Free";

            caesarSalad = caesarSalad + "Gluten Free" + System.Environment.NewLine;
            CurrentOrder.Content = caesarSalad;
        }

       
    }
}
