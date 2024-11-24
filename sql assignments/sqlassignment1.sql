create database client_project
use client_project
create table Clients(
client_id int primary key,
cname varchar(40) not null,
Address varchar(30),
Email varchar(30) unique,
phone bigint,
bussiness varchar(20) not null )
insert into Clients(client_id,cname,Address,Email,phone,bussiness)values(1001,'ACME Utilities','Noida','contact@acmeutil.com',9567880032,'manufacturing')
insert into Clients(client_id,cname,Address,Email,phone,bussiness)values(1002,'Tractorconsultsant','mumbai','consult@trackon.com',8734210090,'consultant')
insert into Clients(client_id,cname,Address,Email,phone,bussiness)values(1003,'MoneySaver Distributors','kolkata','save@moneysaver.com',7799886655,'Reseller')
insert into Clients(client_id,cname,Address,Email,phone,bussiness)values(1004,'Lawful crop','chennai','justice@lawful.com',9210342219,'Professional')
create table Department( deptno int primary key, Dname varchar(15) not null, Loc varchar(20))
insert into Department(deptno,Dname,Loc)VALUES(10,'DESIGN','PUNE')
insert into Department(deptno,Dname,Loc)VALUES(20,'DEVELOPMENT','PUNE')
insert into Department(deptno,Dname,Loc)VALUES(30,'TESTING','MUMBAI')
insert into Department(deptno,Dname,Loc)VALUES(40,'DOCUMENT','MUMBAI')
create table Employees(Empno int primary key ,Ename varchar(20) not null,Job varchar(15),Salary bigint CHECK(SALARY >0),Deptno int references Department(deptno))
insert into Employees(Empno,Ename,Job,Salary,Deptno)values(7001,'Sandeep','Analyst',25000,10)
insert into Employees(Empno,Ename,Job,Salary,Deptno)values(7002,'Rajesh','Designer',30000,10)
insert into Employees(Empno,Ename,Job,Salary,Deptno)values(7003,'Madhav','Developer',40000,20)
insert into Employees(Empno,Ename,Job,Salary,Deptno)values(7004,'Manoj','Developer',40000,20)
insert into Employees(Empno,Ename,Job,Salary,Deptno)values(7005,'Abhay','Designer',35000,10)
insert into Employees(Empno,Ename,Job,Salary,Deptno)values(7006,'Uma','Tester',30000,30)
insert into Employees(Empno,Ename,Job,Salary,Deptno)values(7007,'Gita','Tech,writer',30000,40)
insert into Employees(Empno,Ename,Job,Salary,Deptno)values(7008,'Priya','Tester',35000,30)
insert into Employees(Empno,Ename,Job,Salary,Deptno)values(7009,'Nutan','Developer',45000,20)
insert into Employees(Empno,Ename,Job,Salary,Deptno)values(7010,'Smita','Analyst',20000,10)
insert into Employees(Empno,Ename,Job,Salary,Deptno)values(7011,'Anand','Project mgr',65000,10)
EXEC sp_help 'Employees'
create table Projects(Project_id int primary key,Descr varchar(30) not null,Start_date date ,planned_end_date date,actual_end_date date,Budget int check(Budget >0),Client_id int references Clients(client_id) )
alter table projects
add constraint a check(actual_end_date >planned_end_date)
insert into Projects (Project_id,Descr,Start_date,planned_end_date,actual_end_date,Budget, Client_id)values(401,'inventory','01-Apr-11','01-Oct-11','31-Oct-11',150000,1001)
insert into Projects (Project_id,Descr,Start_date,planned_end_date,actual_end_date,Budget, Client_id)values(402,'Accounting','01-Aug-11','01-jan-11','NULL',150000,1001)
insert into Projects (Project_id,Descr,Start_date,planned_end_date,actual_end_date,Budget, Client_id)values(403,'Payroll','01-jun-11','31-Dec-11','NULL',150000,1001)
insert into Projects (Project_id,Descr,Start_date,planned_end_date,actual_end_date,Budget,Client_id)values(404,'Contact mgmt','01-Nov-11','31-Dec-11','NULL',150000,1001)

select * from Projects
update Projects set Budget=500000, Client_id=1002 where Project_id=402
update Projects set Budget=75000, Client_id=1002 where Project_id=403
update Projects set Budget=500000, Client_id=1002 where Project_id=404
create table EmpProjectTask(Project_id int references projects(project_id), Empno int references Employees(Empno),start_date date,End_date date,Task varchar(25) not null,status varchar(15) not null,constraint composite_key primary key(project_id,Empno))
insert into EmpProjectTask(Project_id,Empno,start_date,End_date,Task,status)values(401,7001,'01-Apr-11','20-Apr-11','System Analysis','Completed')
insert into EmpProjectTask(Project_id,Empno,start_date,End_date,Task,status)values(401,7002,'21-Apr-11','30-May-11','System Design','Completed')
insert into EmpProjectTask(Project_id,Empno,start_date,End_date,Task,status)values(401,7003,'01-jun-11','20-jul-11','Coding','Completed')
insert into EmpProjectTask(Project_id,Empno,start_date,End_date,Task,status)values(401,7004,'01-jul-11','20-sep-11','Coding','Completed')
insert into EmpProjectTask(Project_id,Empno,start_date,End_date,Task,status)values(401,7006,'01-sep-11','20-Sep-11','Testing','Completed')
insert into EmpProjectTask(Project_id,Empno,start_date,End_date,Task,status)values(401,7009,'01-sep-11','20-oct-11','code change','Completed')
insert into EmpProjectTask(Project_id,Empno,start_date,End_date,Task,status)values(401,7008,'01-oct-11','20-Oct-11','Testing','Completed')
insert into EmpProjectTask(Project_id,Empno,start_date,End_date,Task,status)values(401,7007,'01-oct-11','20-Oct-11','Documentation','Completed')
insert into EmpProjectTask(Project_id,Empno,start_date,End_date,Task,status)values(401,7011,'01-oct-11','20-Oct-11','Sign off ','Completed')
insert into EmpProjectTask(Project_id,Empno,start_date,End_date,Task,status)values(402,7010,'01-Aug-11','20-Aug-11','System Analysis','Completed')
insert into EmpProjectTask(Project_id,Empno,start_date,End_date,Task,status)values(402,7002,'01-Aug-11','20-sep-11','System Design','Completed')
insert into EmpProjectTask(Project_id,Empno,start_date,End_date,Task,status)values(402,7004,'01-oct-11',null,'Coding','IN progress')
select* from EmpProjectTask