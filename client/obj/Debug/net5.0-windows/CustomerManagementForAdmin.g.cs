﻿#pragma checksum "..\..\..\CustomerManagementForAdmin.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "CB95CD5DEF3333555ABC874554EBF6EB1567B47B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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
using client;


namespace client {
    
    
    /// <summary>
    /// CustomerManagementForAdmin
    /// </summary>
    public partial class CustomerManagementForAdmin : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\..\CustomerManagementForAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid CustomersDG;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\CustomerManagementForAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid CustomersAndMeetingDG;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\CustomerManagementForAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid AddNewCustomerGrid;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\..\CustomerManagementForAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox personalId;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\..\CustomerManagementForAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox firstName;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\..\CustomerManagementForAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox lastName;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\..\CustomerManagementForAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox address;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\..\CustomerManagementForAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BackClick;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.6.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/client;component/customermanagementforadmin.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\CustomerManagementForAdmin.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.6.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.CustomersDG = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.CustomersAndMeetingDG = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 3:
            this.AddNewCustomerGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 4:
            this.personalId = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.firstName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.lastName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.address = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            
            #line 93 "..\..\..\CustomerManagementForAdmin.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AddCustomerClick);
            
            #line default
            #line hidden
            return;
            case 9:
            this.BackClick = ((System.Windows.Controls.Button)(target));
            
            #line 102 "..\..\..\CustomerManagementForAdmin.xaml"
            this.BackClick.Click += new System.Windows.RoutedEventHandler(this.BackClick_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

