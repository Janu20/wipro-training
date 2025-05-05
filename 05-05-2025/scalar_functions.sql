create table students(
StudenId int Primary key,
FirstName varchar(50),
Marks Int,
DOB date
);

Insert into students (StudenId,FirstName,Marks,DOB)
Values
(1,'Amit',92,'2003-05-10'),
(2,'Neha',78,'2002-11-15'),
(3,'Rahul',61,'2004-01-20'),
(4,'Sneha',49,'2003-09-01');

select* from students;

Create table employees(
EmpID INT Primary key,
Name Varchar(50),
Department varchar(50),
Salary Decimal(10,2),
JoinDate Date);

Insert into employees(EmpID,Name,Department,Salary,Joindate)
values
(1,'John','HR',50000,'2021-06-01'),
(2,'Priya','Finace',60000,'2020-09-15'),
(3,'Amit','IT',75000,'2019-01-10'),
(4,'Sara','IT',72000,'2023-02-25');

select Firstname, Upper(Firstname) as UpperName from students;

select Firstname, datediff(Year,DOB,GetDate()) as age From students;

select name, round(salary,-3)as roundedsalary from employees;
