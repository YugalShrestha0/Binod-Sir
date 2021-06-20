create procedure SP_DeleteSubject
(
@SubjectID int
)
as begin
delete from SubjectTable where
SubjectID = @SubjectID
end
