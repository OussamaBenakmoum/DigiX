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
using System.Windows.Shapes;
using logisimConsole;
using QuickGraph;
using System.ComponentModel;


namespace WpfApp2.TableVerite
{
    /// <summary>
    /// Logique d'interaction pour TabVerites.xaml
    /// </summary>
    public partial class TabVerites : Window
    {
        private BidirectionalGraph<Outils, Edge<Outils>> circuit;
       
        
        public TabVerites( BidirectionalGraph<Outils, Edge<Outils>> graph )
        {
            Console.WriteLine("rani hna");
            this.circuit = graph;
            InitializeComponent();
       
        }

        private void graph_Click(object sender, RoutedEventArgs e)
        {
            //int n = circuit.VertexCount{ get;}

            /*if (circuit.Vertices.Count() == 0) Console.WriteLine("graph is empty");
            else Console.WriteLine("it contains : " + circuit.Vertices.Count());*/


          



            IEnumerable<Outils> lst = circuit.Vertices;
            List<Outils> liste = lst.ToList();
            foreach (Outils noeud in liste)
            {
                Console.WriteLine("Un vertice.");
                //Console.WriteLine(lst.);
                 //circuit.
                
            }
        }
    }
}
