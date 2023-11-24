using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B1.NatPaireSolution
{
    class Paire : Nat
    {
        public Paire(int x)  : base(x)   // appeler le constructeur de la classe de base (Nat)
        {           
            if (valeur % 2 != 0) { valeur = valeur + 1; }
        }

        // overload 
        public Paire Add(Paire x)
        {
            Console.WriteLine("Je suis la fonction Add de Paire");
            return new Paire(this.valeur + x.valeur);
        }

        /* 
         * Différemment de Java, en C# l'override exige aussi que la méthode possède 
         * exactement le même type de retour. Dans l'exemple présent, il faut alors  
         * utiliser hide (new) et, dans cet exemple, cela empêche de créer une mauvaise  
         * héritage (violation de Liskov) 
         */

        public new Paire Succ()      
        {
            Console.WriteLine("Je suis la fonction Succ de Paire");
            return new Paire(this.valeur + 2);
        }
    }
}
