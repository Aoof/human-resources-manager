# Human Resources Manager

A Windows Forms desktop app for managing a company's employee records, built in C# with a three-tier design (UI, business logic, data access) over SQL Server. Coursework at Collège LaSalle (October 2025).

## Features
- Insert, update, delete and display employees: ID, first and last name, email, SSN and hire date
- Search by employee ID or SSN
- Validation in the business layer for IDs, names, email format and SSN format, with custom exceptions
- A feedback panel that reports each result or error
- Data access through ADO.NET and a typed DataSet

## Architecture
```
UI/   HR_ManagerApp form: inputs, action buttons, data grid, feedback
BLL/  Employee entity, Validator, HighTechExceptions
DAL/  ConnectionDB, EmployeeDB (CRUD queries), DataExceptions, HighTechDataSet
Documentation/Employee.sql   table schema and 10 sample employees
```

## Tech
C#, .NET Framework 4.7.2, Windows Forms, ADO.NET, SQL Server LocalDB

## Run it
Requires Windows and Visual Studio with the .NET desktop development workload (LocalDB is included).

1. Clone the repository and open `HumanResourcesManager_Solution/HumanResourcesManager_Solution.sln`.
2. Create the database: in **Server Explorer**, add a SQL Server database file named `HighTechDB.mdf` in the project's `DAL` folder (the connection string `HighTechDBConnectionString` in `App.config` attaches `DAL\HighTechDB.mdf` through `(LocalDB)\MSSQLLocalDB`).
3. Run `Documentation/Employee.sql` against it to create the `Employee` table and the sample rows.
4. Press **F5**.

## License
[MIT](LICENSE.txt)

## Author
Abdulrahman (Aoof) Mousa · [aoof.ca](https://aoof.ca)
