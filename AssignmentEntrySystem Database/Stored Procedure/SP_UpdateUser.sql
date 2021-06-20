create procedure SP_UpdateUser
(
@UserID int,
@FisrtName varchar(100),
@LastName varchar(100),
@UserName varchar(100),
@Password varchar(100),
@Role varchar(100)
)
as Begin
Update UserTable set
FirstName = @FisrtName,
LastName = @LastName,
UserName = @UserName,
Password = @Password,
Role = @Role
where 
UserID = @UserID
end