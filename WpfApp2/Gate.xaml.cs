﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Logique d'interaction pour Gate.xaml
    /// </summary>
    public partial class Gate : UserControl
    {
        Path path;
        public Gate(String ph /*, Outils outil*/)
        {
            InitializeComponent();

            path = new Path();
            path.StrokeThickness = 2;
            path.Stroke = Brushes.Black;
            path.Data = StreamGeometry.Parse(ph);

            CanvasShape.Children.Add(path);

            //GateElement.Height = 30;
            //GateElement.Width = 30;
            //TO-DO :  Width and Height proportionnels à la grille (y compris les entrees et sorties)
        }
    }

}
