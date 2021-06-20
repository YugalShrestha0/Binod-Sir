create procedure SP_AssignmentTable
(
@Program varchar(100),
@SubjectName varchar(100),
@AssignmentTitle varchar(100),
@ReleaseDate datetime,
@SubmittedDate datetime
)
as begin
insert into AssignmentTable (Program, SubjectName, AssignmentTitle, ReleaseDate, SubmittedDate)
values (@Program, @SubjectName, @AssignmentTitle, @ReleaseDate, @SubmittedDate)
end