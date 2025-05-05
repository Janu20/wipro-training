begin transaction;

update employees
set salary = salary + 1000
where empId =1;

save transaction IncreaseJohn;

update employees
set salary = salary + 1000
where empId = 2;

rollback transaction IncreaseJohn;

commit;