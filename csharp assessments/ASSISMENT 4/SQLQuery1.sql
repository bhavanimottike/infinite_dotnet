use employ_details
select * from employee
declare @sal float
declare @name varchar(30)
select @name=ename, @sal=sal from employee  where empno =7386-- 5100

if(@sal <=)
 begin
   set @sal = @sal+100
   print 'the revised salary is ' + cast(@sal as varchar(5))
 end
 else
  begin
    print 'Salary is Ok'
  end
  

  with cte(n,wkday)
  as (select 0,DATENAME(dw,0)
  union all
  select n+1,DATENAME(dw,n+1) from cte where n<6)
  select n,wkday from cte
  select DATENAME(dw,getdate())
  


with cte_week(n,wkday)
as(select 0,DATENAME(dw,0)
union all
select n + 1, datename(dw,n+1) from cte_week where n < 6)

select n,wkday from cte_week
select datename(dw,getdate())


with ourcte(empno,ename,MGR,EmpLevel)
as(select empno,ename,mgrid, 1 EmpLevel          -- initial subquery
    from employee where mgrid is null
union all
select e.empno,e.ename,e.mgrid,oc.emplevel + 1   -- recursive
from employee e inner join ourcte oc on e.mgrid=oc.empno
where e.mgrid is not null)

select * from ourcte
order by EmpLevel


create or alter proc  increase_sal(@empid int)
as 
begin
select ename,sal+100 from employee where sal<1250 and empno=@empid
end



create or alter proc  increase_sal(@empid int)
as 
begin
select ename,sal+100 from employee where sal<1250 and empno= @empid
end

increase_sal  7369


create  or alter  proc inc_sal @empid int
as
begin 
declare @employname varchar(20)
declare @salary int
     select @employname = ename,@salary= sal from employee where @empid=empno
	 if(@salary< 1500)
	 begin
	 print @salary+100 
	 end
end

inc_sal  7369