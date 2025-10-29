using System;
using System.Text.RegularExpressions;

namespace HumanResourcesManager_Project.BLL
{
    internal class Validator
    {
        public static int ValidateId(int id)
        {
            if (id < 0 || id > 999999999)
            {
                throw new ValidationException("ID is out of range, must be a valid number between 1 digit to 9");
            }

            return id;
        }

        public static string ValidateName(string name, string fieldName)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ValidationException($"{fieldName} cannot be empty");
            }

            if (!Regex.IsMatch(name, @"^[a-zA-Z\s\'\-\,]+$"))
            {
                throw new ValidationException($"{fieldName} contains invalid characters");
            }

            return name;
        }

        public static string ValidateEmail(string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                throw new ValidationException("Email cannot be empty");
            }

            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                throw new ValidationException("Email format is invalid");
            }

            return email;
        }

        public static string ValidateSSN(string ssn)
        {
            if (string.IsNullOrEmpty(ssn))
            {
                throw new ValidationException("Social Security Number cannot be empty");
            }

            if (!Regex.IsMatch(ssn, @"^[0-9]{3}\-[0-9]{3}\-[0-9]{3}$"))
            {
                throw new ValidationException("Social Security Number was in the wrong format (Must be XXX-XXX-XXX)");
            }

            return ssn;
        }
    }
}
