﻿#pragma checksum "..\..\..\..\Windows\Appointment\AppointmentList.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1F4E9B00C664BA75372F608DBCB2B20B290E973C"
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
    /// AppointmentList
    /// </summary>
    public partial class AppointmentList : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\..\..\Windows\Appointment\AppointmentList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid AppointmentGrid;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\..\Windows\Appointment\AppointmentList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.DialogHost AddDialogHost;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\..\Windows\Appointment\AppointmentList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddPriem;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\..\Windows\Appointment\AppointmentList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EditPriems;
        
        #line default
        #line hidden
        
        
        #line 92 "..\..\..\..\Windows\Appointment\AppointmentList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Was;
        
        #line default
        #line hidden
        
        
        #line 98 "..\..\..\..\Windows\Appointment\AppointmentList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button NotWas;
        
        #line default
        #line hidden
        
        
        #line 104 "..\..\..\..\Windows\Appointment\AppointmentList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Back;
        
        #line default
        #line hidden
        
        
        #line 115 "..\..\..\..\Windows\Appointment\AppointmentList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker DatePicker;
        
        #line default
        #line hidden
        
        
        #line 124 "..\..\..\..\Windows\Appointment\AppointmentList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.TimePicker TimePicker;
        
        #line default
        #line hidden
        
        
        #line 129 "..\..\..\..\Windows\Appointment\AppointmentList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ServiceChoose;
        
        #line default
        #line hidden
        
        
        #line 136 "..\..\..\..\Windows\Appointment\AppointmentList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ClientNameCombo;
        
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
            System.Uri resourceLocater = new System.Uri("/AestheticService;component/windows/appointment/appointmentlist.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Windows\Appointment\AppointmentList.xaml"
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
            
            #line 18 "..\..\..\..\Windows\Appointment\AppointmentList.xaml"
            ((AestheticService.AppointmentList)(target)).Closed += new System.EventHandler(this.PriemList_OnClosed);
            
            #line default
            #line hidden
            return;
            case 2:
            this.AppointmentGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 3:
            this.AddDialogHost = ((MaterialDesignThemes.Wpf.DialogHost)(target));
            return;
            case 4:
            this.AddPriem = ((System.Windows.Controls.Button)(target));
            
            #line 72 "..\..\..\..\Windows\Appointment\AppointmentList.xaml"
            this.AddPriem.Click += new System.Windows.RoutedEventHandler(this.AddPriem_OnClick);
            
            #line default
            #line hidden
            return;
            case 5:
            this.EditPriems = ((System.Windows.Controls.Button)(target));
            
            #line 79 "..\..\..\..\Windows\Appointment\AppointmentList.xaml"
            this.EditPriems.Click += new System.Windows.RoutedEventHandler(this.EditPriems_OnClick);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Was = ((System.Windows.Controls.Button)(target));
            
            #line 94 "..\..\..\..\Windows\Appointment\AppointmentList.xaml"
            this.Was.Click += new System.Windows.RoutedEventHandler(this.Was_OnClick);
            
            #line default
            #line hidden
            return;
            case 7:
            this.NotWas = ((System.Windows.Controls.Button)(target));
            
            #line 100 "..\..\..\..\Windows\Appointment\AppointmentList.xaml"
            this.NotWas.Click += new System.Windows.RoutedEventHandler(this.NotWas_OnClick);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Back = ((System.Windows.Controls.Button)(target));
            
            #line 106 "..\..\..\..\Windows\Appointment\AppointmentList.xaml"
            this.Back.Click += new System.Windows.RoutedEventHandler(this.Back_OnClick);
            
            #line default
            #line hidden
            return;
            case 9:
            this.DatePicker = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 10:
            this.TimePicker = ((MaterialDesignThemes.Wpf.TimePicker)(target));
            return;
            case 11:
            this.ServiceChoose = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 12:
            this.ClientNameCombo = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 13:
            
            #line 144 "..\..\..\..\Windows\Appointment\AppointmentList.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.CreateAppointmentBtn_OnClick);
            
            #line default
            #line hidden
            return;
            case 14:
            
            #line 149 "..\..\..\..\Windows\Appointment\AppointmentList.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.CancelBtn_OnClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

