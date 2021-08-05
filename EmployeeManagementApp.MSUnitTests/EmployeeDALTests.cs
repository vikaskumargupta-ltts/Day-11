using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmployeeManagementApp.DataModels;
using EmployeeManagementApp.DataAccessLayer;
using System.Collections.Generic;
using EmployeeManagementApp.CustomExceptions;

namespace EmployeeManagementApp.MSUnitTests
{
    [TestClass]
    public class EmployeeDALTests
    {
        [TestMethod]
        public void GetAllEmployees_Test()
        {
            //Create an EmployeeDAL Object
            IEmployeeDAL employeeDAL = new EmployeeDAL();
            //Invoke the GetAllEmployees Method
            var lstEmps = employeeDAL.GetAllEmployees();
            //Assert that the return value is not null
            Assert.IsNotNull(lstEmps);
            //Assert that the  return value is of List<Employee>
            Assert.IsInstanceOfType(lstEmps, typeof(List<Employee>));

            //Assert that the number of Employees returned is 4 
            int expectedCount = 4;
            Assert.AreEqual(expectedCount, lstEmps.Count);
        }
        [TestMethod]
        public void AddNewEmployee_Test()
        {
            //Create an EmployeeDAL Object
            IEmployeeDAL employeeDAL = new EmployeeDAL();
            //Invoke GetAllEmployees Method - Find the existing count of employee
            //expected = count +1
            int expectedCountAfterAddition = (employeeDAL.GetAllEmployees()).Count + 1;
            //Create a new Employee Object
            //set the properties
            //Invoke the AddNewEmployeeMethod
            Employee employee = new Employee();
            
            employee.Name = "River under cliff ਆਈ";
            employee.Salary = 77777.77m;
            employee.DateOfBirth = DateTime.Now.AddYears(-42).Date;
            Employee addedEmp = employeeDAL.AddNewEmployee(employee);
            //Asserts

            //Assert not null
            Assert.IsNotNull(addedEmp);
            //Assert Employee Type
            Assert.IsInstanceOfType(addedEmp, typeof(Employee));
            //Assert are properties Name, DateOfBirth and Salary are identical with the values that you passed to the method
            Assert.AreEqual(employee.Name, addedEmp.Name);
            Assert.AreEqual(employee.DateOfBirth, addedEmp.DateOfBirth);
            Assert.AreEqual(employee.Salary, addedEmp.Salary);

            //Post Effect
            //Invoke GetAllEmployees - Actual
            int actualEmployeesAfterAddtion = employeeDAL.GetAllEmployees().Count;
            //Assert(expected,acutal)
            Assert.AreEqual(expectedCountAfterAddition, actualEmployeesAfterAddtion);


        }
        //Must return an employee based on the Id
        [TestMethod]
        public void Get_Employee_ById_Test_ExistingId()
        {
            //Create an EmployeeDAL Object
            IEmployeeDAL employeeDAL = new EmployeeDAL();
            Employee emp = employeeDAL.GetEmployeeById(7);
            Assert.IsNotNull(emp);
            //Assert Employee Type
            Assert.IsInstanceOfType(emp, typeof(Employee));


        }
        [TestMethod]
        [ExpectedException(typeof(NoEmployeeFoundException))]
        public void Get_Employee_ById_Test_NonExistentId_ThrowsException()
        {
            //Create an EmployeeDAL Object
            IEmployeeDAL employeeDAL = new EmployeeDAL();
            Employee emp = employeeDAL.GetEmployeeById(92);
            Assert.IsNotNull(emp);
            //Assert Employee Type
            Assert.IsInstanceOfType(emp, typeof(Employee));


        }
        [TestMethod]
        public void Get_Employee_ByBaseAge_Test_WithinBounds()
        {
            //Create an EmployeeDAL Object
            IEmployeeDAL employeeDAL = new EmployeeDAL();
            var emp = employeeDAL.SearchEmployeesByAge(20);
            Assert.IsNotNull(emp);
            //Assert Employee Type
            Assert.IsInstanceOfType(emp, typeof(List<Employee>));


        }
        [TestMethod]
        [ExpectedException(typeof(NoEmployeeFoundException))]
        public void Get_Employee_ByBaseAge_Test_OutsideBounds()
        {
            //Create an EmployeeDAL Object
            IEmployeeDAL employeeDAL = new EmployeeDAL();
            var lstEmps = employeeDAL.SearchEmployeesByAge(200);
            Assert.IsNotNull(lstEmps);
            //Assert Employee Type
            Assert.IsInstanceOfType(lstEmps, typeof(List<Employee>));


        }
        [TestMethod]
        [ExpectedException(typeof(InvalidAgeException))]
        public void Get_Employee_ByBaseAge_Test_OutsideBounds_NegativeValue()
        {
            //Create an EmployeeDAL Object
            IEmployeeDAL employeeDAL = new EmployeeDAL();
            var lstEmps = employeeDAL.SearchEmployeesByAge(-1);
            Assert.IsNotNull(lstEmps);
            //Assert Employee Type
            Assert.IsInstanceOfType(lstEmps, typeof(List<Employee>));


        }

        [TestMethod]
        public void Get_Employee_ByBaseSalary_Test_WithinBounds()
        {
            //Create an EmployeeDAL Object
            IEmployeeDAL employeeDAL = new EmployeeDAL();
            var emp = employeeDAL.SearchEmployeesBySalary(200000);
            Assert.IsNotNull(emp);
            //Assert Employee Type
            Assert.IsInstanceOfType(emp, typeof(List<Employee>));


        }
        [TestMethod]
        [ExpectedException(typeof(NoEmployeeFoundException))]
        public void Get_Employee_ByBaseSalary_Test_OutsideBounds()
        {
            //Create an EmployeeDAL Object
            IEmployeeDAL employeeDAL = new EmployeeDAL();
            //Create an EmployeeDAL Object
            var emp = employeeDAL.SearchEmployeesBySalary(2000000);
            Assert.IsNotNull(emp);
            //Assert Employee Type
            Assert.IsInstanceOfType(emp, typeof(List<Employee>));


        }
        [TestMethod]
        [ExpectedException(typeof(InvalidSalaryException))]
        public void Get_Employee_ByBaseSalary_Test_OutsideBounds_NegativeValue()
        {
            //Create an EmployeeDAL Object
            IEmployeeDAL employeeDAL = new EmployeeDAL();
            //Create an EmployeeDAL Object
            var emp = employeeDAL.SearchEmployeesBySalary(-15000);
            Assert.IsNotNull(emp);
            //Assert Employee Type
            Assert.IsInstanceOfType(emp, typeof(List<Employee>));


        }
    }
}
