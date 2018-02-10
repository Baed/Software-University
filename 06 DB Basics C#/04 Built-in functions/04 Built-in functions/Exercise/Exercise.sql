-- ******** Part I – Queries for SoftUni Database ********* --
USE SoftUni

-- -------------------------01. Find Names of All Employees by First Name---------
SELECT FirstName, LastName 
FROM Employees
WHERE FirstName LIKE 'SA%'
ORDER BY FirstName desc;

-- -------------------------02. Find Names of All Employees by Last Name---------
SELECT FirstName, LastName 
FROM Employees
WHERE LastName LIKE '%ei%';

-- -------------------03. Find First Names of All Employess--------------------
SELECT FirstName 
FROM Employees
WHERE (DepartmentID = 10 OR DepartmentID = 3) AND (year(HireDate) >= 1995 AND year(HireDate) <= 2005);

-- -------------------04. Find All Employees Except Engineers-----
SELECT FirstName, LastName 
FROM Employees
WHERE JobTitle NOT LIKE '%engineer%';

-- -----------------05. Find Towns with Name Length-------------
SELECT Name 
FROM Towns
WHERE LEN(Name) IN (5, 6)
--WHERE LEN(Name) = 5 OR LEN(Name) = 6
ORDER BY Name;

-- -----------------06. Find Towns Starting With-------------
SELECT TownID, Name 
FROM Towns
WHERE LEFT(Name, 1) IN ('M', 'K', 'B', 'E')
--WHERE Name LIKE 'M%' OR Name LIKE'K%' OR Name LIKE 'B%' OR Name LIKE 'E%'
ORDER BY Name

-- -----------------07. Find Towns Not Starting With-------------
SELECT TownID, Name 
FROM Towns	
WHERE Name LIKE '[^RBD]%'
--WHERE Name NOT LIKE 'R%' AND Name NOT LIKE 'B%' AND Name NOT LIKE 'D%'
ORDER BY Name

-- -----------08. Create View Employees Hired After--------------------
CREATE VIEW  v_employees_hired_after_2000 AS
SELECT FirstName, LastName 
FROM Employees
WHERE YEAR(HireDate) > 2000;

SELECT *
FROM v_employees_hired_after_2000

-- ----------09. Length of Last Name---------------------
SELECT FirstName, LastName
FROM employees
WHERE LEN(LastName) = 5;

-- ******** Part II – Queries for Geography Database ********* --
USE Geography

-- -----------10. Countries Holding 'A'------------------
SELECT CountryName, IsoCode
FROM Countries
WHERE CountryName LIKE '%a%a%a%'
--WHERE LOWER(LEN(CountryName) - LEN(REPLACE(CountryName, 'a', '')) + 1) >= 3
ORDER BY IsoCode;

-- -----------11. Mix of Peak and River Names------------------
--SELECT p.PeakName, 
--	    r.RiverName, 
--	    LOWER(CONCAT(p.PeakName, SUBSTRING(r.RiverName, 2, LEN(r.RiverName) - 1))) AS Mix
--FROM Peaks AS p, Rivers AS r
--WHERE RIGHT(p.PeakName, 1) = LEFT(r.RiverName, 1)
--ORDER BY mix;

SELECT PeakName,
       RiverName, 
	  LOWER(SUBSTRING(PeakName, 1, LEN(PeakName) - 1) + RiverName) AS Mix
FROM Peaks JOIN Rivers
ON RIGHT(Peaks.PeakName, 1) = LEFT(Rivers.RiverName, 1)
ORDER BY Mix

-- ******** Part III – Queries for Diablo Database ********* --
USE Diablo

-- -----------12. Games From 2011 and 2012 Year------------------
SELECT TOP (50) Name,
FORMAT(Start, 'yyyy-MM-dd') AS Start
--LEFT(CONVERT(varchar, Start, 120), 10) AS Start			-- YYYY-MM-DD hh:mi:ss
--REPLACE(CONVERT(varchar, Start, 111), '/', '-') AS Start	-- YYYY/MM/DD
--REPLACE(CONVERT(varchar, Start, 102), '.', '-') AS Start	-- YYYY.MM.DD
FROM Games
WHERE YEAR(Start) IN (2011, 2012)
--WHERE YEAR(START)= 2011 or YEAR(START) = 2012
--WHERE YEAR(START) BETWEEN 2011 AND 2012
ORDER BY Start, Name

-- -----------13. User Email Providers------------------
SELECT TOP (10) Username, --Email,
--RIGHT(Email, LEN(Email) - CHARINDEX('@', Email)) AS [Email Provider]
SUBSTRING(Email, CHARINDEX('@', Email) + 1, LEN(Email)) AS [Email Provider]
FROM Users
ORDER BY [Email Provider], Username;

-- -----------14. Get Users with IPAddress Like Pattern------------------
SELECT Username, IpAddress
FROM Users
WHERE IpAddress LIKE '___.1%.%.___'
ORDER BY Username;

-- -----------15. Show All Games with Duratio------------------
SELECT Name AS [Game],
CASE 
     WHEN DATEPART(HH, Start) BETWEEN 0 AND 11 THEN 'Morning'
--	WHEN DATEPART(HH, Start) IN (0, 11) THEN 'Morning'
--	WHEN DATEPART(HH, Start) < (0, 11) THEN 'Morning'
     WHEN DATEPART(HH, Start) BETWEEN 12 AND 17 THEN 'Afternoon'
     WHEN DATEPART(HH, Start) BETWEEN 18 AND 23 THEN 'Evening'
END AS [Part of the day],
CASE 
     WHEN Duration <= 3 THEN 'Extra Short'
     WHEN Duration BETWEEN 4 AND 6 THEN 'Short'
     WHEN Duration BETWEEN 7 AND 10 THEN 'Long'
     ELSE 'Extra Long'
END AS [Duration]
FROM Games;

-- ******** Part IV – Date Functions Queries ********* --
USE Orders
SELECT * FROM Orders
-- -----------16. Orders Table------------------
SELECT ProductName, OrderDate,
DATEADD(DAY, 3, OrderDate)   AS [Pay Due],
DATEADD(MONTH, 1,  OrderDate)  AS [Deliver Due]
FROM Orders;

-- -----------17. People Table-----------------
SELECT ProductName AS [Product Name],
       OrderDate AS [Order Date],
DATEDIFF(YEAR, OrderDate, GETDATE()) AS [Age In Years],
DATEDIFF(MONTH, OrderDate,  GETDATE()) AS [Age In Month],
DATEDIFF(DAY, OrderDate, GETDATE()) AS [Age In Days],
DATEDIFF(MINUTE, OrderDate, GETDATE()) AS [Age In Minutes]
FROM Orders;
