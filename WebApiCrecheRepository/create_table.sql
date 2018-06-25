CREATE TABLE [dbo].[Creche] (
    [Id]					INT           IDENTITY (1, 1) NOT NULL,
    [ChildName]             NVARCHAR (60) NOT NULL,
    [ChildAddress]          NVARCHAR (max) NOT NULL,
    [GuardianName]			NVARCHAR (60) NOT NULL,
    [TelNumber]             NVARCHAR (30) NOT NULL,
	[MobileNumber]             NVARCHAR (30) NOT NULL,
    [EmergencyNumber]       NVARCHAR (30) NOT NULL,
	[Email]					NVARCHAR (max) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
         );
