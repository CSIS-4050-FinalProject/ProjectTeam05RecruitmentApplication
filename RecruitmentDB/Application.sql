CREATE TABLE [dbo].[Application]
(
	[ApplicationId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [JobId] INT NOT NULL, 
    [CandidateId] INT NOT NULL, 
    [SubmissionDate] DATE NULL, 
    [EmployeeReferral] NVARCHAR(50) NOT NULL, 
    [ProcessDuration] INT NOT NULL, 
    [Status] NVARCHAR(50) NOT NULL, 
    [StatusDate] DATE NOT NULL,
    CONSTRAINT [FK_Application_Job] FOREIGN KEY ([JobId]) REFERENCES [Job] ([JobId]),
    CONSTRAINT [FK_Application_Candidate] FOREIGN KEY ([CandidateId]) REFERENCES [Candidate] ([CandidateId]),
)
