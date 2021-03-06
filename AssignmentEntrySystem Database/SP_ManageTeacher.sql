CREATE PROCEDURE SP_MANAGETEACHER
(
@ID int,
@TeacherID int,
@TeacherName varchar(100),
@Department varchar(100),
@Post varchar(100),
@mode int
)
as begin
if (@mode=1)
	insert into TeacherTable(TeacherID, TeacherName, Department, Post)
	values (@TeacherID, @TeacherName, @Department, @Post)

if (@mode=2)
	update TeacherTable set
	TeacherID = @TeacherID,
	TeacherName = @TeacherName,
	Department = @Department,
	Post = @Post
	where
	ID = @ID

if (@mode=3)
	Delete TeacherTable Where
	ID = @ID
end