using System;
using System.Data;
using System.Linq;
using System.Media;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using AestheticService;
using AestheticService.Models;
using DBConnect;
using Microsoft.EntityFrameworkCore;

namespace AestheticService
{
    public partial class AppointmentList : Window
    {
        private string choosedDate = "";

        public AppointmentList(string date)
        {
            InitializeComponent();
            choosedDate = date;
            Title += " на " + date + " число.";
            var priceList = UM.db.Preyskurant.Select(service => service.name).ToList();
            priceList.Sort((a, b) => a.CompareTo(b));
            ServiceChoose.ItemsSource = priceList;
            DatePicker.SelectedDate = DateTime.Parse(date);
            UpdateDataGrid();
            DataContext = new priems();

            // ДЛЯ ИЗМЕНЕНИЯ ДАТ ПРИЁМОВ
            // foreach (var appointment in UM.db.Priems.ToList())
            // {
            //     appointment.date=  appointment.date.Replace(".09.2021", ".05.2022");
            // }
            // UM.db.SaveChanges();
        }

        private void PriemList_OnClosed(object sender, EventArgs e)
        {
            UM.CloseApp(this);
        }

        private void EditPriems_OnClick(object sender, RoutedEventArgs e)
        {
            UM.GoInside(this, new AppointmentEditor());
        }

        private void Back_OnClick(object sender, RoutedEventArgs e)
        {
            UM.GoBack(this);
        }

        void UpdateDataGrid()
        {
            AppointmentGrid.ItemsSource =
                UM.db.Priems.Where(item => item.date.Contains(choosedDate)).ToList();
            var clients = UM.db.Priems.Select(item => item.who_fname + " " + item.who_sname).Distinct().ToList();
            clients.Sort((a, b) => a.CompareTo(b));
            ClientNameCombo.ItemsSource = clients;
        }


        private void AddPriem_OnClick(object sender, RoutedEventArgs e)
        {
            AddDialogHost.IsOpen = true;
            priems newAppointment = new priems();
            newAppointment.was = 0;
            DataContext = newAppointment;
        }

        private void CreateAppointmentBtn_OnClick(object sender, RoutedEventArgs e)
        {
            priems newAppointment = DataContext as priems;
            newAppointment.date = DatePicker.SelectedDate.Value.ToShortDateString();
            if (newAppointment.time != null)
            {
                string timeFormated = TimePicker.SelectedTime.Value.ToShortTimeString();
                newAppointment.time = timeFormated.Split(':')[0] + ":" + timeFormated.Split(':')[1];
                var client = ClientNameCombo.Text.Split(' ');
                if (client.Length > 1)
                {
                    newAppointment.who_fname = client[0];
                    newAppointment.who_sname = client[1];
                    try
                    {
                        priems lastService = UM.db.Priems.ToList().Last(item =>
                            item.date.Contains(choosedDate) &&
                            DateTime.Parse(item.time) <= DateTime.Parse(newAppointment.time));
                        int lastServiceDuration =
                            UM.db.Preyskurant.First(item => item.name.Contains(lastService.service)).duration;
                        if (DateTime.Parse(lastService.time).AddMinutes(lastServiceDuration) <=
                            DateTime.Parse(newAppointment.time))
                        {
                            if (newAppointment.service != null)
                            {
                                if (newAppointment.who_fname != null || newAppointment.who_sname != null)
                                {
                                    UM.db.Priems.Add(newAppointment);
                                    try
                                    {
                                        var val = new DbContextOptionsBuilder();
                                        val.EnableSensitiveDataLogging();
                                        UM.db.SaveChanges();
                                        UpdateDataGrid();
                                        DataContext = new priems();
                                        AddDialogHost.IsOpen = false;
                                        MessageBox.Show($"{newAppointment} добавлена!");
                                    }
                                    catch (Exception exception)
                                    {
                                        MessageBox.Show(exception.InnerException.Message + " " + exception.StackTrace);
                                    }
                                }
                                else
                                {
                                    UM.ErrorMessage("Клиент не выбран!");
                                }
                            }
                            else
                            {
                                UM.ErrorMessage("Услуга не выбрана!");
                            }
                        }
                        else
                        {
                            UM.ErrorMessage(
                                $"Время занято для  {lastService.who_sname} {lastService.who_fname} {lastService.service} {lastService.time}-{DateTime.Parse(lastService.time).AddMinutes(lastServiceDuration).ToShortTimeString().Split(':')[0] + ":" + DateTime.Parse(lastService.time).AddMinutes(lastServiceDuration).ToShortTimeString().Split(':')[1]}");
                            // Поиск свободного времени для услуги
                        }
                    }
                    catch (Exception)
                    {
                        if (newAppointment.service != null)
                        {
                            if (newAppointment.who_fname != null || newAppointment.who_sname != null)
                            {
                                UM.db.Priems.Add(newAppointment);
                                try
                                {
                                    UM.db.SaveChanges();
                                    UpdateDataGrid();
                                    DataContext = new priems();
                                    AddDialogHost.IsOpen = false;
                                    MessageBox.Show($"{newAppointment} добавлена!");
                                }
                                catch (Exception exception)
                                {
                                    MessageBox.Show(exception.InnerException.Message + " " + exception.StackTrace);
                                }
                            }
                            else
                            {
                                UM.ErrorMessage("Клиент не выбран!");
                            }
                        }
                        else
                        {
                            UM.ErrorMessage("Услуга не выбрана!");
                        }
                    }
                }

                else
                {
                    UM.ErrorMessage("Запишите клиента правильно. Имя Фамилия. Например:Иван Иванович.");
                }
            }
            else
            {
                UM.ErrorMessage("Время не выбрано!");
            }
        }

        private void CancelBtn_OnClick(object sender, RoutedEventArgs e)
        {
            AddDialogHost.IsOpen = false;
        }


        private void AppointmentGrid_OnCurrentCellChanged(object sender, EventArgs e)
        {
            if (AppointmentGrid.SelectedItem != null)
            {
                priems selectedAppointment = AppointmentGrid.SelectedItem as priems;
                selectedAppointment.was = selectedAppointment.was == 1 ? 0 : 1;
                UM.db.SaveChanges();
                UpdateDataGrid();
            }
        }

        private void ClientNameCombo_OnSelectionChanged(object sender, EventArgs eventArgs)
        {
            try
            {
                ((MaskedTextBox) DialogContent.Children[5]).Text =
                    UM.db.Priems.ToList().First(item =>
                        item.who_fname.Contains(ClientNameCombo.Text.Split(' ')[0]) ||
                        item.who_sname.Contains(ClientNameCombo.Text.Split(' ')[0])).phone;
                (DataContext as priems).phone = ((MaskedTextBox) DialogContent.Children[5]).Text;
            }
            catch (Exception exception)
            {
                System.Media.SystemSounds.Exclamation.Play();
            }
        }

        private void AppointmentList_OnIsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            UpdateDataGrid();
        }
    }
}