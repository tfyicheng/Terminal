#pragma checksum "..\..\..\..\Component\Windows\Meeting.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9DFC9B3D66FA32FDBB80F5458CD7C8E26F9183FB5BD2D522AC5493DF58FE6C53"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using HandyControl.Controls;
using HandyControl.Data;
using HandyControl.Expression.Media;
using HandyControl.Expression.Shapes;
using HandyControl.Interactivity;
using HandyControl.Media.Animation;
using HandyControl.Media.Effects;
using HandyControl.Properties.Langs;
using HandyControl.Themes;
using HandyControl.Tools;
using HandyControl.Tools.Converter;
using HandyControl.Tools.Extension;
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
    /// Meeting
    /// </summary>
    public partial class Meeting : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\..\Component\Windows\Meeting.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Main;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\Component\Windows\Meeting.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnMin;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\Component\Windows\Meeting.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnState;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\Component\Windows\Meeting.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnClose;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\..\Component\Windows\Meeting.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ItemsControl itc;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\..\Component\Windows\Meeting.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button jybt;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\..\Component\Windows\Meeting.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock jytb;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\..\..\Component\Windows\Meeting.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button cameraB;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\..\..\Component\Windows\Meeting.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock cameraT;
        
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
            System.Uri resourceLocater = new System.Uri("/Terminal;component/component/windows/meeting.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Component\Windows\Meeting.xaml"
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
            this.Main = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.btnMin = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\..\Component\Windows\Meeting.xaml"
            this.btnMin.Click += new System.Windows.RoutedEventHandler(this.BtnMin_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnState = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\..\Component\Windows\Meeting.xaml"
            this.btnState.Click += new System.Windows.RoutedEventHandler(this.BtnState_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnClose = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\..\Component\Windows\Meeting.xaml"
            this.btnClose.Click += new System.Windows.RoutedEventHandler(this.BtnClose_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.itc = ((System.Windows.Controls.ItemsControl)(target));
            return;
            case 6:
            this.jybt = ((System.Windows.Controls.Button)(target));
            
            #line 75 "..\..\..\..\Component\Windows\Meeting.xaml"
            this.jybt.Click += new System.Windows.RoutedEventHandler(this.CloseVoice);
            
            #line default
            #line hidden
            return;
            case 7:
            this.jytb = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.cameraB = ((System.Windows.Controls.Button)(target));
            
            #line 86 "..\..\..\..\Component\Windows\Meeting.xaml"
            this.cameraB.Click += new System.Windows.RoutedEventHandler(this.CloseCarmera);
            
            #line default
            #line hidden
            return;
            case 9:
            this.cameraT = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

