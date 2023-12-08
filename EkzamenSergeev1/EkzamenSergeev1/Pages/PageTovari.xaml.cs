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
//using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using EkzamenSergeev1.ApplicationData;

namespace EkzamenSergeev1.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageTovari.xaml
    /// </summary>
    public partial class PageTovari : Page
    {
        public PageTovari()
        {
            InitializeComponent();
            DGridTovari.ItemsSource = bdSergeevEntities.GetContext().ToList();

        }

        private void DataGridRowHeader_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
