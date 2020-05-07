// Updated by XamlIntelliSenseFileGenerator 5/8/2020 12:13:52 AM
#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "FF331141CC4726A443E89AB1010A9F9C218E85C8185801EDE72C33E3C741926A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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


namespace WpfApp2
{


    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {

#line default
#line hidden


#line 12 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid grid;

#line default
#line hidden


#line 26 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas Grille;

#line default
#line hidden


#line 54 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel Menu;

#line default
#line hidden


#line 56 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid top_Bar;

#line default
#line hidden


#line 59 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button minimize;

#line default
#line hidden


#line 64 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button normal;

#line default
#line hidden


#line 68 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button maximize;

#line default
#line hidden


#line 73 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button close;

#line default
#line hidden


#line 90 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CaptEcran;

#line default
#line hidden


#line 97 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button sauvegarde;

#line default
#line hidden


#line 104 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button clock;

#line default
#line hidden


#line 111 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button simuler;

#line default
#line hidden


#line 118 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button pause;

#line default
#line hidden


#line 125 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button stop;

#line default
#line hidden


#line 132 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button aide;

#line default
#line hidden


#line 145 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ChronoButton;

#line default
#line hidden


#line 161 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Tools;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
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
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler)
        {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
        }

        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
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

#line 27 "..\..\MainWindow.xaml"
                    this.Grille.MouseMove += new System.Windows.Input.MouseEventHandler(this.MouseMoved);

#line default
#line hidden

#line 28 "..\..\MainWindow.xaml"
                    this.Grille.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.MouseReleased);

#line default
#line hidden

#line 30 "..\..\MainWindow.xaml"
                    this.Grille.DragOver += new System.Windows.DragEventHandler(this.Grille_DragOver);

#line default
#line hidden

#line 31 "..\..\MainWindow.xaml"
                    this.Grille.Drop += new System.Windows.DragEventHandler(this.Grille_Drop);

#line default
#line hidden
                    return;
                case 4:
                    this.Menu = ((System.Windows.Controls.StackPanel)(target));
                    return;
                case 5:
                    this.top_Bar = ((System.Windows.Controls.Grid)(target));
                    return;
                case 6:
                    this.minimize = ((System.Windows.Controls.Button)(target));

#line 59 "..\..\MainWindow.xaml"
                    this.minimize.Click += new System.Windows.RoutedEventHandler(this.minimize_click);

#line default
#line hidden
                    return;
                case 7:
                    this.normal = ((System.Windows.Controls.Button)(target));

#line 64 "..\..\MainWindow.xaml"
                    this.normal.Click += new System.Windows.RoutedEventHandler(this.normal_click);

#line default
#line hidden
                    return;
                case 8:
                    this.maximize = ((System.Windows.Controls.Button)(target));

#line 68 "..\..\MainWindow.xaml"
                    this.maximize.Click += new System.Windows.RoutedEventHandler(this.maximize_click);

#line default
#line hidden
                    return;
                case 9:
                    this.close = ((System.Windows.Controls.Button)(target));

#line 73 "..\..\MainWindow.xaml"
                    this.close.Click += new System.Windows.RoutedEventHandler(this.close_click);

#line default
#line hidden
                    return;
                case 10:
                    this.CaptEcran = ((System.Windows.Controls.Button)(target));

#line 90 "..\..\MainWindow.xaml"
                    this.CaptEcran.Click += new System.Windows.RoutedEventHandler(this.CaptEcran_Click);

#line default
#line hidden
                    return;
                case 11:
                    this.sauvegarde = ((System.Windows.Controls.Button)(target));

#line 97 "..\..\MainWindow.xaml"
                    this.sauvegarde.Click += new System.Windows.RoutedEventHandler(this.sauvegarde_click);

#line default
#line hidden
                    return;
                case 12:
                    this.clock = ((System.Windows.Controls.Button)(target));

#line 104 "..\..\MainWindow.xaml"
                    this.clock.Click += new System.Windows.RoutedEventHandler(this.clock_click);

#line default
#line hidden
                    return;
                case 13:
                    this.simuler = ((System.Windows.Controls.Button)(target));

#line 111 "..\..\MainWindow.xaml"
                    this.simuler.Click += new System.Windows.RoutedEventHandler(this.simuler_click);

#line default
#line hidden
                    return;
                case 14:
                    this.pause = ((System.Windows.Controls.Button)(target));

#line 118 "..\..\MainWindow.xaml"
                    this.pause.Click += new System.Windows.RoutedEventHandler(this.pause_click);

#line default
#line hidden
                    return;
                case 15:
                    this.stop = ((System.Windows.Controls.Button)(target));

#line 125 "..\..\MainWindow.xaml"
                    this.stop.Click += new System.Windows.RoutedEventHandler(this.stop_click);

#line default
#line hidden
                    return;
                case 16:
                    this.aide = ((System.Windows.Controls.Button)(target));

#line 132 "..\..\MainWindow.xaml"
                    this.aide.Click += new System.Windows.RoutedEventHandler(this.aide_click);

#line default
#line hidden
                    return;
                case 17:

#line 143 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.open_file);

#line default
#line hidden
                    return;
                case 18:

#line 144 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.open_tut);

#line default
#line hidden
                    return;
                case 19:
                    this.ChronoButton = ((System.Windows.Controls.Button)(target));

#line 145 "..\..\MainWindow.xaml"
                    this.ChronoButton.Click += new System.Windows.RoutedEventHandler(this.ChronogrammesClick);

#line default
#line hidden
                    return;
                case 20:

#line 146 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.TVClick);

#line default
#line hidden
                    return;
                case 21:
                    this.Tools = ((System.Windows.Controls.Grid)(target));
                    return;
                case 22:

#line 170 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.ListViewItem)(target)).MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.TextBlock_MouseRightButtonDown);

#line default
#line hidden
                    return;
            }
            this._contentLoaded = true;
        }

        internal System.Windows.Window DigiX;
    }
}

