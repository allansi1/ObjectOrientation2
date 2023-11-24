using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentNS
{
    public class StudentDataException : Exception
    {
        private int code;
        private Object obj;
        private String msg;

        internal StudentDataException(int code, Object obj)
        {
            this.code = code;
            this.obj = obj;
            if (code == 1)
                this.msg = "Invalid id: " + (int)obj;
            else if (code == 2)
                this.msg = "Invalid name: " + (String)obj;
            else if (code == 3)
                this.msg = "Invalid given name: " + (String)obj;
            else if (code == 4)
                this.msg = "Invalid grade: " + (double)obj;
            else
                this.msg = "Unknown exception";
        }
        public int GetCode()
        {
            return this.code;
        }

        public Object GetObj()
        {
            return this.obj;
        }
        /* En C#, Message est une Propriété de Exception 
         * Alors il faut faire l'override de cette Propriété.
         */
        public override String Message
        {
            get => msg;
        }
    }

    public class Student : IComparable<Student>
    {
        /* 
	 * Attributs des objets de cette clase 
	 * */

        private int id;
        private String name;
        private String givenName;
        private double grade;

        /* 
         * Constructeurs    
         * */

        /* 
         * Constructeurs   sans donner la note 
         * */
        public Student(int id, String name, String givenName)
        {
            SetId(id);
            SetName(name);
            SetGivenName(givenName);
        }

        /* 
         * Constructeurs   en donnant la note  --> tous les attributs
         * */
        public Student(int id, String name, String givenName, double grade)
        {
            SetId(id);
            SetName(name);
            SetGivenName(givenName);
            SetGrade(grade);
        }

        /* 
	     * Function auxiliaire pour valider les noms et les prénoms. 
	     * Normalement, ce type de function est privée (private) de la classe.
	     */
        private bool IsValidName(String n)
        {
            foreach (char c in n)
                if ((c < 'a' || c > 'z') && (c < 'A' || c > 'Z') && (c != ' ') && (c != '-'))
                    return false;
            return true;
        }
        /* 
         * Les accesseurs (getters) et les mutateurs (setters) 
         */

        /* 
         * Accesseur et mutateur de l'attribut id 
         */
        public int GetId()
        {
            return id;
        }
        /* 
         * mutateur privé / protegé, parce que il doit être utilisé seulement 
         * au moment de construir l'object 
         */
        protected void SetId(int id)
        {
            if (id <= 0)
            {
                throw new StudentDataException(1, id);
            }
            else
            {
                this.id = id;
            }
        }
        /* 
    	 * Accesseur et mutateur de l'attribut name 
	     */
        public String GetName()
        {
            return name;
        }
        /* 
         * mutateur privé / protegé, parce que il doit être utilisé seulement 
         * au moment de construir l'object 
         */
        protected void SetName(String name)
        {
            if (!IsValidName(name))
            {
                throw new StudentDataException(2, name);
            }
            else
            {
                this.name = name;
            }
        }
        /* 
	     * Accesseur et mutateur de l'attribut givenName 
	     */
        public String GetGivenName()
        {
            return givenName;
        }
        /* 
         * mutateur privé / protegé, parce que il doit être utilisé seulement 
         * au moment de construir l'object 
         */
        protected void SetGivenName(String givenName)
        {
            if (!IsValidName(givenName))
            {
                throw new StudentDataException(3, givenName);
            }
            else
            {
                this.givenName = givenName;
            }
        }
        /* 
         * Accesseur et mutateur de l'attribut grade
         */
        public double GetGrade()
        {
            return grade;
        }
        /* 
         * mutateur publique, parce que la note peut être donnée 
         * après que l'objet est créé.
         */
        public void SetGrade(double grade)
        {
            if (grade < 0)
            {
                throw new StudentDataException(4, grade);
            }
            else
            {
                this.grade = grade;
            }
        }

        /* 
         * méthode "with" pour utiliser le mutateur et retourner l'objet courant 
         */
        public Student WithGrade(double grade)
        {
            this.SetGrade(grade);
            return this;
        }

        /* 
	     * Override de la méthode toString de la classe Object.
	     * Cela permet facilement d'imprimer et de concatener avec des "strings"  
	     */
        public override String ToString()
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

    public class NameComparer : IComparer<Student>
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
            int r = s1.GetName().CompareTo(s2.GetName());
            /* 
             * Si les noms sont egaux, on compare les prénoms (givenName) en utilisant 
             * le compareTo de String 
             */
            if (r == 0) { r = s1.GetGivenName().CompareTo(s2.GetGivenName()); }
            /* 
             * Si les prénoms sont aussi egaux, il ne nous reste qu'à comparer par l'id
             */
            if (r == 0) { r = s1.GetId() - s2.GetId(); }
            return r;
        }

    }

    public class GradeComparer : IComparer<Student>{

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
        if (s1.GetGrade() > s2.GetGrade())
        {
            r = 1;
        }
        else if (s1.GetGrade() == s2.GetGrade())
        {
            r = 0;
        }
        else
        { // s1.GetGrade()<s2.GetGrade()
            r = -1;
        }
        /* 
		 * Si les notes sont egales, il ne nous reste qu'à comparer par l'id
		 */
        if (r == 0)
        {
            r = s1.GetId() - s2.GetId();
        }
        return r;
    }

}


}
