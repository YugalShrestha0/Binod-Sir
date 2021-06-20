Create Procedure SP_ManageSubject
(
@SubjectID int,
@SubjectName varchar(100),
@SubjectCode varchar(100),
@Credit varchar(100),
@Program varchar(100),
@mode int
)
as begin
if (@mode=1)
	insert into SubjectTable (SubjectName, SubjectCode, Credit, Program)
	values (@SubjectName, @SubjectCode, @Credit, @Program)

if (@mode=2)
	update SubjectTable set
	SubjectName = @SubjectName,
	SubjectCode = @SubjectCode,
	Credit = @Credit,
	Program = @Program
	where
	SubjectId = @SubjectID

if (@mode=3)
	delete from SubjectTable where
	SubjectID = @SubjectID
end