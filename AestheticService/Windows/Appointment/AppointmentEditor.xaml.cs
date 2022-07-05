using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using AestheticService;
using AestheticService.Models;
using DBConnect;

namespace AestheticService
{
    public partial class AppointmentEditor : Window
    {
        public AppointmentEditor()
        {
            InitializeComponent();
            UpdateDataGrid();
        }

        private void Back_OnClick(object sender, RoutedEventArgs e)
        {
            UM.GoBack(this);
        }

        private void PriemEditor_OnClosed(object sender, EventArgs e)
        {
            UM.CloseApp(this);
        }

        private void Save_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                UM.db.SaveChanges();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message + " " + exception.StackTrace);
            }
        }

        void UpdateDataGrid()
        {
            AppointmentGrid.ItemsSource = UM.db.Priems.ToList();
        }

        private void DeleteBtn_OnClick(object sender, RoutedEventArgs e)
        {
            var itemToDelete = AppointmentGrid.SelectedItems.Cast<priems>().ToList();
            if (MessageBox.Show($"Будут удалены {itemToDelete.Count} строк. Согласны?", "Предупреждение системы", MessageBoxButton.YesNo,MessageBoxImage.Question,MessageBoxResult.No)==MessageBoxResult.Yes)
            {
                UM.db.Priems.RemoveRange(itemToDelete);
                UM.db.SaveChanges();
                UpdateDataGrid();
            }
        }
    }

    public class DateTimeToDateConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            //01.01.0001
            var date = value.ToString().Split('.');
            return $"{date[2]}.{date[1]}.{date[0]}";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return DependencyProperty.UnsetValue;
        }
    }
}