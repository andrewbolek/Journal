﻿#pragma checksum "..\..\View.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "927202C9D23DA23C63E9EEC4116565E825E31119"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Journal;
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


namespace Journal {
    
    
    /// <summary>
    /// View
    /// </summary>
    public partial class View : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\View.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Go;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\View.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button back;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\View.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox titles;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\View.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox titleName;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\View.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox entry;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\View.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox date;
        
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
            System.Uri resourceLocater = new System.Uri("/Journal;component/view.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\View.xaml"
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
            this.Go = ((System.Windows.Controls.Button)(target));
            
            #line 10 "..\..\View.xaml"
            this.Go.Click += new System.Windows.RoutedEventHandler(this.GoClick);
            
            #line default
            #line hidden
            return;
            case 2:
            this.back = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\View.xaml"
            this.back.Click += new System.Windows.RoutedEventHandler(this.Back);
            
            #line default
            #line hidden
            return;
            case 3:
            this.titles = ((System.Windows.Controls.TextBox)(target));
            
            #line 12 "..\..\View.xaml"
            this.titles.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Titles);
            
            #line default
            #line hidden
            return;
            case 4:
            this.titleName = ((System.Windows.Controls.TextBox)(target));
            
            #line 14 "..\..\View.xaml"
            this.titleName.TextInput += new System.Windows.Input.TextCompositionEventHandler(this.TitleName);
            
            #line default
            #line hidden
            return;
            case 5:
            this.entry = ((System.Windows.Controls.TextBox)(target));
            
            #line 16 "..\..\View.xaml"
            this.entry.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Entry);
            
            #line default
            #line hidden
            return;
            case 6:
            this.date = ((System.Windows.Controls.TextBox)(target));
            
            #line 17 "..\..\View.xaml"
            this.date.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Date);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
