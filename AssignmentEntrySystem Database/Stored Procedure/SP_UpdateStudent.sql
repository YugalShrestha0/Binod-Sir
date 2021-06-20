create procedure SP_UpdateStudent
(
@StudentID int,
@StudentName varchar(100),
@Class varchar(100),
@Contact bigint,
@Email varchar(100),
@Program varchar(100)
)
as begin
update StudentTable set
StudentName = @StudentName,
Class  = @Class,
Contact = @Contact,
Email = @Email,
Program = @Program
where
StudentID = @StudentID
end
