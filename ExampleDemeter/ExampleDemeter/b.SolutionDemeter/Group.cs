using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b.SolutionDemeter
{
    class Group
    {
        private List<Student> l_students;

        public List<Student> students()
        {
            return l_students;
        }

        public int totalOfStudents()
        {
            return students().Count;
        }

        public Student findStudent(int num)
        {
            Student e = null;
            bool found = false;
            for (int i = 0; (i < students().Count) && (!found); i++)
            {
                if (num == students().ElementAt(i).getId())
                {
                    e = students().ElementAt(i);
                    found = true;
                }
            }
            return e;

        }
    }
}
