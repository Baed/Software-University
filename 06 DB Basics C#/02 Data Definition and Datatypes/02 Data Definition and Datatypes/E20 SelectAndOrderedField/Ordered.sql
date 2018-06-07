use Soft_Uni

SELECT * FROM towns;
SELECT * FROM departments;
SELECT * FROM employees;
SELECT * FROM addresses;

/*** E20 Ordered fields (x => x.FieldName) ***/

select * from towns as t order by t.name;
select * from departments as d order by d.name;
select * from employees as s order by s.salary desc;

/*** E21 Basic select some fields ***/

select name from towns order by name;
select name from departments order by name;
select first_name,last_name,job_title,salary from employees order by salary desc;


