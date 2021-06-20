Create Procedure SP_ProgarmTable
(
@ProgramName varchar(200),
@ProgramCode varchar(100),
@Duration varchar(100),
@Description varchar(400)
)
as begin
insert into ProgramTable(ProgramName, ProgramCode, Duration, Description)
values(@ProgramName, @ProgramCode, @Duration, @Description)
end