select
name,
department,
salary,
avg(salary) over() as avsalary 
from employees;

select 
name,
department,
salary,
avg(salary) over(partition by department) as DeptAvgSalary
from employees;


