﻿#pragma checksum "..\..\..\..\..\Presentation\Controls\DayBoxAppointmentControl.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "786E1D41784C410617A7D8D9DC14AC6C"
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


namespace Guest_Booker_Studio.Presentation.Controls {
    
    
    /// <summary>
    /// DayBoxAppointmentControl
    /// </summary>
    public partial class DayBoxAppointmentControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\..\..\Presentation\Controls\DayBoxAppointmentControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border BorderElement;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\..\..\Presentation\Controls\DayBoxAppointmentControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DisplayText;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\..\..\Presentation\Controls\DayBoxAppointmentControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock datetxtBlk;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\..\..\Presentation\Controls\DayBoxAppointmentControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAptDelete;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\..\..\Presentation\Controls\DayBoxAppointmentControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAptUpdate;
        
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
            System.Uri resourceLocater = new System.Uri("/Guest Booker Studio;component/presentation/controls/dayboxappointmentcontrol.xam" +
                    "l", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Presentation\Controls\DayBoxAppointmentControl.xaml"
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
            this.BorderElement = ((System.Windows.Controls.Border)(target));
            return;
            case 2:
            this.DisplayText = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.datetxtBlk = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.btnAptDelete = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\..\..\Presentation\Controls\DayBoxAppointmentControl.xaml"
            this.btnAptDelete.Click += new System.Windows.RoutedEventHandler(this.btnAptDelete_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnAptUpdate = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\..\..\Presentation\Controls\DayBoxAppointmentControl.xaml"
            this.btnAptUpdate.Click += new System.Windows.RoutedEventHandler(this.btnAptSave_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

