#pragma checksum "..\..\..\..\Windows\Goods\GoodsEditor.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "594B4DF674B778C18B247BA9379A117FD6927078"
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
    /// GoodsEditor
    /// </summary>
    public partial class GoodsEditor : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 30 "..\..\..\..\Windows\Goods\GoodsEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid GoodsList;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\..\Windows\Goods\GoodsEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CategoryCombo;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\..\..\Windows\Goods\GoodsEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Save;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\..\..\Windows\Goods\GoodsEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeleteMistake;
        
        #line default
        #line hidden
        
        
        #line 92 "..\..\..\..\Windows\Goods\GoodsEditor.xaml"
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
            System.Uri resourceLocater = new System.Uri("/AestheticService;component/windows/goods/goodseditor.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Windows\Goods\GoodsEditor.xaml"
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
            
            #line 18 "..\..\..\..\Windows\Goods\GoodsEditor.xaml"
            ((AestheticService.GoodsEditor)(target)).Closed += new System.EventHandler(this.GoodsEditor_OnClosed);
            
            #line default
            #line hidden
            return;
            case 2:
            this.GoodsList = ((System.Windows.Controls.DataGrid)(target));
            
            #line 33 "..\..\..\..\Windows\Goods\GoodsEditor.xaml"
            this.GoodsList.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.GoodsList_OnSelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.CategoryCombo = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.Save = ((System.Windows.Controls.Button)(target));
            
            #line 83 "..\..\..\..\Windows\Goods\GoodsEditor.xaml"
            this.Save.Click += new System.Windows.RoutedEventHandler(this.Save_OnClick);
            
            #line default
            #line hidden
            return;
            case 5:
            this.DeleteMistake = ((System.Windows.Controls.Button)(target));
            
            #line 89 "..\..\..\..\Windows\Goods\GoodsEditor.xaml"
            this.DeleteMistake.Click += new System.Windows.RoutedEventHandler(this.DeleteMistake_OnClick);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Back = ((System.Windows.Controls.Button)(target));
            
            #line 95 "..\..\..\..\Windows\Goods\GoodsEditor.xaml"
            this.Back.Click += new System.Windows.RoutedEventHandler(this.Back_OnClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

