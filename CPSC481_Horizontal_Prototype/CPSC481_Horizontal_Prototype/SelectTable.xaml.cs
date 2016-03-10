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
    /// Interaction logic for SelectTable.xaml
    /// </summary>
    public partial class SelectTable : UserControl
    {
        public SelectTable()
        {
            InitializeComponent();
        }

        private void switchToMenuCatagories(object sender, RoutedEventArgs e)
        {
            Button b = e.Source as Button;
            MainWindow.tableNum = b.Content as String; 
            MainWindow.switchToMenuCatagories();
           
        }
    }
}
