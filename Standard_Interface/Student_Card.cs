using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standard_Interface
{
    class Student_Card
    {
        public int Number { get; set; }
        public string Series { get; set; }

        internal static int Compare(Student_Card card1, Student_Card card2)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $" {Number} {Series}";
        }
    }
}
