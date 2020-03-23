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

CREATE TABLE [dbo].[User] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
    [Username]    VARCHAR (50)  NOT NULL,
    [Password]    VARCHAR (50)  NOT NULL,
    [Type]        VARCHAR (14)  DEFAULT 'PATIENT',
    PRIMARY KEY CLUSTERED ([Id] ASC), 
    CONSTRAINT ckUser check (Type in ('PATIENT', 'DOCTOR', 'LAB_TECHNICIAN', 'PHARMACIST'))
);

