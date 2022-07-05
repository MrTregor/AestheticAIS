using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using AestheticService;
using AestheticService.Models;

namespace AestheticService
{
    public partial class PriceListEditor : Window
    {
        private bool addFlag = false;

        public PriceListEditor()
        {
            InitializeComponent();

            UpdateDataGrid();
        }

        private void Back_OnClick(object sender, RoutedEventArgs e)
        {
            UM.GoBack(this);
        }

        private void PreyskurantEditor_OnClosed(object sender, EventArgs e)
        {
            UM.CloseApp(this);
        }

        private void Save_OnClick(object sender, RoutedEventArgs e)
        {
            if (addFlag)
            {
                UM.db.Preyskurant.Add(DataContext as preyskurant);
                UM.db.SaveChanges();
                UpdateDataGrid();
                addFlag = false;
            }

            UM.db.SaveChanges();
        }

        void UpdateDataGrid()
        {
            DataGrid.ItemsSource = UM.db.Preyskurant.ToList();
            ServicesCombo.ItemsSource = UM.db.Preyskurant.Select(item => item.category).Distinct().ToList();
            var categories = UM.db.Preyskurant.Select(item => item.category).Distinct().ToList();
            CategorySearchCombo.ItemsSource = categories;
        }

        private void AddBtn_OnClick(object sender, RoutedEventArgs e)
        {
            addFlag = true;
            DataContext = new preyskurant();
        }

        private void DeleteBtn_OnClick(object sender, RoutedEventArgs e)
        {
            var itemsForRemoving = DataGrid.SelectedItems.Cast<preyskurant>().ToList();
            if (MessageBox.Show($"Вы точно хотите удалить {itemsForRemoving.Count} усл. из прейскуранта?",
                    "Предупреждение!", MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.No) ==
                MessageBoxResult.Yes)
            {
                try
                {
                    UM.db.Preyskurant.RemoveRange(itemsForRemoving);
                    UM.db.SaveChanges();
                    MessageBox.Show("Данные удалены!");
                    UpdateDataGrid();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message + ' ' + exception.StackTrace);
                }
            }
        }

        private void DataGrid_OnSelected(object sender, RoutedEventArgs e)
        {
            DataContext = DataGrid.SelectedItem as preyskurant;
        }

        void Search()
        {
            DataGrid.ItemsSource =
                UM.db.Preyskurant.Where(item =>
                    (String.IsNullOrEmpty(ServiceNameSearchText.Text) ||
                     item.name.Contains(ServiceNameSearchText.Text)) &&
                    (String.IsNullOrEmpty(CategorySearchCombo.Text) ||
                     item.category.Contains(CategorySearchCombo.SelectedItem as string)
                    )).ToList();
        }

        private void SearchBtn_OnClick(object sender, RoutedEventArgs e)
        {
            Search();
        }

        private void ServiceNameSearchText_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            Search();
        }

        private void CategorySearchCombo_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Search();
        }
    }
}