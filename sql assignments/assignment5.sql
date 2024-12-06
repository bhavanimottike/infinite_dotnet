use employ_details
select * from employee
create or alter proc PaySlip(@Emp_Id int)
as
begin
declare @e_name varchar(20),@Sal int
declare @HRA float
declare @DA float
declare @PF float
declare @IT float
declare @Deduction float
declare @Gross_Salary float
declare @Net_Salary float
 
select @e_name=ename,@Sal=Sal from Employee where EmpNo=@Emp_Id
 
set @HRA=@sal*0.10
set @DA=@sal*0.20
set @PF=@sal*0.08
set @IT=@sal*0.05
set @Deduction=@PF+@IT
set @Gross_Salary=@sal+@HRA+@DA
set @Net_Salary=@Gross_Salary-@Deduction
 
print 'Payslip for Employee : ' +@e_name
print 'Basic Salary : '+cast(@Sal as varchar(10))
print 'HRA : ' +cast(@HRA as varchar(10))
print 'DA : ' +cast(@DA as varchar(10))
print 'PF : ' +cast(@PF as varchar(10))
print 'IT : ' +cast(@IT as varchar(10))
print 'Deduction : ' +cast(@Deduction as varchar(10))
print 'Gross salary : ' +cast(@Gross_Salary as varchar(10))
print 'Net salary : ' +cast(@Net_Salary as varchar(10))
end
 
exec PaySlip 7521


create table Holidays
(
holiday_date date,
Holiday_name varchar(30)
)
 
insert into Holidays values('2024-01-26','Republic day'),
('2024-08-15','Independence Day'),('2024-09-05','Teachers day'),('2024-11-14','Childerens day')
insert into Holidays values('2024-12-06','Today is  Holiday')
 
 
select * from Holidays
--trigger
create or alter trigger ResEmployeedata
on Employee
for insert,update,delete
as
begin
  declare @hol_name varchar(20)
  select @hol_name=Holiday_name from Holidays where holiday_date=cast(Getdate() as date)
  if @hol_name is not null
  begin
      raiserror('you can not manipulate the data due to %s',16,1,@hol_name)
	  rollback
   end 
end
select * from Employee
 
--Testing triggers
insert into Employee values(6759,'bhavani','associate development',8896,'2019-10-11',9000,400,40)
 
delete from Employee where EmpNo=8896
 
update Employee set Sal=3000 where EmpNo=8896