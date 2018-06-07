USE SoftUni;
-- 01. Employee Address
SELECT TOP 5 e.EmployeeID,
             e.JobTitle,
             e.AddressID,
             a.AddressText
FROM Employees AS e
     JOIN Addresses AS a ON e.AddressID = a.AddressID
ORDER BY e.AddressID;

-- 02. Addresses with Towns
SELECT TOP 50 e.FirstName,
              e.LastName,
              t.Name AS [Town],
              a.AddressText
FROM Employees AS e
     JOIN Addresses AS a ON a.AddressID = e.AddressID
     JOIN Towns AS t ON t.TownID = a.TownID
ORDER BY FirstName,
         LastName;

-- 03. Sales Employees
SELECT e.EmployeeID,
       e.FirstName,
       e.LastName,
       d.Name AS [DepartmentName]
FROM Employees AS e
     JOIN Departments AS d ON d.DepartmentID = e.DepartmentID
WHERE d.Name = 'Sales'
ORDER BY EmployeeID;

-- 04. Employee Departments
SELECT TOP 5 e.EmployeeID,
             e.FirstName,
             e.Salary,
             d.Name AS [DepartmentName]
FROM Employees AS e
     JOIN Departments AS d ON d.DepartmentID = e.DepartmentID
WHERE e.Salary > 15000
ORDER BY e.DepartmentID;

-- 05. Employees Without Projects
SELECT TOP 3 e.EmployeeID,
             e.FirstName
FROM Employees AS e
     LEFT OUTER JOIN EmployeesProjects AS p ON p.EmployeeID = e.EmployeeID
WHERE p.EmployeeID IS NULL
ORDER BY e.EmployeeID;

-- Another solution
SELECT TOP 3 e.EmployeeID,
             e.FirstName
FROM Employees AS e
WHERE e.EmployeeID NOT IN
(
    SELECT DISTINCT
           EmployeeID
    FROM EmployeesProjects
)
ORDER BY e.EmployeeID;

-- 06. Employees Hired After
SELECT e.FirstName,
       e.LastName,
       e.HireDate,
       d.Name AS [DeptName]
FROM Employees AS e
     JOIN Departments AS d ON d.DepartmentID = e.DepartmentID
WHERE e.HireDate > '1999/01/01'
      AND d.Name IN('Sales', 'Finance');

-- Another solution
SELECT e.FirstName,
       e.LastName,
       e.HireDate,
       d.Name AS [DeptName]
FROM Employees AS e
     JOIN Departments AS d ON(d.DepartmentID = e.DepartmentID
                              AND e.HireDate > '1999/01/01'
                              AND d.Name IN('Sales', 'Finance'));

-- 07. Employees With Project
SELECT TOP 5 e.EmployeeID,
             e.FirstName,
             p.Name AS [ProjectName]
FROM Employees AS e
     JOIN EmployeesProjects AS ep ON ep.EmployeeID = e.EmployeeID
     JOIN Projects AS p ON p.ProjectID = ep.ProjectID
WHERE p.StartDate > '2002/08/13'
      AND p.EndDate IS NOT NULL
ORDER BY e.EmployeeID;

-- 08. Employee 24
SELECT e.EmployeeID,
       e.FirstName,
       IIF(p.StartDate >= '2005/01/01', NULL, p.Name) AS [ProjectName]
FROM Employees AS e
     JOIN EmployeesProjects AS ep ON ep.EmployeeID = e.EmployeeID
     JOIN Projects AS p ON p.ProjectID = ep.ProjectID
WHERE e.EmployeeID = 24;

-- Another solution
SELECT e.EmployeeID,
       e.FirstName,
       CASE
           WHEN p.StartDate >= '2005/01/01'
           THEN NULL
           ELSE p.Name
       END [ProjectName]
FROM Employees AS e
     JOIN EmployeesProjects AS ep ON ep.EmployeeID = e.EmployeeID
     JOIN Projects AS p ON p.ProjectID = ep.ProjectID
WHERE e.EmployeeID = 24;

-- 09. Employee Manager
SELECT e.EmployeeID,
       e.FirstName,
       e.ManagerID,
       m.FirstName
FROM Employees AS e
     JOIN Employees AS m ON e.ManagerID = m.EmployeeID
WHERE e.ManagerID IN(3, 7)
ORDER BY e.EmployeeID;

-- 10. Employees Summary
SELECT TOP 50 e.EmployeeID,
              CONCAT(e.FirstName, ' ', e.LastName) AS [EmployeeName],
              CONCAT(m.FirstName, ' ', m.LastName) AS [ManagerName],
              d.Name AS [DepartmentName]
FROM Employees AS e
     JOIN Employees AS m ON e.ManagerID = m.EmployeeID
     JOIN Departments AS d ON e.DepartmentID = d.DepartmentID
ORDER BY e.EmployeeID;

-- 11. Min Average Salary
SELECT MIN(avg.AverageSalary) AS [MinAverageSalary]
FROM
(
    SELECT AVG(Salary) AS [AverageSalary]
    FROM Employees
    GROUP BY DepartmentID
) AS avg;

-- 12. Highest Peaks in Bulgaria
USE Geography;
SELECT c.CountryCode,
       m.MountainRange,
       p.PeakName,
       p.Elevation
FROM MountainsCountries AS c
     JOIN Mountains AS m ON m.Id = c.MountainId
     JOIN Peaks AS p ON p.MountainId = c.MountainId
WHERE c.CountryCode = 'BG'
      AND p.Elevation > 2835
ORDER BY p.Elevation DESC;

-- 13. Count Mountain Ranges
SELECT CountryCode,
       COUNT(MountainId) AS [MountainRanges]
FROM MountainsCountries
WHERE CountryCode IN('US', 'BG', 'RU')
GROUP BY CountryCode;

-- another solution
SELECT mc.CountryCode,
       COUNT(mc.MountainId) AS [MountainRanges]
FROM Countries AS c
     JOIN MountainsCountries AS mc ON c.CountryCode = mc.CountryCode
WHERE c.CountryName IN('United States', 'Bulgaria', 'Russia')
GROUP BY mc.CountryCode;

-- 14. Countries With or Without Rivers
SELECT TOP 5 c.CountryName,
             r.RiverName
FROM Countries AS c
     JOIN Continents AS cont ON cont.ContinentCode = c.ContinentCode
     LEFT JOIN CountriesRivers AS cr ON cr.CountryCode = c.CountryCode
     LEFT JOIN Rivers AS r ON r.Id = cr.RiverId
WHERE cont.ContinentName = 'Africa'
ORDER BY c.CountryName;

-- 15. *Continents and Currencies
WITH CCYContUsage_CTE(ContinentCode,
                      CurrencyCode,
                      CurrencyUsage)
     AS (SELECT ContinentCode,
                CurrencyCode,
                COUNT(CountryCode) AS [CurrencyUsage]
         FROM Countries
         GROUP BY ContinentCode,
                  CurrencyCode
         HAVING COUNT(CountryCode) > 1)
     SELECT ContMax.ContinentCode,
            ccy.CurrencyCode,
            ContMax.TopCCYUsage
     FROM
(
    SELECT ContinentCode,
           MAX(CurrencyUsage) AS [TopCCYUsage]
    FROM CCYContUsage_CTE
    GROUP BY ContinentCode
) AS [ContMax]
JOIN CCYContUsage_CTE AS ccy ON(ContMax.ContinentCode = ccy.ContinentCode
                                AND ContMax.TopCCYUsage = ccy.CurrencyUsage)
     ORDER BY ContMax.ContinentCode;

-- Another solution
SELECT ContinentCode,
       CurrencyCode,
       CurrencyUsage
FROM
(
    SELECT ContinentCode,
           CurrencyCode,
           CurrencyUsage,
           DENSE_RANK() OVER(PARTITION BY(ContinentCode) ORDER BY CurrencyUsage DESC) AS [Rank]
    FROM
       (
           SELECT ContinentCode,
                  CurrencyCode,
                  COUNT(CurrencyCode) AS [CurrencyUsage]
           FROM Countries
           GROUP BY ContinentCode,
                    CurrencyCode
       ) AS [currencies]
) AS [RankCurrencies]
WHERE [Rank] = 1
      AND CurrencyUsage > 1
ORDER BY ContinentCode;

-- 16. Countries Without any Mountains
SELECT COUNT(c.CountryCode) AS [CountryCode]
FROM Countries AS c
     LEFT JOIN MountainsCountries AS m ON c.CountryCode = m.CountryCode
WHERE m.MountainId IS NULL;

-- 17. Highest Peak and Longest River by Country
SELECT TOP 5 c.CountryName,
             MAX(p.Elevation) AS [HighestPeakElevation],
             MAX(r.Length) AS [LongestRiverLength]
FROM Countries AS c
     LEFT JOIN MountainsCountries AS mc ON c.CountryCode = mc.CountryCode
     LEFT JOIN Peaks AS p ON p.MountainId = mc.MountainId
     LEFT JOIN CountriesRivers AS cr ON c.CountryCode = cr.CountryCode
     LEFT JOIN Rivers AS r ON r.Id = cr.RiverId
GROUP BY c.CountryName
ORDER BY HighestPeakElevation DESC,
         LongestRiverLength DESC,
         c.CountryName;

-- 18. *Highest Peak Name and Elevation by Country
WITH PeaksMountains_CTE(Country,
                        PeakName,
                        Elevation,
                        Mountain)
     AS (SELECT c.CountryName,
                p.PeakName,
                p.Elevation,
                m.MountainRange
         FROM Countries AS c
              LEFT JOIN MountainsCountries AS mc ON c.CountryCode = mc.CountryCode
              LEFT JOIN Mountains AS m ON mc.MountainId = m.Id
              LEFT JOIN Peaks AS p ON p.MountainId = m.Id)
     SELECT TOP 5 TopElevations.Country AS Country,
                  ISNULL(pm.PeakName, '(no highest peak)') AS [HighestPeakName],
                  ISNULL(TopElevations.HighestElevation, 0) AS [HighestPeakElevation],
                  ISNULL(pm.Mountain, '(no mountain)') AS [Mountain]
     FROM
(
    SELECT Country,
           MAX(Elevation) AS [HighestElevation]
    FROM PeaksMountains_CTE
    GROUP BY Country
) AS [TopElevations]
LEFT JOIN PeaksMountains_CTE AS pm ON(TopElevations.Country = pm.Country
                                      AND TopElevations.HighestElevation = pm.Elevation)
     ORDER BY Country,
              HighestPeakName;

-- Another solution
SELECT TOP 5 CountryName AS [Country],
       CASE
           WHEN PeakName IS NULL
           THEN '(no highest peak)'
           ELSE PeakName
       END AS [Highest Peak Name],
       CASE
           WHEN Elevation IS NULL
           THEN 0
           ELSE Elevation
       END AS [Highest Peak Elevation],
       CASE
           WHEN MountainRange IS NULL
           THEN '(no mountain)'
           ELSE MountainRange
       END AS [Mountain]
FROM
(
    SELECT CountryName,
           PeakName,
           Elevation,
           MountainRange,
           DENSE_RANK() OVER(PARTITION BY CountryName ORDER BY Elevation DESC) AS [Rank]
    FROM
	   (
	       SELECT c.CountryName,
	              p.PeakName,
	              p.Elevation,
	              m.MountainRange
	       FROM Countries AS c
	            LEFT JOIN MountainsCountries AS mc ON c.CountryCode = mc.CountryCode
	            LEFT JOIN Mountains AS m ON mc.MountainId = m.Id
	            LEFT JOIN Peaks AS p ON p.MountainId = m.Id
	   ) AS [AllPeaks]
) AS [RankedPeaks]
WHERE [Rank] = 1
ORDER BY CountryName,
         PeakName;