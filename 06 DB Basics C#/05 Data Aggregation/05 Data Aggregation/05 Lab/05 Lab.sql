USE SoftUni
SELECT * FROM Employees

--With GROUP BY you can get each separate group and use an
--"aggregate" function over it (like Average, Min or Max):
  SELECT e.DepartmentID 
    FROM Employees AS e
GROUP BY e.DepartmentID

--With DISTINCT you will get all unique values:
SELECT DISTINCT e.DepartmentID 
FROM Employees AS e

--After grouping every employee by it's department we can use 
--aggregate function to calculate total amount of money per group.
  SELECT e.DepartmentID, 
         SUM(e.Salary) AS [Total Salary]
    FROM Employees AS e
GROUP BY e.DepartmentID
ORDER BY e.DepartmentID

-- **** Aggregate Functions **** --

--Operate over (non-empty) groups
--Perform data analysis on each one
--MIN, MAX, AVG, COUNT etc.
  SELECT e.DepartmentID, 
         MIN(e.Salary) AS [Min Salary]
    FROM Employees AS e
GROUP BY e.DepartmentID
ORDER BY [Min Salary]
--Aggregate functions usually ignore NULL values.

--COUNT(ColumnName)
  SELECT e.DepartmentID, 
         COUNT(e.Salary) AS [Salary Count]
    FROM Employees AS e
GROUP BY e.DepartmentID
--Note: COUNT ignores any employee with NULL salary.

--If any department has no salaries, it returns NULL.
  SELECT e.DepartmentID,
         SUM(e.Salary) AS [Total Salary]
    FROM Employees AS e
GROUP BY e.DepartmentID

--MAX Syntax
  SELECT e.DepartmentID,   
         MAX(e.Salary) AS [Max Salary]
    FROM Employees AS e
GROUP BY e.DepartmentID

--MIN Syntax
  SELECT e.DepartmentID,    
         MIN(e.Salary) AS [Min Salary]
    FROM Employees AS e
GROUP BY e.DepartmentID

--AVG Syntax
  SELECT e.DepartmentID,
         d.Name,
         --AVG(e.Salary) AS [Average Salary]
	    ROUND(AVG(e.Salary), 2) AS [Average Salary]
    FROM Employees AS e,
         Departments AS d
GROUP BY e.DepartmentID, d.Name
ORDER BY [Average Salary] DESC

-- **** Having Clause **** --

--The HAVING clause is used to filter data based on aggregate values 
--We cannot use it without grouping first
--Aggregate functions (MIN, MAX, SUM etc.) are executed only once
--Unlike HAVING, WHERE filters rows before aggregation

--HAVING Syntax
  SELECT e.DepartmentID,        
         SUM(e.Salary) AS [Total Salary]
    FROM Employees AS e
GROUP BY e.DepartmentID
  HAVING SUM(e.Salary) < 250000


-- *** LAB *** --
  SELECT e.EmployeeID,
         e.FirstName,
         e.Salary,
         SUM(e.Salary) 
	    OVER (ORDER BY e.EmployeeID) AS [Comulative Total]
    FROM Employees AS e
