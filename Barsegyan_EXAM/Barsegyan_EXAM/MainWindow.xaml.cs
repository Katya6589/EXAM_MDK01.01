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

namespace Barsegyan_EXAM
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Class1._mainFrame = _mainFrame;
            Class1._mainFrame.Navigate(new pages.Page1());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _mainFrame.Navigate(new pages.Page2());
        }

        private void Button_Nazad(object sender, RoutedEventArgs e)
        {
            _mainFrame.Navigate(new pages.Page1());
        }

        private void Button_Text(object sender, RoutedEventArgs e)
        {
            _mainFrame.Navigate(new pages.Page3());
        }

    }
}
