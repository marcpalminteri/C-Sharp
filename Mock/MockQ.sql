--Q1 List the last name, first name and employee number of all employees that have a last name starting with M.
--SELECT Last_Name, First_Name, Employee_No FROM Employees WHERE Last_Name LIKE 'M%';

--Q2 List the last name, first name and employee number of all programmers who were hired on or before 11 Feburary 1994 sorted in descending order of last name. *HINT* JOIN Jobs
--SELECT Last_Name, First_Name, Employee_No FROM Employees JOIN Jobs ON Employees.Job_ID = Jobs.Job_ID WHERE Job_Title = 'Programmer' AND Hire_Date <= '1994-02-11' ORDER BY Last_Name DESC; 

--Q3 List all the data for all jobs where the maximum salary is greater than 12000 sorted in ascending order of the maximum salary.
--SELECT * FROM Jobs WHERE Max_Salary > 12000 ORDER BY Max_Salary ASC;

--Q4 List all the data for all jobs where the minimum salary is less than or equal to 4500 sorted in descending order of the minimum salary.
--SELECT * FROM Jobs WHERE Min_Salary <= 4500 ORDER BY Min_Salary DESC;

--Q5 List the department name, location id, last name and salary of employees who work in location 1700 sorted in ascending order of department name. *HINT* JOIN Employees
--SELECT Department_Name, Location_ID, Last_Name, Annual_Salary FROM Departments JOIN Employees ON Departments.Department_No = Employees.Department_No WHERE Departments.Location_ID = 1700 ORDER BY Department_Name ASC;

--Q6 Which jobs are found in the Marketing and Accounting departments?  *HINT* JOIN Employees JOIN Jobs OR 
--SELECT DISTINCT Job_Title FROM Jobs JOIN Employees ON Jobs.Job_ID = Employees.Job_ID WHERE Department_No IN (SELECT Employees.Department_No FROM Employees JOIN Departments ON Employees.Department_No = Departments.Department_No WHERE Department_Name = 'Marketing' OR Department_Name = 'Accounting');

--Q7 Show the total salaries figure for one week displayed with no decimal places.
--SELECT ROUND(SUM(Annual_Salary)/52,0) AS Total_Weekly_Salary FROM Employees;

--Q8 Show the total number of jobs.
--SELECT COUNT(Job_ID) AS Number_of_Jobs FROM Jobs;

--Q9 List the department number, department name and the number of employees for each department that has less than 4 employees grouping by department number and department name. *HINT* JOIN Employees. The HAVING clause was added to SQL because the WHERE keyword could not be used with aggregate functions.
--SELECT Departments.Department_No, Department_Name, COUNT(Job_ID) As No_of_Employees FROM Departments JOIN Employees ON Departments.Department_No = Employees.Department_No GROUP BY Departments.Department_No, Department_Name HAVING COUNT(Job_ID) < 4;

--Q10 List the department number, department name and the number of employees for the department that has the lowest number of employees using appropriate grouping. *HINT* JOIN Employees
SELECT Departments.Department_No, Department_Name, COUNT(Job_ID) FROM Departments JOIN Employees ON Departments.Department_No = Employees.Department_No GROUP BY Departments.Department_No, Department_Name;

--Q11 List the department number and name for all departments where no sales representatives work. *HINT* JOIN Employees JOIN Jobs
--SELECT Department_No, Department_Name FROM Departments WHERE Department_No NOT IN (SELECT Employees.Department_No FROM Employees JOIN Jobs ON Employees.Job_ID = Jobs.Job_ID WHERE Job_Title = 'Sales Representative');

--Q12 Add the following new job IT_ASST, IT Assistant, 5000, 8000
--INSERT INTO Jobs (Job_ID, Job_Title, Min_Salary, Max_Salary) Values ('IT_ASST', 'IT Assistant', 5000, 8000);

--Q13 Update all the maximum salaries for jobs with an increase of 2000
--UPDATE Jobs SET Max_Salary += 2000;

--Q14 List all the data for jobs sorted in descending order of job id.
--SELECT * FROM Jobs ORDER BY Job_ID DESC;

--Q15 a) The job history for employee number 125 is no longer required. Delete this record. b) List all the data for job history sorted in descending order of employee number.
--DELETE FROM Job_History WHERE Employee_No = 125;
--SELECT * FROM Job_History;

--Q16 Create a new view for clerks’s details only using all the fields from the employee table. *HINT* '%CLERK'
--CREATE VIEW ClerkView AS (SELECT * FROM Employees WHERE Job_ID LIKE '%CLERK');

--Q17 Show all the fields and all the clerks using the view for clerks sorted in descending order of employee number.
--SELECT * From ClerkView;

--Q18 Grant the authority to all other users to access the view for clecks for SELECT statements only.
--GRANT SELECT ON ClerkView to PUBLIC;

--Q19 Create an index named LOC_POSTAL_CODE on the Postal Code in the locations table. Provide a printout showing that the index has been created.
CREATE INDEX LOC_POSTAL_CODE ON Locations(Postal_Code);