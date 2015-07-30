--Q1
--SELECT Last_Name, First_Name, Employee_No FROM Employees JOIN Jobs ON Employees.Job_ID = Jobs.Job_ID WHERE Job_Title = 'Programmer' AND Hire_Date <= '1991-5-21' ORDER BY Last_Name ASC;

--Q2
--SELECT Department_No, Last_Name, Annual_Salary FROM Employees WHERE Hire_Date BETWEEN '1987-9-16' AND '1996-5-12' ORDER BY Department_No ASC, Last_Name;

--Q3
--SELECT * FROM Jobs WHERE Max_Salary > 15000 ORDER BY Max_Salary DESC;

--Q4
--SELECT Last_Name, First_Name, Job_ID, Commission_Percent FROM Employees WHERE Commission_Percent IS NOT NULL ORDER BY Last_Name ASC, First_Name ASC;

--Q5
--SELECT DISTINCT Job_Title FROM Jobs JOIN Employees ON Jobs.Job_ID = Employees.Job_ID WHERE Department_No IN (SELECT Employees.Department_No FROM Employees JOIN Departments ON Employees.Department_No = Departments.Department_No WHERE Department_Name = 'Sales' OR Department_Name = 'IT');

--Q6
--SELECT Last_Name, CAST(ROUND(Annual_Salary/12, 2) AS DECIMAL(12,2)) AS Monthly_Salary FROM Employees WHERE Department_No IN (50, 90) ORDER BY Last_Name ASC;

--Q7
--SELECT CAST(ROUND(SUM(Annual_Salary)/12,0) AS DECIMAL(12,2)) AS Total_Monthly_Salary FROM Employees;

--Q8
--SELECT COUNT(*) AS Total_Employee_Number FROM Employees;

--Q9
--SELECT Departments.Department_No, Department_Name, COUNT(Job_ID) AS No_of_Employees FROM Departments JOIN Employees ON Departments.Department_No = Employees.Department_No GROUP BY Departments.Department_No, Department_Name HAVING COUNT(Job_ID) > 2;

--Q10
--SELECT TOP 1 Departments.Department_No, Department_Name, COUNT(*) AS No_of_Employees FROM Departments JOIN Employees ON Departments.Department_No = Employees.Department_No GROUP BY Departments.Department_No, Department_Name ORDER BY COUNT(*) DESC;

--Q11
--SELECT Department_No, Department_Name FROM Departments WHERE Department_No NOT IN (SELECT Employees.Department_No FROM Employees JOIN Jobs ON Employees.Job_ID = Jobs.Job_ID WHERE Job_Title = 'Programmer');

--Q12
/*SELECT * FROM Jobs;
INSERT INTO Jobs (Job_ID, Job_Title, Min_Salary, Max_Salary) VALUES ('IT_ANAL', 'IT Analyst', 10000, 15000);
SELECT * FROM Jobs;*/

--Q13
/*SELECT * FROM Jobs;
UPDATE Jobs SET Max_Salary += 1000;
SELECT * FROM Jobs;*/

--Q14
--SELECT * FROM Jobs ORDER BY Job_ID ASC;

--Q15
/*SELECT * FROM Job_History;
DELETE FROM Job_History WHERE Employee_No = 102;
SELECT * FROM Job_History;*/

--Q16
SELECT Employee_No,
    CASE WHEN Department_No IN (10, 20) THEN CONCAT(5,'%')
		 WHEN Department_No IN (50, 80, 90, 110) THEN CONCAT(10,'%')
		 ELSE CONCAT(0,'%') END AS Raise,
Annual_Salary AS Old_Salary,
Annual_Salary*
   (CASE WHEN Department_No IN (10, 20) THEN 1.05
		 WHEN Department_No IN (50, 80, 90, 110) THEN 1.1
		 ELSE 1 END) AS New_Salary FROM Employees;

