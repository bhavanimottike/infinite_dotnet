use employ_details
select * from employee
--1. Retrieve a list of MANAGERS. 

select ename,empno from employee where empno= any (select mgrid from employee)

-- Find out the names and salaries of all employees earning more than 1000 per month. 
select ename,sal from employee where sal >1000



-- Display the names and salaries of all employees except JAMES. 
select ename,sal from employee where ename != 'james'

--Find out the names of all employees that have ‘A’ anywhere in their name.

select ename from employee where ename like '%[A]%'

-- Find out the details of employees whose names begin with ‘S’.
select * from employee where ename like 's%'

--6. Find out the names of all employees that have ‘L’ as their third character in their name
select * from employee where ename like '__l%'

--7. Compute daily salary of JONES. 
select sal/30 dailysalary from employee where  ename= 'jones'

--8. Calculate the total monthly salary of all employees. 
select sum(sal)  ' totaol monthly salary of all employees' from employee

--9. Print the average annual salary 
select avg(sal*12)  "annual average salary" from employee 

--10. Select the name, job, salary, department number of all employees except  SALESMAN from department number 30. 
select ename,empno,deptno from employee  where empno not in ( SELECT empno FROM employee WHERE JOB = 'SALESMAN' AND deptno= 30)



--11. List unique departments of the EMP table.
select distinct(deptno) from employee


--12. List the name and salary of employees who earn more than 1500 and are in department 10 or 30. Label the columns Employee and Monthly Salary respectively.
select ename,sal from employee where sal>1500 and (deptno=10 or deptno=30)

-- Display the name, job, and salary of all the employees whose job is MANAGER or 
--ANALYST and their salary is not equal to 1000, 3000, or 5000.
select ename,sal ,job,sal from employee where (job= 'manager' or job= 'analyst') and (sal != 1000 AND sal != 3000 AND sal!= 500)

--Display the name, salary and commission for all employees whose commission 
--amount is greater than their salary increased by 10%. 
 select ename,sal,comm  from employee where comm >(sal*1.1)

-- 15. Display the name of all employees who have two Ls in their name and are in 
--department 30 or their manager is 7782
select ename from employee where ename like '%l%l%' and (deptno=30 or mgrid=7782)

--Display the names of employees with experience of over 30 years and under 40 yrs.
-- Count the total number of employees. 
select ename from employee  WHERE    DATEDIFF(year,hiredate,GETDATE()) > 30   AND  DATEDIFF(year,hiredate ,GETDATE())  < 40

select count(ename)  countofemp from employee  WHERE    DATEDIFF(year,hiredate,GETDATE()) > 30   AND  DATEDIFF(year,hiredate ,GETDATE())  < 40




--Retrieve the names of departments in ascending order and their employees in 
--descending order.

select d.dname ,e.ename 
from Department d   left join employee e 
on d.deptno  = e.deptno  
order by d.dname ,e.ename  desc





--. Find out experience of MILLER
select DATEDIFF(year,hiredate,GETDATE()) as experience from employee where ename = 'MILLER'