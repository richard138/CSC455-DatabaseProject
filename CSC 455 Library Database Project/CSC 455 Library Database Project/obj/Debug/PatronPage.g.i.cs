﻿#pragma checksum "..\..\PatronPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "B0023AFDCD46A42A07450FAB85F34FB26F17ACDB"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using CSC_455_Library_Database_Project;
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


namespace CSC_455_Library_Database_Project {
    
    
    /// <summary>
    /// PatronPage
    /// </summary>
    public partial class PatronPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\PatronPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid ___No_Name__No_Name_;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\PatronPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button pay_fine_button;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\PatronPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button return_books_button;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\PatronPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button logout_button;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\PatronPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button view_checked_out_books;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\PatronPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button search_button;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\PatronPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button clear_search_button_Copy;
        
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
            System.Uri resourceLocater = new System.Uri("/CSC 455 Library Database Project;component/patronpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\PatronPage.xaml"
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
            this.___No_Name__No_Name_ = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.pay_fine_button = ((System.Windows.Controls.Button)(target));
            return;
            case 3:
            this.return_books_button = ((System.Windows.Controls.Button)(target));
            return;
            case 4:
            this.logout_button = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\PatronPage.xaml"
            this.logout_button.Click += new System.Windows.RoutedEventHandler(this.logout_button_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.view_checked_out_books = ((System.Windows.Controls.Button)(target));
            return;
            case 6:
            this.search_button = ((System.Windows.Controls.Button)(target));
            return;
            case 7:
            this.clear_search_button_Copy = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

