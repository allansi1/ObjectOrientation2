using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class CPP : IDev
    {
        private IDev bd;
        private Language competence;

        
        public CPP(IDev bd)
        {
            this.bd = bd;
            this.competence = Language.CPP;
        }

        public string Name
        {
            get { return bd.Name; }
        }

        public string getCompetence()
        {
            return this.competence + ", " + bd.getCompetence();
        }

        public string detailCompetence(Language l)
        {
            if (l == Language.CPP)
            {
                return bd.Name + " specific details of " + l + ".";
            }
            else
            {
                return bd.detailCompetence(l);
            }
        }
    }
}
