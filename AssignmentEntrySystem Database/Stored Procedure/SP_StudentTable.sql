create procedure SP_StudentTable
(
@StudentName varchar(100),
@Class varchar(100),
@Contact bigint,
@Email varchar(100),
@Program varchar(100)
)
as begin
insert into StudentTable(StudentName, Class, Contact, Email, Program)
values (@StudentName, @Class, @Contact, @Email, @Program)
end