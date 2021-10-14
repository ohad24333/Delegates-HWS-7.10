using System;

namespace MechlalaDll
{
    public class Student
    {
        public int Age { get; set; }
        public int Grade { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int Debt { get; set; }
        public int Paid { get; set; }
        public override string ToString()
        {
            return FirstName +" "+ LastName;
        }

    }
}
