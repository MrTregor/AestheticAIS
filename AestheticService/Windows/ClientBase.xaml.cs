using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using AestheticService.Models;

namespace AestheticService.Windows
{
    public partial class ClientBase : Window
    {
        public ClientBase()
        {
            InitializeComponent();
            var clients = UM.db.Priems.ToList();
            var clientsPhones = clients.Select(item => item.phone).Distinct().ToList();
            List<ClientBaseObj> clientsList = new List<ClientBaseObj>();
            foreach (string phone in clientsPhones)
            {
                clientsList.Add(new ClientBaseObj(){who_fname = clients.Find(priems => priems.phone==phone).who_fname, who_sname = clients.Find(priems => priems.phone==phone).who_sname, phone = phone});
            }

            DataGrid.ItemsSource = clientsList;
        }

        private void Exit_OnClick(object sender, EventArgs eventArgs)
        {
            UM.CloseApp(this);
        }

        private void CancelBtn_OnClick(object sender, RoutedEventArgs e)
        {
            UM.GoBack(this);
        }

        class ClientBaseObj
        {
            public string who_fname { get; set; }
            public string who_sname { get; set; }
            public string phone { get; set; }
        }

        private void SearchField_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            var clients = UM.db.Priems.Where(item =>
                (FNameField.Text == null || item.who_fname.Contains(FNameField.Text)) &&
                (SNameField.Text == null || item.who_sname.Contains(SNameField.Text)) &&
                (PhoneField.Text == null || item.phone.Contains(PhoneField.Text))).ToList();
            
            var clientsPhones = clients.Select(item => item.phone).Distinct().ToList();
            List<ClientBaseObj> clientsList = new List<ClientBaseObj>();
            foreach (string phone in clientsPhones)
            {
                clientsList.Add(new ClientBaseObj(){who_fname = clients.Find(priems => priems.phone==phone).who_fname, who_sname = clients.Find(priems => priems.phone==phone).who_sname, phone = phone});
            }

            DataGrid.ItemsSource = clientsList;
        }
    }
}