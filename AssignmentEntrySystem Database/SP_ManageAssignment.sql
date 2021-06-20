Create Procedure SP_ManageAssignment
(
@AssignmentID int,
@Program varchar(100),
@SubjectName varchar(100),
@AssignmentTitle varchar(100),
@ReleaseDate varchar(100),
@SubmittedDate varchar(100),
@mode int
)
as begin
if (@mode = 1)
	insert into AssignmentTable(Program, SUbjectName, AssignmentTitle, ReleaseDate, SubmittedDate)
	values (@Program, @SubjectName, @AssignmentTitle, @ReleaseDate, @SubmittedDate)

if (@mode = 2)
	update AssignmentTable set
	Program = @Program,
	SubjectName = @SubjectName,
	AssignmentTitle = @AssignmentTitle,
	ReleaseDate = @ReleaseDate,
	SubmittedDate = @SubmittedDate
	where
	AssignmentID = @AssignmentID

if (@mode = 3)
	delete from AssignmentTable where
	AssignmentID = @AssignmentID
end