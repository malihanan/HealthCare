CREATE TABLE [dbo].[User] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
    [Username]    VARCHAR (50)  NOT NULL,
    [Password]    VARCHAR (50)  NOT NULL,
    [Type]        VARCHAR (14)  DEFAULT 'PATIENT',
    PRIMARY KEY CLUSTERED ([Id] ASC), 
    CONSTRAINT ckUser check (Type in ('PATIENT', 'DOCTOR', 'LAB_TECHNICIAN', 'PHARMACIST'))
);

CREATE TABLE [dbo].[Medicine] (
    [Id]   INT           NOT NULL IDENTITY,
    [Name] NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[Case] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
    [DoctorId]    INT           NOT NULL,
    [PatientId]   INT           NOT NULL,
    [OpenDate]    DATE          NOT NULL,
    [ModifyDate]  DATE          NOT NULL,
    [ClosingDate] DATE          NULL,
    [Title]       VARCHAR (50)  NULL,
    [Description] VARCHAR (MAX) NULL,
    [Disease]     NVARCHAR (50) NULL,
    [ClosingSummary] VARCHAR(MAX) NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Case_User] FOREIGN KEY ([PatientId]) REFERENCES [dbo].[User] ([Id])
);

CREATE TABLE [dbo].[Prescription] (
    [Id]         INT           IDENTITY (1, 1) NOT NULL,
    [CaseId]     INT           NOT NULL,
    [MedicineId] INT           NOT NULL,
    [Time]       NVARCHAR (50) NOT NULL,
    [Amount]     INT           NOT NULL,
    [Days]       INT           NOT NULL,
    [Date]       DATETIME      NOT NULL,
    [Bought] BIT NOT NULL DEFAULT 0, 
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Prescription_ToCase] FOREIGN KEY ([CaseId]) REFERENCES [dbo].[Case] ([Id]),
    CONSTRAINT [FK_Prescription_ToMedicine] FOREIGN KEY ([MedicineId]) REFERENCES [dbo].[Medicine] ([Id])
);
