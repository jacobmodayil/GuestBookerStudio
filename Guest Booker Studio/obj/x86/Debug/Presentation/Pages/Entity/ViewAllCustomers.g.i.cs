﻿#pragma checksum "..\..\..\..\..\..\Presentation\Pages\Entity\ViewAllCustomers.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "7856CC45A5C1757F654F8440A3C93633"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
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


namespace Guest_Booker_Studio.Presentation.Pages.Entity {
    
    
    /// <summary>
    /// ViewAllCustomers
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
    public partial class ViewAllCustomers : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\..\..\..\Presentation\Pages\Entity\ViewAllCustomers.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border ModalBorder;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\..\..\Presentation\Pages\Entity\ViewAllCustomers.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label viewallcustomerlabel;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\..\..\..\Presentation\Pages\Entity\ViewAllCustomers.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button cmdCancel;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\..\..\Presentation\Pages\Entity\ViewAllCustomers.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid grdNewCustomer;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\..\..\..\Presentation\Pages\Entity\ViewAllCustomers.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid datagrdViewCustomer;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\..\..\..\Presentation\Pages\Entity\ViewAllCustomers.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblCustomerOrg;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\..\..\..\Presentation\Pages\Entity\ViewAllCustomers.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox chkNotActive;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Guest Booker Studio;component/presentation/pages/entity/viewallcustomers.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\Presentation\Pages\Entity\ViewAllCustomers.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.ModalBorder = ((System.Windows.Controls.Border)(target));
            return;
            case 2:
            this.viewallcustomerlabel = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.cmdCancel = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\..\..\..\..\Presentation\Pages\Entity\ViewAllCustomers.xaml"
            this.cmdCancel.Click += new System.Windows.RoutedEventHandler(this.cmdCancelButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.grdNewCustomer = ((System.Windows.Controls.Grid)(target));
            return;
            case 5:
            this.datagrdViewCustomer = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 6:
            this.lblCustomerOrg = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.chkNotActive = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 8:
            
            #line 74 "..\..\..\..\..\..\Presentation\Pages\Entity\ViewAllCustomers.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Refresh_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 75 "..\..\..\..\..\..\Presentation\Pages\Entity\ViewAllCustomers.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Export_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
