using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standard_Interface
{
    class Student_Auditory : IEnumerable
    {
        Student[] student =
        {
            new Student{FirstName = "John", LastName = "Juliet",
                BirthDay =new DateTime(2000, 10, 09),
                Card = new Student_Card{Series="BG", Number = 18366}},

            new Student{FirstName = "Dolly", LastName = "Loveth",
                BirthDay =new DateTime(2009, 01, 9),
                Card = new Student_Card{Series="DS", Number = 19970}},

            new Student{FirstName = "Tana", LastName = "Vlad",
                BirthDay =new DateTime(1987, 06, 03),
                Card = new Student_Card{Series="KU", Number = 97456}},

            new Student{FirstName = "Rowland", LastName = "Justice",
                BirthDay =new DateTime(2030, 7, 24),
                Card = new Student_Card{Series="DO", Number = 28766}},

            new Student{FirstName = "Lucky", LastName = "Chris",
                BirthDay =new DateTime(2023, 7, 24),
                Card = new Student_Card{Series="FR", Number = 67766}}
        };

        IEnumerator IEnumerable.GetEnumerator()
        {
            return student.GetEnumerator();
        }

        public void Sort()
        {
            Array.Sort(student);
        }

        public void Sort(IComparer comparer)
        {
            Array.Sort(student, comparer);
        }
    }
}
