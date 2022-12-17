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
using Recipes.Models;

namespace Recipes.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageListIngridients.xaml
    /// </summary>
    public partial class PageListIngridients : Page
    {
        Models.MyRecipesEntities _context = new Models.MyRecipesEntities();

        public PageListIngridients()
        {
            InitializeComponent();

            RefreshData();
        }

        private void RefreshData()
        {
            List<Models.Ingredient> listIngredients = _context.Ingredients.ToList();
            DGridIngredients.ItemsSource = listIngredients;

            LblTotalQuantity.Content = listIngredients.Count + " наименований";

            double sum = listIngredients.Sum(x => x.Price * x.AvailableCount);
            LblTotalSum.Content = $"Запасов в холодильнике на сумму (руб.): {sum:N2}";
        }

        private void BtnFirstPage_OnClick(object sender, RoutedEventArgs e)
        {
            RefreshData();
        }

        private void BtnPreviousPage_OnClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnNextPage_OnClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnLastPage_OnClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BorderPlus_OnMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
