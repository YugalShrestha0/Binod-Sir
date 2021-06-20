create table StudentTable(
StudentID int identity(1,1) primary key,
StudentName varchar(100) not null,
Class varchar(100) not null,
Address varchar(150),
Contact bigint not null,
Email varchar(100),
Program varchar(100) not null
);