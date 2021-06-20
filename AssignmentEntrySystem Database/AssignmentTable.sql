create table AssignmentTable(
AssignmentID int identity(1,1) primary key,
Program varchar(100) not null,
SubjectName varchar(100) not null,
AssignmentTitle varchar(100) not null,
ReleaseDate varchar(100) not null,
SubmittedDate varchar(100) not null
);