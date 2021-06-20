Create Procedure SP_UserTable
(
@FisrtName varchar(100),
@LastName varchar(100),
@UserName varchar(100),
@Password varchar(100),
@Role varchar(100)
)
as begin
insert into UserTable (FirstName, LastName, UserName,Password, Role)
Values (@FisrtName, @LastName, @UserName, @Password, @Role)
end