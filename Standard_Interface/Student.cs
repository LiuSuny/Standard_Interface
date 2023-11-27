using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standard_Interface
{
    class Student: IComparable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDay { get; set; }
        public Student_Card Card { get; set; }

        public int CompareTo(object obj)
        {
            if(obj is Student)
            {
                return LastName.CompareTo((obj as Student).LastName);
            }
            throw new NotImplementedException();
        }
        
        //Note Icomparable is not posible to duplicate our sort method and the only possible way is through compare

       
        public override string ToString()
        {
            return $"{FirstName, -15} {LastName, -15} {BirthDay.ToLongDateString(), -17} {Card, -10}";
        }

       
    }
}
