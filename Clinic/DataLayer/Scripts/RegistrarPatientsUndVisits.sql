create view dbo.registrarVisitView as 
SELECT dbo.Visit.id_visit, dbo.Patient.fname AS patientFname, dbo.Patient.lname AS patientLname, dbo.[User].fname AS doctorFname, dbo.[User].lname AS doctorLname, dbo.Visit.state, dbo.Visit.registration_date, 
dbo.Visit.execution_cancel_datetime
FROM dbo.Doctor INNER JOIN
dbo.Visit ON dbo.Doctor.id_doc = dbo.Visit.id_doctor INNER JOIN
dbo.Patient ON dbo.Visit.id_patient = dbo.Patient.id_patient INNER JOIN
dbo.[User] ON dbo.Doctor.user_name = dbo.[User].user_name

