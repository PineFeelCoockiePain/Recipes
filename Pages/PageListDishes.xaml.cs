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
    /// Логика взаимодействия для PageListDishes.xaml
    /// </summary>
    
    public partial class PageListDishes : Page
    {
        Models.MyRecipesEntities _context = new Models.MyRecipesEntities();
        
        public PageListDishes()
        {
            InitializeComponent();

            CmbCategory.ItemsSource = _context.Categories.ToList();
            CmbCategory.SelectedIndex = 0;

            RefreshData();
        }

        private void RefreshData()
        {
            List<Models.Dish> listDishes = _context.Dishes.ToList();

            // фильтрация по категориям
            Models.Category selectedCategory = (Models.Category)CmbCategory.SelectedItem;
            listDishes = listDishes.Where(x => x.CategoryId == selectedCategory.Id).ToList();
            
            // поиск по тексту
            var searchString = TxtSearch.Text;
            if (!string.IsNullOrWhiteSpace(searchString))
            {
                listDishes = listDishes.Where(x => x.Name.Contains(searchString)).ToList();
            }

            // сортировка по себестоимости блюда
            listDishes = listDishes.OrderByDescending(x => x.ServingPrice).ToList();
            
            LViewDishes.ItemsSource = listDishes;
        }

        private void CmbCategory_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            RefreshData();
        }

        private void TxtSearch_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            RefreshData();
        }
    }
}
