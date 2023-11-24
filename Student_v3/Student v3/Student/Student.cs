using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    public class Student : IComparable<Student>
    {
        private int id;
        private string name;
        private string givenName;
        private double grade;

        public int Id
        {
            get => id;
            /* 
             * mutateur privé / protegé, parce que il doit être utilisé seulement 
             * au moment de construir l'object 
             */
            protected set
            {
                if (value <= 0)
                {
                    throw new StudentDataException(1, value);
                }
                else
                {
                    this.id = value;
                }
            }
        }

        public string Name
        {
            get => name;
            /* 
             * mutateur privé / protegé, parce que il doit être utilisé seulement 
             * au moment de construir l'object 
             */
            protected set
            {
                if (!isValidName(value))
                {
                    throw new StudentDataException(2, value);
                }
                else
                {
                    this.name = value;
                }
            }
        }

        public string GivenName
        {
            get => givenName;
            /* 
             * mutateur privé / protegé, parce que il doit être utilisé seulement 
             * au moment de construir l'object 
             */
            protected set
            {
                if (!isValidName(value))
                {
                    throw new StudentDataException(3, value);
                }
                else
                {
                    this.givenName = value;
                }
            }
        }

        public double Grade
        {
            get => grade;
            /* 
             * mutateur publique, parce que la note peut être donnée 
             * après que l'objet est créé.
             */
            set          // set(double value)
            {
                if (value < 0)
                {
                    throw new StudentDataException(4, value);
                }
                else
                {
                    this.grade = value;
                }
            }
        }

        public Student(int id, String name, String givenName)
        {
            Id = id;
            Name = name;
            GivenName = givenName;
        }

        public Student(int id, String name, String givenName, double grade)
        {
            Id = id;
            Name = name;
            GivenName = givenName;
            Grade = grade;
        }

        /* 
         * Function auxiliaire pour valider les noms et les prénoms. 
         * Normalement, ce type de function est privée (private) de la classe.
         */
        private bool isValidName(String n)
        {
            bool r = true;
            foreach (char c in n)
                // if ((c < 'a' || c > 'z') && (c < 'A' || c > 'Z') && (c != ' ') && (c != '-'))
                if (!((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z') || (c == ' ') || (c == '-')))
                    r = false;
            return r;
        }

        /* 
         * méthode "with" pour utiliser le mutateur et retourner l'objet courant 
         */
        public Student withGrade(double grade)
        {
            Grade = grade;
            return this;
        }

        /* 
         * Override de la méthode toString de la classe Object.
         * Cela permet facilement d'imprimer et de concatener avec des "strings"  
         */
        public override string ToString()
        {
            return "Student [id=" + id + ", name=" + name + ", givenName=" + givenName + ", grade=" + grade + "]";
        }

        /* Override de la méthode compareTo de l'interface Comparable
    	 * Attention:  
	     *        a.compareTo(b) < 0  ==>  a est "plus petit" que b 
    	 *        a.compareTo(b) = 0  ==>  a est égal à b 
    	 *        a.compareTo(b) > 0  ==>  a est "plus grand" que b
    	 */
        public int CompareTo(Student s)
        {

            // ordre par id 
            return this.id - s.id;  // for ascending order
        }
    }
}
