using HumanResourcesManager_Project.BLL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace HumanResourcesManager_Project.DAL
{
    internal class EmployeeDB
    {
        private static SqlConnection connection = null;
        private static SqlCommand command = null;
        public static void Insert(Employee entity)
        {
            try
            {
                connection = ConnectionDB.GetConnection();
                string insertQuery = "INSERT INTO Employee (Id, FirstName, LastName, Email, Ssn, HireDate) " +
                                     "VALUES (@Id, @FirstName, @LastName, @Email, @Ssn, @HireDate)";
                command = new SqlCommand(insertQuery, connection);
                command.Parameters.AddWithValue("@Id", entity.Id);
                command.Parameters.AddWithValue("@FirstName", entity.FirstName);
                command.Parameters.AddWithValue("@LastName", entity.LastName);
                command.Parameters.AddWithValue("@Email", entity.Email);
                command.Parameters.AddWithValue("@Ssn", entity.Ssn);
                command.Parameters.AddWithValue("@HireDate", entity.HireDate);
                command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new DataAccessException("An error occurred while inserting the employee record.", ex);
            }
            finally
            {
                ConnectionDB.CloseConnection();
            }
        }

        public static void Update(Employee entity)
        {
            try
            {
                connection = ConnectionDB.GetConnection();
                string updateQuery = "UPDATE Employee SET FirstName = @FirstName, LastName = @LastName, " +
                                     "Email = @Email, Ssn = @Ssn, HireDate = @HireDate WHERE Id = @Id";
                command = new SqlCommand(updateQuery, connection);
                command.Parameters.AddWithValue("@Id", entity.Id);
                command.Parameters.AddWithValue("@FirstName", entity.FirstName);
                command.Parameters.AddWithValue("@LastName", entity.LastName);
                command.Parameters.AddWithValue("@Email", entity.Email);
                command.Parameters.AddWithValue("@Ssn", entity.Ssn);
                command.Parameters.AddWithValue("@HireDate", entity.HireDate);
                command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new DataAccessException("An error occurred while updating the employee record.", ex);
            }
            finally
            {
                ConnectionDB.CloseConnection();
            }
        }

        public static void Delete(Employee entity)
        {
            try
            {
                connection = ConnectionDB.GetConnection();
                string deleteQuery = "DELETE FROM Employee WHERE Id = @Id";
                command = new SqlCommand(deleteQuery, connection);
                command.Parameters.AddWithValue("@Id", entity.Id);
                command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new DataAccessException("An error occurred while deleting the employee record.", ex);
            }
            finally
            {
                ConnectionDB.CloseConnection();
            }
        }

        public static Employee GetById(int id)
        {
            Employee employee = null;
            try
            {
                connection = ConnectionDB.GetConnection();
                string selectQuery = "SELECT Id, FirstName, LastName, Email, Ssn, HireDate FROM Employee WHERE Id = @Id";
                command = new SqlCommand(selectQuery, connection);
                command.Parameters.AddWithValue("@Id", id);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    employee = new Employee
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        FirstName = Convert.ToString(reader["FirstName"]),
                        LastName = Convert.ToString(reader["LastName"]),
                        Email = Convert.ToString(reader["Email"]),
                        Ssn = Convert.ToString(reader["Ssn"]),
                        HireDate = (DateTime)reader["HireDate"]
                    };
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                throw new DataAccessException("An error occurred while retrieving the employee data.", ex);
            }
            finally
            {
                ConnectionDB.CloseConnection();
            }
            return employee;
        }

        public static List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            try
            {
                connection = ConnectionDB.GetConnection();
                string selectQuery = "SELECT * FROM Employee";
                command = new SqlCommand(selectQuery, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Employee employee = new Employee
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        FirstName = Convert.ToString(reader["FirstName"]),
                        LastName = Convert.ToString(reader["LastName"]),
                        Email = Convert.ToString(reader["Email"]),
                        Ssn = Convert.ToString(reader["Ssn"]),
                        HireDate = (DateTime)reader["HireDate"]
                    };
                    employees.Add(employee);
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                throw new DataAccessException("An error occurred while retrieving the employees data.", ex);
            }
            finally
            {
                ConnectionDB.CloseConnection();
            }
            return employees;
        }
    }
}
