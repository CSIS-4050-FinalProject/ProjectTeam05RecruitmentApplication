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

            this.buttonUpdateApplication.Click += (s, e) => UpdateApplication();
            this.buttonAddInterview.Click += (s, e) => AddInterview();
            this.buttonUpdateInterview.Click += (s, e) => UpdateInterview();
            this.dataGridViewInterviewDetails.Click += (s, e) => UpdateInterviewFields();


        }

        private void UpdateInterviewFields()
        {
            if (dataGridViewInterviewDetails.SelectedRows.Count > 0)
            {
                textBoxRecruiterName.Text = dataGridViewInterviewDetails.SelectedRows[0].Cells[2].Value.ToString();
                textBoxInterviewRound.Text = dataGridViewInterviewDetails.SelectedRows[0].Cells[1].Value.ToString();
                textBoxMedium.Text = dataGridViewInterviewDetails.SelectedRows[0].Cells[3].Value.ToString();
                textBoxScore.Text = dataGridViewInterviewDetails.SelectedRows[0].Cells[4].Value.ToString();
            }
        }

        private void UpdateInterview()
        {
            int interviewId;
            using (RecruitmentEntities context = Controller<RecruitmentEntities, DbSet>.SetContext())
            {
                if (textBoxRecruiterName.Text.ToString() == "" ||
                    textBoxInterviewRound.Text.ToString() == "" ||
                    textBoxMedium.Text.ToString() == "" ||
                    textBoxScore.Text.ToString() == "")
                {
                    MessageBox.Show("Please enter all interview fields!");
                    return;
                }

                string inputRecruiterName = textBoxRecruiterName.Text.ToString();
                string inputInterviewRound = textBoxInterviewRound.Text.ToString();
                string inputMedium = textBoxMedium.Text.ToString();
                string inputScore = textBoxScore.Text.ToString();

                int intInterviewRound, intScore;
                if (!Int32.TryParse(inputInterviewRound, out intInterviewRound))
                {
                    MessageBox.Show("Please enter the interview rounds in numeric form!");
                    return;
                }
                if (!Int32.TryParse(inputScore, out intScore))
                {
                    MessageBox.Show("Please enter the score in numeric form!");
                    return;
                }

                if (dataGridViewInterviewDetails.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select the interview first!");
                    return;
                }

                interviewId = Int32.Parse(dataGridViewInterviewDetails.SelectedRows[0].Cells[0].Value.ToString());

                Interview newInterview = context.Interviews.Find(interviewId);
                newInterview.RecruiterName = inputRecruiterName;
                newInterview.InterviewRound = intInterviewRound;
                newInterview.ApplicationId = this.applicationID;
                newInterview.Medium = inputMedium;
                newInterview.Score = intScore;

                context.SaveChanges();

                InitializeUpdateForm();
            }
        }

        private void AddInterview()
        {
            using (RecruitmentEntities context = Controller<RecruitmentEntities, DbSet>.SetContext())
            {
                if (textBoxRecruiterName.Text.ToString() == "" || 
                    textBoxInterviewRound.Text.ToString() == "" ||
                    textBoxMedium.Text.ToString() == "" ||
                    textBoxScore.Text.ToString() == "")
                {
                    MessageBox.Show("Please enter all interview fields!");
                    return;
                }

                string inputRecruiterName = textBoxRecruiterName.Text.ToString();
                string inputInterviewRound = textBoxInterviewRound.Text.ToString();
                string inputMedium = textBoxMedium.Text.ToString();
                string inputScore = textBoxScore.Text.ToString();

                int intInterviewRound, intScore;
                if (!Int32.TryParse(inputInterviewRound, out intInterviewRound))
                {
                    MessageBox.Show("Please enter the interview rounds in numeric form!");
                    return;
                }
                if (!Int32.TryParse(inputScore, out intScore))
                {
                    MessageBox.Show("Please enter the score in numeric form!");
                    return;
                }

                Interview newInterview = new Interview() {
                    RecruiterName = inputRecruiterName,
                    InterviewRound = intInterviewRound,
                    ApplicationId = this.applicationID,
                    Medium = inputMedium,
                    Score = intScore
                };
                

                context.Interviews.Add(newInterview);
                context.SaveChanges();

                InitializeUpdateForm();
            }
        }

        private void UpdateApplication()
        {
            using (RecruitmentEntities context = Controller<RecruitmentEntities, DbSet>.SetContext())
            {
                if(textBoxUpdateDateOutput.Text.ToString() == "" || textBoxStatusOutput.Text.ToString() == "")
                {
                    MessageBox.Show("Please enter both update fields!");
                    return;
                }

                string inputDate = textBoxUpdateDateOutput.Text.ToString();
                string inputStatus = textBoxStatusOutput.Text.ToString();

                DateTime applicationDate;

                if (!DateTime.TryParse(inputDate, out applicationDate))
                {
                    MessageBox.Show("Please enter the date in correct form!");
                    return;
                }
                context.Applications.Find(applicationID).StatusDate = applicationDate;
                context.Applications.Find(applicationID).Status = inputStatus;
                context.SaveChanges();

                InitializeUpdateForm();
            }
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
                if (context.Applications.Find(applicationID).Status.Equals("discarded") ||
                    context.Applications.Find(applicationID).Status.Equals("hired"))
                {
                    buttonAddInterview.Enabled = false;
                }
                else
                {
                    buttonAddInterview.Enabled = true;
                }

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
