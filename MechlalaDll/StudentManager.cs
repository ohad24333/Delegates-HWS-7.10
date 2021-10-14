using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MechlalaDll
{
    public delegate bool FilterDelegate(Student student);

    public delegate int SumForDelegate(Student student);

    public delegate decimal AverageByDelegate(Student student);
    public static class StudentManager
    {
        static List<Student> studentsList = new List<Student>()
        {
            new Student {FirstName = "ohad", LastName = "Saadia",Age = 27,Grade = 100 , Debt = 55 , Paid = 89},
            new Student {FirstName = "omer", LastName = "oz",Age = 30,Grade =40 , Debt = 900 , Paid = 55},
            new Student {FirstName = "Eden", LastName = "lev",Age = 26,Grade =60 , Debt = 90 , Paid = 40},
            new Student {FirstName = "Barak", LastName = "mor",Age = 22,Grade =80, Debt = 53 , Paid = 799 },
        };

        public static void AddStudentToList(Student student)
        {
            studentsList.Add(student);
        }

        public static void RemoveStudentFromList(Student student)
        {
            studentsList.Remove(student);
        }

        public static List<Student> Filter(FilterDelegate filterDelegate)
        {
            List<Student> list = new List<Student>();
            foreach (Student student in studentsList)
            {
                if (filterDelegate(student))
                {
                    list.Add(student);
                }
            }
            return list;
        }

        public static List<Student> GetStudentList()
        {
            return studentsList;
        }

        public static bool Contain(FilterDelegate filterDelegate)
        {         
            foreach (var student in studentsList)
            {
                if (filterDelegate(student)) return true;
            }
            return false;
        }

        public static int Sum(SumForDelegate sumForDelegate)
        {
            int sum = 0;
            foreach (var student in studentsList)
            {
                sum += sumForDelegate(student);
            }
            return sum;
        }

        public static decimal Average(AverageByDelegate averageByDelegate)
        {
            decimal sum = 0;
            int count = 0;
            foreach (var student in studentsList)
            {
                sum += averageByDelegate(student);
                count++;
            }
            return sum / count;
            
        }
    }
}
