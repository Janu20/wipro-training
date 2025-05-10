begin transaction

delete from students where marks < 60;

rollback;