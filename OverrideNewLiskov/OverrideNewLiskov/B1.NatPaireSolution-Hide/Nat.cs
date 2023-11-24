using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B1.NatPaireSolution
{
    class Nat
    {
        protected int valeur;

        // constructeur
        public Nat(int x)
        {
            if (x >= 0)
            {
                valeur = x;
            }
            else
            {
                Console.WriteLine("Les nombres naturels ne peuvent pas être négatifs");
                Console.WriteLine(x + " converti en " + (-1 * x));
                valeur = -1 * x;
            }
        }


        // acèsseur pour lire la valeur de l'objet
        public int GetValeur()
        {
            return valeur;
        }

        public Nat Add(Nat x)
        {
            // un nouveau objet du type Nat dont la valeur est l'addition de la valeur
            // de l'objet courant (this) et la valeur de x.
            Console.WriteLine("Je suis la fonction Add de NAT");
            return new Nat(this.valeur + x.valeur);
        }

        public virtual Nat Succ()
        {
            Console.WriteLine("Je suis la fonction Succ de NAT");
            return new Nat(this.valeur + 1);
        }
    }
}
