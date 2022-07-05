﻿#pragma checksum "..\..\..\..\Windows\PriceList\PriceList.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D9240D52B2A0B62C930DF9BCC702EBE92DE593B5CF3EFE6F18A96D031A8CF107"
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
    /// PriceList
    /// </summary>
    public partial class PriceList : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 36 "..\..\..\..\Windows\PriceList\PriceList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ServiceNameSearchText;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\..\Windows\PriceList\PriceList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CategorySearchCombo;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\..\Windows\PriceList\PriceList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Back;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\..\Windows\PriceList\PriceList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid Preykurant;
        
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
            System.Uri resourceLocater = new System.Uri("/AestheticService;component/windows/pricelist/pricelist.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Windows\PriceList\PriceList.xaml"
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
            
            #line 18 "..\..\..\..\Windows\PriceList\PriceList.xaml"
            ((AestheticService.PriceList)(target)).Closed += new System.EventHandler(this.PriceList_OnClosed);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ServiceNameSearchText = ((System.Windows.Controls.TextBox)(target));
            
            #line 38 "..\..\..\..\Windows\PriceList\PriceList.xaml"
            this.ServiceNameSearchText.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.ServiceNameSearchText_OnTextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.CategorySearchCombo = ((System.Windows.Controls.ComboBox)(target));
            
            #line 41 "..\..\..\..\Windows\PriceList\PriceList.xaml"
            this.CategorySearchCombo.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CategorySearchCombo_OnSelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 45 "..\..\..\..\Windows\PriceList\PriceList.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SearchBtn_OnClick);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 51 "..\..\..\..\Windows\PriceList\PriceList.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.EditorBtn_OnClick);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Back = ((System.Windows.Controls.Button)(target));
            
            #line 57 "..\..\..\..\Windows\PriceList\PriceList.xaml"
            this.Back.Click += new System.Windows.RoutedEventHandler(this.Back_OnClick);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Preykurant = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

