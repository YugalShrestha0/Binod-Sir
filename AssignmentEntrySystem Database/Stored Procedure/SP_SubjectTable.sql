create procedure SP_SubjectTable
(
@SubjectName varchar(100),
@SubjectCode varchar(100),
@Credit varchar(100),
@Program varchar(100)
)
as begin
insert into SubjectTable (SubjectName, SubjectCode, Credit, Program)
values (@SubjectName, @SubjectCode, @Credit, @Program)
end