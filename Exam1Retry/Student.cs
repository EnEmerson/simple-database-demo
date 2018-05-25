using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1Retry
{
    class Student
    {
        private string firstName;
        private string lastName;
        private int age;

        public Student()
        {
            //default constructor
        }

        public Student(string pFirst, string pLast, int pAge)
        {
            firstName = pFirst;
            lastName = pLast;
            age = pAge;
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
    }
}
