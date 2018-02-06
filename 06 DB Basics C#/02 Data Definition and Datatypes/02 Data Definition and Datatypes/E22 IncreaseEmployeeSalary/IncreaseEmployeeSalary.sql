use Soft_Uni

SELECT * FROM towns;
SELECT * FROM departments;
SELECT * FROM employees;
SELECT * FROM addresses;

/*** E22 Increase employees salary ***/

update employees
set salary = salary * 1.1; /* salary *= 1.1 */
select salary from employees;

/*** E23 Decrease employees salary ***/

update employees
set salary /= 1.60;
select salary from employees;