using HrManagementLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCase
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Console.ReadLine();
        }

        public static void SeedData(List<IEmployee> employee)
        {
            IEmployee teacher1 = new Teacher
            {
                Id = 1,
                FirstName = "David",
                LastName = "Moore",
                Salary = 4000

            };

            employee.Add(teacher1);

            IEmployee teacher2 = new Teacher
            {
                Id = 2,
                FirstName = "John",
                LastName = "Banner",
                Salary = 4500
            };

            employee.Add(teacher2);

            IEmployee headOfDepartment = new HeadOfDepartment { 
            
             Id = 3,
             FirstName = "Mario",
             LastName = "Kings",
             Salary = 6000
            };

            employee.Add(headOfDepartment);

            IEmployee deputyHeadMaster = new DeputyHeadMaster
            {
                Id = 4,
                FirstName = "Michael",
                LastName = "Nartey",
                Salary = 7500
            };

            employee.Add(deputyHeadMaster);

            IEmployee headMaster = new HeadMaster {
                Id = 5,
                FirstName = "Joseph",
                LastName = "Hagan",
                Salary = 8000
            
            };

            employee.Add(headMaster);
        }

        

        
    }
}
