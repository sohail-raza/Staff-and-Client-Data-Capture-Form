﻿#pragma checksum "..\..\ClientRegisterWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "CEE1DABB334670277D03C0E2A9FAE2BDA069C2CC94E2830402743C23C30FEEA8"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MattioliWoodsTask;
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


namespace MattioliWoodsTask {
    
    
    /// <summary>
    /// ClientRegisterWindow
    /// </summary>
    public partial class ClientRegisterWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 32 "..\..\ClientRegisterWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button staffBtn;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\ClientRegisterWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button clientBtn;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\ClientRegisterWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox staffForenameBox;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\ClientRegisterWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox staffSurnameBox;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\ClientRegisterWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox staffDOBBox;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\ClientRegisterWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button staffSubmitBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/MattioliWoodsTask;component/clientregisterwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ClientRegisterWindow.xaml"
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
            this.staffBtn = ((System.Windows.Controls.Button)(target));
            return;
            case 2:
            this.clientBtn = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\ClientRegisterWindow.xaml"
            this.clientBtn.Click += new System.Windows.RoutedEventHandler(this.ClientBtn_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.staffForenameBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 46 "..\..\ClientRegisterWindow.xaml"
            this.staffForenameBox.GotFocus += new System.Windows.RoutedEventHandler(this.removeStaffForenameText);
            
            #line default
            #line hidden
            return;
            case 4:
            this.staffSurnameBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 50 "..\..\ClientRegisterWindow.xaml"
            this.staffSurnameBox.GotFocus += new System.Windows.RoutedEventHandler(this.removeStaffSurnameText);
            
            #line default
            #line hidden
            return;
            case 5:
            this.staffDOBBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 55 "..\..\ClientRegisterWindow.xaml"
            this.staffDOBBox.GotFocus += new System.Windows.RoutedEventHandler(this.removestaffDOBBoxText);
            
            #line default
            #line hidden
            return;
            case 6:
            this.staffSubmitBtn = ((System.Windows.Controls.Button)(target));
            
            #line 58 "..\..\ClientRegisterWindow.xaml"
            this.staffSubmitBtn.Click += new System.Windows.RoutedEventHandler(this.staffSubmitData_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

