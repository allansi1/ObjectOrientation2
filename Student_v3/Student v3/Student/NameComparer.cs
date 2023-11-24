using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class NameComparer : IComparer<Student>
    {
        // order par name, givenName, id
        /* Override de la méthode compare de l'interface Comparator
         * Attention:  
         *        a.compare(b) < 0  ==>  a est "plus petit" que b 
         *        a.compare(b) = 0  ==>  a est égal à b 
         *        a.compare(b) > 0  ==>  a est "plus grand" que b
         */
        public int Compare(Student s1, Student s2)
        {
            /* 
             * D'abord, on compare les noms (name) en utilisant le compareTo de String 
             */
            int r = s1.Name.CompareTo(s2.Name);
            /* 
             * Si les noms sont egaux, on compare les prénoms (givenName) en utilisant 
             * le compareTo de String 
             */
            if (r == 0) { r = s1.GivenName.CompareTo(s2.GivenName); }
            /* 
             * Si les prénoms sont aussi egaux, il ne nous reste qu'à comparer par l'id
             */
            if (r == 0) { r = s1.Id - s2.Id; }
            return r;
        }
    }
}
