create procedure SP_DeleteUser
(
@UserID int
)
as begin
Delete from UserTable where 
UserID = @UserID
end