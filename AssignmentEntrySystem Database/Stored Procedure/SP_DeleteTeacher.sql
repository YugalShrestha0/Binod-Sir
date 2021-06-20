create Procedure SP_DeleteTeacher
(
@TeacherID int
)
as begin
Delete TeacherTable Where
TeacherID = @TeacherID
end