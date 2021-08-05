using System;
using NUnit.Framework;
using System.Collections.Generic;
using TestStack.White;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;
using System.Threading;
using TestStack.White.UIItems.TableItems;

namespace EmployeeManagementApp.WhiteTests
{
    [TestFixture]
    public class frmLoginTests
    {
        Application thisApp = null;
        List<Window> appWindows = null;
        Window currentWindow = null;
        [OneTimeSetUp]
        public void Setup()
        {
            //Launch the application from the exe - using FilePath
            thisApp = Application.Launch(@"D:\Training Data\L&T Testing-Jul-Aug-2021\CodeFactory\Day11\EmployeeManagementApp\Day-11\EmployeeManagementApp\bin\Debug\EmployeeManagementApp.exe");
            appWindows = thisApp.GetWindows();
            //Get the opening window (loginwindow)
            //Check that the application is open
            if (thisApp == null)
            {
                //fail the test
                return;
            }
            //find the window with name "Employee Management Login" and acquire a reference to the Login Window
            currentWindow = appWindows.Find(x => x.Name == "Employee Management Login");
        }

        [Test, Order(1)]
        //[TestCase(1, TestName = "UI-Login-001-InvalidCredentials")]
        public void Open_LoginForm_Test_ZInvalidCredentials()
        {

            TextBox txtBoxUserId = currentWindow.Get<TextBox>(SearchCriteria.ByAutomationId("txtUserId"));

            //Follow the best practice of waiting for Automation Inputs
            Thread.Sleep(3000);
            //set the value of the TextBox to admin
            txtBoxUserId.SetValue("admin1");
            Thread.Sleep(3000);

            TextBox txtPassword = currentWindow.Get<TextBox>(SearchCriteria.ByAutomationId("txtPassword"));
            txtPassword.SetValue("admin");
            Thread.Sleep(3000);

            //Get a reference to the Login button

            Button btnLogin = currentWindow.Get<Button>(SearchCriteria.ByAutomationId("btnLogin"));
            Thread.Sleep(3000);
            //click on the button
            btnLogin.Click();
            //wait for the new form to load

            Label lblLoginError = currentWindow.Get<Label>(SearchCriteria.ByAutomationId("lblLoginError"));

            Assert.AreEqual("Login Error", lblLoginError.Text);

        }
        [Test, Order(2)]
       // [TestCase(2, TestName = "UI-Login-002-ValidCredentials")]
        public void Open_LoginForm_Test_ValidCredentials()
        {

            //Get the textBox in the form that has the AutomationId = txtUserId

            TextBox txtBoxUserId = currentWindow.Get<TextBox>(SearchCriteria.ByAutomationId("txtUserId"));

            //Follow the best practice of waiting for Automation Inputs
            Thread.Sleep(3000);
            //set the value of the TextBox to admin
            txtBoxUserId.SetValue("admin");
            Thread.Sleep(3000);

            TextBox txtPassword = currentWindow.Get<TextBox>(SearchCriteria.ByAutomationId("txtPassword"));
            txtPassword.SetValue("admin");
            Thread.Sleep(3000);

            //Get a reference to the Login button

            Button btnLogin = currentWindow.Get<Button>(SearchCriteria.ByAutomationId("btnLogin"));
            Thread.Sleep(3000);
            //click on the button
            btnLogin.Click();
            //wait for the new form to load
            Thread.Sleep(3000);
            //Check if the name of the new form is 
            string expectedWindowsTitle = "Employees List";
             currentWindow = thisApp.GetWindows()[0];
            string actualWindowTitle = currentWindow.Name;
            Assert.AreEqual(expectedWindowsTitle, actualWindowTitle);
           
            

        }
        [Test,Order(3)]
        public void EmployesListForm_Displays_12Employees_ByDefault()
        {
            //check if the grid displays a list of 12 employees
            int expectedEmployeeCount = 12;
            //get a reference to the dataGridView
            string strEmpListWindowName = currentWindow.Name;
            var btnLoadEmployees = currentWindow.Get<Button>(SearchCriteria.ByAutomationId("btnLoadEmployees"));
            Thread.Sleep(3000);
            btnLoadEmployees.Click();
            Thread.Sleep(5000);
            var lstTableEmps = currentWindow.Get<Table>(SearchCriteria.ByAutomationId("dgViewEmployeesList"));
            int actualEmployeeCount = lstTableEmps.Rows.Count;
            Assert.AreEqual(expectedEmployeeCount, actualEmployeeCount);
        }

        [OneTimeTearDown]
        public void TeamDown()
        {
            //Close current Window
            currentWindow.Close();
            thisApp.Close();
        }
    }
}
