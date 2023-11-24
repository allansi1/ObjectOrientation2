using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public  class BasicDev : IDev
    {
        private string name;

        public string Name { get ; set; }

        public BasicDev(string name)
        {
            this.Name = name;
        }

            
        
        public string getCompetence()
        {
            return "";
        }

        public string detailCompetence(Language l)
        {
            return "I, " + Name + ", don't know " + l + ".";
        }
    }
}
