﻿#pragma checksum "..\..\..\Pages\ReturnBooksPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9C00AF1DA2520F99617D68D85D770AB61D7B8081"
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
    /// ReturnBooksPage
    /// </summary>
    public partial class ReturnBooksPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\..\Pages\ReturnBooksPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button pay_fine_button;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Pages\ReturnBooksPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Home_button;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\Pages\ReturnBooksPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button logout_button;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\Pages\ReturnBooksPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button view_checked_out_books;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\Pages\ReturnBooksPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button search_button;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\Pages\ReturnBooksPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button return_books_button;
        
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
            System.Uri resourceLocater = new System.Uri("/CSC 455 Library Database Project;component/pages/returnbookspage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\ReturnBooksPage.xaml"
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
            this.pay_fine_button = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\Pages\ReturnBooksPage.xaml"
            this.pay_fine_button.Click += new System.Windows.RoutedEventHandler(this.Pay_fine_button_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Home_button = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\Pages\ReturnBooksPage.xaml"
            this.Home_button.Click += new System.Windows.RoutedEventHandler(this.Home_button_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.logout_button = ((System.Windows.Controls.Button)(target));
            return;
            case 4:
            this.view_checked_out_books = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\..\Pages\ReturnBooksPage.xaml"
            this.view_checked_out_books.Click += new System.Windows.RoutedEventHandler(this.View_checked_out_books_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.search_button = ((System.Windows.Controls.Button)(target));
            return;
            case 6:
            this.return_books_button = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

