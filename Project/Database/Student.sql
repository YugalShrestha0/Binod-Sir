Create table Student(
StudentID int identity(1,1) primary key,
FirstName varchar(200) not null,
MiddleName varchar(200),
LastName varchar(200) not null,
Major varchar(100),
Credits varchar(50)
);