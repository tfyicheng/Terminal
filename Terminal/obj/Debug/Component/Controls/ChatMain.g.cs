﻿#pragma checksum "..\..\..\..\Component\Controls\ChatMain.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "342F9DF7D40542FD8E1C19D8DDEBDC807F8212733C6A9A9C1C3A55CD3FAEF907"
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
using Terminal.Library.ViewModel;


namespace Terminal.Component.Controls {
    
    
    /// <summary>
    /// ChatMain
    /// </summary>
    public partial class ChatMain : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\..\Component\Controls\ChatMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txbFriendNickName;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\..\Component\Controls\ChatMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txbScreenCapture;
        
        #line default
        #line hidden
        
        
        #line 98 "..\..\..\..\Component\Controls\ChatMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSend;
        
        #line default
        #line hidden
        
        
        #line 100 "..\..\..\..\Component\Controls\ChatMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RichTextBox rtbMessage;
        
        #line default
        #line hidden
        
        
        #line 115 "..\..\..\..\Component\Controls\ChatMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border brdChat;
        
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
            System.Uri resourceLocater = new System.Uri("/Terminal;component/component/controls/chatmain.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Component\Controls\ChatMain.xaml"
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
            
            #line 6 "..\..\..\..\Component\Controls\ChatMain.xaml"
            ((Terminal.Component.Controls.ChatMain)(target)).Loaded += new System.Windows.RoutedEventHandler(this.UserControlMain_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txbFriendNickName = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.txbScreenCapture = ((System.Windows.Controls.TextBlock)(target));
            
            #line 71 "..\..\..\..\Component\Controls\ChatMain.xaml"
            this.txbScreenCapture.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.TxbScreenCapture_MouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnSend = ((System.Windows.Controls.Button)(target));
            
            #line 98 "..\..\..\..\Component\Controls\ChatMain.xaml"
            this.btnSend.Click += new System.Windows.RoutedEventHandler(this.BtnSend_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.rtbMessage = ((System.Windows.Controls.RichTextBox)(target));
            
            #line 100 "..\..\..\..\Component\Controls\ChatMain.xaml"
            this.rtbMessage.AddHandler(System.Windows.DataObject.PastingEvent, new System.Windows.DataObjectPastingEventHandler(this.RtbMessage_Pasting));
            
            #line default
            #line hidden
            
            #line 100 "..\..\..\..\Component\Controls\ChatMain.xaml"
            this.rtbMessage.KeyDown += new System.Windows.Input.KeyEventHandler(this.RtbMessage_KeyDown);
            
            #line default
            #line hidden
            return;
            case 6:
            this.brdChat = ((System.Windows.Controls.Border)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

