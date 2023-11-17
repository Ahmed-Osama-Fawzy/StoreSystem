create database StoreSystem

use StoreSystem

create table Users(
	ID int identity(1,1),
	Username nvarchar(20) not null,
	Password varchar(25) not null,
	AccountType nvarchar(10) not null,
	Primary Key(ID),
	Unique(Username), 
	Unique(Password)
)

create table Category(
	ID int identity (1,1),
	Name nvarchar(15) not null,
	PorductsAmount int ,
	CreaterID int ,
	CreatedDate Date DEFAULT GETDATE(),
	primary key(ID),
	unique(Name),
	foreign key(CreaterID) 
	references Users(ID)
)

create table Supplier(
	ID int identity(1,1),
	Name nvarchar(30) not null,
	Address nvarchar(25) not null,
	Mobile nvarchar(15) not null,
	Email nvarchar(20) null,
	CreaterID int ,
	CreatedDate Date default getdate(),
	InMoney decimal ,
	OutMoney decimal ,
	NetMoney decimal ,
	primary key(ID),
	foreign key(CreaterID) 
	references Users(ID),
	unique(Name)
)

delete from Users

alter table Users
add InsertedDate Date default GETDATE()


alter table Users
alter column UserID int not null

alter  table Users
add constraint FK_USERID foreign key (UserID) references Users (ID)

insert into Users(Username,Password,AccountType,UserID) values('Zain','234567',N'مالك',1)

alter table Supplier
alter column InMoney float not null

alter table Supplier
alter column OutMoney float not null

alter table Supplier
alter column NetMoney float not null 

alter table Supplier
add City nvarchar(20) null

alter table Supplier
add AccountType nvarchar(20) not null 



create table Customer(
	ID int identity(1,1),
	Name nvarchar(30) not null,
	Address nvarchar(25) not null,
	Mobile nvarchar(15) not null,
	Email nvarchar(20) null,
	City nvarchar(20) null,
	AccountType nvarchar(20) not null,
	UserID int ,
	Date Date default getdate(),
	InMoney float ,
	OutMoney float ,
	NetMoney float ,
	primary key(ID),
	foreign key(UserID) 
	references Users(ID)
)


create table SupplierBill(
	ID int identity(1,1),
	UserID int not null,
	Date Date default GETDATE(),
	ProductsNumber int not null default 0,
	FullPrice float not null default 0.0,
	InPrice float not null default 0.0,
	NetPrice float not null default 0.0,
	primary key(ID),
	foreign key(UserID) references Users(ID)
)
create table Product(
	ID int identity(1,1),
	BillID int not null,
	Category nvarchar(15) not null,
	Description nvarchar(50) not null,
	Amount float not null,
	MainPrice float not null, 
	OneProfit float not null,
	ManyProfit float not null,
	Unit nvarchar(15) not null,
	primary key (ID),
	foreign key (BillID) references SupplierBill(ID),
	foreign key (Category) references Category(Name)
)
alter table SupplierBill
add SupplierID int foreign key references Supplier(ID)


alter table Product
add CategoryID int foreign key references Category(ID)

create table Bill(
	ID int identity(1,1),
	UserID int not null,
	Date Date default GETDATE(),
	ProductsNumber int not null default 0,
	FullPrice float not null default 0,
	InMoney float not null default 0,
	NetMoney float not null default 0
	primary key(ID),
	foreign key (UserID) references Users(ID) 
)

create table CustomerBill(
	BillID int not null,
	CustomerID int not null,
	ProductID int not null,
	Amount float not null,
	Price float not null,
	foreign key (BillID) references Bill(ID),
	foreign key (CustomerID) references Customer(ID),
	foreign key (ProductID) references Product(ID)
)

create table SupplierBill(
	BillID int not null,
	SupplierID int not null,
	ProductID int not null,
	Amount float not null,
	Price float not null,
	foreign key (BillID) references Bill(ID),
	foreign key (SupplierID) references Supplier(ID),
	foreign key (ProductID) references Product(ID)
)
delete from Bill
delete from SupplierBill
delete from Product
select * from Bill
select * from SupplierBill
select * from Product
select * from Category

SELECT TOP 1 ID FROM Bill order by ID DESC;

select * from Customer;
select * from Supplier;
select * from Users;
select * from Category;
select * from CustomerBill;
select * from SupplierBill;
select * from Product;
select * from Bill;




