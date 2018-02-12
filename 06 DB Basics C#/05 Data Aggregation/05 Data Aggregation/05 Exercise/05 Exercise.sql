USE Gringotts;
SELECT * FROM WizzardDeposits

-- 01. Records’ Count
SELECT COUNT(Id) AS [Count]
FROM WizzardDeposits;

--02. Longest Magic Wand
SELECT MAX(MagicWandSize) AS [LongestMagicWand]
FROM WizzardDeposits;

--03. Longest Magic Wand per Deposit Groups
SELECT DepositGroup,
       MAX(MagicWandSize) AS [LongestMagicWand]
FROM WizzardDeposits
GROUP BY DepositGroup;

--04.* Smallest Deposit Group per Magic Wand Size
-- EXERCISE solution
SELECT TOP (2) DepositGroup
FROM WizzardDeposits
GROUP BY DepositGroup
ORDER BY AVG(MagicWandSize);

-- Another solution
SELECT DepositGroup
FROM WizzardDeposits
GROUP BY DepositGroup
HAVING AVG(MagicWandSize) =
(
    SELECT TOP (1) AVG(MagicWandSize) AS [AverageWandSize]
    FROM WizzardDeposits
    GROUP BY DepositGroup
    ORDER BY AverageWandSize
);

-- solution WITH TIES
SELECT TOP 1 WITH TIES DepositGroup
FROM WizzardDeposits
GROUP BY DepositGroup
ORDER BY AVG(MagicWandSize);

-- another solution
SELECT DepositGroup
FROM WizzardDeposits
GROUP BY DepositGroup
HAVING AVG(MagicWandSize) =
(
    SELECT MIN(AvWandSizes.AvWandSize)
    FROM
(
    SELECT DepositGroup,
           AVG(MagicWandSize) AS [AvWandSize]
    FROM WizzardDeposits
    GROUP BY DepositGroup
) AS [AvWandSizes]
);

--05. Deposits Sum
SELECT DepositGroup,
       SUM(DepositAmount) AS [TotalSum]
FROM WizzardDeposits
GROUP BY DepositGroup;

--06. Deposits Sum for Ollivander Family
SELECT DepositGroup,
       SUM(DepositAmount) AS [TotalSum]
FROM WizzardDeposits
WHERE MagicWandCreator = 'Ollivander family'
GROUP BY DepositGroup;

--07. Deposits Filter
SELECT DepositGroup,
       SUM(DepositAmount) AS [TotalSum]
FROM WizzardDeposits
WHERE MagicWandCreator = 'Ollivander family'
GROUP BY DepositGroup
HAVING SUM(DepositAmount) < 150000
ORDER BY TotalSum DESC;

--08. Deposit Charge
SELECT DepositGroup,
       MagicWandCreator,
       MIN(DepositCharge) AS [MinDepositCharge]
FROM WizzardDeposits
GROUP BY DepositGroup,
         MagicWandCreator
ORDER BY MagicWandCreator,
         DepositGroup;

--09. Age Groups
SELECT CASE
           WHEN AGE BETWEEN 0 AND 10
           THEN '[0-10]'
           WHEN AGE BETWEEN 11 AND 20
           THEN '[11-20]'
           WHEN AGE BETWEEN 21 AND 30
           THEN '[21-30]'
           WHEN AGE BETWEEN 31 AND 40
           THEN '[31-40]'
           WHEN AGE BETWEEN 41 AND 50
           THEN '[41-50]'
           WHEN AGE BETWEEN 51 AND 60
           THEN '[51-60]'
           WHEN AGE > 60
           THEN '[61+]'
       END AS [AgeGroup],
       COUNT(*) AS [WizardCount]
FROM WizzardDeposits
GROUP BY CASE
             WHEN AGE BETWEEN 0 AND 10
             THEN '[0-10]'
             WHEN AGE BETWEEN 11 AND 20
             THEN '[11-20]'
             WHEN AGE BETWEEN 21 AND 30
             THEN '[21-30]'
             WHEN AGE BETWEEN 31 AND 40
             THEN '[31-40]'
             WHEN AGE BETWEEN 41 AND 50
             THEN '[41-50]'
             WHEN AGE BETWEEN 51 AND 60
             THEN '[51-60]'
             WHEN AGE > 60
             THEN '[61+]'
         END;

-- Another solution
SELECT IIF(Age >= 61, '[61+]', IIF(Age = 0, '[0-10]', CONCAT('[', (Age - 1) / 10 * 10 + 1, '-', (Age - 1) / 10 * 10 + 10, ']'))) AS [AgeGroup],
       COUNT(Age) AS [WizardCount]
FROM WizzardDeposits
GROUP BY IIF(Age >= 61, '[61+]', IIF(Age = 0, '[0-10]', CONCAT('[', (Age - 1) / 10 * 10 + 1, '-', (Age - 1) / 10 * 10 + 10, ']')))
HAVING COUNT(Age) > 0
ORDER BY AgeGroup;

--10. First Letter
SELECT LEFT(FirstName, 1) AS [FirstLetter]
FROM WizzardDeposits
WHERE DepositGroup = 'Troll Chest'
GROUP BY LEFT(FirstName, 1)
ORDER BY FirstLetter;

-- Another solution
SELECT DISTINCT
       LEFT(FirstName, 1) AS [FirstLetter]
FROM WizzardDeposits
WHERE DepositGroup = 'Troll Chest'
ORDER BY FirstLetter;

--11. Average Interest
SELECT DepositGroup,
       IsDepositExpired,
       AVG(DepositInterest) AS [AverageInterest]
FROM WizzardDeposits
WHERE DepositStartDate > '1985/01/01'
GROUP BY DepositGroup,
         IsDepositExpired
ORDER BY DepositGroup DESC,
         IsDepositExpired;

--12*. Rich Wizard, Poor Wizard
-- EXERCISE solution
SELECT SUM([Difference]) AS [SumDifference]
FROM
(
    SELECT DepositAmount - LEAD(DepositAmount) OVER(ORDER BY ID ASC) AS [Difference] -- LEAD next position 
    FROM WizzardDeposits
) AS [DiffResult];

-- Another solution
SELECT TOP 1
(
    SELECT DepositAmount
    FROM WizzardDeposits
    WHERE Id = (SELECT MIN(Id) FROM WizzardDeposits)
) -
(
    SELECT DepositAmount
    FROM WizzardDeposits
    WHERE Id = (SELECT MAX(Id) FROM WizzardDeposits)
) AS [SumDifference]
FROM WizzardDeposits;
   
-- solution with LAG
SELECT SUM(DepoDifference) AS [SumDifference]
FROM
(
    SELECT LAG(FirstName) OVER(ORDER BY Id) AS [Host Wizard],
           LAG(DepositAmount) OVER(ORDER BY Id) AS [Host Wizard Deposit],
           FirstName AS [Guest Wizard],
           DepositAmount AS [Guest Wizard Deposit],
           LAG(DepositAmount) OVER(ORDER BY Id) - DepositAmount AS [DepoDifference]
    FROM WizzardDeposits
) AS [Differences];

-- solution with CURSOR
DECLARE @currentDeposit DECIMAL(8, 2);
DECLARE @previousDeposit DECIMAL(8, 2);
DECLARE @sumDifferences DECIMAL(8, 2)= 0;
DECLARE wizardCursor CURSOR
FOR SELECT DepositAmount
    FROM WizzardDeposits;

OPEN wizardCursor;
FETCH NEXT FROM wizardCursor INTO @currentDeposit;
WHILE(@@FETCH_STATUS = 0)
    BEGIN
        IF(@previousDeposit IS NOT NULL)
            BEGIN
                SET @sumDifferences+=@previousDeposit - @currentDeposit;
            END;
        SET @previousDeposit = @currentDeposit;
        FETCH NEXT FROM wizardCursor INTO @currentDeposit;
    END;
CLOSE wizardCursor;
DEALLOCATE wizardCursor;

SELECT @sumDifferences AS SumDifference

--13. Departments Total Salaries
USE SoftUni;

SELECT DepartmentID,
       SUM(Salary) AS [TotalSalary]
FROM Employees
GROUP BY DepartmentID
ORDER BY DepartmentID;

--14. Employees Minimum Salaries
SELECT DepartmentID,
       MIN(Salary) AS [MinimumSalary]
FROM Employees
WHERE DepartmentID IN(2, 5, 7)
AND HireDate > '2000/01/01'
GROUP BY DepartmentID;

--15. Employees Average Salaries
SELECT *
INTO NewTable
FROM Employees
WHERE Salary > 30000;
DELETE FROM NewTable
WHERE ManagerId = 42;
UPDATE NewTable
  SET
      Salary += 5000
WHERE DepartmentID = 1;
SELECT DepartmentID,
       AVG(Salary) AS [AverageSalary]
FROM NewTable
GROUP BY DepartmentID;

--16. Employees Maximum Salaries
SELECT DepartmentID,
       MAX(Salary) AS [MaxSalary]
FROM Employees
GROUP BY DepartmentID
HAVING MAX(Salary) NOT IN(30000, 70000);
--HAVING MAX(Salary) NOT BETWEEN 30000 AND 70000;

--17. Employees Count Salaries
SELECT COUNT(Salary) AS [Count]
FROM Employees
WHERE ManagerID IS NULL;

--18.** 3rd Highest Salary
-- EXERCISE solution
SELECT DepartmentID,
       Salary
FROM
(
    SELECT DepartmentID,
           Salary,
           DENSE_RANK() OVER(PARTITION BY DepartmentID ORDER BY SALARY DESC) AS [Rank]
    FROM Employees
    GROUP BY DepartmentID,
             Salary
) AS [ThirdHighestSalary]
WHERE Rank = 3;

-- ANOTHER solution
SELECT DepartmentID,
(
    SELECT DISTINCT
           Salary
    FROM Employees
    WHERE DepartmentID = e.DepartmentID
    ORDER BY Salary DESC
    OFFSET 2 ROWS FETCH NEXT 1 ROWS ONLY
) AS [Third Highest Salary]
FROM Employees e
WHERE
(
    SELECT DISTINCT
           Salary
    FROM Employees
    WHERE DepartmentID = e.DepartmentID
    ORDER BY Salary DESC
    OFFSET 2 ROWS FETCH NEXT 1 ROWS ONLY
) IS NOT NULL
GROUP BY DepartmentID;

--19.** Salary Challenge
SELECT TOP 10 FirstName,
              LastName,
              e.DepartmentID
FROM Employees AS e
     INNER JOIN
(
    SELECT DepartmentID,
           AVG(Salary) AS [Average Salary]
    FROM Employees
    GROUP BY DepartmentID
) AS av ON e.DepartmentID = av.DepartmentID
WHERE Salary > [Average Salary]
ORDER BY e.DepartmentID;

-- LAB solution
SELECT TOP 10 FirstName,
              LastName,
              DepartmentID
FROM Employees AS [emp1]
WHERE Salary >
(
    SELECT AVG(Salary)
    FROM Employees AS [emp2]
    WHERE emp1.DepartmentID = emp2.DepartmentID
    GROUP BY DepartmentID
)
ORDER BY DepartmentID;
