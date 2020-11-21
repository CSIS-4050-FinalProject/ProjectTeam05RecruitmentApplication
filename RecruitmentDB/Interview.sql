CREATE TABLE [dbo].[Interview]
(
	[InterviewId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [RecruiterName] NVARCHAR(50) NOT NULL, 
    [InterviewRound] INT NULL, 
    [ApplicationId] INT NOT NULL, 
    [Medium] NVARCHAR(50) NULL,
    [Score] INT NULL, 
    CONSTRAINT [FK_Interview_Application] FOREIGN KEY ([ApplicationId]) REFERENCES [Application] ([ApplicationId]),
)
