﻿using Heritage.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage
{
    public static class MyFunctions
    {
        public static void Afficher(Vache v)
        {
            Console.WriteLine("Mon nom est {0}", v.NomVache);
            v.Naissance();
            v.Reproduction();
            v.Alimentation();
            v.Expression();
            v.Oxigenation();
            v.Mort();
        }

        public static void Afficher(Pangolin p)
        {
            Console.WriteLine("Mon nom est {0}", p.NomPangolin);
            p.Naissance();
            p.Reproduction();
            p.Alimentation();
            p.Expression();
            p.Oxigenation();
            p.Mort();
        }
        public static void Afficher(Chien c)
        {
            Console.WriteLine("Mon nom est {0}", c.NomChien);
            c.Naissance();
            c.Reproduction();
            c.Alimentation();
            c.Expression();
            c.Oxigenation();
            c.Mort();
            c.Aboyer();
        }
        public static void Afficher(Fleur f)
        {
            Console.WriteLine("Mon nom est {0}", f.NomFleur);
            f.Naissance();
            f.Reproduction();
            f.Alimentation();
            f.Expression();
            f.Oxigenation();
            f.Mort();
        }
        public static void Afficher(Poisson p)
        {
            Console.WriteLine("Mon nom est {0}", p.NomPoisson);
            p.Naissance();
            p.Reproduction();
            p.Alimentation();
            p.Expression();
            p.Oxigenation();
            p.Mort();
        }
        public static void Afficher(EtreVivant e)
        {
            Console.WriteLine("Mon nom est {0}", e.Nom);
            Console.WriteLine("Je suis de type {0}", e.Type);
            e.Naissance();
            e.Reproduction();
            e.Alimentation();
            e.Expression();
            e.Oxigenation();
            e.Mort();                
            Console.WriteLine("--------------------------------");
        }

    }
}
