CREATE TABLE [dbo].[Candidate]
(
	[CandidateId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [FirstName] NVARCHAR(50) NOT NULL, 
    [LastName] NVARCHAR(50) NOT NULL, 
    [Address] NVARCHAR(50) NOT NULL, 
    [Language] NVARCHAR(50) NULL, 
    [Gender] NVARCHAR(50) NULL, 
    [ExpectedSalary] INT NOT NULL, 
    [LatestPosition] NVARCHAR(50) NULL, 
    [ExperienceYears] INT NULL
)
