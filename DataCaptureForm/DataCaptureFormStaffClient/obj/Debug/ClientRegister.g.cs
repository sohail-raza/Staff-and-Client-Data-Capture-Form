﻿#pragma checksum "..\..\ClientRegister.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "954DF86121183C75C7DEF5A3F25F14C2889C43C0FFD9C74E9172F414C27C3F15"
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
    /// ClientRegister
    /// </summary>
    public partial class ClientRegister : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 34 "..\..\ClientRegister.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button staffBtn;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\ClientRegister.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button clientBtn;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\ClientRegister.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox clientForenameBox;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\ClientRegister.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox clientSurnameBox;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\ClientRegister.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label clientDOBBox;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\ClientRegister.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dateOfBirthPicker;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\ClientRegister.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox clientAddrBox1;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\ClientRegister.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox clientAddrBox2;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\ClientRegister.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox clientCityBox;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\ClientRegister.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox clientPostCodeBox;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\ClientRegister.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox clientCountyBox;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\ClientRegister.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button clientSubmitBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/MattioliWoodsTask;component/clientregister.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ClientRegister.xaml"
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
            
            #line 34 "..\..\ClientRegister.xaml"
            this.staffBtn.Click += new System.Windows.RoutedEventHandler(this.StaffBtn_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.clientBtn = ((System.Windows.Controls.Button)(target));
            return;
            case 3:
            this.clientForenameBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 48 "..\..\ClientRegister.xaml"
            this.clientForenameBox.GotFocus += new System.Windows.RoutedEventHandler(this.RemoveForenameText);
            
            #line default
            #line hidden
            
            #line 48 "..\..\ClientRegister.xaml"
            this.clientForenameBox.LostFocus += new System.Windows.RoutedEventHandler(this.ValidateForenameText);
            
            #line default
            #line hidden
            return;
            case 4:
            this.clientSurnameBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 52 "..\..\ClientRegister.xaml"
            this.clientSurnameBox.GotFocus += new System.Windows.RoutedEventHandler(this.RemoveSurnameText);
            
            #line default
            #line hidden
            
            #line 52 "..\..\ClientRegister.xaml"
            this.clientSurnameBox.LostFocus += new System.Windows.RoutedEventHandler(this.ValidateSurnameText);
            
            #line default
            #line hidden
            return;
            case 5:
            this.clientDOBBox = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.dateOfBirthPicker = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 7:
            this.clientAddrBox1 = ((System.Windows.Controls.TextBox)(target));
            
            #line 64 "..\..\ClientRegister.xaml"
            this.clientAddrBox1.GotFocus += new System.Windows.RoutedEventHandler(this.RemoveAddr1BoxText);
            
            #line default
            #line hidden
            
            #line 64 "..\..\ClientRegister.xaml"
            this.clientAddrBox1.LostFocus += new System.Windows.RoutedEventHandler(this.ValidateAddr1BoxText);
            
            #line default
            #line hidden
            return;
            case 8:
            this.clientAddrBox2 = ((System.Windows.Controls.TextBox)(target));
            
            #line 68 "..\..\ClientRegister.xaml"
            this.clientAddrBox2.GotFocus += new System.Windows.RoutedEventHandler(this.RemoveAddr2BoxText);
            
            #line default
            #line hidden
            
            #line 68 "..\..\ClientRegister.xaml"
            this.clientAddrBox2.LostFocus += new System.Windows.RoutedEventHandler(this.ValidateAddr2BoxText);
            
            #line default
            #line hidden
            return;
            case 9:
            this.clientCityBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 72 "..\..\ClientRegister.xaml"
            this.clientCityBox.GotFocus += new System.Windows.RoutedEventHandler(this.RemoveCityBoxText);
            
            #line default
            #line hidden
            
            #line 72 "..\..\ClientRegister.xaml"
            this.clientCityBox.LostFocus += new System.Windows.RoutedEventHandler(this.ValidateCityBoxText);
            
            #line default
            #line hidden
            return;
            case 10:
            this.clientPostCodeBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 76 "..\..\ClientRegister.xaml"
            this.clientPostCodeBox.GotFocus += new System.Windows.RoutedEventHandler(this.RemovePostCodeBoxText);
            
            #line default
            #line hidden
            
            #line 76 "..\..\ClientRegister.xaml"
            this.clientPostCodeBox.LostFocus += new System.Windows.RoutedEventHandler(this.ClientPostCodeLengthCheck);
            
            #line default
            #line hidden
            return;
            case 11:
            this.clientCountyBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 80 "..\..\ClientRegister.xaml"
            this.clientCountyBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ClientCountyBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 12:
            this.clientSubmitBtn = ((System.Windows.Controls.Button)(target));
            
            #line 86 "..\..\ClientRegister.xaml"
            this.clientSubmitBtn.Click += new System.Windows.RoutedEventHandler(this.ClientSubmitData_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

