﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> list = new List<Student>();
            Student s1 = new Student(1, "Tremblay", "Pierre");
            s1.Grade = 83.5;
            list.Add(s1);
            list.Add(new Student(44, "Smith", "Anne").withGrade(85.3));
            list.Add(new Student(45, "Smith", "Anne").withGrade(85.3));
            list.Add(new Student(28, "Barros", "Renan", 81.4));
            list.Add(new Student(17, "Picard", "Jean", 90.5));
            list.Add(new Student(19, "Brown", "Mary", 88.5));

            Console.WriteLine("List is by default sorted by the inclusion order");
            foreach (Student a in list)
                Console.WriteLine(a);
            Console.WriteLine();

            // Avec Comparison, nous pouvons trier les objets d'une classe 
            // indépendamment de IComparable  et de IComparer.    
            // Cela équivaut à créer un "Comparer" anonym. 
            Console.WriteLine("List sorted by id (using Comparison)");
            list.Sort(new Comparison<Student>((st1, st2) => st1.Id - st2.Id));
            foreach (Student a in list)
                Console.WriteLine(a);
            Console.WriteLine();

            Console.WriteLine("Student List sorted by id (default order)");
            list.Sort();
            foreach (Student a in list)
                Console.WriteLine(a);
            Console.WriteLine();

            Console.WriteLine("List sorted by id  (Student default order - reversed)");
            list.Sort();
            list.Reverse();
            foreach (Student a in list)
                Console.WriteLine(a);
            Console.WriteLine();

            Console.WriteLine("List sorted by id descending (using Comparison)");
            list.Sort(new Comparison<Student>((st1, st2) => st2.Id - st1.Id));
            foreach (Student a in list)
                Console.WriteLine(a);
            Console.WriteLine();

            Console.WriteLine("List sorted by name");
            list.Sort(new NameComparer());
            foreach (Student a in list)
                Console.WriteLine(a);
            Console.WriteLine();

            Console.WriteLine("List sorted by sorted by grade");
            list.Sort(new GradeComparer());
            foreach (Student a in list)
                Console.WriteLine(a);
            Console.WriteLine();

            Console.WriteLine("List sorted by grade (reverse order)");
            list.Sort(new GradeComparer());
            list.Reverse();
            foreach (Student a in list)
                Console.WriteLine(a);
            Console.WriteLine();

            Console.WriteLine("List sorted by grade (reverse order - using Comparison)");
            list.Sort(new Comparison<Student>((st1, st2) => -1*(new GradeComparer().Compare(st1, st2))));
            foreach (Student a in list)
                Console.WriteLine(a);
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
