using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Icomparable
{
    internal class Student_SortFirstNameDSc : IComparer<Student>
    {

        int IComparer<Student>.Compare(Student x, Student y)
        {
            return x.FirstName.CompareTo(y.FirstName) * -1;


        }//main
    }//class

    
}//namespcae
