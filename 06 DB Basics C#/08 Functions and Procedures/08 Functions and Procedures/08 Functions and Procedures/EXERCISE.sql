-- 01. Employees with Salary Above 35000
USE SoftUni;
GO
CREATE PROC usp_GetEmployeesSalaryAbove35000
AS
     SELECT FirstName,
            LastName
     FROM Employees
     WHERE Salary > 35000;
GO
-- testing
EXEC usp_GetEmployeesSalaryAbove35000;

-- 02. Employees with Salary Above Number
GO
CREATE PROC usp_GetEmployeesSalaryAboveNumber(@minSalary MONEY)
AS
     SELECT FirstName,
            LastName
     FROM Employees
     WHERE Salary >= @minSalary;
GO
-- testing
EXEC usp_GetEmployeesSalaryAboveNumber 48100;

-- 03. Town Names Starting With
GO
CREATE PROC usp_GetTownsStartingWith(@startingWith VARCHAR(MAX))
AS
     SELECT Name AS [Town]
     FROM Towns
     WHERE Name LIKE CONCAT(@startingWith, '%');
GO
--testing
EXEC usp_GetTownsStartingWith
     'b';

-- 04. Employees from Town
GO
CREATE PROC usp_GetEmployeesFromTown(@townName VARCHAR(MAX))
AS
     SELECT e.FirstName,
            e.LastName
     FROM Employees AS e
          JOIN Addresses AS a ON a.AddressID = e.AddressID
          JOIN Towns AS t ON t.TownID = a.TownID
     WHERE Name = @townName;
GO
--testing
EXEC usp_GetEmployeesFromTown
     'Sofia';

-- 05. Salary Level Function
GO
CREATE OR ALTER FUNCTION ufn_GetSalaryLevel (@salary MONEY)
RETURNS VARCHAR(10)
AS
     BEGIN
         DECLARE @salaryLevel VARCHAR(10)= 'High';
         IF(@salary < 30000)
             SET @salaryLevel = 'Low';
             ELSE
         IF(@salary <= 50000)
             SET @salaryLevel = 'Average';
         RETURN @salaryLevel;
     END;
GO
--testing only, do not submit in Judge
SELECT dbo.ufn_GetSalaryLevel(Salary) AS [SalaryLevel],
       COUNT(*)
FROM Employees
GROUP BY dbo.ufn_GetSalaryLevel(Salary)
ORDER BY SalaryLevel;

-- 06. Employees by Salary Level
-- Using Function ufn_GetSalaryLevel from Problem 05
GO
CREATE PROC usp_EmployeesBySalaryLevel (@salaryLevel varchar(10))
AS
  SELECT FirstName, LastName
  FROM Employees
  WHERE dbo.ufn_GetSalaryLevel(Salary) = @salaryLevel
GO
-- testing
EXEC usp_EmployeesBySalaryLevel 'High';

-- 07. Define Function
GO
CREATE FUNCTION ufn_IsWordComprised (@setOfLetters VARCHAR(MAX), @word VARCHAR(MAX))
RETURNS BIT
AS
     BEGIN
         DECLARE @IsComprised BIT= 0;
         DECLARE @CurrentIndex INT= 1;
         DECLARE @CurrentChar CHAR;
         WHILE(@CurrentIndex <= LEN(@Word))
             BEGIN
                 SET @currentChar = SUBSTRING(@Word, @CurrentIndex, 1);
			  DECLARE @Match int = CHARINDEX(@currentChar, @SetOfLetters); -- if is not valid returns 0
                 IF(@Match = 0) 
                     RETURN @IsComprised;
                 SET @CurrentIndex += 1;
             END;
         RETURN @IsComprised + 1;
     END;
GO
--testing
CREATE TABLE TestDB (SetOfLetters VARCHAR(MAX), Word VARCHAR(MAX));
GO
INSERT INTO TestDB
VALUES('oistmiahf', 'Sofia'), ('oistmiahf', 'halves'), ('bobr', 'Rob'), ('pppp', 'Guy'), ('', 'empty');
GO
SELECT SetOfLetters,
       Word,
       dbo.ufn_IsWordComprised(SetOfLetters, Word) AS [Result]
FROM TestDB;

-- 08.* Delete Employees and Departments
-- delete projects for employees in targeted departments
GO
CREATE OR ALTER PROC usp_DeleteEmployeesFromDepartment(@departmentID INT)
AS
         BEGIN
             DELETE FROM EmployeesProjects
             WHERE EmployeeID = @departmentID
(SELECT e.EmployeeID
 FROM Employees AS e
      JOIN Departments AS d ON e.DepartmentID = d.DepartmentID
 WHERE d.Name IN('Production', 'Production Control')
);
         END;
GO
-- testing
EXEC usp_DeleteEmployeesFromDepartment 12;

-- make ManagerID in Departments nullable
ALTER TABLE Departments ALTER COLUMN ManagerID INT NULL;
-- set ManagerID = NULL for targeted departments
UPDATE Departments
  SET
      ManagerID = NULL
WHERE Name IN('Production', 'Production Control');
-- set ManagerID = NULL for employees in targeted departments
UPDATE Employees
  SET
      ManagerID = NULL
WHERE DepartmentID IN
(
    SELECT DepartmentID
    FROM Departments
    WHERE Name IN('Production', 'Production Control')
);
-- drop constraint ManagerID_EmployeeID
ALTER TABLE Employees DROP CONSTRAINT FK_Employees_Employees;
-- delete employees from targeted departments
DELETE FROM Employees
WHERE DepartmentID IN
(
    SELECT DepartmentID
    FROM Departments
    WHERE Name IN('Production', 'Production Control')
);
-- delete targeted departements
DELETE FROM Departments
WHERE Name IN('Production', 'Production Control');
-- testing for targeted departements & employees in DB - do not submit in Judge
SELECT *
FROM EmployeesProjects
WHERE EmployeeID IN
(
    SELECT e.EmployeeID
    FROM Employees e
         JOIN Departments d ON E.DepartmentID = D.DepartmentID
    WHERE D.Name IN('Production', 'Production Control')
);

SELECT d.DepartmentID,
       d.Name AS [Department],
       d.ManagerID AS [DeptManager],
       e.EmployeeID,
       e.FirstName,
       e.LastName,
       e.ManagerID AS [EmplManager],
       E.JobTitle
FROM Departments AS d
     JOIN Employees AS e ON d.DepartmentID = e.DepartmentID
WHERE d.Name IN('Production', 'Production Control');  

SELECT DepartmentID,
       Name AS [Department]
FROM Departments
WHERE Name IN('Production', 'Production Control');
-- restoring modified DB constraints
ALTER TABLE Departments ALTER COLUMN ManagerID INT NOT NULL;
-- why can't self-referencing be restored as well ???
ALTER TABLE Employees
ADD CONSTRAINT FK_Employees_Employees FOREIGN KEY(ManagerID) REFERENCES Employees(EmployeeID);

-- 09. Find Full Name
GO
CREATE PROC usp_GetHoldersFullName
AS
     SELECT CONCAT(FirstName, ' ', LastName) AS [Full Name]
     FROM AccountHolders;
GO
-- testing
EXEC usp_GetHoldersFullName;

-- 10. People with Balance Higher Than
GO
CREATE PROC usp_GetHoldersWithBalanceHigherThan(@minBalance MONEY)
AS
         BEGIN
             WITH CTE_MinBalanceAccountHolders(HolderId)
                  AS (SELECT AccountHolderId
                      FROM Accounts
                      GROUP BY AccountHolderId
                      HAVING SUM(Balance) > @minBalance)
                  SELECT ah.FirstName AS [First Name],
                         ah.LastName AS [Last Name]
                  FROM CTE_MinBalanceAccountHolders AS minBalanceHolders
                       JOIN AccountHolders AS ah ON ah.Id = minBalanceHolders.HolderId
                  ORDER BY ah.LastName,
                           ah.FirstName; 
  -- NB not a requirement, however Judge would accept the solution only in that precise order!
         END;
GO
-- testing - do not submit in Judge
EXEC usp_GetHoldersWithBalanceHigherThan 6000000;
EXEC usp_GetHoldersWithBalanceHigherThan 5000000;
EXEC usp_GetHoldersWithBalanceHigherThan 1000;

-- 11. Future Value Function
GO
CREATE FUNCTION ufn_CalculateFutureValue(@sum MONEY, @annualIntRate FLOAT, @years INT)
RETURNS MONEY
AS
     BEGIN
         RETURN @sum * POWER(1 + @annualIntRate, @years);
     END;
GO
-- testing - do not submit in Judge
SELECT dbo.ufn_CalculateFutureValue(1000, 0.10, 5) AS FV

-- 12. Calculating Interest
GO
CREATE PROC usp_CalculateFutureValueForAccount(@accountId INT, @interestRate FLOAT)
AS
         BEGIN
             DECLARE @years INT= 5;
             SELECT a.Id AS [Account Id],
                    ah.FirstName AS [First Name],
                    ah.LastName AS [Last Name],
                    a.Balance AS [Current Balance],
                    dbo.ufn_CalculateFutureValue(a.Balance, @interestRate, @years) AS [Balance in 5 years]
             FROM AccountHolders AS ah
                  JOIN Accounts AS a ON ah.Id = a.AccountHolderId
             WHERE a.Id = @accountId;
         END;
GO
-- testing - do not submit in Judge
EXEC usp_CalculateFutureValueForAccount 1, 0.10;
EXEC usp_CalculateFutureValueForAccount 2, 0.10;
EXEC usp_CalculateFutureValueForAccount 3, 0.10;

-- 13. *Cash in User Games Odd Rows
--USE Diablo
GO
CREATE FUNCTION ufn_CashInUsersGames(@gameName NVARCHAR(50))
RETURNS TABLE
AS
RETURN
         SELECT SUM(Cash) as [SumCash]
         FROM
(SELECT ug.Cash,
        ROW_NUMBER() OVER(ORDER BY Cash DESC) AS [RowNum]
    FROM UsersGames AS ug
         JOIN Games AS g ON g.Id = ug.GameId
    WHERE g.Name = @gameName) AS [CashList]
         WHERE RowNum % 2 = 1;
GO
-- testing
SELECT * FROM dbo.ufn_CashInUsersGames ('Lily Stargazer');
SELECT * FROM dbo.ufn_CashInUsersGames ('Love in a mist');


