using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    public class StudentDataException : Exception
    {
        private int code;
        private Object obj;
        private String msg;

        public int Code { get => code; }
        public Object Obj { get => obj; }
        public override string Message { get => msg; }   // C'est pour avoir le "même effet" que le 
                                                         // "override" de getMessage chez Java

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

        // Remplacée par la propriété Message (voir plus haut). 
        //@Override
        //public String getMessage()
        //{
        //    return this.msg;
        //}
    }
}
