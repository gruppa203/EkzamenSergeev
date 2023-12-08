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

namespace EkzamenSergeev1.Pages
{
    /// <summary>
    /// Логика взаимодействия для ViborRoli.xaml
    /// </summary>
    public partial class ViborRoli : Page
    {
        public ViborRoli()
        {
            InitializeComponent();
        }

        private void AdminButton_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.GlavniFrame.Navigate(new PageTovari());
        }
    }
}
