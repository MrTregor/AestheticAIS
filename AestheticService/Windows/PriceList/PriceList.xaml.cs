using System;
using System.Data;
using System.Linq;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace AestheticService
{
    public partial class PriceList : Window
    {
        public PriceList()
        {
            InitializeComponent();
            var preyskurant = UM.db.Preyskurant.ToList();
            Preykurant.ItemsSource = preyskurant;
            var categories = preyskurant.Select(item => item.category).Distinct().ToList();
            // NavBar.ItemsSource = categories;
            CategorySearchCombo.ItemsSource = categories;
        }

        private void CategoryBtn_OnClick(object sender, RoutedEventArgs e)
        {
            Preykurant.ItemsSource = UM.db.Preyskurant.ToList()
                .Where(item => item.category == e.Source.ToString().Substring(32));
        }


        private void PriceList_OnClosed(object sender, EventArgs e)
        {
            UM.CloseApp(this);
        }

        private void EditorBtn_OnClick(object sender, RoutedEventArgs e)
        {
            UM.GoInside(this, new PriceListEditor());
        }

        private void Back_OnClick(object sender, RoutedEventArgs e)
        {
            UM.GoBack(this);
        }

        void Search()
        {
            
            Preykurant.ItemsSource =
                UM.db.Preyskurant.Where(item =>
                    (String.IsNullOrEmpty(ServiceNameSearchText.Text) || item.name.Contains(ServiceNameSearchText.Text)) &&
                    (String.IsNullOrEmpty(CategorySearchCombo.Text) || item.category.Contains(CategorySearchCombo.SelectedItem as string)
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