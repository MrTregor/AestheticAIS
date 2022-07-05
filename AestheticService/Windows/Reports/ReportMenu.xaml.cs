using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace AestheticService
{
    public partial class ReportMenu : Window
    {
        public ReportMenu()
        {
            InitializeComponent();
            StartDatePicker.Text = DateTime.Today.ToShortDateString();
            EndDatePicker.Text = DateTime.Today.ToShortDateString();
        }

        private void Dohodi_OnClick(object sender, RoutedEventArgs e)
        {
            CheckDatePick(true);
        }

        private void Rashodi_OnClick(object sender, RoutedEventArgs e)
        {
            CheckDatePick(false);
        }

        void CheckDatePick(bool type)
        {
            List<string> dates = new List<string>();

            if (EndDatePicker.SelectedDate < StartDatePicker.SelectedDate)
            {
                ReportFrame.Navigate(new ReportTables(EndDatePicker.SelectedDate.Value,
                    StartDatePicker.SelectedDate.Value, type));
            }
            else
            {
                ReportFrame.Navigate(new ReportTables(StartDatePicker.SelectedDate.Value,
                    EndDatePicker.SelectedDate.Value, type));
            }
        }

        private void Back_OnClick(object sender, RoutedEventArgs e)
        {
            UM.GoBack(this);
        }

        private void ReportMenu_OnClosed(object sender, EventArgs e)
        {
            UM.CloseApp(this);
        }
    }
}