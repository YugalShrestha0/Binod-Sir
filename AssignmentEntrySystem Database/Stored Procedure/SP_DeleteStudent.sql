create procedure SP_DeleteStudent
(
@StudentID int
)
as begin
delete from StudentTable where
StudentID = @StudentID
end
