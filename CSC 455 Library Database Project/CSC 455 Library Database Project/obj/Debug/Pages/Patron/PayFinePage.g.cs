﻿#pragma checksum "..\..\..\..\Pages\Patron\PayFinePage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "752594FBD2A7E5D0C47FF58C4CC70EE00F0A4A46"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using CSC_455_Library_Database_Project.Pages;
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


namespace CSC_455_Library_Database_Project.Pages {
    
    
    /// <summary>
    /// PayFinePage
    /// </summary>
    public partial class PayFinePage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\..\..\Pages\Patron\PayFinePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Home_button;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\..\Pages\Patron\PayFinePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button return_books_button;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\..\Pages\Patron\PayFinePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button logout_button;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\..\Pages\Patron\PayFinePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label ___No_Name_;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\..\Pages\Patron\PayFinePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button view_checked_out_books;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\..\Pages\Patron\PayFinePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button process_button;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\..\Pages\Patron\PayFinePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgFines;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\..\Pages\Patron\PayFinePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button pay_fine_button;
        
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
            System.Uri resourceLocater = new System.Uri("/CSC 455 Library Database Project;component/pages/patron/payfinepage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\Patron\PayFinePage.xaml"
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
            this.Home_button = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\..\..\Pages\Patron\PayFinePage.xaml"
            this.Home_button.Click += new System.Windows.RoutedEventHandler(this.Home_button_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.return_books_button = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\..\..\Pages\Patron\PayFinePage.xaml"
            this.return_books_button.Click += new System.Windows.RoutedEventHandler(this.Return_books_button_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.logout_button = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\..\..\Pages\Patron\PayFinePage.xaml"
            this.logout_button.Click += new System.Windows.RoutedEventHandler(this.logout_button_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.___No_Name_ = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.view_checked_out_books = ((System.Windows.Controls.Button)(target));
            
            #line 49 "..\..\..\..\Pages\Patron\PayFinePage.xaml"
            this.view_checked_out_books.Click += new System.Windows.RoutedEventHandler(this.View_checked_out_books_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.process_button = ((System.Windows.Controls.Button)(target));
            return;
            case 7:
            this.dgFines = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 8:
            this.pay_fine_button = ((System.Windows.Controls.Button)(target));
            
            #line 63 "..\..\..\..\Pages\Patron\PayFinePage.xaml"
            this.pay_fine_button.Click += new System.Windows.RoutedEventHandler(this.Pay_fine_button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

