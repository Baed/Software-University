USE SoftUni

-- CREATE FUNCTION  --SCALAR (return one value)
GO
CREATE FUNCTION udf_ProjectDurationWeeks (@StartDate DATETIME, @EndDate DATETIME)
RETURNS INT 
AS
  BEGIN
    DECLARE @ProjectWeeks INT;
    IF(@EndDate IS NULL)
	   BEGIN 
		  SET @EndDate = GETDATE();
	   END
    SET @ProjectWeeks = DATEDIFF(WEEK, @StartDate, @EndDate);
    RETURN @ProjectWeeks;
  END;
GO

SELECT ProjectID, 
	  StartDate, 
	  EndDate, 
	  dbo.udf_ProjectDurationWeeks(StartDate, EndDate) AS [ProjectWeeks]
FROM Projects
ORDER BY ProjectWeeks DESC

-- CREATE FUNCTION  --SCALAR (return one value)
GO
CREATE FUNCTION ufn_GetSalaryLevel(@salary INT)
RETURNS VARCHAR(10)
AS
BEGIN
DECLARE @salaryLevel VARCHAR(10)
 IF (@salary < 30000)
     SET @salaryLevel = 'Low'
  ELSE IF(@salary >= 30000 AND @salary <= 50000)
     SET @salaryLevel = 'Average'
  ELSE
     SET @salaryLevel = 'High'
RETURN @salaryLevel
END;
GO

SELECT  dbo.ufn_GetSalaryLevel(Salary) AS [SalaryLevel],
	   COUNT(*)
FROM Employees
GROUP BY dbo.ufn_GetSalaryLevel(Salary)
ORDER BY SalaryLevel


-- *** PROCEDURE / PROC *** --
-- *** EXECUTE / EXEC *** --
-- CREATE PROCEDURE
USE SoftUni
GO
CREATE PROC usp_SelectEmployeesBySeniority
AS
BEGIN
  SELECT * 
  FROM Employees
  WHERE	DATEDIFF(YEAR, HireDate, GETDATE()) > 5
END
GO

-- ALTER PROCEDURE
ALTER PROC dbo.usp_SelectEmployeesBySeniority -- CREATE OR ALTER
AS
  SELECT FirstName, 
	    LastName, 
	    HireDate
  FROM Employees
  WHERE	DATEDIFF(YEAR, HireDate, GETDATE()) > 5
  ORDER BY HireDate
GO

-- EXECUTE PROCEDURE
EXEC dbo.usp_SelectEmployeesBySeniority;

-- INSERT INTO
INSERT INTO Customers
EXEC dbo.usp_SelectEmployeesBySeniority

EXEC sp_depends 'usp_SelectEmployeesBySeniority';

-- DROP PROCEDURE
DROP PROC dbo.usp_SelectEmployeesBySeniority

-- PROCEDURE with parameters
GO
CREATE OR ALTER PROC usp_SelectEmployeesBySeniority (@minYearsAtWork int = 5)
AS
  SELECT FirstName, 
	    LastName,
	    HireDate, 
	    DATEDIFF(YEAR, HireDate, GETDATE()) AS [Years]
  FROM Employees
  WHERE DATEDIFF(YEAR, HireDate, GETDATE()) > @minYearsAtWork
  ORDER BY HireDate DESC
GO

EXEC dbo.usp_SelectEmployeesBySeniority;
EXEC dbo.usp_SelectEmployeesBySeniority 17;
EXEC dbo.usp_SelectEmployeesBySeniority @minYearsAtWork = 17;

-- Passing parameters 
-- by parameter name
EXEC usp_AddCustomer 
  @customerID = 'ALFKI',
  @companyName = 'Alfreds Futterkiste',
  @address = 'Obere Str. 57',
  @city = 'Berlin',
  @phone = '030-0074321' 
-- by position
EXEC usp_AddCustomer 'ALFKI2', 'Alfreds Futterkiste', 'Obere Str. 57', 'Berlin', '030-0074321';

-- PROCEDURE with OUTPUT
GO
CREATE PROCEDURE dbo.usp_AddNumbers
   @firstNumber smallint,
   @secondNumber smallint,
   @result int OUTPUT
AS
   SET @result = @firstNumber + @secondNumber
GO

DECLARE @answer smallint;
EXECUTE usp_AddNumbers 5, 6, @answer OUTPUT ;
SELECT 'The result is: ' AS [Message], 
	   @answer AS [Output] -- The result is: 11

--TRANSACTION / TRAN
USE SoftUni
GO
CREATE OR ALTER PROC udp_AssignProject (@EmployeeID INT, @ProjectID INT)
AS
BEGIN
    DECLARE @MaxEmployeeProjectsCount INT = 3
    DECLARE @EmployeeProjectsCount INT
    SET @EmployeeProjectsCount = 
	   (SELECT COUNT(*) 
	    FROM EmployeesProjects AS e
	    WHERE e.EmployeeId = @EmployeeID)
    BEGIN TRAN
    INSERT INTO [dbo].[EmployeesProjects] (EmployeeID, ProjectID)VALUES (@EmployeeID, @ProjectID)  
    IF(@EmployeeProjectsCount >= @maxEmployeeProjectsCount)
    BEGIN
      RAISERROR('The employee has too many projects!', 16, 1)
	 ROLLBACK
    END
    ELSE
      COMMIT
END

EXEC udp_AssignProject 1, 3
SELECT * FROM EmployeesProjects
GO
--TRANSACTION / TRAN

USE Bank
GO
CREATE PROCEDURE usp_WithdrawMoney 
@account INT, @withdrawAmount DECIMAL(15, 2)
AS
BEGIN
  BEGIN TRAN
    UPDATE Accounts 
    SET Balance -= @withdrawAmount
    WHERE Id = @account
    IF @@ROWCOUNT <> 1 -- Affected rows are different than one.
      BEGIN
        ROLLBACK
        RAISERROR('Invalid account!', 16, 1)
        RETURN
      END
    ELSE
      COMMIT
  END
END


EXEC usp_WithdrawMoney 1, 3
GO
-- *** TRIGGER FOR / TRIGGER INSTEAD OF *** --

-- CREATE TRIGGER FOR
GO
USE SoftUni
CREATE TRIGGER tr_TownsUpdate ON Towns FOR UPDATE
AS
  IF(EXISTS(SELECT * FROM inserted WHERE Name IS NULL) OR -- system account
     EXISTS(SELECT * FROM inserted WHERE LEN(Name) = 0))
    BEGIN
      RAISERROR('Town name cannot be empty.', 16, 1);
      ROLLBACK TRAN;
      RETURN;
    END

UPDATE Towns SET Name = '' WHERE TownId = 1 -- error
GO

--CREATE TRIGGER INSTEAD OF
USE SoftUni
GO
CREATE TRIGGER tr_AccountsDelete ON Accounts INSTEAD OF DELETE
AS
  UPDATE a 
  SET Active = 'N'
  FROM Accounts AS a 
  JOIN DELETED AS d ON d.Username = a.Username -- system account
  WHERE a.Active = 'Y'

GO
CREATE TABLE Accounts(
  Username varchar(10) NOT NULL PRIMARY KEY,
  Password varchar(20) NOT NULL,
  Active char NOT NULL DEFAULT 'Y'
)
INSERT INTO Accounts VALUES
  ('AAA', 123, DEFAULT), ('BBB', 123, DEFAULT), ('CCC', 123, DEFAULT)
  
DELETE FROM Accounts WHERE Username = 'AAA' -- inactive (trigger logic)

-- ALTER TRIGGER
ALTER TRIGGER tr_AccountsDelete --[...]

-- DROP TRIGGER

DROP TRIGGER tr_AccountsDelete
DELETE FROM Accounts WHERE Username = 'AAA' -- deleted