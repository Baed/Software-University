use SoftUni

GO
SELECT * FROM Employees
SELECT EmployeeID, * FROM Employees
SELECT EmployeeID, FirstName, LastName, JobTitle, Salary FROM Employees
	WHERE Salary > 20000
	ORDER BY Salary DESC;

SELECT EmployeeID AS ID, FirstName AS First, LastName as Last FROM Employees;

SELECT * FROM Departments
SELECT d.DepartmentID, d.Name AS [Department Name],
	 e.FirstName + ' ' + e.LastName AS [Manager Name], 
	 e.EmployeeID, 
	 d.ManagerID 
FROM Departments AS d
JOIN Employees AS e ON d.ManagerID = e.EmployeeID;


SELECT e.FirstName + ' ' + e.LastName AS [Full Name], 
	   e.JobTitle AS [Job Title],
	   e.Salary
  FROM Employees AS e

SELECT DISTINCT e.DepartmentID AS [Department ID]
           FROM Employees AS e

SELECT * FROM Employees AS e
WHERE e.DepartmentID = 6

SELECT * FROM Employees AS e
WHERE e.DepartmentID = (SELECT DepartmentID FROM Departments WHERE Name = 'Marketing')

SELECT e.LastName, e.Salary FROM Employees AS e
 WHERE Salary <= 20000

SELECT * FROM Employees
WHERE NOT (ManagerID = 3 OR ManagerID = 4)

SELECT * FROM Employees
WHERE ManagerID NOT IN(3, 4)

SELECT LastName, Salary FROM Employees
WHERE Salary BETWEEN 20000 AND 22000

SELECT FirstName, LastName, ManagerID FROM Employees
WHERE ManagerID IN (109, 3, 16)

SELECT LastName, ManagerId FROM Employees
WHERE ManagerId = NULL /* FALSE */

SELECT LastName, ManagerId
  FROM Employees
 WHERE ManagerId IS NULL

SELECT LastName, ManagerId
  FROM Employees
 WHERE ManagerId IS NOT NULL

  SELECT LastName, HireDate
    FROM Employees
ORDER BY HireDate

  SELECT LastName, HireDate
    FROM Employees
ORDER BY HireDate DESC

/* CREATE VIEW */
CREATE VIEW v_EmployeesByDepartment AS
SELECT d.DepartmentID, d.Name AS [Department Name],
	 e.FirstName + ' ' + e.LastName AS [Manager Name], 
	 e.EmployeeID, 
	 d.ManagerID 
FROM Departments AS d
JOIN Employees AS e ON d.ManagerID = e.EmployeeID;
/* SELECT VIEW */
SELECT * FROM v_EmployeesByDepartment

SELECT * FROM Employees

USE Geography
SELECT * FROM Peaks

/* CREATE VIEW */
CREATE VIEW v_HighestToFivePeaks AS
SELECT TOP 5 * FROM Peaks 
ORDER BY Elevation DESC
/* SELECT VIEW */
SELECT * FROM v_HighestToFivePeaks

SELECT TOP 10 PERCENT * FROM Peaks 

USE SoftUni
SELECT * FROM Employees

/****  INSERT VALUES INTO TABLE  ****/
INSERT INTO Employees(FirstName, MiddleName , LastName, DepartmentID, ManagerID, HireDate, Salary, JobTitle)
	VALUES ('Barbara', 'S', 'Streisand', 1, 5, GETDATE(), 5000, 'Assistent Manager'),
	       ('Gogo', 'G', 'Gogov', 1, 5, GETDATE(), 50, 'Jigolo'),
		   ('Stamat', 'S', 'Stamatski', 1, 5, GETDATE(), 50, 'Yong Merinjey')

SELECT * FROM v_EmployeesByDepartment

/****   CREATE TABLE FROM SOME VIEW   ****/
SELECT *
  INTO NewTableInSoftUniDB
  FROM v_EmployeesByDepartment

SELECT * FROM NewTableInSoftUniDB


/****   SEQUENCE   ****/
CREATE SEQUENCE seq_Customers_CustomerID            
         AS INT
     START WITH 5
   INCREMENT BY 10

SELECT NEXT VALUE FOR seq_Customers_CustomerID 


/**** DELETING DATA ****/
DELETE FROM NewTableInSoftUniDB
      WHERE EmployeeID = 4

SELECT * FROM NewTableInSoftUniDB

/**** TRUNCATE delete all from the table ****/
TRUNCATE TABLE NewTableInSoftUniDB


/**** UPDATE ****/
UPDATE Employees
   SET LastName = 'Brown'
 WHERE EmployeeID = 1
 /* Note: Don’t forget the WHERE clause! */

UPDATE Employees
   SET Salary = Salary * 1.10,
       JobTitle = 'Senior ' + JobTitle
 WHERE DepartmentID = 3
  /* Note: Don’t forget the WHERE clause! */

UPDATE Projects
SET EndDate = GETDATE()
WHERE EndDate IS NULL

UPDATE Projects
   SET EndDate = '2017-01-23'
 WHERE EndDate IS NULL

  SELECT * 
    FROM Projects
ORDER BY EndDate DESC

SELECT *
  FROM Projects
 WHERE StartDate = '1/1/2006'
