use employ_details


declare @inputno int = 4
declare @fact int =1
while @inputno >= 1
begin
set @fact = @fact * @inputno
set @inputno = @inputno - 1
end
print  'the factorial is ' + cast(@fact as varchar(5))

--2.	Create a stored procedure to generate multiplication table that accepts a number and generates up to a given number.

create or alter proc  sp_table(@inputnum int)
as
begin
declare @no int =1
declare @res int
while(@no <=10) 
begin
set @res = @inputnum * @no
print cast(@inputnum as varchar(6)) +'*'+ cast(@no as varchar(3)) + '=' +  cast(@res as varchar(7))
set @no =@no +1
end
end

sp_table 5

--Create a function to calculate the status of the student. If student score >=50 then pass, else fail. Display the data neatly

create table student_table(sid int identity, sname varchar(20))

insert into student_table values('Jack')

insert into student_table values('Rithvik')
insert into student_table values('Jaspreeth')
insert into student_table values(' Praveen')
insert into student_table values('Bisa')
insert into student_table values('Suraj')
select * from student_table

create table marks_table(Mid  int, Sid int,Score int)

insert into marks_table values(1,1,23)
insert into marks_table values(2,6,95)
insert into marks_table values(3,4,98)
insert into marks_table values(4,2,17)
insert into marks_table values(5,3,53)
insert into marks_table values(6,5,13)
select * from marks_table

create or alter function  fn_status(@score int)
returns varchar(15)
as
begin
declare @status varchar(15)
if @score > = 50
begin
  set @status ='pass'
 end
 else
 begin
  set @status = 'fail'
 end
 return @status
 end

 
 
 select s.sid,mid,m.Score ,dbo.fn_status(m.Score) as 'result' from student_table s inner join marks_table m on s.sid = m.Sid order by s.sid

 
