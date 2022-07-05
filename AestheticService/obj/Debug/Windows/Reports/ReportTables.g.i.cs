﻿#pragma checksum "..\..\..\..\Windows\Reports\ReportTables.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D3447F1B3F1F1C1A98BC35BED85FBE6D967C29448ED1674F2D113E474250461C"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using AestheticService;
using LiveCharts.Wpf;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace AestheticService {
    
    
    /// <summary>
    /// ReportTables
    /// </summary>
    public partial class ReportTables : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 27 "..\..\..\..\Windows\Reports\ReportTables.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid IncomeReportDataGrid;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\..\Windows\Reports\ReportTables.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid SpendingReportDataGrid;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\..\..\Windows\Reports\ReportTables.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ResultReport;
        
        #line default
        #line hidden
        
        
        #line 109 "..\..\..\..\Windows\Reports\ReportTables.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PopularReport;
        
        #line default
        #line hidden
        
        
        #line 136 "..\..\..\..\Windows\Reports\ReportTables.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal LiveCharts.Wpf.CartesianChart ReportDiagram;
        
        #line default
        #line hidden
        
        
        #line 138 "..\..\..\..\Windows\Reports\ReportTables.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal LiveCharts.Wpf.Axis LabelsObj;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/AestheticService;component/windows/reports/reporttables.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Windows\Reports\ReportTables.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.IncomeReportDataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.SpendingReportDataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 3:
            this.ResultReport = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.PopularReport = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            
            #line 114 "..\..\..\..\Windows\Reports\ReportTables.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ExportReportBtn_OnClick);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 121 "..\..\..\..\Windows\Reports\ReportTables.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.DaysDiagram_OnClick);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 126 "..\..\..\..\Windows\Reports\ReportTables.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.MonthDiagram_OnClick);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 131 "..\..\..\..\Windows\Reports\ReportTables.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.YearDiagram_OnClick);
            
            #line default
            #line hidden
            return;
            case 9:
            this.ReportDiagram = ((LiveCharts.Wpf.CartesianChart)(target));
            return;
            case 10:
            this.LabelsObj = ((LiveCharts.Wpf.Axis)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

