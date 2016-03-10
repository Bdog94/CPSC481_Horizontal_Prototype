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
    /// Interaction logic for OrderAdded.xaml
    /// </summary>
    public partial class OrderAdded : UserControl
    {
        public OrderAdded()
        {
            InitializeComponent();
            lblNote.Content = MainWindow.note;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Sent to Kitchen");
            MainWindow.FoodFromKitchen();
            MainWindow.switchToTableView();
            
        }
    }
}
