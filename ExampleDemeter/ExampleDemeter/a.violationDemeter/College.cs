using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a.violationDemeter
{
    class College
    {
        private List<Course> l_courses;

        public List<Course> courses()
        {
            return l_courses;
        }

        public int totalOfStudents()
        {
            int r = 0;
            foreach (Course c in courses())
            {
                foreach (Group g in c.groups())
                {
                    foreach (Student e in g.students())
                    {
                        r++;
                    }
                }
            }
            return r;
        }

        public Student findStudent(int num)
        {
            Student e = null;
            bool found = false;
            for (int i = 0; (i < courses().Count) && (!found); i++)
            {
                for (int j = 0; (j < courses().ElementAt(i).groups().Count) && (!found); j++)
                {
                    for (int k = 0; (k < courses().ElementAt(i).groups().ElementAt(j).students().Count)
                            && (!found); k++)
                    {
                        Student ec = courses().ElementAt(i).groups().ElementAt(j).students().ElementAt(k);
                        if (num == ec.getId())
                        {
                            e = ec;
                            found = true;
                        }
                    }
                }
            }

            return e;
        }
    }
}
