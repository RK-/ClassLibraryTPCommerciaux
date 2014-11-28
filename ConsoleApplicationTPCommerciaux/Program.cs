﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryTPCommerciaux;

namespace ConsoleApplicationTPCommerciaux
{
   public class Program
    {
        static void Main(string[] args)
        {
            ////////////////////////////////////////////////////////////////////////
            // À LIRE : Enlever les commentaires en fonctions des tests désirés ! //
            ////////////////////////////////////////////////////////////////////////

            /*
            ServiceCommercial sc1 = PersisteServiceCommercial.charge("service.sr"); //le ServiceCommercial sc1 est désérialisé

            // 3.	Code de la classe Commercial 
            Console.WriteLine("3.	Code de la classe Commercial ");
            Commercial c, c1;
            c = new Commercial("Jean", "Dupond", 8, 'A');
            Console.WriteLine(c.ToString());
            Console.WriteLine();

            // 4.	Code de la classe NoteFrais
            Console.WriteLine("4.	Code de la classe NoteFrais");
            NoteFrais f, f1, f2, f3, f4, f5;
            f = new NoteFrais(new DateTime(2013, 11, 12), c);
            Console.WriteLine(f.ToString());
            Console.WriteLine();

            // 6.1 La classe FraisTransport
            Console.WriteLine("6.1 La classe FraisTransport");
            f1 = new FraisTransport(new DateTime(2013, 11, 12), c, 250);
            Console.WriteLine(f1.ToString());
            Console.WriteLine();

            // 6.2 La classe RepasMidi
            Console.WriteLine("6.2 La classe RepasMidi");
            f2 = new RepasMidi(new DateTime(2013, 11, 12), c, 35);
            Console.WriteLine(f2.ToString());
            f3 = new RepasMidi(new DateTime(2013, 11, 12), c, 15);
            Console.WriteLine(f3.ToString());
            Console.WriteLine();

            // 6.3 La classe Nuitee
            Console.WriteLine("6.3 La classe Nuitee");
            f4 = new Nuitee(new DateTime(2013, 11, 12), c, 2, 46);
            Console.WriteLine(f4.ToString());
            f5 = new Nuitee(new DateTime(2013, 11, 12), c, 3, 80);
            Console.WriteLine(f5.ToString());
            Console.WriteLine();

            // 7.	Gestion des notes de frais d'un commercial
            Console.WriteLine("7.	Gestion des notes de frais d'un commercial");
            ServiceCommercial sc;
            sc = new ServiceCommercial();
            c1 = new Commercial("Dupond", "Jean", 7, 'B');
            sc.ajouterCommercial(c1);
            sc.ajouterNote(c1, new DateTime(2013, 11, 15), 100); // ajoute un frais de transport 
            sc.ajouterNote(c1, new DateTime(2013, 11, 21), 15.5); // ajoute une note de repas 
            sc.ajouterNote(c1, new DateTime(2013,11 , 25), 105, 2); // ajoute une nuitée 
            Console.WriteLine("Les frais ajouté depuis la classe service commercial : {0}",sc.nbFraisNonRembourses());

            f.setFraisRembourser();
            f1.setFraisRembourser();
            f2.setFraisRembourser();
            Console.WriteLine("Test du cumul des notes de frais remboursées en 2013 : {0} euros.", c.cumulNoteFraisRemboursees(2013));

            PersisteServiceCommercial.sauve(sc, "service.sr"); // le ServiceCommercial sc est sérialisé et enregistré en mémoire
            */

            // Exercice : Les interfaces
            /*
            IVoyageurCommercial c1;
            ISalarie s1;
            ServiceCommercial sc;
            ServiceComptable sComp;
            sc = new ServiceCommercial();
            sComp = new ServiceComptable();
            DateTime d = new DateTime(2014, 10, 21);
            c1 = new Commercial("Dupont", "Jean", 7, 'B');
            sc.ajouterCommercial(c1);
            s1 = new Commercial("Dupont", "Jean", d, "1740275111068");
            sComp.ajouteSalarie(s1);
            int numSalarie = 0;
            Console.Write("Nom du salarié numéro {0} : ", numSalarie);
            Console.Write(sComp.getSalarie(0).Nom);
            */

            // Trie des notes de frais
            /*
            DateTime d = new DateTime(2009, 10, 21);
            DateTime d1 = new DateTime(2010, 10, 21);
            DateTime d2 = new DateTime(2011, 10, 21);
            IVoyageurCommercial c = new Commercial("Dupont", "Jean", 7, 'B');
            NoteFrais f = new FraisTransport(d2, c, 100);
            NoteFrais f1 = new RepasMidi(d1, c, 15.5);
            NoteFrais f2 = new Nuitee(d, c, 75, 3);
            NoteFrais f3 = new Nuitee(d, c, 2, 89);
            NoteFrais f4 = new Nuitee(d2, c, 1, 70);
            // affichage
            List<NoteFrais> lesNotes = c.getMesNotesFrais();

            foreach (NoteFrais nf in lesNotes)
            {
                Console.WriteLine(nf.ToString());
            }
            // tri
            c.trierNotes();
            // affichage après le tri
            lesNotes = c.getMesNotesFrais();
            Console.WriteLine("AFFICHAGE APRÈS TRI");
            foreach (NoteFrais nf in lesNotes)
            {
                Console.WriteLine(nf.ToString());
            }
            */

            // test de la classe Ecran
            /*
            Commercial c1, c2, c3;
            ServiceCommercial sc = new ServiceCommercial();
            c1 = new Commercial("Dupond", "Jean", 7, 'B');
            c2 = new Commercial("Durand", "Dominique", 11, 'C');
            c3 = new Commercial("Chamir", "Jéremy", 15, 'A');
            sc.ajouterCommercial(c1);
            sc.ajouterCommercial(c2);
            sc.ajouterCommercial(c3);
            Ecran.affiche(sc);
            */

            // 5.3	Une variation inattendue du foreach
            DateTime d = new DateTime(2009, 10, 21);
            Commercial c = new Commercial("Dupont", "Jean", 7, 'B', d, "0132457898");
            foreach(Object o in c)
            {
                Console.WriteLine(o.ToString());
            }

            Console.ReadLine();
        }
    }
}