using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_S23_L11_ICompareable
{
    internal class Student : IComparable<Student>
    {
        // abstracting the list

        // IComparable
        // IComparer

        // 3 Fields
        string _firstName;
        string _lastName;
        int _grade;

        public Student(string firstName, string lastName, int grade)
        {
            _firstName = firstName;
            _lastName = lastName;
            _grade = grade;
        }

        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public int Grade { get => _grade; set => _grade = value; }

        // Calling .Sort on a list of an object, Calls the CompareTo method built inside of the object
        public int CompareTo(Student? other)
        {
            // We are going to compare two fields

     
            // else if they are the same, return 0

            // If the current object is GREATER than the other object, return 1

            // To reverse the result, either swap the greater and less than, or which numbers are returned, 1 and -1
            if (this._grade > other._grade)
            {
                return -1;
            }
            // If the current object is LESS THAN, return -1
            else if (this._grade < other._grade)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public override string ToString()
        {
            return $"{_firstName} {_lastName} - {_grade}";
        }
    }
}
