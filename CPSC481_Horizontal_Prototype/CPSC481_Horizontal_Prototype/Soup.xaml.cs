﻿using System;
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
            popOverAllergies.Visibility = Visibility.Hidden;
        }

        private void showPopOverAllergies(object sender, MouseButtonEventArgs e)
        {
            popOverAllergies.Visibility = Visibility.Visible;
            Label testLbl = new Label();
            testLbl.Content = "Gluten Free";

            popOverAllergies.Children.Add(testLbl);
        }

        private void ShowAllergies(object sender, MouseEventArgs e)
        {
            popOverAllergies.Visibility = Visibility.Visible;
            Label testLbl = new Label();
            testLbl.Content = "Gluten Free";

            popOverAllergies.Children.Add(testLbl);
        }

        private void HideAllergies(object sender, MouseEventArgs e)
        {
            popOverAllergies.Visibility = Visibility.Hidden;



           
        }
    }
}
