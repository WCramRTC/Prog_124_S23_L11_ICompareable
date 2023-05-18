using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_S23_L11_ICompareable
{
    internal class DemoCompare : IComparable<DemoCompare>
    {
        string _name;
        int _number;
        DateTime _date;

        public DemoCompare(string name, int number, DateTime date)
        {
            _name = name;
            _number = number;
            _date = date;
        }

        public int CompareTo(DemoCompare? other)
        {
            if(_number > other._number)
            {
                return 1;
            }
            else if (_number < other._number)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        public override string ToString()
        {
            return $"{_name} - Number: {_number} - DateTime: {_date.ToShortDateString()}";
        }
    }
}
