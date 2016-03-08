/*--1.Create a database with two tables: Persons(Id(PK), FirstName, LastName, SSN)
-- and Accounts(Id(PK), PersonId(FK), Balance). Insert few records for testing. 
--Write a stored procedure that selects the full names of all persons
CREATE DATABASE Bank
GO
USE Bank
CREATE TABLE Persons(
PersonId int NOT NULL PRIMARY KEY IDENTITY,
FirstName nvarchar(30),
LastName nvarchar(30),
SSN nvarchar(50) NOT NULL UNIQUE)
GO
CREATE TABLE Accounts(
AccountID int NOT NULL PRIMARY KEY IDENTITY,
PersonID int FOREIGN KEY REFERENCES Persons(PersonId),
Balance money NOT NULL)
GO
INSERT INTO Persons (FirstName, LastName, SSN)
VALUES ('Ivan', 'Ivanov', '00000000000000123'),
('Ani', 'Angelova', '00000000000000124'),
('Iva', 'Ludvig', '00000000000000100')
INSERT INTO Accounts (PersonID, Balance)
VALUES (1, 1.23),
(2, 1000.00),
(3, 2000000.00)
GO
CREATE PROC usp_SelectPersonFullName
AS
	SELECT FirstName + ' ' + LastName AS [Full Name]
	FROM Persons
GO
USE Bank
EXEC usp_usp_SelectPersonFullName

--2.Create a stored procedure that accepts a number 
--as a parameter and returns all persons who have more
-- money in their accounts than the supplied number
CREATE PROC usp_SelectPersonByBalance(
@number money)
AS
	SELECT p.FirstName + ' ' + p.LastName, a.Balance 
	FROM Persons p
		INNER JOIN Accounts a
		ON p.PersonId = a.PersonID
		WHERE a.Balance > @number
EXEC usp_SelectPersonByBalance 1000.00

--3.Create a function that accepts as parameters – 
--sum, yearly interest rate and number of months. 
--It should calculate and return the new sum. Write 
--a SELECT to test whether the function works as expected*/
CREATE FUNCTION ufn_SumInterestForMonts(@sum money, @yearinter money,
@months int)
	RETURNS money
AS
BEGIN
RETURN @sum + @sum*@yearinter/@months  
END
