create database railway
use railway

CREATE TABLE Trains (
    TrainNumber INT PRIMARY KEY,
    TrainName NVARCHAR(100),
    Source NVARCHAR(100),
    Destination NVARCHAR(100),
    IsDeleted BIT DEFAULT 0
);

CREATE TABLE Classes (
    ClassID INT IDENTITY(1,1) PRIMARY KEY,
    TrainNumber INT,
    Class NVARCHAR(50),
    AvailableSeats INT,
    PricePerTicket DECIMAL(10, 2),
    FOREIGN KEY (TrainNumber) REFERENCES Trains(TrainNumber)
);

CREATE TABLE Customers (
    CustomerID INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(100),
    Age INT,
    Gender NVARCHAR(10),
    TrainNumber INT,
    Class NVARCHAR(50),
    SeatsBooked INT,
    TotalPrice DECIMAL(10, 2),
    FOREIGN KEY (TrainNumber) REFERENCES Trains(TrainNumber)
);


select * from Trains
select * from Customers
select * from Classes




create or alter proc Get_availableTrains
as
begin
   select * from Trains where IsDeleted =0
   end

create or alter proc GET_CUSTOMERDETAILS(@ticketsNeeded int)
as
begin
     if(@ticketsNeeded <=0)
	 begin
	   print 'enter valid number'
	   return
	   end

	   select top (@ticketsNeeded) * from Customers order by CustomerID desc

   
   end







