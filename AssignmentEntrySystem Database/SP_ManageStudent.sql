CREATE PROCEDURE SP_ManageStudent
(
@studentID int,
@StudentName varchar(100),
@Class varchar(100),
@Address varchar(150),
@Contact bigint,
@Email varchar(100),
@Program varchar(100),
@mode int
)
as begin
if (@mode=1)
	insert into StudentTable(StudentName, Class, Address, Contact, Email, Program)
	values (@StudentName, @Class, @Address, @Contact, @Email, @Program)

if (@mode=2)
	update StudentTable set
	StudentName = @StudentName,
	Class  = @Class,
	Contact = @Contact,
	Email = @Email,
	Program = @Program
	where
	StudentID = @StudentID

if (@mode=3)
	delete from StudentTable where
	StudentID = @StudentID
end