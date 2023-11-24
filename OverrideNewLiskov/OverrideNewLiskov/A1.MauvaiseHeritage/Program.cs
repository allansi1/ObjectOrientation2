using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1.MauvaiseHeritage
{
    class Program
    {
        public static void F(Rectangle x)
        {
            double a = x.Aire();
            x.SetC(2 * x.GetC());  /* on double un côté du rectangle */
            if (x.Aire() == 2 * a)
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
             * Cepandant, ce n'est pas le cas. Alors, cet héritage viole le Principe de Liskov. 
             */
            F(v1);

            Console.ReadKey();
        }
    }
}
