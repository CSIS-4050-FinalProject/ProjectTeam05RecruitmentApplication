using ControllerUtilities;
using RecruitmentCodeFirstFromDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RecruitmentDashboardForm
{
    public partial class UpdateApplicationProgressForm : Form
    {
        string role;
        int applicationID;
        public UpdateApplicationProgressForm(string role, int application)
        {
            // Load main form
            this.Load += (s, e) => UpdateForm_Load();

            //get role and application
            this.role = role;
            this.applicationID = application;

            InitializeComponent();
        }


        /// <summary>
        /// Initializes default parameters for Filter and Recruiter Dashboard 
        /// </summary>
        private void UpdateForm_Load()
        {

            using (RecruitmentEntities context = Controller<RecruitmentEntities, DbSet>.SetContext())
            {
                context.SeedDatabase();
            }

            //Initialize Form Settings
            InitializeUpdateForm();
        }


        private void InitializeUpdateForm() {
            labelRole.Text = role;

            labelApplicationIDOutput.Text = applicationID.ToString();

            using (RecruitmentEntities context = Controller<RecruitmentEntities, DbSet>.SetContext())
            {
                //get candidateID from Application Table
                var getApplicationDetails = context.Applications.Find(applicationID);
                var cadidateID = getApplicationDetails.CandidateId;

                //get Candidate
                var getCandidate = from candidate in context.Candidates
                                   where candidate.CandidateId == cadidateID
                                   select new { 
                                       FirstName = candidate.FirstName, 
                                       LastName = candidate.LastName, 
                                       Address = candidate.Address, 
                                       Language = candidate.Language, 
                                       Gender = candidate.Gender, 
                                       ExpectedSalary = candidate.ExpectedSalary, 
                                       LatestPosition = candidate.LatestPosition, 
                                       ExperienceYears = candidate.ExperienceYears
                                   };
                dataGridViewCandidateDetails.DataSource = getCandidate.ToList();

                //get Application 

                var getApplication = from app in context.Applications
                                   where app.ApplicationId == applicationID
                                   select new
                                   {
                                       SubmissionDate = app.SubmissionDate,
                                       EmployeeReferral = app.EmployeeReferral,
                                       Status = app.Status,
                                       StatusDate = app.StatusDate
                                   };
                dataGridViewApplicationDetails.DataSource = getApplication.ToList();

                //get interviews

                var getInterviews = from interview in context.Interviews
                                     where interview.ApplicationId == applicationID
                                     select new
                                     {
                                         InterviewID = interview.InterviewId,
                                         InterviewRound = interview.InterviewRound,
                                         Recruiter = interview.RecruiterName,
                                         Medium = interview.Medium,
                                         Score = interview.Score
                                     };
                dataGridViewInterviewDetails.DataSource = getInterviews.ToList();
            }



        }
    }
}
