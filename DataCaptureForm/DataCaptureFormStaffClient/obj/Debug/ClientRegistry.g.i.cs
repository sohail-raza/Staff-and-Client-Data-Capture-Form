﻿#pragma checksum "..\..\ClientRegistry.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C2F77EE35FF3DE59D6862A6AAD9D75A031A9C2EEC6882FFF2418507FB2004C37"
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
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 30 "..\..\ClientRegistry.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button staffBtn;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\ClientRegistry.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button clientBtn;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\ClientRegistry.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox staffForenameBox;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\ClientRegistry.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox staffSurnameBox;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\ClientRegistry.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox staffDOBBox;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\ClientRegistry.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox addrBox1;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\ClientRegistry.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox addrBox2;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\ClientRegistry.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox cityBox;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\ClientRegistry.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox countyComboBox;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\ClientRegistry.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox postCodeText;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\ClientRegistry.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox countryComboBox;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\ClientRegistry.xaml"
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
            System.Uri resourceLocater = new System.Uri("/MattioliWoodsTask;component/clientregistry.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ClientRegistry.xaml"
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
            return;
            case 3:
            this.staffForenameBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 44 "..\..\ClientRegistry.xaml"
            this.staffForenameBox.GotFocus += new System.Windows.RoutedEventHandler(this.removeStaffForenameText);
            
            #line default
            #line hidden
            return;
            case 4:
            this.staffSurnameBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 48 "..\..\ClientRegistry.xaml"
            this.staffSurnameBox.GotFocus += new System.Windows.RoutedEventHandler(this.removeStaffSurnameText);
            
            #line default
            #line hidden
            return;
            case 5:
            this.staffDOBBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 53 "..\..\ClientRegistry.xaml"
            this.staffDOBBox.GotFocus += new System.Windows.RoutedEventHandler(this.removestaffDOBBoxText);
            
            #line default
            #line hidden
            return;
            case 6:
            this.addrBox1 = ((System.Windows.Controls.TextBox)(target));
            
            #line 58 "..\..\ClientRegistry.xaml"
            this.addrBox1.GotFocus += new System.Windows.RoutedEventHandler(this.removeAddr1Focus);
            
            #line default
            #line hidden
            return;
            case 7:
            this.addrBox2 = ((System.Windows.Controls.TextBox)(target));
            
            #line 62 "..\..\ClientRegistry.xaml"
            this.addrBox2.GotFocus += new System.Windows.RoutedEventHandler(this.removeAddr2Focus);
            
            #line default
            #line hidden
            return;
            case 8:
            this.cityBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 66 "..\..\ClientRegistry.xaml"
            this.cityBox.GotFocus += new System.Windows.RoutedEventHandler(this.removeCityFocus);
            
            #line default
            #line hidden
            return;
            case 9:
            this.countyComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 70 "..\..\ClientRegistry.xaml"
            this.countyComboBox.GotFocus += new System.Windows.RoutedEventHandler(this.removeCountyFocus);
            
            #line default
            #line hidden
            return;
            case 10:
            this.postCodeText = ((System.Windows.Controls.TextBox)(target));
            
            #line 75 "..\..\ClientRegistry.xaml"
            this.postCodeText.GotFocus += new System.Windows.RoutedEventHandler(this.removePostCodeFocus);
            
            #line default
            #line hidden
            return;
            case 11:
            this.countryComboBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 80 "..\..\ClientRegistry.xaml"
            this.countryComboBox.GotFocus += new System.Windows.RoutedEventHandler(this.removCountryFocus);
            
            #line default
            #line hidden
            return;
            case 12:
            this.staffSubmitBtn = ((System.Windows.Controls.Button)(target));
            
            #line 85 "..\..\ClientRegistry.xaml"
            this.staffSubmitBtn.Click += new System.Windows.RoutedEventHandler(this.staffSubmitData_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

