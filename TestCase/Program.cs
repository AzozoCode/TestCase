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

           //  decimal totalSalaries = 0;

            List<IEmployee> employees = new List<IEmployee>();

            SeedData(employees);

            unsafe
            {
                
                int x = 100;

                int* pointer = &x;

                Console.WriteLine((int)pointer);
                Console.WriteLine($"The int value is : {*pointer}");
                Console.WriteLine($"The string value is : {pointer->ToString()}");
            }
            

            Console.WriteLine($"Total Annual Salaries (including bonus) : {employees.Sum(e => e.Salary)}");
            Console.ReadKey();
        }

        public static void SeedData(List<IEmployee> employee)
        {
            IEmployee teacher1 = EmployeeFactory.GetEmployeeInstance(EmployeeType.Teacher, 1, "Randy", "Barrigah", 40000);
            employee.Add(teacher1);

            IEmployee teacher2 = EmployeeFactory.GetEmployeeInstance(EmployeeType.Teacher, 2, "John", "Banner", 45000);
           employee.Add(teacher2);

            IEmployee headOfDepartment = EmployeeFactory.GetEmployeeInstance(EmployeeType.HeadOfDepartment, 3, "Mario", "Kings", 48000); 
            employee.Add(headOfDepartment);

            IEmployee deputyHeadMaster = EmployeeFactory.GetEmployeeInstance(EmployeeType.DeputyHeadMaster, 4, "Michael", "Nartey", 52000);
            employee.Add(deputyHeadMaster);

            IEmployee headMaster = EmployeeFactory.GetEmployeeInstance(EmployeeType.HeadMaster, 4, "Joseph", "Hagan", 58000);
            employee.Add(headMaster);
        }

        
        
        
    }
}
