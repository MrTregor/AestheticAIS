﻿using System;
using System.Windows;
using System.Windows.Controls;

namespace AestheticService
{
    public partial class AppointmentCalendar : Window
    {
        public AppointmentCalendar()
        {
            InitializeComponent();
        }

        private void PriemsCalendar_OnClosed(object sender, EventArgs e)
        {
            UM.isCalendarOpen = false;
        }

        private void MaterialCalendar_OnSelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            UM.GoInside(this, new AppointmentList(MaterialCalendar.SelectedDate.Value.ToShortDateString()));
        }

        private void Back_OnClick(object sender, RoutedEventArgs e)
        {
            UM.GoBack(this);
            this.Hide();
            this.Owner.Show();
            this.Owner.Focus();
            this.Close();
            UM.isCalendarOpen = false;
        }
    }
}