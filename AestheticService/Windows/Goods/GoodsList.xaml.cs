using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using AestheticService.Models;


namespace AestheticService
{
    public partial class GoodsList : Window
    {
        public GoodsList()
        {
            InitializeComponent();
            UpdateDataGrid();
            LocaleDatePicker.SelectedDate = DateTime.Now;
            ConsumptionDatePicker.SelectedDate = DateTime.Now;
        }

        private void UpdateDataGrid()
        {
            GoodsDataGrid.ItemsSource = UM.db.Goods.ToList();

            var goodsNames = UM.db.Goods.Select(item => item.name).ToList();
            goodsNames.Sort((a, b) => a.CompareTo(b));
            NameField.ItemsSource = goodsNames;

            var categoryItems = UM.db.Goods.Select(goods => goods.category).Distinct().ToList();
            categoryItems.Sort((a, b) => a.CompareTo(b));
            CategoryField.ItemsSource = categoryItems;
            CategorySearchCombo.ItemsSource = categoryItems;

            var suppliers = UM.db.Goods.Select(item => item.supplier).Distinct().ToList();
            suppliers.Sort((a, b) => a.CompareTo(b));
            SupplierCombo.ItemsSource = suppliers;
        }

        private void EditGoods_OnClick(object sender, RoutedEventArgs e)
        {
            UM.GoInside(this, new GoodsEditor());
        }

        private void ArrivalBtn_OnClick(object sender, RoutedEventArgs e)
        {
            ArrivalDialogHost.IsOpen = true;
            DataContext = new goods();
        }

        private void ConsumptionBtn_OnClick(object sender, RoutedEventArgs e)
        {
            ConsumptionDialogHost.IsOpen = true;
        }

        private void CancelBtn_OnClick(object sender, RoutedEventArgs e)
        {
            ArrivalDialogHost.IsOpen = false;
        }

        private void GoodsList_OnClosed(object sender, EventArgs e)
        {
            UM.CloseApp(this);
        }

        private void CreateArrivalBtn_OnClick(object sender, RoutedEventArgs e)
        {
            var newGoods = DataContext as goods;
            StringBuilder errors = new StringBuilder();

            if (String.IsNullOrEmpty(newGoods.name))
            {
                errors.AppendLine("Заполните наименование.");
            }

            if (String.IsNullOrEmpty(PriceField.Text))
            {
                errors.AppendLine("Заполните цену единицу (в рублях).");
            }

            if (String.IsNullOrEmpty(newGoods.count.ToString()))
            {
                errors.AppendLine("Заполните количество.");
            }

            if (String.IsNullOrEmpty(newGoods.supplier))
            {
                errors.AppendLine("Заполните поставщика.");
            }

            if (LocaleDatePicker.SelectedDate == null)
            {
                errors.AppendLine("Заполните дату.");
            }

            if (String.IsNullOrEmpty(newGoods.category))
            {
                errors.AppendLine("Заполните категорию.");
            }


            if (errors.Length == 0)
            {
                int price = Convert.ToInt32(PriceField.Text);

                var existingGoods = UM.db.Goods.Where(goods => goods.name == newGoods.name).ToList();
                if (existingGoods.Count > 0)
                {
                    var existingGood = existingGoods.First();
                    if (newGoods != null)
                    {
                        existingGood.count += newGoods.count;
                        existingGood.supplier = newGoods.supplier;
                    }
                }
                else
                {
                    UM.db.Goods.Add(newGoods);
                }


                UM.db.Goods_oborot.Add(new goods_oborot()
                {
                    name = newGoods.name, action = "arrival", cost = newGoods.count * price,
                    supplier = newGoods.supplier,
                    date = LocaleDatePicker.SelectedDate.Value.ToShortDateString(), count = newGoods.count
                });

                try
                {
                    UM.db.SaveChanges();
                    UpdateDataGrid();
                    ArrivalDialogHost.IsOpen = false;
                    LocaleDatePicker.SelectedDate = DateTime.Now;

                    MessageBox.Show("Поставка сохранена!");
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.InnerException.Message + " " + exception.StackTrace);
                }
            }
            else
            {
                MessageBox.Show(errors.ToString());
            }
        }

        private void CreateConsumptionBtn_OnClick(object sender, RoutedEventArgs e)
        {
            if (GoodsDataGrid.SelectedItem != null)
            {
                var selectedGoods = GoodsDataGrid.SelectedItem as goods;
                int inputVaule = Convert.ToInt32(ConsumptionCountField.Text);
                if (selectedGoods.count >= inputVaule)
                {
                    selectedGoods.count -= inputVaule;
                    ConsumptionDialogHost.IsOpen = false;
                    UM.db.Goods_oborot.Add(new goods_oborot()
                    {
                        name = selectedGoods.name, action = "consumption",
                        count = Convert.ToInt32(ConsumptionCountField.Text),
                        comment = ReasonField.Text, date = ConsumptionDatePicker.Text
                    });
                    try
                    {
                        UM.db.SaveChanges();
                        CountField.Text = "";
                        UpdateDataGrid();
                        MessageBox.Show("Расход выполнен успешно!");
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.InnerException.Message + " " + exception.StackTrace);
                    }
                }
                else
                {
                    MessageBox.Show("Указаное значение больше остатка!", "Ошибка");
                }
            }
            else

            {
                MessageBox.Show("Выберите строку!", "Ошибка");
            }
        }

        private void CancelConsumptionBtn_OnClick(object sender, RoutedEventArgs e)
        {
            ConsumptionDialogHost.IsOpen = false;
        }

        private void BackBtn_OnClick(object sender, RoutedEventArgs e)
        {
            UM.GoBack(this);
        }

        private void SearchBtn_OnClick(object sender, RoutedEventArgs e)
        {
            Search();
        }

        private void NameSearchField_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            Search();
        }

        void Search()
        {
            
            GoodsDataGrid.ItemsSource = UM.db.Goods.Where(item =>
                (CategorySearchCombo.SelectedItem == null || 
                 item.category.Contains(CategorySearchCombo.SelectedItem as string)) &&
                (!String.IsNullOrEmpty(NameField.Text) || item.name.Contains(NameSearchField.Text))
            ).ToList();
        }

        private void CategorySearchCombo_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Search();
        }
    }
}