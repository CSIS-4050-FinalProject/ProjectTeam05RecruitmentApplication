/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

-- 10 Perks

SET IDENTITY_INSERT [dbo].[Perk] ON
insert into Perk (PerkId, Description, Amount, AvailableAfterMonth) values (1, 'Paid day off', 703, 3);
insert into Perk (PerkId, Description, Amount, AvailableAfterMonth) values (2, 'Performance bonus', 1046, 4);
insert into Perk (PerkId, Description, Amount, AvailableAfterMonth) values (3, 'Retirement plan', 795, 3);
insert into Perk (PerkId, Description, Amount, AvailableAfterMonth) values (4, 'Medical insurance', 919, 1);
insert into Perk (PerkId, Description, Amount, AvailableAfterMonth) values (5, 'Gym membership', 1539, 1);
insert into Perk (PerkId, Description, Amount, AvailableAfterMonth) values (6, 'Free development programs and courses', 811, 3);
insert into Perk (PerkId, Description, Amount, AvailableAfterMonth) values (7, 'Tuition coverage of reimbursement', 1967, 3);
insert into Perk (PerkId, Description, Amount, AvailableAfterMonth) values (8, 'Commuter assistance', 423, 4);
insert into Perk (PerkId, Description, Amount, AvailableAfterMonth) values (9, 'Childcare assistance', 1590, 1);
insert into Perk (PerkId, Description, Amount, AvailableAfterMonth) values (10, 'Employee discount', 1102, 1);
SET IDENTITY_INSERT [dbo].[Perk] OFF

-- 20 Companies
SET IDENTITY_INSERT [dbo].[Company] ON
insert into Company (CompanyId, Name, HiringDepartment, HiringManager, Size) values (1, 'Edgetag', 'Research and Development', 'Rosalia MacHostie', 'large');
insert into Company (CompanyId, Name, HiringDepartment, HiringManager, Size) values (2, 'Eire', 'Marketing', 'Rubetta Shobbrook', 'medium-sized');
insert into Company (CompanyId, Name, HiringDepartment, HiringManager, Size) values (3, 'Gabtune', 'Support', 'Claudia Baison', 'micro');
insert into Company (CompanyId, Name, HiringDepartment, HiringManager, Size) values (4, 'Gevee', 'Legal', 'Bentley Pinchback', 'medium-sized');
insert into Company (CompanyId, Name, HiringDepartment, HiringManager, Size) values (5, 'Ntag', 'Human Resources', 'Lucilia Ashbey', 'large');
insert into Company (CompanyId, Name, HiringDepartment, HiringManager, Size) values (6, 'Dabjam', 'Product Management', 'Maxine Simonitto', 'large');
insert into Company (CompanyId, Name, HiringDepartment, HiringManager, Size) values (7, 'Wordpedia', 'Legal', 'Pansie O''Kuddyhy', 'large');
insert into Company (CompanyId, Name, HiringDepartment, HiringManager, Size) values (8, 'Dynabox', 'Support', 'Valene Stopps', 'medium-sized');
insert into Company (CompanyId, Name, HiringDepartment, HiringManager, Size) values (9, 'Blognation', 'Sales', 'Leora Macvey', 'large');
insert into Company (CompanyId, Name, HiringDepartment, HiringManager, Size) values (10, 'Skiba', 'Business Development', 'Renard MacArdle', 'large');
insert into Company (CompanyId, Name, HiringDepartment, HiringManager, Size) values (11, 'Quamba', 'Product Management', 'Myrah Whatley', 'large');
insert into Company (CompanyId, Name, HiringDepartment, HiringManager, Size) values (12, 'Cogidoo', 'Services', 'Haslett Caig', 'medium-sized');
insert into Company (CompanyId, Name, HiringDepartment, HiringManager, Size) values (13, 'Trudeo', 'Human Resources', 'Valenka Aizkovitch', 'medium-sized');
insert into Company (CompanyId, Name, HiringDepartment, HiringManager, Size) values (14, 'Divanoodle', 'Research and Development', 'Kizzie Jacqueme', 'large');
insert into Company (CompanyId, Name, HiringDepartment, HiringManager, Size) values (15, 'Yacero', 'Training', 'Daisi Skeldinge', 'medium-sized');
insert into Company (CompanyId, Name, HiringDepartment, HiringManager, Size) values (16, 'Leexo', 'Human Resources', 'Vivyan Glavis', 'large');
insert into Company (CompanyId, Name, HiringDepartment, HiringManager, Size) values (17, 'Ainyx', 'Accounting', 'Aloysius Heggie', 'micro');
insert into Company (CompanyId, Name, HiringDepartment, HiringManager, Size) values (18, 'Blognation', 'Services', 'Marrissa Noquet', 'small');
insert into Company (CompanyId, Name, HiringDepartment, HiringManager, Size) values (19, 'Eayo', 'Product Management', 'Hastie Pechet', 'micro');
insert into Company (CompanyId, Name, HiringDepartment, HiringManager, Size) values (20, 'Mybuzz', 'Product Management', 'Gianni Ropartz', 'small');
SET IDENTITY_INSERT [dbo].[Company] OFF

-- 20 Jobs
SET IDENTITY_INSERT [dbo].[Job] ON
insert into Job (JobId, CompanyId, RoundsRequired, Description, Salary) values (1,  20, 1, 'Web Designer', 76626);
insert into Job (JobId, CompanyId, RoundsRequired, Description, Salary) values (2, 8, 3, 'Bus Driver', 35786);
insert into Job (JobId, CompanyId, RoundsRequired, Description, Salary) values (3, 6, 3, 'Nurse', 64405);
insert into Job (JobId, CompanyId, RoundsRequired, Description, Salary) values (4, 13, 2, 'Big Data Analyst', 70005);
insert into Job (JobId, CompanyId, RoundsRequired, Description, Salary) values (5,  6, 3, 'Teacher', 64010);
insert into Job (JobId, CompanyId, RoundsRequired, Description, Salary) values (6, 12, 3, 'Bus Driver', 55495);
insert into Job (JobId, CompanyId, RoundsRequired, Description, Salary) values (7,  13, 2, 'Nurse', 44739);
insert into Job (JobId, CompanyId, RoundsRequired, Description, Salary) values (8, 2, 2, 'CEO', 43718);
insert into Job (JobId, CompanyId, RoundsRequired, Description, Salary) values (9, 9, 2, 'Construction Worker', 90075);
insert into Job (JobId, CompanyId, RoundsRequired, Description, Salary) values (10, 5, 1, 'Truck Driver', 63848);
insert into Job (JobId, CompanyId, RoundsRequired, Description, Salary) values (11, 11, 1, 'Financial Advisor', 63181);
insert into Job (JobId, CompanyId, RoundsRequired, Description, Salary) values (12, 18, 2, 'Programmer', 53837);
insert into Job (JobId, CompanyId, RoundsRequired, Description, Salary) values (13, 5, 2, 'Fire Fighter', 87686);
insert into Job (JobId, CompanyId, RoundsRequired, Description, Salary) values (14, 10, 2, 'Bus Driver', 51974);
insert into Job (JobId, CompanyId, RoundsRequired, Description, Salary) values (15, 18, 3, 'Bus Driver', 82307);
insert into Job (JobId, CompanyId, RoundsRequired, Description, Salary) values (16, 10, 0, 'CEO', 56211);
insert into Job (JobId, CompanyId, RoundsRequired, Description, Salary) values (17, 5, 1, 'Teacher', 98344);
insert into Job (JobId, CompanyId, RoundsRequired, Description, Salary) values (18, 16, 3, 'Bus Driver', 49579);
insert into Job (JobId, CompanyId, RoundsRequired, Description, Salary) values (19, 1, 2, 'Plumber', 97517);
insert into Job (JobId, CompanyId, RoundsRequired, Description, Salary) values (20, 8, 3, 'CEO', 38403);
SET IDENTITY_INSERT [dbo].[Job] OFF

 --50 candidates

SET IDENTITY_INSERT [dbo].[Candidate] ON
insert into Candidate (CandidateId, FirstName, LastName, Address, Language, Gender, ExpectedSalary, LatestPosition, ExperienceYears) values (1, 'Rosaline', 'Gatward', '73852 Aberg Trail', 'Bengali', 'Female', 32, 'Bus Driver', 2);
insert into Candidate (CandidateId, FirstName, LastName, Address, Language, Gender, ExpectedSalary, LatestPosition, ExperienceYears) values (2, 'Giorgi', 'Reavell', '9064 Wayridge Plaza', 'Chinese', 'Male', 33, 'Plumber', 5);
insert into Candidate (CandidateId, FirstName, LastName, Address, Language, Gender, ExpectedSalary, LatestPosition, ExperienceYears) values (3, 'Russell', 'Auguste', '7 Myrtle Trail', 'Portuguese', 'Male', 35, 'CEO', 2);
insert into Candidate (CandidateId, FirstName, LastName, Address, Language, Gender, ExpectedSalary, LatestPosition, ExperienceYears) values (4, 'Siegfried', 'Arden', '78526 Ridge Oak Avenue', 'English', 'Male', 24, 'Fire Fighter', 3);
insert into Candidate (CandidateId, FirstName, LastName, Address, Language, Gender, ExpectedSalary, LatestPosition, ExperienceYears) values (5, 'Faustine', 'Nevet', '4213 Maple Wood Parkway', 'English', 'Female', 27, 'General Doctor', 3);
insert into Candidate (CandidateId, FirstName, LastName, Address, Language, Gender, ExpectedSalary, LatestPosition, ExperienceYears) values (6, 'Austina', 'Peyntue', '9 Oak Junction', 'Hindi', 'Female', 5, 'Teacher', 3);
insert into Candidate (CandidateId, FirstName, LastName, Address, Language, Gender, ExpectedSalary, LatestPosition, ExperienceYears) values (7, 'Mateo', 'Phalp', '5 Vera Circle', 'Portuguese', 'Male', 42, 'Web Designer', 2);
insert into Candidate (CandidateId, FirstName, LastName, Address, Language, Gender, ExpectedSalary, LatestPosition, ExperienceYears) values (8, 'Bendix', 'De Benedictis', '83 Mallory Place', 'Portuguese', 'Male', 10, 'Nurse', 3);
insert into Candidate (CandidateId, FirstName, LastName, Address, Language, Gender, ExpectedSalary, LatestPosition, ExperienceYears) values (9, 'Dulcinea', 'McGinley', '1850 West Center', 'Bengali', 'Female', 33, 'Plumber', 4);
insert into Candidate (CandidateId, FirstName, LastName, Address, Language, Gender, ExpectedSalary, LatestPosition, ExperienceYears) values (10, 'Hervey', 'Torrejon', '10086 Del Sol Parkway', 'Arabic', 'Male', 100, 'Big Data Analyst', 3);
insert into Candidate (CandidateId, FirstName, LastName, Address, Language, Gender, ExpectedSalary, LatestPosition, ExperienceYears) values (11, 'Wendie', 'Elfes', '59986 Butterfield Way', 'Spanish', 'Female', 16, 'CEO', 1);
insert into Candidate (CandidateId, FirstName, LastName, Address, Language, Gender, ExpectedSalary, LatestPosition, ExperienceYears) values (12, 'Arly', 'Burdas', '68 Hayes Terrace', 'Portuguese', 'Female', 19, 'General Doctor', 4);
insert into Candidate (CandidateId, FirstName, LastName, Address, Language, Gender, ExpectedSalary, LatestPosition, ExperienceYears) values (13, 'Inglis', 'Dudmarsh', '221 Pine View Road', 'Spanish', 'Male', 26, 'Construction Worker', 3);
insert into Candidate (CandidateId, FirstName, LastName, Address, Language, Gender, ExpectedSalary, LatestPosition, ExperienceYears) values (14, 'Clarabelle', 'Fortnon', '1797 Raven Plaza', 'Spanish', 'Female', 18, 'Programmer', 2);
insert into Candidate (CandidateId, FirstName, LastName, Address, Language, Gender, ExpectedSalary, LatestPosition, ExperienceYears) values (15, 'Mackenzie', 'Hincham', '7 Hansons Center', 'English', 'Male', 15, 'Financial Advisor', 2);
insert into Candidate (CandidateId, FirstName, LastName, Address, Language, Gender, ExpectedSalary, LatestPosition, ExperienceYears) values (16, 'Heda', 'Bradock', '36746 Mandrake Hill', 'Bengali', 'Female', 95, 'CEO', 2);
insert into Candidate (CandidateId, FirstName, LastName, Address, Language, Gender, ExpectedSalary, LatestPosition, ExperienceYears) values (17, 'Colet', 'Aucourte', '7 Bonner Trail', 'Chinese', 'Male', 74, 'Programmer', 5);
insert into Candidate (CandidateId, FirstName, LastName, Address, Language, Gender, ExpectedSalary, LatestPosition, ExperienceYears) values (18, 'Mahmoud', 'Filliskirk', '75 Lotheville Place', 'Chinese', 'Male', 26, 'Web Designer', 3);
insert into Candidate (CandidateId, FirstName, LastName, Address, Language, Gender, ExpectedSalary, LatestPosition, ExperienceYears) values (19, 'Wyndham', 'Pearn', '6 Bartelt Pass', 'Spanish', 'Male', 75, 'Big Data Analyst', 5);
insert into Candidate (CandidateId, FirstName, LastName, Address, Language, Gender, ExpectedSalary, LatestPosition, ExperienceYears) values (20, 'Saudra', 'Guitt', '77 Manufacturers Trail', 'Arabic', 'Female', 11, 'Big Data Analyst', 1);
insert into Candidate (CandidateId, FirstName, LastName, Address, Language, Gender, ExpectedSalary, LatestPosition, ExperienceYears) values (21, 'Cassie', 'Olivella', '6745 Alpine Park', 'Portuguese', 'Male', 52, 'Teacher', 3);
insert into Candidate (CandidateId, FirstName, LastName, Address, Language, Gender, ExpectedSalary, LatestPosition, ExperienceYears) values (22, 'Vitia', 'MacCrosson', '794 Merry Street', 'Spanish', 'Female', 88, 'Plumber', 2);
insert into Candidate (CandidateId, FirstName, LastName, Address, Language, Gender, ExpectedSalary, LatestPosition, ExperienceYears) values (23, 'Gelya', 'Westwater', '2 Oakridge Plaza', 'Portuguese', 'Female', 99, 'Truck Driver', 4);
insert into Candidate (CandidateId, FirstName, LastName, Address, Language, Gender, ExpectedSalary, LatestPosition, ExperienceYears) values (24, 'Aurelia', 'Paslow', '7 Eastwood Plaza', 'Bengali', 'Female', 72, 'Plumber', 1);
insert into Candidate (CandidateId, FirstName, LastName, Address, Language, Gender, ExpectedSalary, LatestPosition, ExperienceYears) values (25, 'Graham', 'Vyvyan', '8 Oak Valley Center', 'Bengali', 'Male', 16, 'Big Data Analyst', 3);
insert into Candidate (CandidateId, FirstName, LastName, Address, Language, Gender, ExpectedSalary, LatestPosition, ExperienceYears) values (26, 'Cissy', 'Maile', '5150 Dovetail Way', 'Arabic', 'Female', 3, 'Teacher', 2);
insert into Candidate (CandidateId, FirstName, LastName, Address, Language, Gender, ExpectedSalary, LatestPosition, ExperienceYears) values (27, 'Samuele', 'Stockow', '0 Talisman Hill', 'English', 'Male', 7, 'Teacher', 1);
insert into Candidate (CandidateId, FirstName, LastName, Address, Language, Gender, ExpectedSalary, LatestPosition, ExperienceYears) values (28, 'Hallie', 'Gaythorpe', '65 Sullivan Trail', 'Hindi', 'Female', 58, 'Nurse', 3);
insert into Candidate (CandidateId, FirstName, LastName, Address, Language, Gender, ExpectedSalary, LatestPosition, ExperienceYears) values (29, 'Berny', 'Di Ruggiero', '300 Briar Crest Crossing', 'English', 'Female', 20, 'Programmer', 4);
insert into Candidate (CandidateId, FirstName, LastName, Address, Language, Gender, ExpectedSalary, LatestPosition, ExperienceYears) values (30, 'Simone', 'Johnsee', '97 8th Plaza', 'Chinese', 'Male', 44, 'CEO', 1);
insert into Candidate (CandidateId, FirstName, LastName, Address, Language, Gender, ExpectedSalary, LatestPosition, ExperienceYears) values (31, 'Conny', 'Fevier', '4 Harbort Crossing', 'Chinese', 'Female', 5, 'Nurse', 1);
insert into Candidate (CandidateId, FirstName, LastName, Address, Language, Gender, ExpectedSalary, LatestPosition, ExperienceYears) values (32, 'Con', 'Bastian', '222 Cambridge Plaza', 'Bengali', 'Female', 21, 'Programmer', 3);
insert into Candidate (CandidateId, FirstName, LastName, Address, Language, Gender, ExpectedSalary, LatestPosition, ExperienceYears) values (33, 'Carlin', 'Matuszak', '23 Drewry Drive', 'Portuguese', 'Female', 33, 'Plumber', 4);
insert into Candidate (CandidateId, FirstName, LastName, Address, Language, Gender, ExpectedSalary, LatestPosition, ExperienceYears) values (34, 'Rudie', 'Tattershall', '6 Birchwood Terrace', 'English', 'Male', 59, 'Programmer', 2);
insert into Candidate (CandidateId, FirstName, LastName, Address, Language, Gender, ExpectedSalary, LatestPosition, ExperienceYears) values (35, 'Hersh', 'Larver', '2638 Meadow Vale Point', 'Spanish', 'Male', 13, 'Teacher', 4);
insert into Candidate (CandidateId, FirstName, LastName, Address, Language, Gender, ExpectedSalary, LatestPosition, ExperienceYears) values (36, 'Simonette', 'Loakes', '0 Eagle Crest Pass', 'English', 'Female', 27, 'Fire Fighter', 2);
insert into Candidate (CandidateId, FirstName, LastName, Address, Language, Gender, ExpectedSalary, LatestPosition, ExperienceYears) values (37, 'Vanni', 'Frenzl', '7267 Commercial Avenue', 'English', 'Female', 14, 'Teacher', 3);
insert into Candidate (CandidateId, FirstName, LastName, Address, Language, Gender, ExpectedSalary, LatestPosition, ExperienceYears) values (38, 'Gradey', 'Hansmann', '2 Washington Center', 'Portuguese', 'Male', 17, 'Programmer', 2);
insert into Candidate (CandidateId, FirstName, LastName, Address, Language, Gender, ExpectedSalary, LatestPosition, ExperienceYears) values (39, 'Jory', 'Perkin', '36371 Elgar Center', 'Bengali', 'Male', 22, 'Big Data Analyst', 2);
insert into Candidate (CandidateId, FirstName, LastName, Address, Language, Gender, ExpectedSalary, LatestPosition, ExperienceYears) values (40, 'Adena', 'Szabo', '00335 Roxbury Parkway', 'Bengali', 'Female', 5, 'Nurse', 1);
insert into Candidate (CandidateId, FirstName, LastName, Address, Language, Gender, ExpectedSalary, LatestPosition, ExperienceYears) values (41, 'Charmane', 'Christauffour', '027 Riverside Plaza', 'English', 'Female', 76, 'Financial Advisor', 1);
insert into Candidate (CandidateId, FirstName, LastName, Address, Language, Gender, ExpectedSalary, LatestPosition, ExperienceYears) values (42, 'Mord', 'Lipmann', '7 Kedzie Circle', 'English', 'Male', 32, 'Big Data Analyst', 3);
insert into Candidate (CandidateId, FirstName, LastName, Address, Language, Gender, ExpectedSalary, LatestPosition, ExperienceYears) values (43, 'Babb', 'Drepp', '5 Del Mar Plaza', 'English', 'Female', 89, 'Truck Driver', 3);
insert into Candidate (CandidateId, FirstName, LastName, Address, Language, Gender, ExpectedSalary, LatestPosition, ExperienceYears) values (44, 'Maggie', 'Pickthorne', '6 Londonderry Hill', 'Spanish', 'Female', 70, 'Teacher', 1);
insert into Candidate (CandidateId, FirstName, LastName, Address, Language, Gender, ExpectedSalary, LatestPosition, ExperienceYears) values (45, 'Jedidiah', 'Chevolleau', '60106 John Wall Court', 'Hindi', 'Male', 91, 'CEO', 3);
insert into Candidate (CandidateId, FirstName, LastName, Address, Language, Gender, ExpectedSalary, LatestPosition, ExperienceYears) values (46, 'Talia', 'Jamary', '5 Tony Point', 'Portuguese', 'Female', 57, 'CEO', 3);
insert into Candidate (CandidateId, FirstName, LastName, Address, Language, Gender, ExpectedSalary, LatestPosition, ExperienceYears) values (47, 'Mallory', 'Fyall', '7455 Commercial Crossing', 'Portuguese', 'Male', 24, 'General Doctor', 5);
insert into Candidate (CandidateId, FirstName, LastName, Address, Language, Gender, ExpectedSalary, LatestPosition, ExperienceYears) values (48, 'Florencia', 'Lipscombe', '11 Di Loreto Point', 'English', 'Female', 75, 'General Doctor', 4);
insert into Candidate (CandidateId, FirstName, LastName, Address, Language, Gender, ExpectedSalary, LatestPosition, ExperienceYears) values (49, 'Bailie', 'Stading', '6747 5th Place', 'Hindi', 'Male', 77, 'Web Designer', 2);
insert into Candidate (CandidateId, FirstName, LastName, Address, Language, Gender, ExpectedSalary, LatestPosition, ExperienceYears) values (50, 'Alexei', 'Gritsaev', '09 Anderson Place', 'English', 'Male', 40, 'Programmer', 5);
SET IDENTITY_INSERT [dbo].[Candidate] OFF


-- 30 Applications
SET IDENTITY_INSERT [dbo].[Application] ON
insert into Application (ApplicationId, JobId, CandidateId, SubmissionDate, EmployeeReferral, ProcessDuration, status, statusdate) values (1, 7, 38, '2020-09-30', 'Ethelbert Pezey', 0, 'ongoing', '2020-02-02');

insert into Application (ApplicationId, JobId, CandidateId, SubmissionDate, EmployeeReferral, ProcessDuration, status, statusdate) values (2, 13, 17, '2020-03-12 09:00:39', 'Diane-marie Belson', 0, 'received', '2020-05-17 08:06:23');
insert into Application (ApplicationId, JobId, CandidateId, SubmissionDate, EmployeeReferral, ProcessDuration, status, statusdate) values (3, 17, 6, '2020-11-17 00:50:59', 'Wileen Van Niekerk', 0, 'hired', '2020-02-29 10:45:08');
insert into Application (ApplicationId, JobId, CandidateId, SubmissionDate, EmployeeReferral, ProcessDuration, status, statusdate) values (4, 7, 7, '2020-06-19 08:55:53', 'Terrijo De la croix', 0, 'received', '2020-07-24 05:58:02');
insert into Application (ApplicationId, JobId, CandidateId, SubmissionDate, EmployeeReferral, ProcessDuration, status, statusdate) values (5, 19, 42, '2020-06-17 14:47:15', 'Barnie Edelmann', 0, 'hired', '2020-08-25 02:00:52');
insert into Application (ApplicationId, JobId, CandidateId, SubmissionDate, EmployeeReferral, ProcessDuration, status, statusdate) values (6, 9, 26, '2019-11-26 02:42:47', 'Anderea Hurlston', 0, 'hired', '2020-06-14 00:39:11');
insert into Application (ApplicationId, JobId, CandidateId, SubmissionDate, EmployeeReferral, ProcessDuration, status, statusdate) values (7, 2, 38, '2020-07-15 16:28:39', 'Gwenette Brennon', 0, 'submitted', '2020-04-05 16:52:07');
insert into Application (ApplicationId, JobId, CandidateId, SubmissionDate, EmployeeReferral, ProcessDuration, status, statusdate) values (8, 18, 11, '2020-04-03 07:56:14', 'Mil Goodrum', 0, 'ongoing', '2020-08-18 23:22:36');
insert into Application (ApplicationId, JobId, CandidateId, SubmissionDate, EmployeeReferral, ProcessDuration, status, statusdate) values (9, 9, 39, '2020-03-22 01:56:20', 'Martie Dedrick', 0, 'submitted', '2020-02-24 14:26:59');
insert into Application (ApplicationId, JobId, CandidateId, SubmissionDate, EmployeeReferral, ProcessDuration, status, statusdate) values (10, 8, 31, '2020-05-03 18:29:54', 'Kasper Topp', 0, 'hired', '2020-11-05 18:20:36');
insert into Application (ApplicationId, JobId, CandidateId, SubmissionDate, EmployeeReferral, ProcessDuration, status, statusdate) values (11, 10, 4, '2020-10-21 07:55:04', 'Obie Estoile', 0, 'submitted', '2020-09-27 05:12:34');
insert into Application (ApplicationId, JobId, CandidateId, SubmissionDate, EmployeeReferral, ProcessDuration, status, statusdate) values (12, 17, 32, '2019-12-04 05:37:50', 'Elisabet Kevane', 0, 'submitted', '2020-06-30 18:33:44');
insert into Application (ApplicationId, JobId, CandidateId, SubmissionDate, EmployeeReferral, ProcessDuration, status, statusdate) values (13, 6, 22, '2019-11-21 01:45:16', 'Woodman Halkyard', 0, 'hired', '2020-01-28 01:42:17');
insert into Application (ApplicationId, JobId, CandidateId, SubmissionDate, EmployeeReferral, ProcessDuration, status, statusdate) values (14, 8, 34, '2019-12-25 22:23:59', 'Claresta Vlahos', 0, 'hired', '2019-12-06 23:20:54');
insert into Application (ApplicationId, JobId, CandidateId, SubmissionDate, EmployeeReferral, ProcessDuration, status, statusdate) values (15, 2, 17, '2020-06-28 04:39:55', 'Wiatt Littlepage', 0, 'deferred', '2020-07-27 12:04:03');
insert into Application (ApplicationId, JobId, CandidateId, SubmissionDate, EmployeeReferral, ProcessDuration, status, statusdate) values (16, 18, 50, '2020-01-31 02:42:12', 'Mozelle Ghidetti', 0, 'received', '2019-12-26 03:33:00');
insert into Application (ApplicationId, JobId, CandidateId, SubmissionDate, EmployeeReferral, ProcessDuration, status, statusdate) values (17, 16, 48, '2020-08-21 08:32:54', 'Alphard Kesteven', 0, 'hired', '2020-03-02 21:23:29');
insert into Application (ApplicationId, JobId, CandidateId, SubmissionDate, EmployeeReferral, ProcessDuration, status, statusdate) values (18, 18, 24, '2020-02-20 07:21:02', 'Tomi Dahlgren', 0, 'discarded', '2020-07-11 08:13:08');
insert into Application (ApplicationId, JobId, CandidateId, SubmissionDate, EmployeeReferral, ProcessDuration, status, statusdate) values (19, 3, 12, '2019-12-23 22:05:56', 'Osbourne McCready', 0, 'submitted', '2020-07-03 04:18:27');
insert into Application (ApplicationId, JobId, CandidateId, SubmissionDate, EmployeeReferral, ProcessDuration, status, statusdate) values (20, 14, 39, '2020-05-24 10:41:07', 'Anna Jolliffe', 0, 'hired', '2020-03-09 09:27:59');
insert into Application (ApplicationId, JobId, CandidateId, SubmissionDate, EmployeeReferral, ProcessDuration, status, statusdate) values (21, 16, 27, '2020-07-29 06:39:41', 'Teressa Castiblanco', 0, 'ongoing', '2020-10-23 23:35:32');
insert into Application (ApplicationId, JobId, CandidateId, SubmissionDate, EmployeeReferral, ProcessDuration, status, statusdate) values (22, 14, 39, '2020-06-17 02:18:45', 'Kizzie Kenrat', 0, 'received', '2020-06-29 07:49:47');
insert into Application (ApplicationId, JobId, CandidateId, SubmissionDate, EmployeeReferral, ProcessDuration, status, statusdate) values (23, 7, 34, '2020-03-20 10:27:10', 'Lucien Hunsworth', 0, 'submitted', '2019-12-17 19:02:45');
insert into Application (ApplicationId, JobId, CandidateId, SubmissionDate, EmployeeReferral, ProcessDuration, status, statusdate) values (24, 17, 30, '2020-03-05 17:22:43', 'Berni Brugger', 0, 'received', '2020-07-28 04:38:00');
insert into Application (ApplicationId, JobId, CandidateId, SubmissionDate, EmployeeReferral, ProcessDuration, status, statusdate) values (25, 4, 35, '2019-12-04 05:28:46', 'Viola Hallows', 0, 'discarded', '2020-04-23 02:53:38');
insert into Application (ApplicationId, JobId, CandidateId, SubmissionDate, EmployeeReferral, ProcessDuration, status, statusdate) values (26, 4, 3, '2020-06-20 07:28:29', 'Gilda Lefeuvre', 0, 'ongoing', '2020-08-20 01:52:30');
insert into Application (ApplicationId, JobId, CandidateId, SubmissionDate, EmployeeReferral, ProcessDuration, status, statusdate) values (27, 8, 32, '2020-02-16 02:30:40', 'Hale Hanaford', 0, 'submitted', '2020-01-02 02:28:15');
insert into Application (ApplicationId, JobId, CandidateId, SubmissionDate, EmployeeReferral, ProcessDuration, status, statusdate) values (28, 17, 20, '2020-04-24 01:10:15', 'Darell Bowgen', 0, 'ongoing', '2020-05-14 16:49:33');
insert into Application (ApplicationId, JobId, CandidateId, SubmissionDate, EmployeeReferral, ProcessDuration, status, statusdate) values (29, 9, 11, '2020-09-15 07:23:54', 'Rey Streetley', 0, 'discarded', '2020-09-02 14:56:50');
insert into Application (ApplicationId, JobId, CandidateId, SubmissionDate, EmployeeReferral, ProcessDuration, status, statusdate) values (30, 1, 35, '2020-11-03 22:10:23', 'Rycca Ganiclef', 0, 'submitted', '2020-09-14 11:33:40');

SET IDENTITY_INSERT [dbo].[Application] OFF

-- 55 Interviews

SET IDENTITY_INSERT [dbo].[Interview] ON


insert into Interview (InterviewId, RecruiterName, InterviewRound, ApplicationId, Medium, Score) values (1, 'Laura Kerbler', 1, 3, 'Face-to-face', 3);
insert into Interview (InterviewId, RecruiterName, InterviewRound, ApplicationId, Medium, Score) values (2, 'Javier Sired', 1, 8, 'Teams', 10);
insert into Interview (InterviewId, RecruiterName, InterviewRound, ApplicationId, Medium, Score) values (3, 'Hubey Creegan', 2, 4, 'Teams', 7);
insert into Interview (InterviewId, RecruiterName, InterviewRound, ApplicationId, Medium, Score) values (4, 'Margie McDougald', 1, 7, 'Teams', 10);
insert into Interview (InterviewId, RecruiterName, InterviewRound, ApplicationId, Medium, Score) values (5, 'Raynard Perche', 2, 23, 'WebEx', 8);
insert into Interview (InterviewId, RecruiterName, InterviewRound, ApplicationId, Medium, Score) values (6, 'Killie Stone', 1, 5, 'WebEx', 3);
insert into Interview (InterviewId, RecruiterName, InterviewRound, ApplicationId, Medium, Score) values (7, 'Mallissa Tother', 3, 3, 'Phone', 4);
insert into Interview (InterviewId, RecruiterName, InterviewRound, ApplicationId, Medium, Score) values (8, 'Sarge Fisbey', 1, 2, 'Teams', 5);
insert into Interview (InterviewId, RecruiterName, InterviewRound, ApplicationId, Medium, Score) values (9, 'Nolly Grundey', 3, 26, 'Zoom', 4);
insert into Interview (InterviewId, RecruiterName, InterviewRound, ApplicationId, Medium, Score) values (10, 'Egbert Sergean', 3, 19, 'WebEx', 9);
insert into Interview (InterviewId, RecruiterName, InterviewRound, ApplicationId, Medium, Score) values (11, 'Kale Tytler', 1, 25, 'Face-to-face', 8);
insert into Interview (InterviewId, RecruiterName, InterviewRound, ApplicationId, Medium, Score) values (12, 'Tessa Beevor', 1, 4, 'Face-to-face', 5);
insert into Interview (InterviewId, RecruiterName, InterviewRound, ApplicationId, Medium, Score) values (13, 'Ford Toy', 3, 11, 'Teams', 10);
insert into Interview (InterviewId, RecruiterName, InterviewRound, ApplicationId, Medium, Score) values (14, 'Nathalia Stempe', 3, 1, 'Face-to-face', 8);
insert into Interview (InterviewId, RecruiterName, InterviewRound, ApplicationId, Medium, Score) values (15, 'Mercie Stygall', 1, 23, 'WebEx', 7);
insert into Interview (InterviewId, RecruiterName, InterviewRound, ApplicationId, Medium, Score) values (16, 'Tomi Ashbridge', 3, 3, 'Zoom', 9);
insert into Interview (InterviewId, RecruiterName, InterviewRound, ApplicationId, Medium, Score) values (17, 'Dwayne Luscott', 2, 27, 'Face-to-face', 9);
insert into Interview (InterviewId, RecruiterName, InterviewRound, ApplicationId, Medium, Score) values (18, 'Bud De Michele', 2, 24, 'Phone', 8);
insert into Interview (InterviewId, RecruiterName, InterviewRound, ApplicationId, Medium, Score) values (19, 'Andie Foli', 2, 21, 'Phone', 7);
insert into Interview (InterviewId, RecruiterName, InterviewRound, ApplicationId, Medium, Score) values (20, 'Ursala Walthew', 3, 25, 'Skype', 9);
insert into Interview (InterviewId, RecruiterName, InterviewRound, ApplicationId, Medium, Score) values (21, 'Kiley Mertsching', 3, 23, 'Teams', 2);
insert into Interview (InterviewId, RecruiterName, InterviewRound, ApplicationId, Medium, Score) values (22, 'Norris Copeland', 3, 23, 'Teams', 10);
insert into Interview (InterviewId, RecruiterName, InterviewRound, ApplicationId, Medium, Score) values (23, 'Kale Jeskins', 3, 12, 'WebEx', 1);
insert into Interview (InterviewId, RecruiterName, InterviewRound, ApplicationId, Medium, Score) values (24, 'Cassie Aldrin', 3, 1, 'WebEx', 6);
insert into Interview (InterviewId, RecruiterName, InterviewRound, ApplicationId, Medium, Score) values (25, 'Cart Ragot', 1, 17, 'Phone', 7);
insert into Interview (InterviewId, RecruiterName, InterviewRound, ApplicationId, Medium, Score) values (26, 'Harv Duckwith', 2, 23, 'Zoom', 7);
insert into Interview (InterviewId, RecruiterName, InterviewRound, ApplicationId, Medium, Score) values (27, 'Sigismond Gaywood', 3, 14, 'WebEx', 6);
insert into Interview (InterviewId, RecruiterName, InterviewRound, ApplicationId, Medium, Score) values (28, 'Adam Button', 3, 24, 'Skype', 3);
insert into Interview (InterviewId, RecruiterName, InterviewRound, ApplicationId, Medium, Score) values (29, 'Corina Timmons', 1, 9, 'Teams', 1);
insert into Interview (InterviewId, RecruiterName, InterviewRound, ApplicationId, Medium, Score) values (30, 'Orville Fidoe', 2, 5, 'Teams', 9);
insert into Interview (InterviewId, RecruiterName, InterviewRound, ApplicationId, Medium, Score) values (31, 'Billy Hoggins', 2, 28, 'Teams', 7);
insert into Interview (InterviewId, RecruiterName, InterviewRound, ApplicationId, Medium, Score) values (32, 'Bryon Searson', 2, 3, 'Zoom', 4);
insert into Interview (InterviewId, RecruiterName, InterviewRound, ApplicationId, Medium, Score) values (33, 'Analise Berlin', 3, 16, 'Face-to-face', 1);
insert into Interview (InterviewId, RecruiterName, InterviewRound, ApplicationId, Medium, Score) values (34, 'Alvera Disman', 2, 1, 'Skype', 5);
insert into Interview (InterviewId, RecruiterName, InterviewRound, ApplicationId, Medium, Score) values (35, 'Amalie Betterton', 1, 1, 'Teams', 5);
insert into Interview (InterviewId, RecruiterName, InterviewRound, ApplicationId, Medium, Score) values (36, 'Emmalee Ovenell', 3, 14, 'Face-to-face', 2);
insert into Interview (InterviewId, RecruiterName, InterviewRound, ApplicationId, Medium, Score) values (37, 'Mathilda Dwerryhouse', 1, 6, 'Skype', 3);
insert into Interview (InterviewId, RecruiterName, InterviewRound, ApplicationId, Medium, Score) values (38, 'Hillier Dursley', 3, 26, 'Skype', 7);
insert into Interview (InterviewId, RecruiterName, InterviewRound, ApplicationId, Medium, Score) values (39, 'Dwain Drabble', 2, 30, 'Skype', 1);
insert into Interview (InterviewId, RecruiterName, InterviewRound, ApplicationId, Medium, Score) values (40, 'Huberto Ashe', 1, 4, 'Teams', 10);
insert into Interview (InterviewId, RecruiterName, InterviewRound, ApplicationId, Medium, Score) values (41, 'Christel Jorgesen', 3, 3, 'Zoom', 4);
insert into Interview (InterviewId, RecruiterName, InterviewRound, ApplicationId, Medium, Score) values (42, 'Benny Ebbetts', 1, 15, 'Face-to-face', 5);
insert into Interview (InterviewId, RecruiterName, InterviewRound, ApplicationId, Medium, Score) values (43, 'Susann Lipscomb', 1, 14, 'Zoom', 2);
insert into Interview (InterviewId, RecruiterName, InterviewRound, ApplicationId, Medium, Score) values (44, 'Redd Trembath', 2, 21, 'Phone', 1);
insert into Interview (InterviewId, RecruiterName, InterviewRound, ApplicationId, Medium, Score) values (45, 'Noelyn Ramirez', 3, 2, 'Face-to-face', 6);
insert into Interview (InterviewId, RecruiterName, InterviewRound, ApplicationId, Medium, Score) values (46, 'Godfrey Mundow', 1, 8, 'WebEx', 7);
insert into Interview (InterviewId, RecruiterName, InterviewRound, ApplicationId, Medium, Score) values (47, 'Alanson Millhill', 1, 3, 'Face-to-face', 8);
insert into Interview (InterviewId, RecruiterName, InterviewRound, ApplicationId, Medium, Score) values (48, 'Timmi Tointon', 1, 11, 'Face-to-face', 7);
insert into Interview (InterviewId, RecruiterName, InterviewRound, ApplicationId, Medium, Score) values (49, 'Buddie Iannetti', 1, 3, 'Face-to-face', 4);
insert into Interview (InterviewId, RecruiterName, InterviewRound, ApplicationId, Medium, Score) values (50, 'Elana Plaice', 1, 2, 'Face-to-face', 1);
insert into Interview (InterviewId, RecruiterName, InterviewRound, ApplicationId, Medium, Score) values (51, 'Amandy Eby', 2, 13, 'Phone', 7);
insert into Interview (InterviewId, RecruiterName, InterviewRound, ApplicationId, Medium, Score) values (52, 'Jakie Gardiner', 2, 13, 'Face-to-face', 4);
insert into Interview (InterviewId, RecruiterName, InterviewRound, ApplicationId, Medium, Score) values (53, 'Noah Aliman', 3, 28, 'Zoom', 7);
insert into Interview (InterviewId, RecruiterName, InterviewRound, ApplicationId, Medium, Score) values (54, 'Abbye Roback', 3, 30, 'Face-to-face', 2);
insert into Interview (InterviewId, RecruiterName, InterviewRound, ApplicationId, Medium, Score) values (55, 'Betsey Hallybone', 2, 21, 'Teams', 2);
SET IDENTITY_INSERT [dbo].[Interview] OFF


-- Jobs x Perks M:N relationship

insert into JobPerk (JobId, PerkId) values 
(1,8),
(1,6),
(2,10),
(3,5),
(4,9),
(4,6),
(5,9),
(6,1),
(7,5),
(8,8),
(8,1),
(9,4),
(10,10),
(10,2),
(11,4),
(12,10),
(13,4),
(13,5),
(14,6),
(14,4),
(15,2),
(15,7),
(16,10),
(16,2),
(16,4),
(16,7),
(17,5),
(18,10),
(18,3),
(18,9),
(19,3),
(19,7),
(20,2),
(20,6);
