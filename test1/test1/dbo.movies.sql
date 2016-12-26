CREATE TABLE [dbo].[movies] (
    [Id]       INT           IDENTITY (1, 1) NOT NULL,
    [Name]     NVARCHAR (50) NOT NULL,
    [Rating]   FLOAT         NOT NULL, 
	[Year]     INT           NOT NULL,
    [Genre]    NVARCHAR (50) NOT NULL,
    [Director] NVARCHAR (50) NOT NULL,
    [Picture]  IMAGE         NULL,
    
    PRIMARY KEY CLUSTERED ([Id])
);

