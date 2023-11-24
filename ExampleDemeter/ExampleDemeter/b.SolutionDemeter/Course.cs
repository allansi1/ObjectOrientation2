using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b.SolutionDemeter
{
    class Course
    {
        private List<Group> l_groups;

        public List<Group> groups()
        {
            return l_groups;
        }

        public int totalOfStudents()
        {
            int r = 0;
            foreach (Group g in  groups())
            {
                r = r + g.totalOfStudents();
            }
            return r;
        }

        public Student findStudent(int num)
        {
            Student e = null;
            for (int i = 0; (i < groups().Count) && (e == null); i++)
            {
                e = groups().ElementAt(i).findStudent(num);
            }
            return e;
        }
    }
}
