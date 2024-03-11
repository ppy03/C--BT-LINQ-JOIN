using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap3
{
    class Department
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public static List<Department> GetDepartments()
        {
            return new List<Department>() {
                new Department {ID = 1, Name = "IT"},
                new Department {ID =  2, Name = "HR"},
                new Department {ID = 3 ,Name = "Maketing" },
                new Department {ID = 4 ,Name = "Sale" },
                new Department {ID = 5 ,Name = "Dev" },
            };
        }
    }
}
