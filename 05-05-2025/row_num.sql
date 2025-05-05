select
name,
department,
salary,
row_number() over(Partition by department order by salary desc) as rownum
from employees;