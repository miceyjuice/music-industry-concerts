﻿#pragma checksum "..\..\..\Windows\MainView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "CD2CD70150E87F5C6C095E0F5243523392F2CFEDF1A254F0E690740BA67ECAD2"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

using MusicIndustryConcerts.Windows;
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


namespace MusicIndustryConcerts.Windows {
    
    
    /// <summary>
    /// MainView
    /// </summary>
    public partial class MainView : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\..\Windows\MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid nav_panel1;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\Windows\MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel panel2;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Windows\MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView menu_list1;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\Windows\MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Home_btn;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\Windows\MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Place_btn;
        
        #line default
        #line hidden
        
        
        #line 99 "..\..\..\Windows\MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Artist_btn;
        
        #line default
        #line hidden
        
        
        #line 126 "..\..\..\Windows\MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Concerts_btn;
        
        #line default
        #line hidden
        
        
        #line 154 "..\..\..\Windows\MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Tickets_btn;
        
        #line default
        #line hidden
        
        
        #line 182 "..\..\..\Windows\MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Close_btn;
        
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
            System.Uri resourceLocater = new System.Uri("/MusicIndustryConcerts;component/windows/mainview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\MainView.xaml"
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
            this.nav_panel1 = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.panel2 = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 3:
            this.menu_list1 = ((System.Windows.Controls.ListView)(target));
            return;
            case 4:
            this.Home_btn = ((System.Windows.Controls.Button)(target));
            
            #line 48 "..\..\..\Windows\MainView.xaml"
            this.Home_btn.Click += new System.Windows.RoutedEventHandler(this.Home_btn_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Place_btn = ((System.Windows.Controls.Button)(target));
            
            #line 75 "..\..\..\Windows\MainView.xaml"
            this.Place_btn.Click += new System.Windows.RoutedEventHandler(this.Place_btn_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Artist_btn = ((System.Windows.Controls.Button)(target));
            
            #line 102 "..\..\..\Windows\MainView.xaml"
            this.Artist_btn.Click += new System.Windows.RoutedEventHandler(this.Artist_btn_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Concerts_btn = ((System.Windows.Controls.Button)(target));
            
            #line 130 "..\..\..\Windows\MainView.xaml"
            this.Concerts_btn.Click += new System.Windows.RoutedEventHandler(this.Concerts_btn_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Tickets_btn = ((System.Windows.Controls.Button)(target));
            
            #line 158 "..\..\..\Windows\MainView.xaml"
            this.Tickets_btn.Click += new System.Windows.RoutedEventHandler(this.Tickets_btn_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.Close_btn = ((System.Windows.Controls.Button)(target));
            
            #line 183 "..\..\..\Windows\MainView.xaml"
            this.Close_btn.Click += new System.Windows.RoutedEventHandler(this.Close_btn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

