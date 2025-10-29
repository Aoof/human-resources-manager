using System;
using System.Collections.Generic;
using HumanResourcesManager_Project.DAL;

namespace HumanResourcesManager_Project.BLL
{
    internal class Employee
    {
        private static List<Employee> employees = new List<Employee>();

        private int id;
        private string firstName;
        private string lastName;
        private string email;
        private string ssn;
        private DateTime hireDate;

        public int Id
        {
            get { return id; }
            set { id = Validator.ValidateId(value); }
        }

        public string FirstName
        { 
            get { return firstName; } 
            set { firstName = Validator.ValidateName(value, "First Name"); } 
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = Validator.ValidateName(value, "Last Name"); }
        }

        public string Email
        {
            get { return email; }
            set { email = Validator.ValidateEmail(value); }
        }

        public string Ssn
        {
            get { return ssn; }
            set { ssn = Validator.ValidateSSN(value); }
        }

        public DateTime HireDate
        {
            get { return hireDate; }
            set { hireDate = value; }
        }
        public static List<Employee> Employees
        {
            get { return employees; }
        }

        public Employee()
        {
            Id = 0;
            FirstName = "John";
            LastName = "Doe";
            Email = "john@doe.com";
            Ssn = "000-000-000";
            HireDate = DateTime.Now;
        }

        public Employee(int id, string firstName, string lastName, string email, string ssn, DateTime hireDate)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Ssn = ssn;
            HireDate = hireDate;
        }

        public Employee(Employee other)
        {
            Id = other.Id;
            FirstName = other.FirstName;
            LastName = other.LastName;
            Email = other.Email;
            Ssn = other.Ssn;
            HireDate = other.HireDate;
        }

        public static void Insert(Employee entity)
        {
            EmployeeDB.Insert(entity);
            GetAllEmployees();
        }

        public static void Update(Employee entity)
        {
            EmployeeDB.Update(entity);
            GetAllEmployees();
        }

        public static void Delete(int id)
        {
            Employee tmp = new Employee { Id = id };
            EmployeeDB.Delete(tmp);
            GetAllEmployees();
        }

        public static void SearchEmployees(string searchId = "", string searchSsn = "")
        {
            GetAllEmployees();
            List<Employee> searchResults = new List<Employee>();
            foreach (Employee emp in employees)
            {
                if (
                    (!String.IsNullOrEmpty(searchId) && emp.Id.ToString().Contains(searchId)) || 
                    (!String.IsNullOrEmpty(searchSsn) && emp.Ssn.Equals(searchSsn))
                   )
                {
                    searchResults.Add(emp);
                }
            }

            employees = searchResults;

            if (employees == null || employees.Count == 0)
            {
                GetAllEmployees();
                throw new EmployeeNotFoundException("No employees found matching the search criteria.");
            }
        }

        public static List<Employee> GetAllEmployees()
        {
            employees = EmployeeDB.GetEmployees();
            return employees;
        }
    }
}
