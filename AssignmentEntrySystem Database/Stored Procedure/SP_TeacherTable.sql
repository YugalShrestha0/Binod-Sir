Create Procedure SP_TeacherTable
(
@TeacherID int,
@TeacherName varchar(100),
@Department varchar(100),
@Post varchar(100)
)
as begin
insert into TeacherTable(TeacherID, TeacherName, Department, Post)
values (@TeacherID, @TeacherName, @Department, @Post)
end