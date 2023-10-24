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

