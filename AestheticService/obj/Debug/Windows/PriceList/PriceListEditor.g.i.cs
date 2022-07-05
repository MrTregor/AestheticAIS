﻿#pragma checksum "..\..\..\..\Windows\PriceList\PriceListEditor.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "78BD1B9F36C8FAFF9AE452DEC9BCBDA4D36CA5EA9C4DFA02DFEB83ECCEEE8653"
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
    /// PriceListEditor
    /// </summary>
    public partial class PriceListEditor : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 29 "..\..\..\..\Windows\PriceList\PriceListEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DataGrid;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\..\Windows\PriceList\PriceListEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ServiceNameSearchText;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\..\Windows\PriceList\PriceListEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CategorySearchCombo;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\..\..\Windows\PriceList\PriceListEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ServicesCombo;
        
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
            System.Uri resourceLocater = new System.Uri("/AestheticService;component/windows/pricelist/pricelisteditor.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Windows\PriceList\PriceListEditor.xaml"
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
            
            #line 15 "..\..\..\..\Windows\PriceList\PriceListEditor.xaml"
            ((AestheticService.PriceListEditor)(target)).Closed += new System.EventHandler(this.PreyskurantEditor_OnClosed);
            
            #line default
            #line hidden
            return;
            case 2:
            this.DataGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 32 "..\..\..\..\Windows\PriceList\PriceListEditor.xaml"
            this.DataGrid.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.DataGrid_OnSelected);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ServiceNameSearchText = ((System.Windows.Controls.TextBox)(target));
            
            #line 66 "..\..\..\..\Windows\PriceList\PriceListEditor.xaml"
            this.ServiceNameSearchText.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.ServiceNameSearchText_OnTextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.CategorySearchCombo = ((System.Windows.Controls.ComboBox)(target));
            
            #line 70 "..\..\..\..\Windows\PriceList\PriceListEditor.xaml"
            this.CategorySearchCombo.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CategorySearchCombo_OnSelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 74 "..\..\..\..\Windows\PriceList\PriceListEditor.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SearchBtn_OnClick);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ServicesCombo = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            
            #line 98 "..\..\..\..\Windows\PriceList\PriceListEditor.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Save_OnClick);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 102 "..\..\..\..\Windows\PriceList\PriceListEditor.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AddBtn_OnClick);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 106 "..\..\..\..\Windows\PriceList\PriceListEditor.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.DeleteBtn_OnClick);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 110 "..\..\..\..\Windows\PriceList\PriceListEditor.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Back_OnClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
