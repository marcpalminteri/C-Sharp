/*
--Q1
select * from Jobs order by Max_Salary asc;

--Q2
select First_Name, Last_Name, Job_Title, Annual_Salary from Employees, Jobs where Hire_Date > '1999' and Annual_Salary >= 7000 and Jobs.Job_ID = Employees.Job_ID order by First_Name desc;

--Q3
select * from Jobs order by Job_ID asc;

--Q4 a
--update Jobs set Max_Salary = Max_Salary + 2000;
select * from Jobs;

--Q4 b
--delete from Job_History where Employee_No = 122;
select * from Job_History;

--Q5
--insert into Jobs (Job_ID, Job_Title, Min_Salary, Max_Salary) Values ('AC_ASST', 'Accounting Assistant', 8500, 25000);

--Q6
select First_Name, Last_Name, Employee_No from Employees where (Job_ID = 'SA_REP') AND (Hire_Date >= '1997-12-15') order by Last_Name asc;

--Q8
select Last_Name, First_Name, Job_ID from Employees where Commission_Percent >= 0.25 order by Last_Name asc;

--Q9
select Department_No, Last_Name, Annual_Salary from Employees where Hire_Date between '1998-8-26' and '1999-11-16' order by Last_Name asc;

--Q10
select * from Jobs order by Job_ID desc;

--Q11
select Job_ID, count(Job_ID) as Thing from Employees group by Job_ID;*/
/*
--Q1
SELECT * FROM Employees WHERE First_Name = 'Florence' AND Email = 'FWILKINS'

--Q2
SELECT * FROM Employees WHERE Annual_Salary = 23000 OR Annual_Salary = 14990;

--Q3
SELECT * FROM Employees WHERE Employee_No = 182;

--Q4
SELECT * FROM Employees WHERE Employee_No != 182;

--Q5
SELECT Last_Name, First_Name, Employee_No FROM Employees WHERE Last_Name LIKE 'S%';

--Q6
SELECT Last_Name, First_Name, Employee_No, Hire_Date FROM Employees WHERE Job_ID = 'ST_CLERK' AND Hire_Date <= '1998-08-26' ORDER BY Last_Name ASC;

--Q7
SELECT Department_No, Last_Name, Annual_Salary FROM Employees WHERE Hire_Date BETWEEN '1998-11-15' AND '1999-12-07' ORDER BY Last_Name;

--Q8
SELECT Last_Name, Job_ID, Commission_Percent FROM Employees WHERE Commission_Percent <= 0.15 ORDER BY Commission_Percent DESC;

--Q9
SELECT Job_Title FROM Jobs ORDER BY Max_Salary ASC;

--Q10
SELECT Department_No, Department_Name FROM Departments x WHERE 'SA_REP' NOT IN (SELECT Job_ID FROM Employees y WHERE x.Department_No = y.Department_No);

--Q11
SELECT * FROM Countries ORDER BY Country_ID;

--Q12
SELECT * FROM Jobs;
UPDATE Jobs SET Min_Salary += 500;
SELECT * FROM Jobs;

--Q13
SELECT COUNT(Employee_No) AS PeopleInFinance FROM Employees WHERE Department_No = 80;

--Q14
--INSERT INTO Jobs (Job_ID, Job_Title, Min_Salary, Max_Salary) Values ('SA_CLERK', 'Sales Clerk', 9000, 12000);
SELECT * FROM Jobs;

--Q15
--DELETE FROM Job_History WHERE Employee_No = 104;
SELECT * FROM Job_History ORDER BY Employee_No ASC;

--Q16
CREATE TABLE SAL_HISTORY(Employee_No int NOT NULL PRIMARY KEY, First_Name varchar(20), Last_Name varchar(25), Hire_Date datetime, Annual_Salary decimal(8,2));
*/
--Q17
SELECT ROUND(AVG(Annual_Salary),2) AS TotalAvgSalary From Employees;