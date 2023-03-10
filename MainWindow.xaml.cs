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

namespace Recipes
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            MainFrame.Navigate(new Pages.PageListDishes());
        }

        private void BtnDishes_OnClick(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Pages.PageListDishes());
        }

        private void BtnIngridients_OnClick(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Pages.PageListIngridients());
        }

        private void BtnExit_OnClick(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void BtnCapcha_OnClick(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Pages.PageCapcha());
        }
    }
}
