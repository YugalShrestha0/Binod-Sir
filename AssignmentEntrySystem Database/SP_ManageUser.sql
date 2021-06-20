Create Procedure SP_ManageUser
(
@UserID int,
@FisrtName varchar(100),
@LastName varchar(100),
@UserName varchar(100),
@Password varchar(100),
@Role varchar(100),
@mode int
)
as begin
if (@mode=1)
	insert into UserTable (UserId, FirstName, LastName, UserName,Password, Role)
	Values (@UserID, @FisrtName, @LastName, @UserName, @Password, @Role)

if (@mode=2)
	Update UserTable set
	FirstName = @FisrtName,
	LastName = @LastName,
	UserName = @UserName,
	Password = @Password,
	Role = @Role
	where 
	UserID = @UserID

if (@mode=3)
	Delete from UserTable where 
	UserID = @UserID
end