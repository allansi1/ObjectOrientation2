using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface IDev
    {
        String Name {  get; }
        String getCompetence();
        String detailCompetence(Language l);
    }
}
