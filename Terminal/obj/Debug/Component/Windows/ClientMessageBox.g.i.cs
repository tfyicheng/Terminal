﻿#pragma checksum "..\..\..\..\Component\Windows\ClientMessageBox.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F23A41F898F368E331B7B8013025B53BC7B2AB26CD6F98576AC5C50116B95373"
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
using Terminal.Component.Windows;


namespace Terminal.Component.Windows {
    
    
    /// <summary>
    /// ClientMessageBox
    /// </summary>
    public partial class ClientMessageBox : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 39 "..\..\..\..\Component\Windows\ClientMessageBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txbClose;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\Component\Windows\ClientMessageBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnLeft;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\..\Component\Windows\ClientMessageBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRight;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\..\Component\Windows\ClientMessageBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txbMessage;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\..\Component\Windows\ClientMessageBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid grdMask;
        
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
            System.Uri resourceLocater = new System.Uri("/Terminal;component/component/windows/clientmessagebox.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Component\Windows\ClientMessageBox.xaml"
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
            
            #line 8 "..\..\..\..\Component\Windows\ClientMessageBox.xaml"
            ((Terminal.Component.Windows.ClientMessageBox)(target)).Loaded += new System.Windows.RoutedEventHandler(this.ClientMessageBoxMain_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txbClose = ((System.Windows.Controls.TextBlock)(target));
            
            #line 39 "..\..\..\..\Component\Windows\ClientMessageBox.xaml"
            this.txbClose.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.TxbClose_MouseLeftButtonUp);
            
            #line default
            #line hidden
            
            #line 39 "..\..\..\..\Component\Windows\ClientMessageBox.xaml"
            this.txbClose.TouchUp += new System.EventHandler<System.Windows.Input.TouchEventArgs>(this.TxbClose_TouchUp);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnLeft = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\..\..\Component\Windows\ClientMessageBox.xaml"
            this.btnLeft.Click += new System.Windows.RoutedEventHandler(this.BtnValid_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnRight = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\..\..\Component\Windows\ClientMessageBox.xaml"
            this.btnRight.Click += new System.Windows.RoutedEventHandler(this.BtnValid_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.txbMessage = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.grdMask = ((System.Windows.Controls.Grid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
