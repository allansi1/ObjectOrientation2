using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class GradeComparer : IComparer<Student>
    {
        // order par grade, id
        /* Override de la méthode compare de l'interface Comparator
         * Attention:  
         *        a.compare(b) < 0  ==>  a est "plus petit" que b 
         *        a.compare(b) = 0  ==>  a est égal à b 
         *        a.compare(b) > 0  ==>  a est "plus grand" que b
         */
        public int Compare(Student s1, Student s2)
        {
            int r;
            if (s1.Grade > s2.Grade)
            {
                r = 1;
            }
            else if (s1.Grade == s2.Grade)
            {
                r = 0;
            }
            else
            { // s1.Grade<s2.Grade
                r = -1;
            }
            /* 
             * Si les notes sont egales, il ne nous reste qu'à comparer par l'id
             */
            if (r == 0)
            {
                r = s1.Id - s2.Id;
            }
            return r;
        }
    }
}
