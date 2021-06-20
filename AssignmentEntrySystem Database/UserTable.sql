create table UserTable(
UserID int identity(1,1) primary key,
FirstName varchar(100) not null,
LastName varchar(100) not null,
UserName varchar(100) not null unique,
Password varchar(100) not null,
Role varchar(100) not null
);