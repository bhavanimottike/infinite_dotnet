use employ_details
create table books(id int primary key,title varchar(20),author varchar(20) ,isbn bigint unique , published_date datetime)
insert into books values(1,'My first  sql book','Mary Parker',981483029127,'2012-02-22 12:08:17')
insert into books values(2,'My Second SQL book','John Mayer',857300923713,'1972-07-03 09:22:45')
insert into books values(3,'My Third SQL book','Cary Flint',523120967812,'2015-10-18 14:05:44')
select * from books where author like '%[er]'
create table reviews(id int primary key references books(id),book_id int,reviewer_name varchar(20),content varchar(30),rating int,published_date datetime)
insert into reviews values(1,1,'John Smith','My first review',4,'2017-12-10 05:50:11')
insert into reviews values(2,2,'John Smith','My Second review',5,'2017-10-13 15:05:12')
insert into reviews values(3,2,'Alice walker','Another review',1,'2017-10-22 23:47:10')
select b.title, b.author, r.reviewer_name
from books b left join reviews r
on b.id =r.id


select Reviewer_name from Reviews group by Reviewer_name having count(Book_id)>1

create table customer(id int primary key,Name varchar(20) not null,Age int, address varchar(20),salary float)
insert into customer values(1,'RAMESH',32,'AHMEDABAD',2000)
insert into customer values(2,'KHILAN',25,'DELHI',1500.00)
insert into customer values(3,'KAUSHIK',23,'KOTA',2000.00)
insert into customer values(4,'CHAITALI',25,'MUMBAI',6500.00)

insert into customer values(5,'HARDIL',27,'BHOPAL',8500.00)
insert into customer values(6,'KOMAL',22,'MP',4500.00)
insert into customer values(7,'MUFFY',24,'INDORE',10000.00)

select Name from customer where address like '%[o]%'

create table orders(oid int primary key,date datetime, customer_id int,amount int)
insert into orders values(102,'2009-10-08 00:00:00',3,3000)
insert into orders values(100,'2009-10-08 00:00:00',3,1500)
insert into orders values(101,'2009-11-20 00:00:00',2,1560)
insert into orders values(103,'2008-05-20 00:00:00',4,2060)
select * from orders

select date,COUNT(customer_id) count from orders group by date
create table employees(id int primary key,Name varchar(20) not null,Age int, address varchar(20),salary float)
insert into employees values(1,'RAMESH',32,'AHMEDABAD',2000)
insert into employees values(2,'KHILAN',25,'DELHI',1500.00)
insert into employees  values(3,'KAUSHIK',23,'KOTA',2000.00)
insert into employees  values(4,'CHAITALI',25,'MUMBAI',6500.00)

insert into employees  values(5,'HARDIL',27,'BHOPAL',8500.00)
insert into employees values(6,'KOMAL',22,'MP',null)
insert into employees  values(7,'MUFFY',24,'INDORE',null)
select * from employees

select LOWER(Name)  'employe name'  from employees where salary is null
create table student_details(registerno int primary key,name varchar(20),age int ,qualification varchar(10),mno bigint unique,mail varchar(30) unique,location varchar(20),gender char(1))

insert into student_details values(2,'sai',22,'B.E',9952836777,'sai@gmail.com','chennai','M')
insert into student_details values(3,'kumar',20,'bsc',7890125648,'kumar@gmail.com','mudurai','M')
insert into student_details values(4,'selvi',22,'b.tech',8904567342,'selvi@gmail.com','selam','F')
insert into student_details values(5,'nisha',25,'m.e',7834672310,'nisha@gmail.com','theni','F')

insert into student_details values(6,'sairam',21,'b.a',7890345678,'saran@gmail.com','mudurai','F')
insert into student_details values(7,'tom',23,'bca',8901234675,'tom@gmail.com','pune','M')
SELECT * FROM student_details
SELECT GENDER, COUNT(*) AS COUNT FROM student_details GROUP BY gender