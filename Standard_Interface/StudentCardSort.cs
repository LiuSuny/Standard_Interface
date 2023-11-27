using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standard_Interface
{
     class StudentCardSort:IComparer
    {
        public int Compare(object x, object y)
        {
            if (x is Student && y is Student)
            {
              int ser_card = ((Student)x).Card.Series.CompareTo(((Student)y).Card.Series);
                if (ser_card == 0)
                {
                    return ((Student)x).Card.Number.CompareTo(((Student)y).Card.Number);
                }
                else return ser_card;
            }
            
            throw new NotImplementedException();
        }
    }
}
