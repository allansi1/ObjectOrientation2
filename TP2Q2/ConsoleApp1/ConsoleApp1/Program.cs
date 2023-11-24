using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            IDev a0 = new BasicDev("John");
            IDev a1 = new Java(a0);
            IDev a2 = new CPP(a1);

            Console.WriteLine("Name: " + a2.Name);
            Console.WriteLine("Competences: " + a2.getCompetence());
            Console.WriteLine("Details of java: " + a2.detailCompetence(Language.JAVA));
            Console.WriteLine("Details of python: " + a2.detailCompetence(Language.PYTHON));

            Console.WriteLine();
            IDev b = new CSharp(
                new Java(
                    new CPP(
                        new Python(
                            new BasicDev("Mary")))));

            Console.WriteLine("Name: " + b.Name);
            Console.WriteLine("Competences: " + b.getCompetence());
            Console.WriteLine("Details of C#: " + b.detailCompetence(Language.CSHARP));
            Console.WriteLine("Details of Java: " + b.detailCompetence(Language.JAVA));
            Console.WriteLine("Details of Web: " + b.detailCompetence(Language.WEB));
            Console.WriteLine();

            IDev  c = new BasicDev("Paul");
            Console.WriteLine("Name: " + c.Name);
            Console.WriteLine("Basic Dev Competences: " + c.getCompetence());
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
