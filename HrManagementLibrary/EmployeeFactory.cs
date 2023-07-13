using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrManagementLibrary
{
    public static class EmployeeFactory
    {
        
        
            public  static IEmployee GetEmployeeInstance(EmployeeType employeeType,int id,string firstName, string lastName, decimal salary)
            {
                     IEmployee employee = null;

                    switch (employeeType)
                    {
                        case EmployeeType.Teacher:
                            employee = FactoryPattern<IEmployee,Teacher>.GetInstance();
                            break;


                        case EmployeeType.HeadOfDepartment:
                            employee = FactoryPattern<IEmployee, HeadOfDepartment>.GetInstance();
                            break;

                        case EmployeeType.DeputyHeadMaster:
                            employee = FactoryPattern<IEmployee, DeputyHeadMaster>.GetInstance();
                            break;

                        case EmployeeType.HeadMaster:
                            employee = FactoryPattern<IEmployee, HeadMaster>.GetInstance();
                            break;

                        default:
                            break;

                    }

                    if(employee != null)
                    {
                        employee.Id = id;
                        employee.FirstName = firstName;
                        employee.LastName = lastName;
                        employee.Salary = salary;

            }
                    else
                    {
                        throw  new NullReferenceException();
                    }

                     return employee;
            }
        
    }
}
