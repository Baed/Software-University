
-- -----------II Queries for Geography Database -----------------------
USE SoftUni
-- ------------2.FIND ALL INFORMATION ABOUT DEPARTMENTS ----------
SELECT *
  FROM departments

-- -----------3.Find all Department Names------------
SELECT Name
  FROM departments

-- -----------4.Find Salary of Each Employee-------------
SELECT FirstName, LastName, salary
  FROM Employees

-- -----------5.Find Full Name of Each Employee-------------
SELECT FirstName, MiddleName, LastName
  FROM employees

-- -----------6.Find Email Address of Each Employee-------------
SELECT CONCAT(FirstName, '.', LastName, '@softuni.bg') as [Full Email Adress]
  FROM employees

-- -----------7.Find All Different Employee’s Salaries-------------
  SELECT DISTINCT salary 
    FROM employees 
ORDER BY salary

-- -----------8.Find all Information About Employees-------------
SELECT *
  FROM employees 
 WHERE JobTitle = 'Sales Representative';

-- -----------9.Find Names of All Employees by Salary in Range-------------
SELECT FirstName, LastName, JobTitle
  FROM employees 
 WHERE salary >= 20000 and salary <= 30000;

-- -----------10.Find Names of All Employees -------------
SELECT 
CONCAT (FirstName, ' ', MiddleName, ' ', LastName)
    AS [Full Name]
  FROM Employees 
 WHERE Salary IN( 25000, 14000, 12500, 23600);

-- -----------11.Find All Employees Without Manager-------------
SELECT FirstName, LastName  
  FROM employees
 WHERE ManagerID is NULL

-- -----------12.Find All Employees with Salary More Than 50000-------------
SELECT FirstName, LastName, Salary 
  FROM employees
 WHERE salary > 50000
 ORDER BY salary DESC;

-- -----------13.Find 5 Best Paid Employees.-------------
  SELECT TOP 5 FirstName, LastName 
    FROM employees
ORDER BY salary DESC

-- -----------14.Find All Employees Except Marketing-------------
SELECT FirstName, LastName 
  FROM employees
 WHERE DepartmentID != 4

-- -----------15.Sort Employees Table-------------
SELECT * FROM employees
ORDER BY salary DESC, 
      FirstName ASC, 
	   LastName DESC,
	 MiddleName ASC; 

-- -----------16.Create View Employees with Salaries-------------
CREATE VIEW v_EmployeesSalaries  AS
	 SELECT FirstName, LastName, Salary 
       FROM employees;
	   
	 SELECT * 
	   FROM v_EmployeesSalaries

-- -----------17.Create View Employees with Job Titles-------------
UPDATE employees
   SET MiddleName = ''
 WHERE MiddleName IS NULL;
	
CREATE VIEW V_EmployeeNameJobTitle   AS
	 SELECT CONCAT(FirstName, ' ', MiddleName, ' ', LastName) AS 'FullName' , JobTitle 
       FROM employees;

	 SELECT * 
	   FROM V_EmployeeNameJobTitle 

-- -----------18.Distinct Job Titles-------------
  SELECT DISTINCT JobTitle 
    FROM employees
ORDER BY JobTitle

-- -----------19.Find First 10 Started Projects-------------
  SELECT TOP 10 * 
    FROM projects
ORDER BY StartDate, Name 

-- -----------20.Last 7 Hired Employees-------------
  SELECT TOP 7 FirstName, LastName, HireDate 
    FROM employees
ORDER BY HireDate DESC

-- -----------21.Increase Salaries---------------
UPDATE employees
   SET salary = salary * 1.12
 WHERE DepartmentID IN(1, 2, 4, 11)
-- WHERE DepartmentID = '1' or DepartmentID= '2' or DepartmentID = '4' or DepartmentID = '11'; --

SELECT salary 
  FROM employees;


-- -----------II Queries for Geography Database -----------------------
USE Geography
-- -----------22.All Mountain Peaks---------------
  SELECT PeakName 
    FROM peaks 
ORDER BY PeakName

-- -----------23. Biggest Countries by Population---------------
  SELECT TOP 30 CountryName, Population 
    FROM countries 
   WHERE CountryCode = 'EU'
ORDER BY population DESC, CountryName

-- -----------24.*Countries and Currency (Euro / Not Euro)---------------
  SELECT CountryName, CountryCode 
      IF (CurrencyCode = 'EUR', 'Euro', 'Not Euro') 
	  AS currency 
    FROM countries 
ORDER BY country_name ASC
GO

-- -----------II Queries for Geography Database -----------------------
USE Diablo
-- -----------25.All Diablo Characters---------------
  SELECT Name 
    FROM Characters 
ORDER BY Name asc;