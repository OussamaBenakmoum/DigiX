﻿#pragma checksum "..\..\..\TTPack\TableVerites.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "531288C068B4815DB3BE0AEF1EE29338137E694918D238BACFC2709CC3D5FA73"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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
using WpfApp2.TTPack;


namespace WpfApp2.TTPack {
    
    
    /// <summary>
    /// TableVerites
    /// </summary>
    public partial class TableVerites : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\TTPack\TableVerites.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid ttt;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\TTPack\TableVerites.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid top_Bar;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\TTPack\TableVerites.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button minimize;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\TTPack\TableVerites.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button close;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\TTPack\TableVerites.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid tVerite;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp2;component/ttpack/tableverites.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\TTPack\TableVerites.xaml"
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
            this.ttt = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.top_Bar = ((System.Windows.Controls.Grid)(target));
            
            #line 13 "..\..\..\TTPack\TableVerites.xaml"
            this.top_Bar.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.top_Bar_MouseDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.minimize = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\..\TTPack\TableVerites.xaml"
            this.minimize.Click += new System.Windows.RoutedEventHandler(this.minimize_click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.close = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\..\TTPack\TableVerites.xaml"
            this.close.Click += new System.Windows.RoutedEventHandler(this.close_click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.tVerite = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 6:
            
            #line 30 "..\..\..\TTPack\TableVerites.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.graph_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

