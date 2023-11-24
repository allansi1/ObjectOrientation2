﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2.Solution1
{
    class Program
    {
        public static void F(Rectangle x)
        {
            double a = x.Aire();
            Rectangle y = new Rectangle(2 * x.GetC(), x.GetD()); /* pour doubler un côté du rectangle 
		                                                            il faut créer un autre rectangle */
            if (y.Aire() == 2 * a)
            {
                Console.WriteLine("F dit OK");
            }
            else
            {
                throw new Exception();
            }
        }

        static void Main(string[] args)
        {
            Carre v1 = new Carre(10);
            Console.WriteLine("Voici le carré v1 : " + v1);
            Console.WriteLine("Voici l'Aire de v1 : " + v1.Aire());
            Console.WriteLine("Voici le perimètre de v1 : " + v1.Perimetre());

            Rectangle v2 = new Rectangle(10, 20);
            Console.WriteLine("Côté c de v2 : " + v2.GetC());
            Console.WriteLine("Côté d de v2 : " + v2.GetD());

            Console.WriteLine("Voici le rectangle v2 : " + v2);
            Console.WriteLine("Voici l'Aire de v2 : " + v2.Aire());
            Console.WriteLine("Voici le perimètre de v2 : " + v2.Perimetre());

            F(v2);

            /*
             * Étant donné que selon ce modèle le carré est un cas particulier de rectangle, 
             * tous les codes qui marchent pour le rectangle doivent marcher aussi pour le carré.
             * Et cela est effectivement le cas.
             */
            F(v1);
            Console.WriteLine("Voici le carré v1 : " + v1);

            Console.ReadKey();

        }
    }
}
