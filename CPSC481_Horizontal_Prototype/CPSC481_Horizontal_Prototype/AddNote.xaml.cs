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

namespace CPSC481_Horizontal_Prototype
{
    /// <summary>
    /// Interaction logic for AddNote.xaml
    /// </summary>
    public partial class AddNote : UserControl
    {
        public AddNote()
        {
            InitializeComponent();
            lblTableNum.Content = MainWindow.tableNum;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            txtNote.Clear();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow.switchToSoupSaladView();
        }

        private void changeToOrderAdded(object sender, RoutedEventArgs e)
        {
            MainWindow.note = txtNote.Text;
            MainWindow.switchToOrderAddedView();
        }
    }
}
