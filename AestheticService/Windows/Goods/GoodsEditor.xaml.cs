using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using AestheticService.Models;

namespace AestheticService
{
    public partial class GoodsEditor : Window
    {
        public GoodsEditor()
        {
            InitializeComponent();
            UpdateDataGrid();
        }

        private void GoodsEditor_OnClosed(object sender, EventArgs e)
        {
            UM.CloseApp(this);
        }

        private void Save_OnClick(object sender, RoutedEventArgs e)
        {
            UM.db.SaveChanges();
            UpdateDataGrid();
        }

        private void Back_OnClick(object sender, RoutedEventArgs e)
        {
            UM.GoBack(this);
        }

        void UpdateDataGrid()
        {
            GoodsList.ItemsSource = UM.db.Goods.ToList();
            CategoryCombo.ItemsSource = UM.db.Goods.Select(item => item.category).Distinct().ToList();
        }

        private void DeleteMistake_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                if (GoodsList.SelectedItems.Count > 0)
                {
                    var itemsForDelete = GoodsList.SelectedItems.Cast<goods>().ToList();
                    if (MessageBox.Show($"Вы точно хотите удалить расходники в кол-ве {itemsForDelete.Count} шт.?",
                        "Предупреждение системы", MessageBoxButton.YesNo, MessageBoxImage.Question,
                        MessageBoxResult.No) == MessageBoxResult.Yes)
                    {
                        UM.db.Goods.RemoveRange(itemsForDelete);
                        // ТОDO: Сделать удаление из отчётов 
                        UM.db.SaveChanges();
                        UpdateDataGrid();
                        MessageBox.Show("Удаление выполнено!");
                    }
                }
                else
                {
                    MessageBox.Show("Записи не выбраны!");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message + " " + exception.StackTrace);
            }
        }

        private void GoodsList_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataContext = GoodsList.SelectedItem as goods;
        }
    }
}