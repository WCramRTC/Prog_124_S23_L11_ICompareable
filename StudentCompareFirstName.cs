﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_S23_L11_ICompareable
{
    internal class StudentCompareFirstName : IComparer<Student>
    {



        public int Compare(Student? x, Student? y)
        {
            return x.FirstName.CompareTo(y.FirstName);
        }
    }
}
