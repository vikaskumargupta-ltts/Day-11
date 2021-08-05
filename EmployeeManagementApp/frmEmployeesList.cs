using EmployeeManagementApp.CustomExceptions;
using EmployeeManagementApp.DataAccessLayer;
using EmployeeManagementApp.DataModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementApp
{
    public partial class frmEmployeesList : Form
    {
        public frmEmployeesList()
        {
            InitializeComponent();
        }

        private void btnLoadEmployees_Click(object sender, EventArgs e)
        {
            this.tsLblErrorMessage.Text = String.Empty;
            EmployeeDAL objDAL = new EmployeeDAL();
            this.dgViewEmployeesList.DataSource = objDAL.GetAllEmployees();
        }

        private void btnAddNewEmployee_Click(object sender, EventArgs e)
        {
            this.tsLblErrorMessage.Text = String.Empty;
            EmployeeDAL objDAL = new EmployeeDAL();
            //create a new Employee Object
            Employee objEmp = new Employee();
            objEmp.Name = txtEmpName.Text.ToString().Trim();
            objEmp.DateOfBirth = dTPDateOfBirth.Value;
            objEmp.Salary = Decimal.Parse(txtSalary.Text);
            Employee returnedEmployeeFromDB = objDAL.AddNewEmployee(objEmp);
        }

        private void btnSearchByEmployeeId_Click(object sender, EventArgs e)
        {
            this.tsLblErrorMessage.Text = String.Empty;
            try
            {
                int empId = Int32.Parse(txtEmpId.Text);
                EmployeeDAL employeeDAL = new EmployeeDAL();
                Employee emp = employeeDAL.GetEmployeeById(empId);
                List<Employee> lstEmps = new List<Employee>();
                lstEmps.Add(emp);
                this.dgViewEmployeesList.DataSource = lstEmps;
            }
            catch (NoEmployeeFoundException ex)
            {
                tsLblErrorMessage.Text = ex.Message;
            }
            catch (Exception ex)
            {
                tsLblErrorMessage.Text = "No Employee Found";
            }
            
            
        }

        private void btnSearchByBaseAge_Click(object sender, EventArgs e)
        {
            this.tsLblErrorMessage.Text = String.Empty;
            try
            {
                int empBaseAge = Int32.Parse(txtBaseAge.Text);
                EmployeeDAL employeeDAL = new EmployeeDAL();
                List<Employee> lstEmps = employeeDAL.SearchEmployeesByAge(empBaseAge);
                this.dgViewEmployeesList.DataSource = lstEmps;
            }
            catch (NoEmployeeFoundException ex)
            {
                tsLblErrorMessage.Text = ex.Message;
            }
            catch (Exception ex)
            {
                tsLblErrorMessage.Text = "No Employee Found";
            }

        }

        private void btnSearchByBaseSalary_Click(object sender, EventArgs e)
        {
            this.tsLblErrorMessage.Text = String.Empty;
            try
            {
                int empBaseSalary = Int32.Parse(txtBaseSalary.Text);
                EmployeeDAL employeeDAL = new EmployeeDAL();
                List<Employee> lstEmps = employeeDAL.SearchEmployeesBySalary(empBaseSalary);
                this.dgViewEmployeesList.DataSource = lstEmps;
            }
            catch (InvalidSalaryException ex)
            {
                tsLblErrorMessage.Text = ex.Message;
            }
            catch (NoEmployeeFoundException ex)
            {
                tsLblErrorMessage.Text = ex.Message;
            }
            catch (Exception ex)
            {
                tsLblErrorMessage.Text = "No Employee Found";
            }
        }

        private void frmEmployeesList_Load(object sender, EventArgs e)
        {
            Button btn1 = new Button();
            btn1.Text = "First Button";
            btn1.Size = new Size(100, 20);
            btn1.Location = new Point(5, 5);

            panel1.Controls.Add(btn1);

            Button btn2 = new Button();
            btn2.Text = "Second Button";
            btn2.Size = new Size(100, 20);
            btn2.Location = new Point(5,100);
            panel1.Controls.Add(btn2);

        }
    }
}
