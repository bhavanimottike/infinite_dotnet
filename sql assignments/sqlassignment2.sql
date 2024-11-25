create table Department(deptno int primary key, dname varchar(20) not null, loc varchar(20))
insert into Department values(10,'ACCOUNTING','NEW YORK')
insert into Department values(20,'RESEARCH','DALLAS') 

insert into Department values(30,'SALES','CHICAGO') 
insert into Department values(40,'OPERATIONS','BOSTON')

select * from Department

create table employee(empno int primary key, ename varchar(20) not null, job varchar(20), mgrid int, hiredate date, sal int, comm int, deptno int references Department(deptno)) 

insert into employee values(7369,'SMITH','CLERK',7902,'17-DEC-80',800,null,20)
insert into employee values(7499,'ALLEN','SALESMAN',7698,'20-FEB-81',1600,300,30)
insert into employee values(7521,'WARD','SALESMAN',7698,'22-FEB-81',1250,500,30)
insert into employee values(7566,'JONES','MANAGER',7839,'02-APR-81',2975,null,20)
insert into employee values(7654,'MARTIN','SALESMAN',7698,'28-SEP-81',1250,1400,30)

insert into employee values(7698,'BLAKE','MANAGER',7839,'01-MAY-81',2850,null,30)

insert into employee values(7782,'CLARK','MANAGER',7839,'09-JUN-81',2450,null,10)

insert into employee values(7788,'SCOTT','ANALYST',7566,'19-APR-87',3000,null,20)

insert into employee values(7839,'KING','PRESIDENT',null,'17-NOV-81',5000,null,10)

insert into employee values(7844,'TURNER','SALESMAN',7698,'08-SEP-81',1500,0,30)

insert into employee values(7876,'ADAMS','CLERK',7788,'23-MAY-87',1100,null,20)

insert into employee values(7900,'JAMES','CLERK',7698,'03-DEC-81',950,null,30)

insert into employee values(7902,'FORD','ANALYST',7566,'03-DEC-81',3000,null,20)


insert into employee values(7934,'MILLER','CLERK',7782,'23-JAN-82',1300,null,10)
select * from employee
--employees name start with A 

select * from employee where ename like 'A%'

--all those employees who don't have a manager
select * from employee where mgrid is null

--employee name, number and salary for those employees who earn in the range 1200 to 1400
select  ename,empno,sal  from employee where sal between 1200 and 1400

--the employees in the RESEARCH department a 10% pay rise
select empno,ename,(sal*0.1+sal) '10 % increased salary',dname,employee.deptno
from employee left join Department
on employee.deptno =department.deptno where dname= 'RESEARCH'

--the number of CLERKS employed
select count(job) 'count of clerk job holders'  from employee where job ='CLERK'

--average salary for each job type and the number of people employed in each job
select  AVG(sal) as average_salary ,count(ename) 'no of people for job', job from employee group by job

-- employees with the lowest and highest salary
select ename,empno ,sal 'maximum salary' from employee where sal = (select max(sal) from employee)
select ename,empno ,sal 'minimum salary' from employee where sal = (select min(sal) from employee)

--  List full details of departments that don't have any employees.
select dname,department.deptno,loc
from Department left join employee
on department.deptno=employee.deptno where empno is null

--names and salaries of all the analysts earning more than 1200 who are based in department 20 .Sort the answer by ascending order of name. 
select ename,sal from employee where sal >1200 and deptno=20 and job = 'analyst' order by ename asc

-- For each department, list its name and number together with the total salary paid to employees in that department.
select d.dname,d.deptno, sum(e.sal) 'sum of salary paid to dept'
from Department d left join employee e
on d.deptno=e.deptno group by d.deptno,d.dname

--salary of both MILLER and SMITH.
select sal ,ename from employee where ename = 'MILLER' or ename='SMITH'

--the names of the employees whose name begin with ‘A’ or ‘M’. 
select ename from employee where ename like '[am]%'

--yearly salary of SMITH
select ename,sal*12 'annual salary' from employee where ename ='SMITH'

--the name and salary for all employees whose salary is not in the range of 1500 and 2850
select ename,sal from employee where sal not between 1500 and 2850

-- all managers who have more than 2 employees reporting to them
select  mgrid ,count(*) from employee group by mgrid having COUNT(*) >2