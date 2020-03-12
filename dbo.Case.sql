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
    PRIMARY KEY CLUSTERED ([Id] ASC), 
    CONSTRAINT [FK_Case_User] FOREIGN KEY ([PatientId]) REFERENCES [User]([Id])
);

