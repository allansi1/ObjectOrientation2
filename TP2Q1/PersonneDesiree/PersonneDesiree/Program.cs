using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personne
{
    public class MainClass
    {
        private static void Display(PersonneDesiree personne)
        {
            Console.WriteLine("Sexe: " + personne.Sexe);
            Console.WriteLine("Âge minimal: " + personne.MinAge);
            Console.WriteLine("Âge maximal: " + personne.MaxAge);
            Console.WriteLine("Pays d'origine: " + personne.PaysOrigine);
            Console.WriteLine("Couleur des cheveux: " + personne.CouleurCheveu);
            Console.WriteLine("Couleur des yeux: " + personne.CouleurYeux);
            Console.WriteLine("Niveau d'éducation: " + personne.Education);
        }

        public static void Main(string[] args)
        {
            
            
            PersonneDesiree personne1 = new PersonneDesiree.Builder("Femme")
                .WithMinAge(25)
                .WithMaxAge(35)
                .WithPaysOrigine("France")
                .WithColeurCheveau("brune")
                .WithColeurYeux("bleus")
                .WithEducation("licence")
                .Build();

            PersonneDesiree personne2 = new PersonneDesiree.Builder("Homme")
                .WithMinAge(30)
                .WithMaxAge(40)
                .WithPaysOrigine("États-Unis")
                .WithColeurCheveau("blond")
                .WithColeurYeux("verts")
                .WithEducation("master")
                .Build();

            PersonneDesiree p1 = new PersonneDesiree.Builder("Homme")
                .WithMinAge(14)
                .Build();

            
            Console.WriteLine("Personne p1:");
            Display(p1);
            Console.WriteLine();

            Console.WriteLine("Personne 1:");
            Display(personne1);
            Console.WriteLine();

            Console.WriteLine("Personne 2:");
            Display(personne2);

            
            Console.ReadKey();
        }
    }
}