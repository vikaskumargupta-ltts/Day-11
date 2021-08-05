using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementApp.CustomExceptions
{
    public class NoEmployeeFoundException : System.Exception
    {
               public NoEmployeeFoundException(string Message) : base(Message) { }
        
     
    }

    public class InvalidAgeException : System.Exception
    {
        public InvalidAgeException(string Message) : base(Message) { }


    }

    public class InvalidSalaryException : System.Exception
    {
        public InvalidSalaryException(string Message) : base(Message) { }


    }

}
