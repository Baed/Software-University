-- ***** 05. Table Relations (LAB) ***** --
CREATE DATABASE TableRelationsDemo
USE TableRelationsDemo
--One-to-many – e.g. country / towns
--One country has many towns
--Many-to-many – e.g. student / course
--One student has many courses
--One course has many students
--One-to-one – e.g. example driver / car
--One driver has only one car
--Rarely used

-- One-to-Many: Tables
--One-to-Many: Foreign Key
--The table holding the foreign key is the child table
--The table holding the referenced primary key is the parent/referenced table
--CONSTRAINT FK_Peaks_Mountains
--FOREIGN KEY (MountainID) 
--REFERENCES Mountains(MountainID)
CREATE TABLE Mountains
(MountainID   INT IDENTITY,
 MountainName NVARCHAR(50) NOT NULL,
 CONSTRAINT PK_Mountains PRIMARY KEY(MountainID)
);
CREATE TABLE Peaks
(PeakId     INT IDENTITY,
 PeakName NVARCHAR(50) NOT NULL,
 MountainID INT,
 CONSTRAINT PK_Peaks PRIMARY KEY(PeakId),
 CONSTRAINT FK_Peaks_Mountains FOREIGN KEY(MountainID) REFERENCES Mountains(MountainID)
);
INSERT INTO Mountains(MountainName)
VALUES('Rila'), ('Pirin'), ('Vitosha');
INSERT INTO Peaks(PeakName, MountainID)
VALUES('Musala', 1), ('Malyovitza', 1), ('Vihren', 2), ('Cherni vruh', 3);
SELECT *
from Mountains
--FROM Peaks;

-- *** Many-to-Many *** --
-- 01. Create Tables
CREATE TABLE Employees
(ID   INT IDENTITY,
 EmployeeName NVARCHAR(50) NOT NULL,
 CONSTRAINT PK_Employees PRIMARY KEY(ID)
);
CREATE TABLE Projects
(ID   INT IDENTITY,
 ProjectName NVARCHAR(50) NOT NULL,
 CONSTRAINT PK_Projects PRIMARY KEY(ID)
);
-- 02. Mapping Table
CREATE TABLE EmployeesProjects
(EmployeeID INT,
 ProjectID  INT,
 CONSTRAINT PK_EmployeesProjects PRIMARY KEY(EmployeeID, ProjectID),
 CONSTRAINT FK_EmployeesProjects_Employees FOREIGN KEY(EmployeeID) REFERENCES Employees(ID),
 CONSTRAINT FK_EmployeesProjects_Projects FOREIGN KEY(ProjectID) REFERENCES Projects(ID)
);
INSERT INTO Employees(EmployeeName)
VALUES('Bay Ivan'), ('Chicho Gosho'), ('Ceko Sifonya');
INSERT INTO Projects(ProjectName)
VALUES('MySQL Project'), ('Super Java Project'), ('MicroSoft Project');
INSERT INTO EmployeesProjects(EmployeeID, ProjectID)
VALUES(1, 2), (1, 1), (3, 3),  (2, 1);
SELECT e.EmployeeName,
       p.ProjectName,
       ep.EmployeeID,
       ep.ProjectID
FROM Employees AS e
     JOIN EmployeesProjects AS ep ON ep.EmployeeID = e.ID
     JOIN Projects AS p ON p.ID = ep.ProjectID;

-- *** One-to-One *** --
CREATE TABLE Drivers
(ID         INT IDENTITY,
 DriverName NVARCHAR(50) NOT NULL,
 CONSTRAINT PK_Drivers PRIMARY KEY(ID)
);
CREATE TABLE Cars
(ID       INT IDENTITY,
 DriverID INT
 UNIQUE,
 CarName NVARCHAR(50) NOT NULL,
 CONSTRAINT PK_Cars PRIMARY KEY(ID),
 CONSTRAINT FK_Cars_Drivers FOREIGN KEY(DriverID) REFERENCES Drivers(ID)
);
INSERT INTO Drivers(DriverName)
VALUES('Ivan Ivanov'), ('Toshko Africanski');
INSERT INTO Cars(CarName, DriverID)
VALUES ('Lada Samara', 1), ('BMW X5', 2);
SELECT d.ID,
       d.DriverName,
       c.ID,
       c.CarName
FROM Drivers AS d
     JOIN Cars AS c ON c.ID = d.ID;

--With a JOIN statement, we can get data from two tables simultaneously
--JOINs require at least two tables and a "join condition"
SELECT d.ID,
       d.DriverName,
       c.ID,
       c.CarName
FROM Drivers AS d
     JOIN Cars AS c ON c.ID = d.ID;

--Problem: Peaks in Rila
--Use database "Geography". Report all peaks for "Rila" mountain.
--Report includes mountain's name, peak's name and also peak's elevation.
--Peaks should be sorted by elevation descending.
USE Geography
SELECT m.MountainRange,
       p.PeakName,
       p.Elevation
FROM Mountains AS m
     JOIN Peaks AS p ON p.MountainId = m.Id
WHERE m.MountainRange = 'Rila'
ORDER BY p.Elevation DESC;

-- *** Cascade Delete: Example *** --
--Cascade can be either Delete or Update.
--Use Cascade Delete when:
-- -The related entities are meaningless without the "main" one
--Do not use Cascade Delete when:
-- -You perform a “logical delete“
-- -Entities are marked as deleted (but not actually deleted)
-- -In more complicated relations, cascade delete won't work with circular references
CREATE TABLE Drivers
(ID         INT IDENTITY,
 DriverName NVARCHAR(50) NOT NULL,
 CONSTRAINT PK_Drivers PRIMARY KEY(ID)
);
CREATE TABLE Cars
(ID       INT IDENTITY,
 DriverID INT
 UNIQUE,
 CarName NVARCHAR(50) NOT NULL,
 CONSTRAINT PK_Cars PRIMARY KEY(ID),
 CONSTRAINT FK_Cars_Drivers FOREIGN KEY(DriverID) REFERENCES Drivers(ID) ON DELETE CASCADE
);
INSERT INTO Drivers(DriverName)
VALUES('Ivan Ivanov'), ('Toshko Africanski');
INSERT INTO Cars(CarName, DriverID)
VALUES ('Lada Samara', 1), ('BMW X5', 2);
SELECT d.ID,
       d.DriverName,
       c.ID,
       c.CarName
FROM Drivers AS d
     JOIN Cars AS c ON c.ID = d.ID;
-- DELETE CASCADE
DELETE FROM Cars
WHERE DriverID = 1;

-- *** Cascade Update: Example *** --
--Use Cascade Update when:
--The primary key is not identity (not auto-increment) and therefore it can be changed
--Best used with unique constraint
--Do not use Cascade Update when:
--The primary is identity (auto-increment)
--Cascading can be avoided using triggers or procedures.
CREATE TABLE Products
(ID          INT IDENTITY,
 BarcodeName NVARCHAR(50) NOT NULL,
 CONSTRAINT PK_Products PRIMARY KEY(ID)
);
CREATE TABLE Stock
(ID        INT IDENTITY,
 StockName NVARCHAR(50) NOT NULL,
 BarcodeId INT,
 CONSTRAINT PK_Stock PRIMARY KEY(ID),
 CONSTRAINT FK_Stock_Products FOREIGN KEY(BarcodeId) REFERENCES Products(ID) ON UPDATE CASCADE
);
INSERT INTO Products(BarcodeName)
VALUES('1212343'), ('234543536');
INSERT INTO Stock(StockName, BarcodeId)
VALUES ('Samsung HX-765W40', 1), ('Iphone 8 Plus', 2);
