using ControllerUtilities;
using RecruitmentCodeFirstFromDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace RecruitmentDashboardForm
{
    public partial class RecruiterDashboardMainForm : Form
    {
        string role;
        int applicationID;
        public RecruiterDashboardMainForm()
        {
            InitializeComponent();

            // Load main form
            this.Load += (s, e) => RecruiterMainForm_Load();

            // Event handlers

            // Control Filter Change
            comboBoxCompaniesFilter.SelectedIndexChanged += (s, e) => FilterJobList();
            radioButtonActiveApplications.CheckedChanged += (s, e) => FilterJobList();

            // Control listbox selection
            listBoxJobPositions.SelectedIndexChanged += (s, e) => UpdateDashboard();

            // Button CLick Listeners

            // Update recruitment process for selected role
            UpdateApplicationProgressForm updateApplicationProgressForm;
            buttonUpdateApplication.Click += (s, e) => AddOrUpdateForm<Job>(updateApplicationProgressForm = new UpdateApplicationProgressForm(role, applicationID));

            // Backup button event handler
            //buttonBackupDB.Click += (s,e) => BackupDataSetToXML(DataSet);
        }

        /// <summary>
        /// Initializes default parameters for Filter and Recruiter Dashboard 
        /// </summary>
        private void RecruiterMainForm_Load()
        {

            using (RecruitmentEntities context = Controller<RecruitmentEntities, DbSet>.SetContext())
            {
                context.SeedDatabase();
            }

            //Initialize Form Settings
            InitializeFiltersSettings();
            InitializeDashboardSettings();
        }

        /// <summary>
        /// Sets all default control behaviour of the Dashboard in the form
        /// Clears all labels
        /// </summary>
        private void InitializeDashboardSettings()
        {
            //Recruiter Dashboard Settings
            // Set all output labels to blank
            labelSelectedRoleOutput.ResetText();
            labelRoleStatusOutput.ResetText();
            labelNumberOfRoundsOutput.ResetText();
            labelNumberOfCandidatesOutput.ResetText();
            labelSalaryOutput.ResetText();

            //Company labels
            labelCompanyNameOutput.ResetText();
            labelHiringDepartmentOutput.ResetText();
            labelHiringManagerOutput.ResetText();
            labelCompanySizeOutput.ResetText();

        }

        /// <summary>
        /// Sets all default control behaviour of theFilters in the form
        /// </summary>
        private void InitializeFiltersSettings()
        {

            //Filter Settings
            // Set radiobutton to All
            radioButtonActiveApplications.Checked = true;

            //Fill Combobox
            FillCompaniesComboBox();

            // Fill roles listbox
            FillRolesListBox();

            //Fill How to use form section
            FillHowToSection();
        }

        /// <summary>
        /// Fills the combobox with a list of unique companies present in the database
        /// </summary>
        private void FillCompaniesComboBox()
        {
            //Fills combobox with distinct companies

            using (RecruitmentEntities context = Controller<RecruitmentEntities, DbSet>.SetContext())
            {
                var items = context.Companies.Select(c => new
                {
                    company = c.Name
                }).Distinct()
                .AsEnumerable().Select(c => new
                {
                    displayMember = String.Format(c.company)
                });

                comboBoxCompaniesFilter.DisplayMember = "displayMember";
                comboBoxCompaniesFilter.DataSource = items.ToList();

                // Default is none selected
                comboBoxCompaniesFilter.SelectedIndex = -1;

            }
        }

        /// <summary>
        /// Fills the listbox with all the posotions available according to filter selected
        /// </summary>
        private void FillRolesListBox()
        {
            //filters by active roles using unit of work
            using (RecruitmentEntities context = Controller<RecruitmentEntities, DbSet>.SetContext())
            {
                var rolesByStatus = context.Jobs;

                foreach (var job in rolesByStatus)
                {
                    listBoxJobPositions.Items.Add(job.Description);
                }

            }
            // Set role listbox to have no jobs selected
            listBoxJobPositions.SelectedIndex = -1;
        }

        /// <summary>
        /// Filter listbox based on radiobutton 
        /// and combobox selection (if applicable)
        /// </summary>
        private void FilterJobList()
        {

            //TODO: Filter jobs list considering radio and combobox selection

        }

        /// <summary>
        /// Fill the how to use this form section
        /// </summary>
        private void FillHowToSection() {
            labelStep1Details.Text = "Filter through the roles on the system using the Role Filters, then select a role from the 'Select a Role 'list box.";
            labelStep2Details.Text = "Once a role is selected the role details will be displayed in the Role Dashboard along with a table of all applications connected to it.";
            labelSep3Details.Text = "Filter the applications by status using the combobox";
            labelStep4Details.Text = "to see more details on the application select one application from the 'Application Details' datagrid, and click 'Update Application' button";
        }

        /// <summary>
        /// Updates the Recruiter Dashboard
        /// Takes the role selected by the list box and fills the dashboard with details about that role and it's applications
        /// </summary>
        private void UpdateDashboard()
        {
            this.role = listBoxJobPositions.SelectedItem.ToString();

            using (RecruitmentEntities context = Controller<RecruitmentEntities, DbSet>.SetContext())
            {
                var getRoleDetails = context.Jobs.Find(listBoxJobPositions.SelectedIndex);
                int jobID = getRoleDetails.JobId;
                int companyID = getRoleDetails.CompanyId;

                // Initialize Role depedent labels
                labelSelectedRoleOutput.Text = role;

                //TODO: Get radiobutton
                //labelRoleStatusOutput.Text = ;


                var getApplications = context.Applications.Where(a => a.JobId == jobID).ToList().Count();
                labelNumberOfCandidatesOutput.Text = getApplications.ToString();

                labelNumberOfRoundsOutput.Text = getRoleDetails.RoundsRequired.ToString();
                labelSalaryOutput.Text = getRoleDetails.Salary.ToString();

                var getCompany = from company in context.Companies
                                           where company.CompanyId == companyID
                                           select company;

                //Company labels
                foreach (var c in getCompany) {
                    labelCompanyNameOutput.Text = c.Name;
                    labelHiringDepartmentOutput.Text = c.HiringDepartment;
                    labelHiringManagerOutput.Text = c.HiringManager;
                    labelCompanySizeOutput.Text = c.Size.ToString();
                }

                //Initialize Application Status Combobox
                FillApplicationStatusComboBox();

                //Initialize datagridviews

                //TODO: Filter so that the only applications information that shows is the one that matches the jobID for the role selected

                //TODO: Get application number when selected application in the datagrid and instantiate the application
                applicationID = 2;

                //TODO: Filter so that the only perks that show are the ones that matches the the role selected
            }

        }

        /// <summary>
        /// Fills the application status with a list of unique status present in the database
        /// </summary>
        private void FillApplicationStatusComboBox()
        {
            //Fills combobox with distinct status

            using (RecruitmentEntities context = Controller<RecruitmentEntities, DbSet>.SetContext())
            {
                var items = context.Applications.Select(c => new
                {
                    status = c.Status
                }).Distinct()
                .AsEnumerable().Select(c => new
                {
                    displayMember = String.Format(c.status)
                });

                comboBoxApplicationStatus.DisplayMember = "displayMember";
                comboBoxApplicationStatus.DataSource = items.ToList();

                // Default is none selected
                comboBoxApplicationStatus.SelectedIndex = -1;

            }
        }

        private void InitializeDataGridView<T>(DataGridView gridView, params string[] columnsToHide) where T : class
        {
            //Sets grid controls
            gridView.AllowUserToAddRows = false;
            gridView.AllowUserToDeleteRows = false;
            gridView.ReadOnly = true;
            gridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            gridView.DataSource = Controller<RecruitmentEntities, T>.SetBindingList();

            foreach (string column in columnsToHide)
                gridView.Columns[column].Visible = false;
        }

        /// <summary>
        /// Generic method to display a form and then update the relevant gridviews.
        /// </summary>
        /// <typeparam name="T">Data type associated with the gridview</typeparam>
        /// <param name="dataGridView">DataGridView to be updated with new data from DB</param>
        /// <param name="form"></param>
        private void AddOrUpdateForm<T>(Form form) where T : class
        {
            var result = form.ShowDialog();

            // form has closed

            if (result == DialogResult.OK)
            {

            }

            //Hide Form
            form.Hide();
        }

        /// <summary>
		/// Back up a DataSet to an XML file. 
		/// 
		/// File is named using the 
		/// <see cref="DataSet.DataSetName"/> with .xml appended
		/// </summary>
		/// <param name="dataSet">DataSet to be backked up</param>
		/// <param name="fileName">Name of the xml file (should have .xml extension)</param>
		public void BackupDataSetToXML(DataSet dataSet)
        {
            if (dataSet == null)
            {
                Debug.WriteLine("BackupDataSetToXML: Error - null dataset");
                return;
            }

            // writes the DataSet to an xml file including the schema

            Debug.WriteLine("BackupDataSetToXML: backing up to " + dataSet.DataSetName);

            dataSet.WriteXml(dataSet.DataSetName + ".xml", XmlWriteMode.WriteSchema);
        }

    }
}
