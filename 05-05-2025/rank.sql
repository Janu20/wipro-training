select 
name,
salary,
rank() over(order by salary desc) as rankbysalary
from employees;