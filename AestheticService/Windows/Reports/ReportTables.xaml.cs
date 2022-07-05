using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using AestheticService.Models;
using Microsoft.Win32;
using OfficeOpenXml;
using LiveCharts;
using LiveCharts.Wpf;
using OfficeOpenXml.FormulaParsing;
using OfficeOpenXml.Style;

namespace AestheticService
{
    public partial class ReportTables : Page
    {
        private bool _type;
        private DateTime _fromDate, _toDate;
        private List<priems> arrivalData = null;
        private List<goods_oborot> spendingData = null;
        private float totalReport;
        private string favoriteReport;


        public ReportTables(DateTime fromDate, DateTime toDate, bool type)
        {
            InitializeComponent();

            _type = type;
            _fromDate = fromDate;
            _toDate = toDate;

            IncomeReportDataGrid.Visibility = Visibility.Collapsed;
            SpendingReportDataGrid.Visibility = Visibility.Collapsed;
            int sum = 0, maxCount;
            string maxValue;

            switch (_type)
            {
                case true:

                    IncomeReportDataGrid.Visibility = Visibility.Visible;
                    var reportData = UM.db.Priems.ToList().Where(appointment =>
                        appointment.was == 1 && DateTime.Parse(appointment.date) >= fromDate &&
                        DateTime.Parse(appointment.date) <= toDate).ToList();
                    IncomeReportDataGrid.ItemsSource = reportData;
                    arrivalData = reportData;
                    var reportServices = reportData.Select(item => item.service).ToList();

                    foreach (priems priems in reportData)
                    {
                        foreach (var service in UM.db.Preyskurant.ToList())
                        {
                            if (service.name.Contains(priems.service))
                            {
                                sum += service.price;
                                break;
                            }
                        }
                    }


                    maxValue = "";
                    maxCount = 0;
                    foreach (var service in reportServices.Distinct())
                    {
                        int curCount = reportData.Count(appointment => appointment.service == service);
                        if (curCount > maxCount)
                        {
                            maxCount = curCount;
                            maxValue = service;
                        }
                    }

                    PopularReport.Text = maxValue;
                    favoriteReport = maxValue;
                    ResultReport.Text = sum + " рублей.";
                    totalReport = sum;

                    break;
                case false:
                    SpendingReportDataGrid.Visibility = Visibility.Visible;
                    PopularReport.Visibility = Visibility.Hidden;
                    var resultCirculate = UM.db.Goods_oborot.ToList().Where(arrive =>
                        arrive.action == "arrival" && DateTime.Parse(arrive.date) >= fromDate &&
                        DateTime.Parse(arrive.date) <= toDate).ToList();
                    SpendingReportDataGrid.ItemsSource = resultCirculate;
                    spendingData = resultCirculate;
                    foreach (goods_oborot circulate in resultCirculate)
                    {
                        sum += circulate.cost;
                    }

                    ResultReport.Text = sum + " рублей.";
                    totalReport = sum;
                    break;
            }

            // Построение графиков
            List<priems> arrivalDataDiagram = UM.db.Priems.ToList().Where(appointment =>
                appointment.was == 1 && DateTime.Parse(appointment.date) >= fromDate &&
                DateTime.Parse(appointment.date) <= toDate).ToList();
            List<goods_oborot> spendingDataDiagram = UM.db.Goods_oborot.ToList().Where(arrive =>
                arrive.action == "arrival" && DateTime.Parse(arrive.date) >= fromDate &&
                DateTime.Parse(arrive.date) <= toDate).ToList();
            List<preyskurant> servicesDiagram = UM.db.Preyskurant.ToList();

            List<string> dates = new List<string>();
            dates.AddRange(arrivalDataDiagram.Select(item => item.date));
            dates.AddRange(spendingDataDiagram.Select(item => item.date));

            dates = dates.Distinct().ToList();
            List<DateTime> trueDates = new List<DateTime>();
            foreach (string date in dates)
            {
                trueDates.Add(DateTime.Parse(date));
            }

            trueDates.Sort((DateTime time, DateTime dateTime) => time.CompareTo(dateTime));
            // dates.Sort((s, s1) => s.CompareTo(s1));
            dates.Clear();
            foreach (DateTime date in trueDates)
            {
                dates.Add(date.ToShortDateString());
            }

            _dates = dates;
            _arrivalDataDiagram = arrivalDataDiagram;
            _servicesDiagram = servicesDiagram;
            _spendingDataDiagram = spendingDataDiagram;
            SeriesCollection = new SeriesCollection();
            Labels = new string[] { };
            try
            {
                if (dates.Count < 365)
                {
                    if (dates.Count < 31)
                    {
                        ReportForDays();
                    }
                    else
                    {
                        ReportForMonth();
                    }
                }
                else
                {
                    ReportForYear();
                }
            }
            catch (Exception)
            {
                
            }

            DataContext = this;
        }

        private List<string> _dates;
        private List<priems> _arrivalDataDiagram;
        private List<preyskurant> _servicesDiagram;
        private List<goods_oborot> _spendingDataDiagram;

        void ReportForYear()
        {
            List<string> years = new List<string>();
            SeriesCollection.Clear();
            // ReportDiagram.Width = dates.Count * 60;
            ChartValues<int> arrivalSums = new ChartValues<int>();
            ChartValues<int> spendingSums = new ChartValues<int>();

            var curYear = _dates.First().Substring(5);
            var dateParts = _dates.First().Split('.');
            years.Add($"{dateParts[2]} г.");
            int yearArrivalSum = 0, yearSpendingSum = 0;
            foreach (string date in _dates)
            {
                if (!date.Contains(curYear))
                {
                    curYear = date.Substring(5);
                    dateParts = date.Split('.');
                    years.Add($"{dateParts[2]} г.");
                    arrivalSums.Add(yearArrivalSum);
                    spendingSums.Add(yearSpendingSum);
                    yearArrivalSum = 0;
                    yearSpendingSum = 0;
                }

                if (date.Contains(curYear))
                {
                    //adding series will update and animate the chart automatically
                    _arrivalDataDiagram.ForEach(arrival =>
                    {
                        if (arrival.date.Contains(date))
                        {
                            try
                            {
                                yearArrivalSum += _servicesDiagram.First(i => i.name.Contains(arrival.service)).price;
                            }
                            catch (Exception)
                            {
                            }
                        }
                    });
                    _spendingDataDiagram.ForEach(spending =>
                    {
                        if (spending.date.Contains(date))
                        {
                            yearSpendingSum += spending.cost;
                        }
                    });
                }
            }

            if (yearSpendingSum != 0 || yearArrivalSum != 0)
            {
                years.Add($"{monthsList[int.Parse(dateParts[1]) - 1]} {dateParts[2]} г.");
                arrivalSums.Add(yearArrivalSum);
                spendingSums.Add(yearSpendingSum);
                yearArrivalSum = 0;
                yearSpendingSum = 0;
            }

            // SeriesCollection.Add(new ColumnSeries()
            // {
            //     Title = "Доход",
            //     Values = arrivalSums,
            //     DataLabels = true,
            //     LabelPoint = point => point.Y + ""
            // });
            // SeriesCollection.Add(new ColumnSeries()
            // {
            //     Title = "Расход",
            //     Values = spendingSums,
            //     DataLabels = true,
            //     LabelPoint = point => point.Y + ""
            // });
            SeriesCollection.Add(new LineSeries()
            {
                Title = "Доход",
                Values = arrivalSums,
                DataLabels = true,
                LabelPoint = point => point.Y + ""
            });
            SeriesCollection.Add(new LineSeries()
            {
                Title = "Расход",
                Values = spendingSums,
                DataLabels = true,
                LabelPoint = point => point.Y + ""
            });


            ReportDiagram.Width = years.Count * 120;
            Labels = years.ToArray(); // Нужно заносить месяца
            LabelsObj.Labels = Labels;
            Formatter = value => value.ToString("N");
        }

        private string[] monthsList =
        {
            "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Авгсут", "Сентябрь", "Октябрь", "Ноябрь",
            "Декабрь"
        };

        void ReportForMonth()
        {
            List<string> months = new List<string>();
            SeriesCollection.Clear();
            ChartValues<int> arrivalSums = new ChartValues<int>();
            ChartValues<int> spendingSums = new ChartValues<int>();

            var curMonth = _dates.First().Substring(2);
            var dateParts = _dates.First().Split('.');
            months.Add($"{monthsList[int.Parse(dateParts[1]) - 1]} {dateParts[2]} г.");
            int monthArrivalSum = 0, monthSpendingSum = 0;
            foreach (string date in _dates)
            {
                if (!date.Contains(curMonth))
                {
                    curMonth = date.Substring(2);
                    dateParts = date.Split('.');
                    months.Add($"{monthsList[int.Parse(dateParts[1]) - 1]} {dateParts[2]} г.");
                    arrivalSums.Add(monthArrivalSum);
                    spendingSums.Add(monthSpendingSum);
                    monthArrivalSum = 0;
                    monthSpendingSum = 0;
                }

                if (date.Contains(curMonth))
                {
                    //adding series will update and animate the chart automatically
                    _arrivalDataDiagram.ForEach(arrival =>
                    {
                        if (arrival.date.Contains(date))
                        {
                            try
                            {
                                monthArrivalSum += _servicesDiagram.First(i => i.name.Contains(arrival.service)).price;
                            }
                            catch (Exception)
                            {
                            }
                        }
                    });
                    _spendingDataDiagram.ForEach(spending =>
                    {
                        if (spending.date.Contains(date))
                        {
                            monthSpendingSum += spending.cost;
                        }
                    });
                }
            }

            if (monthSpendingSum != 0 || monthArrivalSum != 0)
            {
                months.Add($"{monthsList[int.Parse(dateParts[1]) - 1]} {dateParts[2]} г.");
                arrivalSums.Add(monthArrivalSum);
                spendingSums.Add(monthSpendingSum);
                monthArrivalSum = 0;
                monthSpendingSum = 0;
            }

            // SeriesCollection.Add(new ColumnSeries()
            // {
            //     Title = "Доход",
            //     Values = arrivalSums,
            //     DataLabels = true,
            //     LabelPoint = point => point.Y + ""
            // });
            // SeriesCollection.Add(new ColumnSeries()
            // {
            //     Title = "Расход",
            //     Values = spendingSums,
            //     DataLabels = true,
            //     LabelPoint = point => point.Y + ""
            // });
            SeriesCollection.Add(new LineSeries()
            {
                Title = "Доход",
                Values = arrivalSums,
                DataLabels = true,
                LabelPoint = point => point.Y + ""
            });
            SeriesCollection.Add(new LineSeries()
            {
                Title = "Расход",
                Values = spendingSums,
                DataLabels = true,
                LabelPoint = point => point.Y + ""
            });

            ReportDiagram.Width = 120+months.Count * 60;
            Labels = months.ToArray(); // Нужно заносить месяца
            LabelsObj.Labels = Labels;
            Formatter = value => value.ToString("N");
        }

        void ReportForDays()
        {
            SeriesCollection.Clear();
            ReportDiagram.Width = _dates.Count * 60;
            ChartValues<int> arrivalSums = new ChartValues<int>();
            ChartValues<int> spendingSums = new ChartValues<int>();
            foreach (string date in _dates)
            {
                //adding series will update and animate the chart automatically
                int sumArrival = 0;
                int sumSpending = 0;
                _arrivalDataDiagram.ForEach(arrival =>
                {
                    if (arrival.date.Contains(date))
                    {
                        try
                        {
                            sumArrival += _servicesDiagram.First(i => i.name.Contains(arrival.service)).price;
                        }
                        catch (Exception)
                        {
                        }
                    }
                });
                arrivalSums.Add(sumArrival);
                _spendingDataDiagram.ForEach(spending =>
                {
                    if (spending.date.Contains(date))
                    {
                        sumSpending += spending.cost;
                    }
                });
                spendingSums.Add(sumSpending);
            }

            // SeriesCollection.Add(new ColumnSeries()
            // {
            //     Title = "Доход",
            //     Values = arrivalSums,
            //     DataLabels = true,
            //     LabelPoint = point => point.Y + ""
            // });
            // SeriesCollection.Add(new ColumnSeries()
            // {
            //     Title = "Расход",
            //     Values = spendingSums,
            //     DataLabels = true,
            //     LabelPoint = point => point.Y + ""
            // });

            SeriesCollection.Add(new LineSeries()
            {
                Title = "Доход",
                Values = arrivalSums,
                DataLabels = true,
                LabelPoint = point => point.Y + ""
            });
            SeriesCollection.Add(new LineSeries()
            {
                Title = "Расход",
                Values = spendingSums,
                DataLabels = true,
                LabelPoint = point => point.Y + ""
            });


            
            Labels = _dates.ToArray();
            LabelsObj.Labels = Labels;
            Formatter = value => value.ToString("N");
        }

        private void ExportReportBtn_OnClick(object sender, RoutedEventArgs e)
        {
            string filePath;
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            SaveFileDialog OPF = new SaveFileDialog();
            OPF.Filter = "Файлы xls|*.xls|Файлы xlsx|*.xlsx|Все файлы|*.*";
            if (OPF.ShowDialog().Value)
            {
                filePath = OPF.FileName;
                ExcelWorksheet sheet;
                ExcelPackage report;
                if (_type)
                {
                    report = new ExcelPackage(new FileInfo(@"..\..\Resources\ReportTemplates\Arrival.xlsx"));
                    sheet = report.Workbook.Worksheets.Copy("Asset", "Отчёт по доходам");
                }
                else
                {
                    report = new ExcelPackage(new FileInfo(@"..\..\Resources\ReportTemplates\Spending.xlsx"));
                    sheet = report.Workbook.Worksheets.Copy("Asset", "Отчёт по расходам");
                }

                sheet.Cells["A3"].Value = $"с {_fromDate.ToShortDateString()} по {_toDate.ToShortDateString()}";

                int rowIndex = 6;
                if (arrivalData != null)
                {
                    arrivalData.Sort((priems, priems1) => priems.date.CompareTo(priems1.date));
                    foreach (priems arrival in arrivalData)
                    {
                        sheet.Cells["B" + rowIndex].Value = arrival.date;
                        FormatTablePart(sheet.Cells["B" + rowIndex]);
                        sheet.Cells["C" + rowIndex].Value = arrival.time;
                        FormatTablePart(sheet.Cells["C" + rowIndex]);
                        sheet.Cells["D" + rowIndex].Value = arrival.service;
                        sheet.Cells["D" + rowIndex].Style.WrapText = true;
                        FormatTablePart(sheet.Cells["D" + rowIndex]);
                        sheet.Cells["E" + rowIndex].Value = arrival.who_fname+" "+arrival.who_sname;
                        FormatTablePart(sheet.Cells["E" + rowIndex]);
                        rowIndex++;
                    }

                    rowIndex++;
                    ExcelRange cell = sheet.Cells["C" + rowIndex];
                    cell.Value = "ИТОГ:";
                    UnderLine(cell);
                    HorizontalRight(cell);
                    VerticalCenter(cell);

                    cell = sheet.Cells["D" + rowIndex];
                    cell.Value = totalReport + " рублей.";
                    UnderLine(cell);
                    HorizontalLeft(cell);
                    VerticalCenter(cell);

                    rowIndex++;
                    cell = sheet.Cells["B" + rowIndex];
                    cell.Value = "Самое популярное:";
                    UnderLine(cell);
                    VerticalCenter(cell);

                    cell = sheet.Cells["D" + rowIndex];
                    cell.Value = favoriteReport;
                    UnderLine(cell);
                    HorizontalLeft(cell);
                    VerticalCenter(cell);
                }

                if (spendingData != null)
                {
                    spendingData.Sort((priems, priems1) => priems.date.CompareTo(priems1.date));
                    foreach (goods_oborot spending in spendingData)
                    {
                        sheet.Cells["B" + rowIndex].Value = spending.name;
                        sheet.Cells["B" + rowIndex].Style.WrapText = true;
                        FormatTablePart(sheet.Cells["B" + rowIndex]);
                        sheet.Cells["C" + rowIndex].Value = spending.date;
                        FormatTablePart(sheet.Cells["C" + rowIndex]);
                        sheet.Cells["D" + rowIndex].Value = spending.supplier;
                        FormatTablePart(sheet.Cells["D" + rowIndex]);
                        sheet.Cells["E" + rowIndex].Value = spending.count;
                        FormatTablePart(sheet.Cells["E" + rowIndex]);
                        sheet.Cells["F" + rowIndex].Value = spending.cost;
                        FormatTablePart(sheet.Cells["F" + rowIndex]);

                        rowIndex++;
                    }

                    rowIndex++;
                    ExcelRange cell = sheet.Cells["C" + rowIndex];
                    cell.Value = "ИТОГ:";
                    UnderLine(cell);
                    HorizontalRight(cell);
                    VerticalCenter(cell);

                    cell = sheet.Cells["D" + rowIndex];
                    cell.Value = totalReport + " рублей.";
                    UnderLine(cell);
                    HorizontalLeft(cell);
                    VerticalCenter(cell);
                }


                report.Workbook.Worksheets.Delete("Asset");
                File.WriteAllBytes(filePath, report.GetAsByteArray());
                MessageBox.Show("Экспорт выполнен!");
            }
        }

        void FormatTablePart(ExcelRange cell)
        {
            cell.Style.Border.BorderAround(ExcelBorderStyle.Thin);
            cell.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            VerticalCenter(cell);
        }

        void VerticalCenter(ExcelRange cell)
        {
            cell.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
        }

        void HorizontalLeft(ExcelRange cell)
        {
            cell.Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
        }

        void HorizontalRight(ExcelRange cell)
        {
            cell.Style.HorizontalAlignment = ExcelHorizontalAlignment.Right;
        }

        void UnderLine(ExcelRange cell)
        {
            cell.Style.Font.UnderLine = true;
        }

        public SeriesCollection SeriesCollection { get; set; }
        public string[] Labels { get; set; }
        public Func<double, string> Formatter { get; set; }

        private void DaysDiagram_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                ReportForDays();
            }
            catch (Exception )
            {
                
            }
            
        }

        private void MonthDiagram_OnClick(object sender, RoutedEventArgs e)
        {
            
            try
            {
                ReportForMonth();
            }
            catch (Exception )
            {
                
            }
        }

        private void YearDiagram_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                ReportForYear();
            }
            catch (Exception )
            {
                
            }
        }
    }
}