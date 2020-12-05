CREATE TABLE [dbo].[Job]
(
	[JobId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [CompanyId] INT NOT NULL, 
    [RoundsRequired] INT NULL , 
    [Description] NVARCHAR(50) NOT NULL, 
    [Salary] INT NOT NULL, 
     [Active] INT NOT NULL, 
    CONSTRAINT [FK_Job_Company] FOREIGN KEY ([CompanyId]) REFERENCES [Company] ([CompanyId]),

)
