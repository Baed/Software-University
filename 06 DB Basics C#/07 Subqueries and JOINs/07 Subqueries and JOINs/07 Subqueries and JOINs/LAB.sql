-- *** INNER vs. OUTER Joins *** --
--Inner join
-- *A join of two tables returning only rows matching the join condition
--Left (or right) outer join
-- *Returns the results of the inner join as well as unmatched rows from the left (or right) table
--Full outer join
-- *Returns the results of an inner join along with all unmatched rows

USE SoftUni;
-- Inner Join Syntax
SELECT *
FROM Employees AS e
     INNER JOIN Departments AS d ON e.DepartmentID = d.DepartmentID;

--Left Outer Join
SELECT *
FROM Employees AS e
     LEFT OUTER JOIN Departments AS d ON e.DepartmentID = d.DepartmentID;

--Right Outer Join Syntax
SELECT *
FROM Employees AS e
     RIGHT OUTER JOIN Departments AS d ON e.DepartmentID = d.DepartmentID;

--Full Join Syntax
SELECT *
FROM Employees AS e
     FULL JOIN Departments AS d ON e.DepartmentID = d.DepartmentID;

--Cross Join Syntax
SELECT *
FROM Employees AS e
     CROSS JOIN Departments AS d;

--Solution: Addresses with Towns
--Display address information of all employees in "SoftUni" database. Select first 50 employees.
-- * The exact format of data is shown below. 
-- * Order them by FirstName, then by LastName (ascending).
--  ** Hint: Use three-way join.
SELECT TOP 50 e.FirstName,
              e.LastName,
              t.Name AS [Town],
              a.AddressText
FROM Employees AS e
     JOIN Addresses AS a ON e.AddressID = a.AddressID
     JOIN Towns AS t ON a.TownID = t.TownID
ORDER BY e.FirstName,
         e.LastName;

--Find all employees that are in the "Sales" department. Use "SoftUni" database.
-- * Follow the specified format:
--   ** Order them by EmployeeID
SELECT e.EmployeeID,
       e.FirstName,
       e.LastName,
       d.Name AS [DepartmentName]
FROM Employees AS e
     INNER JOIN Departments AS d ON e.DepartmentID = d.DepartmentID
WHERE d.Name = 'Sales'
ORDER BY e.EmployeeID;

--Show all employees that:
-- * Are hired after 1/1/1999
-- * Are either in "Sales" or "Finance" department
-- * Sorted by HireDate (ascending).
SELECT e.FirstName,
       e.LastName,
       e.HireDate,
       d.Name AS [DeptName]
FROM Employees AS e
     INNER JOIN Departments AS d ON e.DepartmentId = d.DepartmentId
WHERE e.HireDate > '1999/1/1'
      AND d.Name IN('Sales', 'Finance')
ORDER BY e.HireDate ASC;

--Display information about employee's manager and employee's department .
-- * Show only the first 50 employees.
-- * The exact format is shown below:
-- * Sort by EmployeeID (ascending).
SELECT TOP 50 e.EmployeeID,
              e.FirstName + ' ' + e.LastName AS [EmployeeName],
              m.FirstName + ' '+ m.LastName AS [ManagerName],
              d.Name AS [DepartmentName]
FROM Employees AS e
     LEFT JOIN Employees AS m ON m.EmployeeID = e.ManagerID
     LEFT JOIN Departments AS d ON d.DepartmentID = e.DepartmentID
ORDER BY e.EmployeeID ASC;

-- *** Subqueries *** --
SELECT *
FROM Employees AS e
WHERE e.DepartmentID IN
(
    SELECT d.DepartmentID
    FROM Departments AS d
    WHERE d.Name = 'Finance'
);

-- Display lowest average salary of all departments.
-- * Calculate average salary for each department.
-- * Then show the value of smallest one.
SELECT MIN(a.AverageSalary) AS [MinAverageSalary]
FROM
(
    SELECT e.DepartmentID,
           AVG(e.Salary) AS [AverageSalary]
    FROM Employees AS e
    GROUP BY e.DepartmentID
) AS a;

-- *** Common Table Expressions *** --
-- Common Table Expressions (CTE) can be considered as "named subqueries".
-- They could be used to improve code readability and code reuse.
-- Usually they are positioned in the beginning of the query.
--CTE Syntax:
WITH Employees_CTE(FirstName,
                   LastName,
                   DepartmentName)
     AS (SELECT e.FirstName,
                e.LastName,
                d.Name
         FROM Employees AS e
              LEFT JOIN Departments AS d ON d.DepartmentID = e.DepartmentID)

SELECT FirstName,
       LastName,
       DepartmentName
FROM Employees_CTE;

-- *** Indices *** --
--Indices speed up searching of values in a certain column or group of columns.
-- * Usually implemented as B-trees.
--Indices can be built-in the table (clustered) or stored externally (non-clustered).
--Adding and deleting records in indexed tables is slower!
-- * Indices should be used for big tables only (e.g. 50 000 rows).

--Indices Syntax
CREATE NONCLUSTERED INDEX IX_Employees_FirstName_LastName
ON Employees(FirstName, LastName)