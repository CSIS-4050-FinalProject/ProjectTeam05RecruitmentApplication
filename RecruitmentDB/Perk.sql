CREATE TABLE [dbo].[Perk]
(
	[PerkId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Description] NVARCHAR(50) NOT NULL, 
    [Amount] INT NULL, 
    [AvailableAfterMonth] INT NULL
)
