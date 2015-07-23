/*
--Q1
SELECT First_Name, Last_Name, Employee_No FROM Employees WHERE Last_Name LIKE 'M%';

--Q2
SELECT Department_No, Last_Name, First_Name, Phone_Number FROM Employees WHERE Job_ID = 'SA_REP' AND Hire_Date >= '1998-03-24';

--Q3
SELECT * FROM Jobs WHERE Min_Salary <= 4500;

--Q4
SELECT Job_Title FROM Jobs WHERE Job_ID LIKE 'AC%' OR Job_ID LIKE 'MK%';

--Q5
SELECT Department_Name, Location_ID, Last_Name, Annual_Salary from Employees, Departments where Location_ID = 1700 AND Employees.Department_No = Departments.Department_No ORDER BY Department_Name ASC;

--Q6
SELECT Last_Name, First_Name, Hire_Date FROM Employees WHERE MONTH(Hire_Date) = 06 OR MONTH(Hire_Date) = 08;

--Q7
SELECT ROUND(AVG(Annual_Salary),2) AS AverageSalaryTotal FROM Employees;

--Q8
SELECT First_Name, Last_Name, ROUND(Annual_Salary/12,0) FROM Employees WHERE Department_No = '80' OR Department_No = '60';
*/
--Q9
SELECT Employees.Department_No, Departments.Department_Name, COUNT(Employees.Employee_No) FROM Employees, Departments GROUP BY Employees.Department_No;