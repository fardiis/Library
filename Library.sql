create database Library
go
use library
go 
create table Karbar
(
ID int identity primary key,
Name nvarchar(50),
SurName nvarchar(50),
Username nvarchar(50),
Password nvarchar(50),
Title nvarchar(50),
BookName nvarchar(50)
)
Drop table Karbar

create table BookType
( ID int identity primary key,
Title nvarchar(50),
BookName nvarchar(50),
Quantity nvarchar(50)
)
Drop table BookType
go



create table Admin
(
ID int identity(1,1),
Name nvarchar(50),
SurName nvarchar(50),
Username nvarchar(50),
Password nvarchar(50),
Title nvarchar(50),
BookName nvarchar(50),
Quantity nvarchar(50)
)
Drop table Admin

create table Date
(ID int identity primary key,
EntranceDate datetime  ,
KarbarID int,
BookTypeID int
)
Drop table Date
