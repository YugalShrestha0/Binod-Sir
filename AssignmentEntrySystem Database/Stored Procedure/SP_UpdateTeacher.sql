create procedure SP_UpdateTeacher
(
@TeacherID int,
@TeacherName varchar(100),
@Department varchar(100),
@Post varchar(100)
)
as begin 
update TeacherTable set
TeacherName = @TeacherName,
Department = @Department,
Post = @Post
where
TeacherID = @TeacherID
end