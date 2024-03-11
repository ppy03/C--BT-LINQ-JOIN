using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap3
{
    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }
        public DateTime Birthday { get; set; }

        public int DepartmentID { get; set; }

        public static List<Employee> GetEmployees()
        {
            return new List<Employee>() {
                new Employee {ID = 1, Name = "A", Age = 20,Salary = 1000000, Birthday =  new DateTime(2004, 12, 13), DepartmentID = 1},
                new Employee {ID = 2, Name = "D", Age = 21, Salary = 2000000, Birthday = new DateTime(2003, 2, 13), DepartmentID = 2},
                new Employee {ID = 3, Name = "C", Age = 20, Salary = 2500000, Birthday = new DateTime(2004, 4, 17), DepartmentID = 3},
                new Employee {ID = 4, Name = "B", Age = 22, Salary = 5000000, Birthday = new DateTime(2002, 8, 5), DepartmentID = 4},
                new Employee {ID = 5, Name = "E", Age = 23, Salary = 3500000, Birthday = new DateTime(2001, 3, 3), DepartmentID = 5},
            };
        }
    }
}
