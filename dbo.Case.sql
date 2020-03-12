CREATE TABLE [dbo].[Case]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [DoctorId] INT NOT NULL, 
    [PatientId] INT NOT NULL, 
    [OpenDate] DATE NOT NULL, 
    [ModifyDate] DATE NOT NULL, 
    [ClosingDate] DATE NULL, 
    [Title] VARCHAR(50) NULL, 
    [Description] VARCHAR(MAX) NULL, 
    [Disease] NVARCHAR(50) NULL
)

