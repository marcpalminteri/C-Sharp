/*
select * from Jobs where Max_Salary > 30000 order by Max_Salary desc;

select First_Name, Last_Name, Email, Department_Name, Location_ID from Employees, Departments where Employees.Department_No = Departments.Department_No;
select Phone_Number, Job_ID from Employees where Annual_Salary > 20000;

--Q1
select * from Jobs order by Max_Salary asc;

--Q2
select First_Name, Last_Name, Job_Title, Annual_Salary from Employees, Jobs where Hire_Date > '1999' and Annual_Salary >= 7000 and Jobs.Job_ID = Employees.Job_ID order by First_Name desc;

--Q3
select * from Jobs order by Job_ID asc;

--Q4 a
update Jobs set Max_Salary = Max_Salary + 2000;

--Q4 b
delete from Job_History where Employee_No = 122;
select * from Job_History;

--Q5
insert into Jobs (Job_ID, Job_Title, Min_Salary, Max_Salary) Values ('AC_ASST', 'Accounting Assistant', 8500, 25000);

--Q6
select First_Name, Last_Name, Employee_No from Employees where (Job_ID = 'SA_REP') AND (Hire_Date >= '1997-12-15') order by Last_Name asc;

--Q8
select Last_Name, First_Name, Job_ID from Employees where Commission_Percent >= 0.25 order by Last_Name asc;

--Q9
select Department_No, Last_Name, Annual_Salary from Employees where Hire_Date between '1998-8-26' and '1999-11-16' order by Last_Name asc;

--Q10
select * from Jobs order by Job_ID desc;
*/
--Q11
select Job_ID, count(Job_ID) as Thing from Employees group by Job_ID;