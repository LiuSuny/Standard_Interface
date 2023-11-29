using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Standard_Interface
{
    //public class Human
    //{
    //    public string Name { get; set; }
    //    public int Age { get; set; }

    //    public override string ToString()
    //    {
    //        return $"{Name}{Age}";
    //    }

    //}
    class Program
    {
        public static readonly string delimeter = "\n____________________\n";
        static void Main(string[] args)
        {

            //Human b1 = new Human { Name = "John", Age = 29 };
            //Console.WriteLine(b1);
            //Human h2 = b1;
            //Console.WriteLine(delimeter);
            //h2.Age = 30;
            //Console.WriteLine(h2);








            //Student_Auditory auditory = new Student_Auditory();
            //foreach(Student item in auditory)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine(delimeter);

            //auditory.Sort();
            //foreach (Student item in auditory)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine(delimeter);

            //auditory.Sort(new DateSort());
            //foreach (Student item in auditory)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine(delimeter);

            //auditory.Sort(new StudentCardSort());
            //foreach (Student item in auditory)
            //{
            //    Console.WriteLine(item);
            //}



            Student s1 =
            new Student
            {
                FirstName = "John",
                LastName = "Juliet",
                BirthDay = new DateTime(2000, 10, 09),
                Card = new Student_Card { Series = "BG", Number = 18366 }
            };
            Student s2 = (Student)s1.Clone();
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            s2.FirstName = "Thomas";
            s2.Card.Series = "HR";
            Console.WriteLine(delimeter);
            Console.WriteLine(s1);
            Console.WriteLine(s2);




        }
    }
}
