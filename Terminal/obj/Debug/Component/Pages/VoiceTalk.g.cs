#pragma checksum "..\..\..\..\Component\Pages\VoiceTalk.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4904A20DF573D6549B02CC4E53E0B26E1210B1C3B59F2B018D2594E2910F7DB9"
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
using Terminal.Component.Pages;


namespace Terminal.Component.Pages {
    
    
    /// <summary>
    /// VoiceTalk
    /// </summary>
    public partial class VoiceTalk : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 44 "..\..\..\..\Component\Pages\VoiceTalk.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Calling;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\..\Component\Pages\VoiceTalk.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button jybt;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\..\Component\Pages\VoiceTalk.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock jytb;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\..\Component\Pages\VoiceTalk.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Call;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\..\Component\Pages\VoiceTalk.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Called;
        
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
            System.Uri resourceLocater = new System.Uri("/Terminal;component/component/pages/voicetalk.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Component\Pages\VoiceTalk.xaml"
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
            
            #line 8 "..\..\..\..\Component\Pages\VoiceTalk.xaml"
            ((Terminal.Component.Pages.VoiceTalk)(target)).Loaded += new System.Windows.RoutedEventHandler(this.VoiceTalkloaded_Main);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Calling = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.jybt = ((System.Windows.Controls.Button)(target));
            
            #line 47 "..\..\..\..\Component\Pages\VoiceTalk.xaml"
            this.jybt.Click += new System.Windows.RoutedEventHandler(this.toJy);
            
            #line default
            #line hidden
            return;
            case 4:
            this.jytb = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.Call = ((System.Windows.Controls.Grid)(target));
            return;
            case 6:
            this.Called = ((System.Windows.Controls.Grid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

