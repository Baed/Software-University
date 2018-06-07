--create temporary table from an existing one
USE Employees
SELECT Id,
       FirstName,
       LastName
INTO TemporaryTable
FROM Employees;

-- creating new DB for exercise
CREATE DATABASE TableRelationsExercise
USE TableRelationsExercise

-- 01. One-To-One Relationship
CREATE TABLE Passports
(PassportID     INT IDENTITY(101, 1), -- DEFAULT(1, 1)
 PassportNumber CHAR(8) NOT NULL UNIQUE,
 CONSTRAINT PK_Passports PRIMARY KEY(PassportID)
);
CREATE TABLE Persons
(PersonID   INT IDENTITY,
 FirstName  NVARCHAR(20) NOT NULL,
 Salary     DECIMAL(10, 2) NOT NULL,
 PassportID INT NOT NULL,
 CONSTRAINT PK_Persons PRIMARY KEY(PersonID),
 CONSTRAINT FK_Persons_Passports FOREIGN KEY(PassportID) REFERENCES Passports(PassportID)
);

INSERT INTO Passports(PassportNumber)
VALUES('N34FG21B'), ('K65LO4R7'), ('ZE657QP2');
INSERT INTO Persons(FirstName, Salary, PassportID) 
VALUES 
  ('Roberto', 43330.00, 102),
  ('Tom', 56100.00, 103),
  ('Yana', 60200.00, 101);

SELECT p.PassportID,
       h.PersonID,
       h.FirstName,
       h.Salary,
       p.PassportNumber
FROM Passports AS p
     JOIN Persons AS h ON h.PassportID = p.PassportID
ORDER BY p.PassportID;

-- When we want to alter the tables
--ALTER TABLE Persons
--ADD CONSTRAINT PK_Persons PRIMARY KEY(PersonID);
--ALTER TABLE Passports
--ADD CONSTRAINT PK_Passports PRIMARY KEY(PassportID);
--ALTER TABLE Persons
--ADD CONSTRAINT FK_Persons_Passports FOREIGN KEY(PassportID) REFERENCES Passports(PassportID);

-- 02. One-To-Many Relationship
CREATE TABLE Manufacturers
(ManufacturerID INT IDENTITY,
 Name           NVARCHAR(50) NOT NULL,
 EstablishedOn  DATE,
 CONSTRAINT PK_Manufacturers PRIMARY KEY(ManufacturerID)
);
CREATE TABLE Models
(ModelID        INT IDENTITY(101, 1),
 Name           NVARCHAR(50) NOT NULL,
 ManufacturerID INT NOT NULL,
 CONSTRAINT PK_Models PRIMARY KEY(ModelID),
 CONSTRAINT FK_Models_Manufacturers FOREIGN KEY(ManufacturerID) REFERENCES Manufacturers(ManufacturerID)
);

INSERT INTO Manufacturers(Name, EstablishedOn) VALUES
  ('BMW', '1916/03/07'),
  ('Tesla', '2003/01/01'),
  ('Lada', '1966/05/01');
INSERT INTO Models(Name, ManufacturerID) VALUES
  ('X1', 1),
  ('i6', 1),
  ('Model S', 2),
  ('Model X', 2),
  ('Model 3', 2),
  ('Nova', 3);

SELECT c.Name,
       m.Name,
       m.ModelID,
	  c.ManufacturerID,
       c.EstablishedOn
FROM Manufacturers AS c
     JOIN Models AS m ON m.ManufacturerID = c.ManufacturerID
ORDER BY m.ModelID;

-- 03. Many-To-Many Relationship
CREATE TABLE Students
(StudentID INT IDENTITY,
 Name      NVARCHAR(50) NOT NULL,
 CONSTRAINT PK_Students PRIMARY KEY(StudentID)
);
CREATE TABLE Exams
(ExamID INT IDENTITY(101, 1),
 Name   NVARCHAR(50) NOT NULL,
 CONSTRAINT PK_Exams PRIMARY KEY(ExamID)
);
CREATE TABLE StudentsExams
(StudentID INT,
 ExamID    INT,
 CONSTRAINT PK_StudentsExams PRIMARY KEY(StudentID, ExamID),
 CONSTRAINT FK_StudentsExams_Students FOREIGN KEY(StudentID) REFERENCES Students(StudentID),
 CONSTRAINT FK_StudentsExams_Exams FOREIGN KEY(ExamID) REFERENCES Exams(ExamID)
);

INSERT INTO Students(Name)
VALUES('Mila'), ('Toni'), ('Ron');
INSERT INTO Exams(Name)
VALUES('SpringMVC'), ('Neo4j'), ('Oracle 11g');
INSERT INTO StudentsExams(StudentID, ExamID) VALUES
  (1, 101), (1, 102), (2, 101), (3, 103), (2, 102), (2, 103)

SELECT s.StudentID,
       s.Name,
       e.ExamID,
       e.Name
FROM Students AS s
     JOIN StudentsExams AS se ON se.StudentID = s.StudentID
     JOIN Exams AS e ON e.ExamID = se.ExamID;

-- 04. Self-Referencing
CREATE TABLE Teachers
(TeacherID INT IDENTITY(101, 1) UNIQUE,
 Name      NVARCHAR(50) NOT NULL,
 ManagerID INT,
 CONSTRAINT PK_Teachers PRIMARY KEY(TeacherID),
 CONSTRAINT FK_Teachers_Managers FOREIGN KEY(ManagerID) REFERENCES Teachers(TeacherID)
);

INSERT INTO Teachers(Name, ManagerID) VALUES
  ('John', NULL), ('Maya', 106), ('Silvia', 106), ('Ted', 105), ('Mark', 101), ('Greta', 101)

-- LEFT JOIN
SELECT t.TeacherID,
       t.Name,
       t.ManagerID
FROM Teachers AS t
     LEFT JOIN Teachers AS m ON t.ManagerID = m.TeacherID;

-- 05. Online Store Database
CREATE TABLE Cities
(CityID INT IDENTITY,
 Name   VARCHAR(50) NOT NULL,
 CONSTRAINT PK_Cities PRIMARY KEY(CityID)
);
CREATE TABLE Customers
(CustomerID INT IDENTITY,
 Name       VARCHAR(50) NOT NULL,
 Birthday   DATE,
 CityID     INT,
 CONSTRAINT PK_Customers PRIMARY KEY(CustomerID),
 CONSTRAINT FK_Customers_Cities FOREIGN KEY(CityID) REFERENCES Cities(CityID)
);
CREATE TABLE Orders
(OrderID    INT IDENTITY,
 CustomerID INT NOT NULL,
 CONSTRAINT PK_Orders PRIMARY KEY(OrderID),
 CONSTRAINT FK_Orders_Customers FOREIGN KEY(CustomerID) REFERENCES Customers(CustomerID)
);
CREATE TABLE ItemTypes
(ItemTypeID INT IDENTITY,
 Name       VARCHAR(50) NOT NULL,
 CONSTRAINT PK_ItemTypes PRIMARY KEY(ItemTypeID)
);
CREATE TABLE Items
(ItemID     INT IDENTITY,
 Name       VARCHAR(50) NOT NULL,
 ItemTypeID INT NOT NULL,
 CONSTRAINT PK_Items PRIMARY KEY(ItemID),
 CONSTRAINT FK_Items_ItemTypes FOREIGN KEY(ItemTypeID) REFERENCES ItemTypes(ItemTypeID)
);
CREATE TABLE OrderItems
(OrderID INT,
 ItemID  INT,
 CONSTRAINT PK_OrderItems PRIMARY KEY(OrderID, ItemID),
 CONSTRAINT FK_OrderItems_Orders FOREIGN KEY(OrderID) REFERENCES Orders(OrderID),
 CONSTRAINT FK_OrderItems_Items FOREIGN KEY(ItemID) REFERENCES Items(ItemID)
);

-- 06. University Database
CREATE TABLE Majors
(MajorID INT NOT NULL,
 Name    NVARCHAR(50) NOT NULL,
 CONSTRAINT PK_Majors PRIMARY KEY(MajorID)
);
CREATE TABLE NewStudents
(StudentID     INT IDENTITY,
 StudentNumber INT NOT NULL UNIQUE,
 StudentName   NVARCHAR(50) NOT NULL,
 MajorID       INT,
 CONSTRAINT PK_Students PRIMARY KEY(StudentID),
 CONSTRAINT FK_Students_Majors FOREIGN KEY(MajorID) REFERENCES Majors(MajorID)
);
CREATE TABLE Payments
(PaymentID     INT IDENTITY,
 PaymentDate   DATE NOT NULL,
 PaymentAmount DECIMAL(10, 2) NOT NULL,
 StudentID     INT NOT NULL,
 CONSTRAINT PK_Payments PRIMARY KEY(PaymentID),
 CONSTRAINT FK_Payments_Students FOREIGN KEY(StudentID) REFERENCES NewStudents(StudentID)
);
CREATE TABLE Subjects
(SubjectID   INT IDENTITY,
 SubjectName NVARCHAR(50) NOT NULL,
 CONSTRAINT PK_Subjects PRIMARY KEY(SubjectID)
);
CREATE TABLE Agenda
(StudentID INT,
 SubjectID INT,
 CONSTRAINT PK_Agenda PRIMARY KEY(StudentID, SubjectID),
 CONSTRAINT FK_Agenda_Students FOREIGN KEY(StudentID) REFERENCES NewStudents(StudentID),
 CONSTRAINT FK_Agenda_Subjects FOREIGN KEY(SubjectID) REFERENCES Subjects(SubjectID)
);
-- 07. SoftUni Design
--Create an E/R Diagram  

-- 08. Geography Design
--Create an E/R Diagram  

-- 09. *Peaks in Rila
USE Geography
SELECT m.MountainRange,
       p.PeakName,
       p.Elevation
FROM Peaks AS p
     JOIN Mountains AS m ON p.MountainId = m.Id
WHERE m.MountainRange = 'Rila'
ORDER BY p.Elevation DESC;