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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CPSC481_Horizontal_Prototype
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static MainWindow m;
        public static String note;
        //Soup s = new Soup();
        public MainWindow()
        {
            m = this;
            InitializeComponent();
            LoginWindow lw = new LoginWindow();
            stkPanel.Children.Add(lw);
        }

        public void CreateMyMultilineTextBox()
        {
            

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Soup s = new Soup();
            stkPanel.Children.Add(s);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            mainCanvas.Children.Clear();
        }

        public static void switchToTableView()
        {
            SelectTable st = new SelectTable();
            m.switchTo(st);
        }

        public static void switchToMenuCatagories()
        {
            MenuCatagories mc = new MenuCatagories();
            m.switchTo(mc);
        }

        public static void switchToSoupSaladView()
        {
            Soup s = new Soup();
            m.switchTo(s);
        }

        public static void switchToAddNoteView()
        {
            AddNote an = new AddNote();
            m.switchTo(an);
        }

        public static void switchToOrderAddedView()
        {
            OrderAdded oa = new OrderAdded();
            m.switchTo(oa);
        }

        private void switchTo(UserControl u)
        {
            stkPanel.Children.Clear();
            stkPanel.Children.Add(u);
        }
    }
}
