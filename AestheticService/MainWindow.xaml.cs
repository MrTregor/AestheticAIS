using System;
using System.Linq;
using System.Windows;
using AestheticService.Windows;


namespace AestheticService
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DateTime dateTime = DateTime.Today.Date;
            TodayLable.Text = "Сегодня " + DateTime.Today.ToLongDateString();


            // DateTime curDate = DateTime.Parse("01.05.2022");
            // var priems = UM.db.Priems.ToList();
            // for (int i = 0; i < priems.Count; i++)
            // {
            //     priems[i].date = curDate.AddDays(i+1).ToShortDateString();
            // }
            //
            // UM.db.SaveChanges();
        }

        private void ToPriceList_OnClick(object sender, RoutedEventArgs e)
        {
            UM.GoInside(this, new PriceList());
        }

        private void MainWindow_OnClosed(object sender, EventArgs e)
        {
            UM.CloseApp(this);
        }

        private void ToPriemList_OnClick(object sender, RoutedEventArgs e)
        {
            if (!UM.isCalendarOpen)
            {
                var from = this;
                var to = new AppointmentCalendar();
                to.Owner = from;
                to.Show();
                UM.MainWindow = this;
                UM.isCalendarOpen = true;
            }
            else
            {
                MessageBox.Show("Каледнарь для выбора дня уже открыт!", "Сообщение системы", MessageBoxButton.OK,
                    MessageBoxImage.Error);
            }
        }

        private void Goods_OnClick(object sender, RoutedEventArgs e)
        {
            UM.GoInside(this, new GoodsList());
        }

        private void Reports_OnClick(object sender, RoutedEventArgs e)
        {
            UM.GoInside(this, new ReportMenu());
        }

        private void Exit_OnClick(object sender, RoutedEventArgs e)
        {
            UM.CloseApp(this);
        }

        private void ClientBase_OnClick(object sender, RoutedEventArgs e)
        {
            UM.GoInside(this, new ClientBase());
        }
    }
}