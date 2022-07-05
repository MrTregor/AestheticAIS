using System.Threading;
using System.Windows;
using AestheticService.Models;
using DBConnect;

namespace AestheticService
{
    public static class UM
    {
        public static MobileContext db = new MobileContext();
        public static SQLiteConnect DB = new SQLiteConnect();
        public static Window MainWindow;
        public static bool isCalendarOpen = false;

        public static void GoInside(Window from, Window to)
        {
            to.Owner = from;
            to.Show();
            from.Hide();
        }

        public static void GoBack(Window from)
        {
            from.Owner.Show();
            from.Hide();
            from.Close();
        }

        public static void CloseApp(Window what)
        {
            if (what.Visibility != Visibility.Hidden)
            {
                Application.Current.Shutdown(101);
            }
        }

        public static string Ecron(string str)
        {
            str = str.Replace("\"", "\"\"");
            return str;
        }

        public static void ErrorMessage(string message)
        {
            MessageBox.Show(message, "Сообщение об ошибке",
                MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}