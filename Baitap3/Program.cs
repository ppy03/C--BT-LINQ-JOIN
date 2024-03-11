using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = Employee.GetEmployees();

            //cau1
            Console.WriteLine("Maximum Salary: " + employees.Max(e => e.Salary));
            Console.WriteLine("Min Salary: " + employees.Min(e => e.Salary));
            Console.WriteLine("Average Salary: " + employees.Average(e => e.Salary));

            //cau2
            // group join
            var employeesByDepartment = from d in Department.GetDepartments()
                                        join e in Employee.GetEmployees()
                                        on d.ID equals e.DepartmentID into eGroup
                                        select new
                                        {
                                            Department = d,
                                            Employee = eGroup
                                        };
            foreach (var department in employeesByDepartment)
            {
                Console.WriteLine(department.Department.Name);
                foreach(var employee in department.Employee)
                {
                    Console.WriteLine(" " + employee.Name);
                }
                Console.WriteLine();
            }
            // left outer join
            var result = from e in Employee.GetEmployees()
                         join d in Department.GetDepartments()
                         on e.DepartmentID equals d.ID into eGroup
                         from d in eGroup.DefaultIfEmpty()
                         select new
                         {
                             employeeName = e.Name,
                             DepartmentName = d== null ? "No Department" : d.Name

                         };
            foreach (var employee in result)
            {
                Console.WriteLine("{0}-{1}", employee.employeeName, employee.DepartmentName);
            }
            Console.WriteLine();

            // right outer join 
            var result2 = from d in Department.GetDepartments()
                         join e in Employee.GetEmployees()
                         on d.ID equals e.DepartmentID into eGroup
                         from e in eGroup.DefaultIfEmpty()
                         select new
                         {
                             DepartmentName = d == null ? "No Department" : d.Name,
                             EmployeeName = e == null ? "No Employee" : e.Name
                         };

            foreach (var item in result)
            {
                Console.WriteLine("{0}-{1}", item.employeeName, item.DepartmentName);
            }
            Console.WriteLine();

            //cau3
            int maxAge = employees.Max(e => CalculateAge(e.Birthday));
            int minAge = employees.Min(e => CalculateAge(e.Birthday));

            Console.WriteLine($"Max Age: {maxAge}");
            Console.WriteLine($"Min Age: {minAge}");

            int CalculateAge(DateTime bt)
            {
                DateTime today = DateTime.Today;
                int age = today.Year - bt.Year;
                if (bt.Date > today.AddYears(-age))
                    age--;
                return age;
            }


        }
    }
}
