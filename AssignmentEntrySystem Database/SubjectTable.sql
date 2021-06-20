create table SubjectTable(
SubjectID int identity(1,1) primary key,
SubjectName varchar(100) not null,
SubjectCode varchar(100) not null,
Credit varchar(100) not null,
Program varchar(100) not null
);