﻿#pragma checksum "..\..\..\..\Windows\Appointment\AppointmentCalendar.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5AEBB2C5EC58024C2781C821517910E32547A865486DB0E404FB5AE316FBBF38"
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
    /// AppointmentCalendar
    /// </summary>
    public partial class AppointmentCalendar : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 26 "..\..\..\..\Windows\Appointment\AppointmentCalendar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Calendar MaterialCalendar;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\Windows\Appointment\AppointmentCalendar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Back;
        
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
            System.Uri resourceLocater = new System.Uri("/AestheticService;component/windows/appointment/appointmentcalendar.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Windows\Appointment\AppointmentCalendar.xaml"
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
            
            #line 18 "..\..\..\..\Windows\Appointment\AppointmentCalendar.xaml"
            ((AestheticService.AppointmentCalendar)(target)).Closed += new System.EventHandler(this.PriemsCalendar_OnClosed);
            
            #line default
            #line hidden
            return;
            case 2:
            this.MaterialCalendar = ((System.Windows.Controls.Calendar)(target));
            
            #line 27 "..\..\..\..\Windows\Appointment\AppointmentCalendar.xaml"
            this.MaterialCalendar.SelectedDatesChanged += new System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>(this.MaterialCalendar_OnSelectedDatesChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Back = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\..\..\Windows\Appointment\AppointmentCalendar.xaml"
            this.Back.Click += new System.Windows.RoutedEventHandler(this.Back_OnClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

