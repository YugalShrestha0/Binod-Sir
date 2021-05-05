create table AssignmentSubmission(
AssignmentNo int primary key,
StudentID int foreign key references Student(StudentID),
UnitTitle varchar(200),
SubmissionDate datetime,
);