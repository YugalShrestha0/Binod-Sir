create table UserTable
(
UserID int identity(1,1),
UserName varchar(100) not null unique,
Paasword varchar(100) not null unique,
Role varchar(20) not null
);