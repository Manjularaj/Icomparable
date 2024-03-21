using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Icomparable
{
    public class Student_SortGenEdGrade
    {

        public enum Order { Ascending, Descending}
        public Order SortingOrder = Order.Ascending;

        public Student_SortGenEdGrade()
        {
            SortingOrder = Order.Ascending;

        }

        public Student_SortGenEdGrade(Order sortingOrder)
        {

            SortingOrder = sortingOrder;
        }

        
    }
}
