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
