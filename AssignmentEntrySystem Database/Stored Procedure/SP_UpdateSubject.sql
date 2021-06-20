create procedure SP_UpdateSubject
(
@SubjectID int,
@SubjectName varchar(100),
@SubjectCode varchar(100),
@Credit varchar(100),
@Program varchar(100)
)
as begin
update SubjectTable set
SubjectName = @SubjectName,
SubjectCode = @SubjectCode,
Credit = @Credit,
Program = @Program
where
SubjectId = @SubjectID
end