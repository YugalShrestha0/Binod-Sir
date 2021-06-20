create table TeacherTable(
ID int identity(1,1) primary key,
TeacherID int not null,
TeacherName varchar(100) not null,
Department varchar(100) not null,
Post varchar(100) not null
);