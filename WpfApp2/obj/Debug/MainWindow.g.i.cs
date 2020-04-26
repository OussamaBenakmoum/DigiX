﻿#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "FA52B2116E291EAEF34DCEBC0C8C8DFBA9811347A23B01BCC3ABAFCE46204E6C"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using DynamicDataDisplay.Markers;
using DynamicDataDisplay.Markers.MarkerGenerators;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using Microsoft.Research.DynamicDataDisplay;
using Microsoft.Research.DynamicDataDisplay.Charts;
using Microsoft.Research.DynamicDataDisplay.Charts.Axes;
using Microsoft.Research.DynamicDataDisplay.Charts.Axes.Numeric;
using Microsoft.Research.DynamicDataDisplay.Charts.Isolines;
using Microsoft.Research.DynamicDataDisplay.Charts.Maps;
using Microsoft.Research.DynamicDataDisplay.Charts.Maps.Network;
using Microsoft.Research.DynamicDataDisplay.Charts.Navigation;
using Microsoft.Research.DynamicDataDisplay.Charts.NewLine;
using Microsoft.Research.DynamicDataDisplay.Charts.Selectors;
using Microsoft.Research.DynamicDataDisplay.Charts.Shapes;
using Microsoft.Research.DynamicDataDisplay.Common.Palettes;
using Microsoft.Research.DynamicDataDisplay.Converters;
using Microsoft.Research.DynamicDataDisplay.DataSources;
using Microsoft.Research.DynamicDataDisplay.Maps.Charts;
using Microsoft.Research.DynamicDataDisplay.Maps.Charts.TiledRendering;
using Microsoft.Research.DynamicDataDisplay.Maps.Charts.VectorFields.Streamlines;
using Microsoft.Research.DynamicDataDisplay.Maps.DeepZoom;
using Microsoft.Research.DynamicDataDisplay.Maps.Servers;
using Microsoft.Research.DynamicDataDisplay.Maps.Servers.FileServers;
using Microsoft.Research.DynamicDataDisplay.Maps.Servers.Network;
using Microsoft.Research.DynamicDataDisplay.Markers.MarkerGenerators.Rendering;
using Microsoft.Research.DynamicDataDisplay.MarkupExtensions;
using Microsoft.Research.DynamicDataDisplay.Navigation;
using Microsoft.Research.DynamicDataDisplay.PointMarkers;
using Microsoft.Research.DynamicDataDisplay.ViewportConstraints;
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


namespace WpfApp2 {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal WpfApp2.MainWindow DigiX;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid grid;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas Grille;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel StackExceptions;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel Menu;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CaptEcran;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button sauvegarde;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button simuler;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button aide;
        
        #line default
        #line hidden
        
        
        #line 105 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Tools;
        
        #line default
        #line hidden
        
        
        #line 344 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas Chronogrammes;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp2;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            this.DigiX = ((WpfApp2.MainWindow)(target));
            return;
            case 2:
            this.grid = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.Grille = ((System.Windows.Controls.Canvas)(target));
            
            #line 28 "..\..\MainWindow.xaml"
            this.Grille.MouseMove += new System.Windows.Input.MouseEventHandler(this.MouseMoved);
            
            #line default
            #line hidden
            
            #line 29 "..\..\MainWindow.xaml"
            this.Grille.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.MouseReleased);
            
            #line default
            #line hidden
            
            #line 31 "..\..\MainWindow.xaml"
            this.Grille.DragOver += new System.Windows.DragEventHandler(this.Grille_DragOver);
            
            #line default
            #line hidden
            
            #line 32 "..\..\MainWindow.xaml"
            this.Grille.Drop += new System.Windows.DragEventHandler(this.Grille_Drop);
            
            #line default
            #line hidden
            return;
            case 4:
            this.StackExceptions = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 5:
            this.Menu = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 6:
            this.CaptEcran = ((System.Windows.Controls.Button)(target));
            
            #line 57 "..\..\MainWindow.xaml"
            this.CaptEcran.Click += new System.Windows.RoutedEventHandler(this.CaptEcran_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.sauvegarde = ((System.Windows.Controls.Button)(target));
            
            #line 64 "..\..\MainWindow.xaml"
            this.sauvegarde.Click += new System.Windows.RoutedEventHandler(this.sauvegarde_click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.simuler = ((System.Windows.Controls.Button)(target));
            
            #line 71 "..\..\MainWindow.xaml"
            this.simuler.Click += new System.Windows.RoutedEventHandler(this.simuler_click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.aide = ((System.Windows.Controls.Button)(target));
            
            #line 78 "..\..\MainWindow.xaml"
            this.aide.Click += new System.Windows.RoutedEventHandler(this.aide_click);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 89 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.open_file);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 90 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.open_tut);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 91 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ChronogrammesClick);
            
            #line default
            #line hidden
            return;
            case 13:
            this.Tools = ((System.Windows.Controls.Grid)(target));
            return;
            case 14:
            this.Chronogrammes = ((System.Windows.Controls.Canvas)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

