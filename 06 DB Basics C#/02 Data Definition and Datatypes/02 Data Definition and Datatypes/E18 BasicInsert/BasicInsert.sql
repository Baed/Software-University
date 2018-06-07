create database Soft_Uni;
use Soft_Uni;

/*** E16 Create SoftUni Base ***/

create table towns(
   id INT IDENTITY NOT NULL,
   name varchar(30)
   CONSTRAINT PK_towns PRIMARY KEY (id)
);

create table addresses(
   id  INT IDENTITY NOT NULL, 
   address_text nvarchar(50),
   town_id INT,
   CONSTRAINT PK_addresses PRIMARY KEY (id), 
   CONSTRAINT fk_addresses_towns FOREIGN KEY (town_id) REFERENCES towns(id)  
);

create table departments(
   id INT IDENTITY NOT NULL,
   name nvarchar(30)
   CONSTRAINT PK_departments PRIMARY KEY (id), 
);

create table employees(
   id INT IDENTITY NOT NULL,
   first_name nvarchar(20),
   middle_name nvarchar(20),
   last_name nvarchar(20),
   job_title varchar(30),
   department_id INT,
   hire_date date,
   salary decimal (15,2),
   address_id INT,
   CONSTRAINT PK_employees PRIMARY KEY (id),
   CONSTRAINT FK_address_id FOREIGN KEY (address_id)  REFERENCES addresses(id),
   CONSTRAINT FK_department_id FOREIGN KEY (department_id) REFERENCES  departments (id)  
);

/*** E18 Basic Insert ***/

drop table addresses;
drop table towns;
drop table departments;
drop table employees;

insert into towns(name)values
('Sofia'),('Plovdiv'),('Varna'),('Burgas');

insert into departments values
('Engineering'), ('Sales'), ('Marketing'), ('Software Development'), ('Quality Assurance');

insert into employees(first_name,middle_name,last_name,job_title,department_id,hire_date,salary)
values('Ivan','Ivanov','Ivanov','.NET Developer',4,'2013-02-01', 3500.00),
('Petar','Petrov','Petrov','Senior Engineer',1,'2004-03-02', 4000.00),
('Maria','Petrova','Ivanova','Intern',5,'2016-08-28', 525.25),
('Georgi','Terziev','Ivanov','CEO',2,'2007-12-09', 3000.00),
('Peter','Pan','Pan','Intern',3,'2016-08-28', 599.88);

/*** E19 Select All Fields ***/

SELECT * FROM towns;
SELECT * FROM departments;
SELECT * FROM employees;
SELECT * FROM addresses;