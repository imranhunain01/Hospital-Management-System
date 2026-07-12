CREATE DATABASE Hospital_DB;
GO

USE Hospital_DB;
GO

CREATE TABLE Users1 (
    Id INT PRIMARY KEY IDENTITY(1,1),
    FirstName NVARCHAR(50),
    LastName NVARCHAR(50),
    Email NVARCHAR(100) UNIQUE,
    Password NVARCHAR(100)
);

CREATE TABLE patient (
    PatientID INT IDENTITY(1,1) PRIMARY KEY,  -- Auto-increment ID
    FirstName NVARCHAR(50) NOT NULL,
    LastName NVARCHAR(50) NOT NULL,
    Email NVARCHAR(100) NOT NULL UNIQUE,
    Gender NVARCHAR(10) NOT NULL,
    PhoneNumber NVARCHAR(20) NOT NULL,
    Age INT NOT NULL,
    Disease NVARCHAR(100) NOT NULL,
);

IF OBJECT_ID('Doctors', 'U') IS NULL
BEGIN
    CREATE TABLE Doctors (
        DoctorID INT PRIMARY KEY IDENTITY(1,1),
        DoctorName NVARCHAR(100) NOT NULL,
        Specialization NVARCHAR(100) NOT NULL,
        Availability NVARCHAR(50) NOT NULL
    );
END;

-- Insert sample doctors
INSERT INTO Doctors (DoctorName, Specialization, Availability) VALUES
('Dr. Ahmed Khan', 'Cardiologist', 'Mon - Fri, 9:00 AM - 1:00 PM'),
('Dr. Sara Malik', 'Dermatologist', 'Tue - Sat, 10:00 AM - 2:00 PM'),
('Dr. Imran Ali', 'Neurologist', 'Mon - Wed, 12:00 PM - 4:00 PM'),
('Dr. Fatima Noor', 'Pediatrician', 'Mon - Fri, 2:00 PM - 6:00 PM'),
('Dr. Bilal Hussain', 'Orthopedic', 'Thu - Sun, 9:00 AM - 1:00 PM'),
('Dr. Ayesha Khan', 'Gynecologist', 'Mon - Sat, 11:00 AM - 3:00 PM'),
('Dr. Hamza Shah', 'ENT Specialist', 'Tue - Fri, 1:00 PM - 5:00 PM'),
('Dr. Maria Javed', 'Psychiatrist', 'Mon - Thu, 3:00 PM - 7:00 PM'),
('Dr. Usman Raza', 'General Surgeon', 'Sat - Sun, 10:00 AM - 2:00 PM');

CREATE TABLE Appointments
(
    AppointmentID INT IDENTITY(1,1) PRIMARY KEY,
    PatientName NVARCHAR(100) NOT NULL,
    Age INT NOT NULL,
    Disease NVARCHAR(200) NOT NULL,
    DoctorID INT NOT NULL,
    AppointmentTime DATETIME NOT NULL,

    CONSTRAINT FK_Appointments_Doctors FOREIGN KEY (DoctorID) REFERENCES Doctors(DoctorID)
);

select * from Appointments;
SELECT * FROM Users1;
SELECT * FROM Users1 WHERE Email = '123' OR Password = '123';

