using EmployeeManagementApp.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementApp.DataAccessLayer
{
    public interface IEmployeeDAL
    {
        //Define the Operations on the Interface
        //Unit Testcases can be written using the interface definitions

            //CRUD - Create, Retrieve, Update and Delete
        List<Employee> GetAllEmployees();

        List<Employee> SearchEmployeesBySalary(int BaseSalary);

        List<Employee> SearchEmployeesByAge(int BaseAge);

        Employee GetEmployeeById(int EmployeeId);

        Employee AddNewEmployee(Employee objNewEmp);

        Employee UpdateEmployee(int EmpId, Employee empToUpdate);

        Employee RemoveEmployee(Employee empToRemove);


    }
}
