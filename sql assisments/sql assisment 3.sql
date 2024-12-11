use employ_details

create table course_details(c_id varchar(10),c_name varchar(20),s_date date,e_date date,fee bigint)
insert into course_details values('DN003','DOTNET','2018-02-01','2018-02-28',15000)
insert into course_details values('DV004','DARA VISUALIZATION','2018-03-01','2018-04-15',15000)
insert into course_details values('JA002','ADVANCEDJAVA','2018-01-02','2018-01-20',10000)
insert into course_details values('JC001','COREJAVA','2018-01-02','2018-01-12',3000)

CREATE OR ALTER FUNCTION CAL_COURSEDURATION(@START_DATE DATE,@END_DATE DATE)
RETURNS INT
AS 
BEGIN
RETURN  DATEDIFF(DAY,@START_DATE,@END_DATE)
END

SELECT C_ID,c_name, dbo.CAL_COURSEDURATION(s_date,e_date)  as duration_indays from course_details

create table t_courseinfo(c_name varchar(30),s_date date)

create or alter trigger t_displayonfo
on course_details
for insert
as
begin
insert into t_courseinfo (c_name,s_date)
select c_name,s_date from inserted

end

insert into course_details (c_name,s_date) values('sql','2024-09-15')

select * from t_courseinfo


create table product_table(ProductId int identity, ProductName varchar(30), Price int, DiscountedPrice int)


create or alter proc sp_Producttable(@prod_name varchar(30),@prod_price int,@prod_id int out,@discount_price float out)
as
begin
  set @discount_price=@prod_price*0.10
  declare @p_id int 
   select @p_id=ISNULL(MAX(Productid),0)+1 from Products_table
   insert into Product_table values(@prod_id,@prod_name,@prod_price,@discount_price)
 
end

declare @id int,@discount varchar(20),@pname varchar(20),@price int

Exec sp_Producttable 'laptop', 20000, @id output ,@discount output

select @pname=ProductName,@price=Price from Product_table

print 'PID : '+cast(@id as varchar(10))+'ProductName : ' +cast(@pname as varchar(10))

        +'Price : '+cast(@price as varchar(10))+'Discount : '+cast(@id as varchar(10))
 