select FirstName,Marks,
Case
   when marks >= 90 then 'A'
   when marks >= 75 then 'B'
   when marks >= 60 then 'C'
   else 'D'
End as Grade
from Students;



select Name,salary,
case
 When salary >= 70000 then 'High'
 when salary >=50000 then 'Medium'
 else 'Low'
end as SalaruBand
from employees;