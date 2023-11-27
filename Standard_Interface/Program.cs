using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standard_Interface
{
    class Program
    {
        public static readonly string delimeter = "\n____________________\n";
        static void Main(string[] args)
        {
            Student_Auditory auditory = new Student_Auditory();
            foreach(Student item in auditory)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(delimeter);

            auditory.Sort();
            foreach (Student item in auditory)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(delimeter);

            auditory.Sort(new DateSort());
            foreach (Student item in auditory)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(delimeter);

            auditory.Sort(new StudentCardSort());
            foreach (Student item in auditory)
            {
                Console.WriteLine(item);
            }
        }
    }
}
