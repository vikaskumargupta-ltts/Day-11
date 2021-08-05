using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagementApp.DataModels;
using EmployeeManagementApp.CustomExceptions;

namespace EmployeeManagementApp.DataAccessLayer
{
    public class EmployeeDAL : IEmployeeDAL
    {
        private HREntities ctx = null;
        public EmployeeDAL()
        {
            this.ctx = new HREntities();
        }
        public Employee AddNewEmployee(Employee objNewEmp)
        {
            this.ctx.Employees.Add(objNewEmp);
            this.ctx.SaveChanges();
            //get the employee added recently
            var newEmpFromDB = (from emp in ctx.Employees
                                where emp.Name == objNewEmp.Name && emp.DateOfBirth == objNewEmp.DateOfBirth.Date
                                select emp).SingleOrDefault();

            //return the employee
            return newEmpFromDB;
        }

        public List<Employee> GetAllEmployees()
        {
            List<Employee> lstEmps = null;
            try
            {
                lstEmps = (from emp in ctx.Employees
                           select emp).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lstEmps;
        }

        public Employee GetEmployeeById(int EmployeeId)
        {
            Employee thisEmployee = null;

            try
            {
                thisEmployee = (from emp in ctx.Employees
                                where emp.Id == EmployeeId
                                select emp).SingleOrDefault();
                if (thisEmployee == null)
                {
                    throw new NoEmployeeFoundException("Employee not found for Id " + EmployeeId.ToString());
                }
            }
            catch (NoEmployeeFoundException ex)
            {
                //rethrow
                throw ex;
            }
            return thisEmployee;
        }

        public Employee RemoveEmployee(Employee empToRemove)
        {
            throw new NotImplementedException();
        }
        
        //BaseAge - 18-60
        //returns List<Employees> Matching the criteria
        //Throws InvalidAgeException is age is below 18 or above 60
        //Throws NoEmployeeFoundException if criteria is not matched

        public List<Employee> SearchEmployeesByAge(int BaseAge)
        {
            if(BaseAge < 18)
            {
                throw new InvalidAgeException("The age is less than statutory age");
            }
            //SEt the cutoff date based on BaseAge
            DateTime cutOffDate = DateTime.Now.AddYears(-BaseAge);

            //create a linq query where the employee DOB is less than the cut-off date
            var lstEmps = from emp in ctx.Employees
                          where emp.DateOfBirth < cutOffDate
                          select emp;
            // if no employees found throw NoEmployeeFound exception
            if((lstEmps == null) || (lstEmps.ToList().Count == 0))
            {
                throw new NoEmployeeFoundException("No Employee found older than " + BaseAge.ToString() + " years");
            }
            //return the list
            return lstEmps.ToList();

        }

        public List<Employee> SearchEmployeesBySalary(int BaseSalary)
        {
            if (BaseSalary < 0)
            {
                throw new InvalidSalaryException("Employees salary cannot be negative");
            }
                      

            //create a linq query where the employee salary is above the BaseSalary
            var lstEmps = from emp in ctx.Employees
                          where emp.Salary >= BaseSalary
                          select emp;
            // if no employees found throw NoEmployeeFound exception
            if ((lstEmps == null) || (lstEmps.ToList().Count == 0))
            {
                throw new NoEmployeeFoundException("No Employee found with salary above " + BaseSalary.ToString() );
            }
            //return the list
            return lstEmps.ToList();
        }

        public Employee UpdateEmployee(int EmpId, Employee empToUpdate)
        {
            throw new NotImplementedException();
        }
    }


}
