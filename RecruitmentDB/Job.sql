CREATE TABLE [dbo].[Job]
(
	[JobId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [PerkId] INT NULL, 
    [CompanyId] INT NOT NULL, 
    [RoundsRequired] INT NULL , 
    [Description] NVARCHAR(50) NOT NULL, 
    [Salary] INT NOT NULL, 
    CONSTRAINT [FK_Job_Perk] FOREIGN KEY ([PerkId]) REFERENCES [Perk] ([PerkId]),
    CONSTRAINT [FK_Job_Company] FOREIGN KEY ([CompanyId]) REFERENCES [Company] ([CompanyId]),

)
