create table Records(
AssignmentNo int foreign Key references AssignmentSubmission(AssignmnetNo),
FacultID int foreign Key references Faculty(FacultyID)
);