﻿using QuickGraph;
using System.Collections.Generic;
using WpfApp2;
using WpfApp2.Noyau;
using System.Collections.Generic;
using System;
using System.Threading;
using System.Windows.Controls;
using System.Xml.Linq;
using System.Windows;

namespace logisimConsole
{
    [Serializable]
    public class CircuitPersonnalise :Outils
    {
        private bool Sauvegardé;
        private bool simulation;
        private BidirectionalGraph<Outils, Edge<Outils>> Circuit;
        public List<Outils> CompFinaux;

        public BidirectionalGraph<Outils, Edge<Outils>> GetCircuit() { return Circuit; } //to iterate through vertices and edges of the graph created in the constructor
        public List<Outils> GetCompFinaux() { return CompFinaux; }
        public void SetCompFinaux(List<Outils> l) { CompFinaux = l; }
        

        public CircuitPersonnalise()
        {
            Circuit = new BidirectionalGraph<Outils, Edge<Outils>>();
            CompFinaux = new List<Outils>();
            this.liste_entrees = new List<ClasseEntree>();
            this.liste_sorties = new List<Sortie>();
        }
        public BidirectionalGraph<Outils, Edge<Outils>> GetGraph() { return Circuit; }
        //Relate for console
        public bool Relate(Outils component1, Outils component2, int num_sortie, int num_entree)
        { 
            if (!component2.getEntreeSpecifique(num_entree).getRelated() ) //Si l'entrée de component2 n'est pas reliée
            {
                OutStruct outstruct = new OutStruct(num_entree, component2);
                if (!component1.getSortieSpecifique(num_sortie).get_OutStruct().Contains(outstruct))
                {
                    component1.getSortieSpecifique(num_sortie).get_OutStruct().Add(outstruct);//Mise à jour des liaison
                    component2.getEntreeSpecifique(num_entree).setRelated(true);//Mise à jour de related
                }

                if (!Circuit.ContainsEdge(component1, component2))//Si il n'y a pas un edge déja présent liant component1 et component2
                {
                    Edge<Outils> edge = new Edge<Outils>(component1, component2);
                    Circuit.AddEdge(edge); //Ajouter edge entre component1 et component2
                }

                component2.getEntreeSpecifique(num_entree).setEtat(component1.getSortieSpecifique(num_sortie).getEtat());//Mise à jour de l'état d'entree de component2
                return true; // component1 et component2 liées avec succès
            }
            else
            {
                return false;
            }
        }

        //Relate for graphique
        public bool Relate(Outils component1, Outils component2, Sortie sortie, ClasseEntree entree)
        {
            component1.circuit = this;
            component2.circuit = this;
            if (!entree.getRelated() || entree.getEtat() != sortie.getEtat() || !component1.getListesorties().Contains(sortie) || !component2.getListeentrees().Contains(entree)) //Si l'entrée de component2 n'est pas reliée
            {
                OutStruct outstruct = new OutStruct(component2.getListeentrees().IndexOf(entree), component2);//Mise à jour des liaison
                if (!sortie.getSortie().Contains(outstruct))
                {
                    sortie.getSortie().Add(outstruct);
                    entree.setRelated(true);//Mise à jour de related
                }

                if (!Circuit.ContainsEdge(component1, component2)) //Si il n'y a pas un edge déja présent liant component1 et component2
                {
                    Edge<Outils> edge = new Edge<Outils>(component1, component2);
                    Circuit.AddEdge(edge); //Ajouter edge entre component1 et component2
                }

                entree.setEtat(sortie.getEtat());//Mise à jour de l'état d'entree de component2
                return true; // component1 et component2 liées avec succès
            }
            else
            {
                return false;
            }
        }

        public void AddComponent(Outils outil)
        {
            Circuit.AddVertex(outil);
        }


        public bool Empty(Outils outil)  //to make sure an element is considered an ending element
        {
            bool empty = true;

            foreach (Sortie s in outil.get_liste_sortie()) 
            {
                if (s.get_OutStruct() != null)
                {
                    foreach (OutStruct o in s.get_OutStruct())
                    {
                        if (o.getOutils() != null) { empty = false; }
                    }
                }
                else empty = true;
            }
            return empty;
        }

        //pour trouver les elements dor sortie Fonction version  1
        public void EndComponents()
        {
            foreach (var outil in Circuit.Vertices)
            {
                foreach (var edge in Circuit.InEdges(outil))
                {
                    if ((outil is PinOut) || Empty(outil))
                    {
                        CompFinaux.Add(outil);
                    }
                }
            }

        }

        public  void Evaluate(Outils outil)
        {
            
            if (!Circuit.IsInEdgesEmpty(outil))
            {
                IEnumerable<Edge<Outils>> inEdges = Circuit.InEdges(outil);
                foreach (Edge<Outils> edge in inEdges)
                {
                    Evaluate(edge.Source);
                }
            }
            
            outil.calcul_sorties();
            Console.WriteLine("--------------------------");
            Console.WriteLine(outil.GetType());
            Console.WriteLine("apres calcul " + outil.getListeentrees()[0].getEtat() );
            Console.WriteLine("apres calcul " + outil.getListesorties()[0].getEtat());
        }
        public void EvaluateCircuit()
        {
            this.CompFinaux = new List<Outils>();
            this.EndComponents();
            foreach(Outils outil in this.CompFinaux)
            {
               //new Thread(() => Evaluate(outil)).Start();
                Console.WriteLine("********Evaluate circuit *******");
                this.Evaluate(outil);
            }
        }
        public void EvaluateCircuit(IN iN)
        {
            
            foreach (Outils outil in iN.getEndListe())
            {
               // new Thread(() => Evaluate(outil)).Start();
                Console.WriteLine("********Evaluate circuit *******"+ outil);
                this.Evaluate(outil);
            }
        }

        public BidirectionalGraph<Outils, Edge<Outils>> getCircuit()
        {
            return Circuit;
        }
        public bool getSimulation() { return simulation; }
        public void setSimulation(bool s) { this.simulation = s; }

        public override void calcul_sorties()
        {
            this.CompFinaux = new List<Outils>();
            this.EndComponents();
            foreach (Outils outil in this.CompFinaux)
            {
                //new Thread(() => Evaluate(outil)).Start();
                Console.WriteLine("********Evaluate circuit *******");
                this.EvaluatePerso(outil);
            }
        }
        //pour calculsortie()
        public void EvaluatePerso(Outils outil)
        {

            if (!outil.end)
            {
                IEnumerable<Edge<Outils>> inEdges = Circuit.InEdges(outil);
                foreach (Edge<Outils> edge in inEdges)
                {
                    EvaluatePerso(edge.Source);
                }
            }

            outil.calcul_sorties();
            Console.WriteLine("--------------------------");
            Console.WriteLine(outil.GetType());
            Console.WriteLine("apres calcul " + outil.getListeentrees()[0].getEtat());
            Console.WriteLine("apres calcul " + outil.getListesorties()[0].getEtat());
        }
        public void ConstructSortie()
        {
            
            foreach(Outils outils in this.Circuit.Vertices)
            {
                if(outils is PinOut )
                {
                    //on construit la liste des sorties
                   
                    foreach (Edge<Outils> edge in Circuit.InEdges(outils))
                    {
                        RecupSorti(edge.Source,(PinOut)outils);
                    }
                }
            }
            
            
        }
        //recuperation de la sortie
        public void RecupSorti(Outils outil,PinOut pin)
        {
            foreach(Sortie sorti in outil.getListesorties())
            {
                foreach(OutStruct outs in sorti.get_OutStruct())
                {
                    if (outs.getOutils().Equals(pin))
                    {
                        this.nb_sorties++;
                        sorti.set_Sorties(new List<OutStruct>());
                        sorti.setDispo(Disposition.right);
                        this.liste_sorties.Add(sorti);
                        Console.WriteLine("SORTIE"+nb_sorties);
                        
                        //on supprime la sortie de gate 
                        ((Grid)(sorti.Parent)).Children.Remove(sorti);
                    }
                }
            }
        }
        //construction de la liste des entrées
        public void ConstructEntrée()
        {
            List<Edge<Outils>> list = new List<Edge<Outils>>();
            foreach(Outils outils in this.Circuit.Vertices)
            {
                if(outils is PinIn || outils is Horloge)
                {
                    foreach (Edge<Outils> edge in Circuit.OutEdges(outils))
                    {

                         list.Add(edge);
                    }
                   
                    RecupEntré((IN)outils);
                    
                }
            }
            foreach(Edge<Outils> edge in list)
            {
 
                    this.Circuit.RemoveEdge(edge);
            }

            
        }
        //****
        public void RecupEntré(IN outils)
        {
            foreach (OutStruct outs in outils.getListesorties()[0].get_OutStruct())
            {
                this.nb_entrees++;
                ClasseEntree entree = outs.getOutils().getListeentrees()[outs.getNum_entree()];
                entree.setDispo(Disposition.left);
                entree.setRelated(false);
                outs.getOutils().end = true;
                this.liste_entrees.Add(entree);//on ajoute l'entrée 
                Console.WriteLine("ENTREE"+this.nb_entrees);
                
                
                ((Grid)(entree.Parent)).Children.Remove(entree);
            }
        }


    }


}
