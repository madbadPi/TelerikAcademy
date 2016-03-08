/*--Write a SQL query to find the names and salaries of the 
--employees that take the minimal salary in the company. 
--Use a nested SELECT statement.
SELECT FirstName, Salary
FROM Employees
WHERE Salary = 
	(SELECT MIN(Salary)
	FROM Employees)

--Write a SQL query to find the names and salaries of the 
--employees that have a salary that is up to 10% higher than
-- the minimal salary for the company
SELECT FirstName, Salary
FROM Employees
WHERE Salary <= 
	(SELECT (MIN(Salary)+(10*MIN(Salary))/100)	
	FROM Employees)

--Write a SQL query to find the full name, salary and 
--department of the employees that take the minimal salary 
--in their department. Use a nested SELECT statement
SELECT e.FirstName + ' ' + e.LastName AS [Full Name],e.Salary, 
e.DepartmentID , d.DepartmentID, d.Name, e.Salary
FROM Employees e
	INNER JOIN Departments d
	ON e.DepartmentID = d.DepartmentID
WHERE e.Salary = 
	(SELECT MIN(Salary)
	FROM Employees em
	WHERE em.DepartmentID = d.DepartmentID)

--Write a SQL query to find the average salary in 
--the department #1
SELECT AVG(Salary)
FROM Employees
WHERE DepartmentID = 1

--Write a SQL query to find the average salary  in 
--the "Sales" department
SELECT AVG(e.Salary)
FROM Employees e
	INNER JOIN Departments d
	ON e.DepartmentID = d.DepartmentID
WHERE d.Name = 'Sales'

--Write a SQL query to find the number of employees in the 
--"Sales" department.
SELECT COUNT(*)
FROM Employees e
	INNER JOIN Departments d
	ON e.DepartmentID = d.DepartmentID
WHERE d.Name = 'Sales'

--Write a SQL query to find the number of all employees 
--that have manager.
SELECT COUNT(*)
FROM Employees	
WHERE ManagerID IS NOT NULL

--Write a SQL query to find the number of all employees
-- that have no manager
SELECT COUNT(*)
FROM Employees
WHERE ManagerID IS NULL

--Write a SQL query to find all departments and the average salary 
--for each of them.
SELECT DepartmentID, AVG(Salary)
FROM Employees
GROUP BY DepartmentID

--Write a SQL query to find the count of all employees in each 
--department and for each town
SELECT e.DepartmentID , a.TownID, COUNT(EmployeeID) AS [Num Of Empl]
FROM Employees e
	INNER JOIN Addresses a
	ON e.AddressID = a.AddressID
GROUP BY e.DepartmentID , a.TownID

--Write a SQL query to find all managers that have exactly 5 employees. 
--Display their first name and last name
SELECT  e.FirstName+ ' '+ e.LastName AS [Manager Name],
        COUNT(e.EmployeeID) AS [Employees Count]
FROM Employees e 
	INNER JOIN Employees emp
    ON emp.ManagerID = e.EmployeeID
GROUP BY e.FirstName, e.LastName
HAVING COUNT(e.EmployeeID) = 5

--12.Write a SQL query to find all employees along with their managers.
--For employees that do not have manager display the value "(no manager)".
SELECT e.FirstName + ' ' + e.LastName AS [Empl Name],
		ISNULL(m.FirstName + ' ' + m.LastName, 'No Manager') AS [Manager Name] 
FROM Employees e
	LEFT OUTER JOIN Employees m 
	ON e.ManagerID = m.EmployeeID

--13.Write a SQL query to find the names of all employees whose last name is 
--exactly 5 characters long. Use the built-in LEN(str) function
SELECT FirstName, LastName
FROM Employees
WHERE LEN(LastName) = 5

--14.Write a SQL query to display the current date and time in the following 
--format "day.month.year hour:minutes:seconds:milliseconds". Search in  Google to 
--find how to format dates in SQL Server
SELECT CONVERT(varchar, GETDATE(), 104) + ' ' 
+ CONVERT(varchar,GETDATE(),114)

--15.Write a SQL statement to create a table Users. Users should have username,
--password, full name and last login time. Choose appropriate data types for 
--the table fields. Define a primary key column with a primary key constraint. 
--Define the primary key column as identity to facilitate inserting records. 
--Define unique constraint to avoid repeating usernames. 
--Define a check constraint to ensure the password is at least 5 characters long.
CREATE TABLE Users(
UserID int IDENTITY,
UserName nvarchar(30) NOT NULL,
UserPassword nvarchar(50) NOT NULL ,
FullName nvarchar(30) NOT NULL,
LastLogInTime datetime,
CONSTRAINT PK_User PRIMARY KEY(USERID),
CHECK(LEN(UserPAssword)>=5),
UNIQUE(UserName)
)

--16.Write a SQL statement to create a view that displays the 
--users from the Users table that have been in the system today.
--Test if the view works correctly
CREATE VIEW [Users in system today] AS
SELECT *
FROM Users
WHERE DATEDIFF(day, LastLogInTime, GETDATE()) = 0

--17.Write a SQL statement to create a table Groups. Groups should have unique
--name (use unique constraint). Define primary key and identity column
CREATE TABLE Groups(
GroupID int IDENTITY PRIMARY KEY,
GroupName varchar(50) NOT NULL UNIQUE)

--18.Write a SQL statement to add a column GroupID to the table Users. 
--Fill some data in this new column and as well in the Groups table. 
--Write a SQL statement to add a foreign key constraint between tables Users and 
--Groups tables
ALTER TABLE Users
ADD GroupID int --NOT NULL
GO
INSERT INTO Users (UserName, UserPassword,FullName, LastLogInTime, GroupID)
VALUES ('Ivan','ksncxlskjc','Ivan Ivanov', GETDATE(),3)
INSERT INTO Users (UserName, UserPassword,FullName, LastLogInTime, GroupID)
VALUES ('Ani','kscnkdkn','Ani Ivanova', GETDATE(),1)
INSERT INTO Groups (GroupName)
VALUES ('C#'), ('JS'), ('C++')
ALTER TABLE Users
ADD CONSTRAINT FK_Users_Groups FOREIGN KEY (GroupID) REFERENCES Groups(GroupID)

--19.Write SQL statements to insert several records in the Users and Groups tables.
INSERT INTO Users (UserName, UserPassword,FullName, LastLogInTime, GroupID)
VALUES ('Ina', 'xnojbc', 'Ina Nikolova', GETDATE(), 1),
('IVa', 'CXWECxnojbc', 'Iva Todorova', GETDATE(), 2),
('Petkan', 'cwecewcew', 'Petkan Draganov', GETDATE(), 3)
INSERT INTO Groups (GroupName)
VALUES ('OOP Part One'),('OOP Part Two')

--20.Write SQL statements to update some of the records in the Users and Groups tables.
UPDATE Users
SET UserName = 'Ivva', GroupID = 4
WHERE UserName = 'Iva'
UPDATE Users
SET GroupID = 5
WHERE UserID = 5
UPDATE Groups
SET GroupName = 'Java Script'
WHERE GroupName = 'JS'

--21.Write SQL statements 
--to delete some of the records from the Users and Groups tables
ALTER TABLE Users
DROP CONSTRAINT FK_Users_Groups
DELETE FROM Users
WHERE UserID = 1
DELETE FROM Groups
WHERE GroupID = 1

--22.Write SQL statements to insert in the Users table the names 
--of all employees from the Employees table. Combine the first
--and last names as a full name. For username use the first letter
--of the first name + the last name (in lowercase). Use the same 
--for the password, and NULL for last login time
INSERT INTO Users (UserName, UserPassword, FullName, LastLoginTime)
SELECT LOWER(SUBSTRING(FirstName,1,5) + LastName + SUBSTRING(JobTitle,1,1)) AS [User Name],
	 LOWER(SUBSTRING(FirstName,1,5) + LastName + SUBSTRING(JobTitle,1,1)) AS [Password],
	FirstName + ' ' + LastName AS [Full Name], NULL AS [Last Login Time]
FROM Employees

--23.Write a SQL statement that changes the password to NULL for all users that have not 
--been in the system since 10.03.2010
UPDATE Users
SET UserPassword = NULL
FROM Users
WHERE DATEDIFF(day,LastLogInTime,'10.03.2010') <= 0

--24.Write a SQL statement that deletes all users without passwords (NULL password).
DELETE FROM Users
WHERE UserPassword IS NULL

--25.Write a SQL query to display the average employee salary by department
--and job title
SELECT DepartmentID, JobTitle, AVG(Salary)
FROM Employees
GROUP BY DepartmentID, JobTitle

--26.Write a SQL query to display the minimal employee salary by department 
--and job title along with the name of some of the employees that take it.
SELECT DepartmentID, JobTitle, FirstName + ' ' + LastName AS [Full name], MIN(Salary)
FROM Employees
GROUP BY DepartmentID, JobTitle, FirstName + ' ' + LastName*/

--27.Write a SQL query to display the town where maximal number of employees work.
SELECT TOP 1 t.Name, COUNT(e.EmployeeID)
FROM Employees e
	INNER JOIN Addresses a
	ON e.AddressID = a.AddressID
	INNER JOIN Towns t
	ON a.TownID = t.TownID
GROUP BY t.Name
ORDER BY 