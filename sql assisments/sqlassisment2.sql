use employ_details
select * from employee
select * from Department

declare @bday date = '2002-08-30'
select 
 @bday as birthday,
 DATENAME(weekday,@bday) as dayofweek

 declare  @bday date = '2002-08-30'
 select 
 DATEDIFF(day,@bday,getdate()) as MyAgeInDays

 INSERT INTO employee VALUES(20,'BHAVANI','CLERK',7902,'2019-12-02',400,200,20)
 
 INSERT INTO employee VALUES(300,'JOHN','CLERK',7902,'2019-12-01',800,100,20)


 select * from employee  WHERE   DATEDIFF(year,hiredate,GEtDATE()) = 5 and  Month(hiredate) = MONTH(GETDATE())


 begin transaction
CREATE TABLE EMPLOYEE2(EMPNO INT PRIMARY KEY ,ENAME VARCHAR(20),SAL INT,DOJ DATE)
 INSERT INTO EMPLOYEE2 VALUES(1,'BHAVANI',500,'2012-12-12')
  INSERT INTO EMPLOYEE2 VALUES(3,'SHIVANI',300,'2022-09-22')
   INSERT INTO EMPLOYEE2 VALUES(2,'DEEPTHI',900,'2009-08-28')

   SELECT * FROM EMPLOYEE2

   UPDATE EMPLOYEE2 SET SAL = SAL *0.15 where EMPNO =2
   save tran t1
   delete from EMPLOYEE2 where EMPNO =1

   rollback tran t1

 

 create procedure  Sal_updateSal                   
  as
  begin
    update employee
    set sal=sal+500
	where deptno=(select deptno from department where dname='SALES') and sal<1500
  end
 
  Exec Sal_updateSal 
  select *from employee

  create or alter  Function Cal_bonus
  (
  @deptno int,
  @sal float
  )
  returns decimal(18,2)
  as 
  begin
  declare @Bonus float;
  if  @deptno=10
     set  @bonus=@sal*0.15;
  else if @deptno=20
     set @bonus=@sal*0.20;
  else
       set @bonus=@sal*0.05;
  return @bonus;
  end;
 
 select empno, ename,dbo.Cal_bonus(deptno,sal) as BONUS from employee