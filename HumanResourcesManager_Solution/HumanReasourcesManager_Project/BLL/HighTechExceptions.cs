using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourcesManager_Project.BLL
{
    internal class ValidationException : Exception
    {
        public ValidationException() : base("There was a problem validating input") { }
        public ValidationException(string message) : base(message) { }
        public ValidationException(string message, Exception innerException) : base(message, innerException) { }
    }

    internal class EmployeeNotFoundException : Exception
    {
        public EmployeeNotFoundException() : base("Employee not found") { }
        public EmployeeNotFoundException(string message) : base(message) { }
        public EmployeeNotFoundException(string message, Exception innerException) : base(message, innerException) { }
    }
}
