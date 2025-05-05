select count(*) as Total_students from students;

select avg(marks) as Average_marks from students;

select department ,max(salary) as highest_salary
from employees
group by department;

select department ,min(salary) as min_sal from employees group by department;

select sum(salary) from employees;
