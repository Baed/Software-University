-- ******************* STRING FUNCTIONS ******************* --

USE SoftUni;
SELECT FirstName+' '+LastName AS [Full Name]
FROM Employees;
SELECT CONCAT(FirstName, ' ', LastName) AS [Full Name]
FROM Employees;

-- SUBSTRING – extract part of a string
-- !!! Index is 1-based (STARTED WITH ONE)!!! ---

SELECT SUBSTRING('SoftUni', 5, 3); --SUBSTRING(String, StartIndex, Length)

SELECT FirstName,
       SUBSTRING(FirstName, 1, 4)+'UNI' AS NickName
FROM Employees;

-- REPLACE – replace specific string with another
SELECT REPLACE('SoftUni', 'Soft', 'Hard'); --REPLACE(String, Pattern, Replacement) OUTPUT: HARDUNI

SELECT REPLACE(FirstName, 'Gosho', '*****') AS [Replaced Name]
FROM Employees;

--LTRIM & RTRIM – remove spaces from either side of string
SELECT LTRIM('		Softuni');
SELECT RTRIM('Softuni    ');

-- LEN – counts the number of characters
SELECT LEN('Softuni');

-- DATALENGTH – get number of used bytes (double for Unicode)
SELECT DATALENGTH('   Softuni       S Q L ');

-- LEFT & RIGHT – get characters from beginning or end of string
SELECT LEFT('Softuni', 2); -- OUTPUT: So
SELECT RIGHT('Softuni', 4); -- OUTPUT: tuni

SELECT FirstName,
       LastName,
       LEFT(FirstName, 3) AS [Short name]
FROM Employees;
USE Demo;

-- REPLICATE - repeat string 
CREATE VIEW v_PublicPaymentInfo
AS
     SELECT CustomerID,
            FirstName,
            LastName,
            LEFT(PaymentNumber, 6)+REPLICATE('*', 10) AS [Censured Payment Info]
     FROM Customers;
SELECT v_PublicPaymentInfo.CustomerID,
       v_PublicPaymentInfo.FirstName,
       v_PublicPaymentInfo.LastName,
       v_PublicPaymentInfo.[Censured Payment Info]
FROM v_PublicPaymentInfo;

-- LOWER & UPPER – change letter casing
SELECT LOWER('Softuni'); -- OUTPUT: softuni
SELECT UPPER('Softuni'); -- OUTPUT: SOFTUNI

-- REVERSE – reverse order of all characters in string
SELECT REVERSE('Softuni'); -- OUTPUT: inutfoS

-- REPLICATE – repeat string
SELECT REPLICATE('*', 10); -- OUTPUT: **********

-- CHARINDEX – locate specific pattern (substring) in string
SELECT CHARINDEX('uni', 'Softuni', 1); -- CHARINDEX(Pattern, String, [StartIndex]) OUTPUT: 5
SELECT CHARINDEX('uni', 'Softuni');

--STUFF – insert substring at specific position
SELECT STUFF('Softuni', 1, 2, 'TEST'); -- STUFF(String, StartIndex, Length, Substring) OUTPUT: TESTftuni


-- ******************* MATH FUNCTIONS ******************* --
USE Demo;

--CAST – 
SELECT CAST(12.23343 AS INT); --OUTPUT: 12

--find area of triangles by given side and height
SELECT Id,
       (A * H) / 2 AS [Area]
FROM Triangles2;

--PI – get the value of Pi as float (15 –digit precision)
SELECT PI(); --OUTPUT: 3.14159265358979

--ABS – absolute value
SELECT ABS(-9); --OUTPUT: 9

--SQRT – square root (result will be float)
SELECT SQRT(16); --OUTPUT: 4

--SQUARE – raise to power of two
SELECT SQUARE(4); --OUTPUT: 16

-- Find the length of a line by given coordinates of end points
SELECT Id,
       SQRT(SQUARE(X1 - X2) + SQUARE(Y1 - Y2)) AS Length
FROM Lines;

--POWER – raise value to desired exponent
SELECT POWER(4, 2); --OUTPUT: 16

--ROUND – obtain desired precision
--Negative precision rounds characters before decimal point
SELECT ROUND(3.14567, 2); --OUTPUT: 3.15

--FLOOR & CEILING – return the nearest integer
SELECT FLOOR(3.14567); --OUTPUT: 3
SELECT CEILING(3.14567); --OUTPUT: 4

--Since we can't use half a box or half a pallet, we need to round up 
--to the nearest integer value
SELECT CEILING(CEILING(CAST(Quantity AS FLOAT) / BoxCapacity) / PalletCapacity) AS [Number of pallets]
FROM Products;

--SIGN – returns 1, -1 or 0, depending on value sign
SELECT SIGN(-6); --OUTPUT: -1

--RAND – get a random float value in range [0,1)
--If Seed is not specified, one is assigned at random
SELECT RAND(); --OUTPUT: random value
SELECT RAND(-5); --OUTPUT: random value


-- ******************* DATE FUNCTIONS ******************* --

--DATEPART – extract a segment from a date as an integer
--Part can be any part and format of date or time
SELECT DATEPART(day, '2015/01/25'); --OUTPUT: 25

--Use DATEPART to get the relevant parts of the date
USE Orders;
SELECT ProductName,
       OrderDate,
       DATEPART(QUARTER, OrderDate) AS Quarter,
       DATEPART(MONTH, OrderDate) AS Month,
       DATEPART(YEAR, OrderDate) AS Year,
       DATEPART(DAY, OrderDate) AS Day
FROM Orders;

--DATEDIFF – find difference between two dates
--Part can be any part and format of date or time
SELECT DATEDIFF(YEAR, '2015/01/25', '2017/01/25');  --OUTPUT: 2

--Example: Show employee experience
USE SoftUni;
SELECT EmployeeID,
       FirstName+' '+LastName AS [Employee Name],
       DATEDIFF(YEAR, HireDate, GETDATE()) AS [Years In Service]
FROM Employees
ORDER BY HireDate DESC;
SELECT *
FROM Employees;
SELECT EmployeeID,
       *
FROM Employees;
SELECT EmployeeID,
       FirstName,
       LastName,
       JobTitle,
       Salary
FROM Employees
WHERE Salary > 20000
ORDER BY Salary DESC;

--DATENAME – get a string representation of a date's part
SELECT DATENAME(weekday, '2017/01/27'); --OUTPUT: Friday

--DATEADD – perform date arithmetic
--Part can be any part and format of date or time
SELECT DATEADD(YEAR, 1, '2017/01/27'); --OUTPUT: 2018-01-27

--FORMAT – perform date arithmetic
SELECT FORMAT(DATEADD(MONTH, 3, '2017/01/27'), 'yyyy-MMM-dd'); --OUTPUT: 2017-Apr-27

--GETDATE – obtain current date and time
SELECT GETDATE(); --OUTPUT: 2018-02-06 15:40:36.077 current date and time


-- ******************* OTHER FUNCTIONS ******************* --
--CAST & CONVERT – convert between data types
SELECT CAST('2017/01/27' AS NVARCHAR); --OUTPUT:
SELECT CONVERT(NVARCHAR, '2017/01/27', 103); --OUTPUT: 

--ISNULL – swap NULL values with a specified default value
SELECT ISNULL('2017/01/27', 'Date'); --OUTPUT: 

--Example: Display “Not Finished” for projects with no EndDate
SELECT ProjectID,
       Name,
       ISNULL(CAST(EndDate AS VARCHAR), 'Not Finished')
FROM Projects;

--OFFSET & FETCH – get only specific rows from the result set
--Used in combination with ORDER BY for pagination
SELECT EmployeeID,
       FirstName,
       LastName
FROM Employees
ORDER BY EmployeeID
OFFSET 10 ROWS FETCH NEXT 5 ROWS ONLY;

--Wildcards are used with WHERE to filter for partial match
--Similar to Regular Expressions, but less capable
--Example: Find all employees who's first name starts with "Ro"
SELECT EmployeeID,
       FirstName,
       LastName
FROM Employees
WHERE FirstName LIKE 'Ro%';

-- %    -- any string, including zero-length
-- _    -- any single character
-- […]  -- any character within range
-- [^…] -- any character not in the range
SELECT ID,
       Name
FROM Tracks
WHERE Name LIKE '%max!%' ESCAPE '!';
