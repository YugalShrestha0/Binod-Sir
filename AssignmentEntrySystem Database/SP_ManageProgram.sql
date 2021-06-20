Create Procedure SP_ManageProgram
(
@ProgramID int,
@ProgramName varchar(200),
@ProgramCode varchar(100),
@Duration varchar(100),
@Description varchar(400),
@mode int
)
as begin
if (@mode=1)
   Insert into ProgramTable(ProgramName, ProgramCode, Duration, Description)
   Values (@ProgramName, @ProgramCode, @Duration, @Description)

if (@mode=2)
   Update ProgramTable set
   ProgramName=@ProgramName,
   ProgramCode=@ProgramCode,
   Duration=@Duration,
   Description=@Description
   where
   ProgamId=@ProgramID

if (@mode=3)
   Delete from ProgramTable where 
   ProgamId=@ProgramID
end