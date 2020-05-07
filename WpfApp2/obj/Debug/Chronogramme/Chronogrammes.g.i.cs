﻿#pragma checksum "..\..\..\Chronogramme\Chronogrammes.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "290FCA032BDD9B129EBD514D381761D90A41FB932B6D7842F2446B40AB568516"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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
using WpfApp2;


namespace WpfApp2.Chronogramme {
    
    
    /// <summary>
    /// Chronogrammes
    /// </summary>
    public partial class Chronogrammes : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\Chronogramme\Chronogrammes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Menu menu;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\Chronogramme\Chronogrammes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem SignalsChrono;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\Chronogramme\Chronogrammes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox TimeChrono;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\Chronogramme\Chronogrammes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PreviousButton;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\Chronogramme\Chronogrammes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button NextButton;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\Chronogramme\Chronogrammes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AxesButton;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\Chronogramme\Chronogrammes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button StopButton;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\Chronogramme\Chronogrammes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PauseButton;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\Chronogramme\Chronogrammes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button StartContinuerButton;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\..\Chronogramme\Chronogrammes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas Errors;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\..\Chronogramme\Chronogrammes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel ChronoStack;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp2;component/chronogramme/chronogrammes.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Chronogramme\Chronogrammes.xaml"
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
            
            #line 9 "..\..\..\Chronogramme\Chronogrammes.xaml"
            ((WpfApp2.Chronogramme.Chronogrammes)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Window_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.menu = ((System.Windows.Controls.Menu)(target));
            return;
            case 3:
            this.SignalsChrono = ((System.Windows.Controls.MenuItem)(target));
            
            #line 17 "..\..\..\Chronogramme\Chronogrammes.xaml"
            this.SignalsChrono.Click += new System.Windows.RoutedEventHandler(this.Ajouter);
            
            #line default
            #line hidden
            return;
            case 4:
            this.TimeChrono = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.PreviousButton = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\..\Chronogramme\Chronogrammes.xaml"
            this.PreviousButton.Click += new System.Windows.RoutedEventHandler(this.PreviousClick);
            
            #line default
            #line hidden
            return;
            case 6:
            this.NextButton = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\..\Chronogramme\Chronogrammes.xaml"
            this.NextButton.Click += new System.Windows.RoutedEventHandler(this.NextClick);
            
            #line default
            #line hidden
            return;
            case 7:
            this.AxesButton = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\..\Chronogramme\Chronogrammes.xaml"
            this.AxesButton.Click += new System.Windows.RoutedEventHandler(this.AfficherAxe);
            
            #line default
            #line hidden
            return;
            case 8:
            this.StopButton = ((System.Windows.Controls.Button)(target));
            
            #line 61 "..\..\..\Chronogramme\Chronogrammes.xaml"
            this.StopButton.Click += new System.Windows.RoutedEventHandler(this.StopClick);
            
            #line default
            #line hidden
            return;
            case 9:
            this.PauseButton = ((System.Windows.Controls.Button)(target));
            
            #line 65 "..\..\..\Chronogramme\Chronogrammes.xaml"
            this.PauseButton.Click += new System.Windows.RoutedEventHandler(this.PauseClick);
            
            #line default
            #line hidden
            return;
            case 10:
            this.StartContinuerButton = ((System.Windows.Controls.Button)(target));
            
            #line 69 "..\..\..\Chronogramme\Chronogrammes.xaml"
            this.StartContinuerButton.Click += new System.Windows.RoutedEventHandler(this.StartContinuerClick);
            
            #line default
            #line hidden
            return;
            case 11:
            this.Errors = ((System.Windows.Controls.Canvas)(target));
            return;
            case 12:
            this.ChronoStack = ((System.Windows.Controls.StackPanel)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

