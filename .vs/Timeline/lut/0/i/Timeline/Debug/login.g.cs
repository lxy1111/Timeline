﻿#pragma checksum "login.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "E7D5C1212F7F1797FB04BBA355151C42863DF521"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
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
using 软测期末项目;


namespace Timeline {
    
    
    /// <summary>
    /// login
    /// </summary>
    public partial class login : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 53 "login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox UsernameBox;
        
        #line default
        #line hidden
        
        
        #line 54 "login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock UsernameBlock;
        
        #line default
        #line hidden
        
        
        #line 55 "login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox PwdBox;
        
        #line default
        #line hidden
        
        
        #line 56 "login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock PwdBlock;
        
        #line default
        #line hidden
        
        
        #line 60 "login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button1;
        
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
            System.Uri resourceLocater = new System.Uri("/Timeline;component/login.xaml", System.UriKind.Relative);
            
            #line 1 "login.xaml"
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
            
            #line 11 "login.xaml"
            ((Timeline.login)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.DragWindow);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 50 "login.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.loginuser);
            
            #line default
            #line hidden
            return;
            case 3:
            this.UsernameBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 53 "login.xaml"
            this.UsernameBox.LostFocus += new System.Windows.RoutedEventHandler(this.user_losefocus);
            
            #line default
            #line hidden
            
            #line 53 "login.xaml"
            this.UsernameBox.GotFocus += new System.Windows.RoutedEventHandler(this.user_gotfocus);
            
            #line default
            #line hidden
            return;
            case 4:
            this.UsernameBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.PwdBox = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 55 "login.xaml"
            this.PwdBox.LostFocus += new System.Windows.RoutedEventHandler(this.pwd_losefocus);
            
            #line default
            #line hidden
            
            #line 55 "login.xaml"
            this.PwdBox.GotFocus += new System.Windows.RoutedEventHandler(this.pwd_gotfocus);
            
            #line default
            #line hidden
            return;
            case 6:
            this.PwdBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            
            #line 58 "login.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.openregisterwindow);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Button1 = ((System.Windows.Controls.Button)(target));
            
            #line 60 "login.xaml"
            this.Button1.Click += new System.Windows.RoutedEventHandler(this.CloseWindow);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

