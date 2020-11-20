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

namespace RecruitmentDashboardForm
{
    public partial class RecruiterDashboardMainForm : Form
    {
        string role;
        public RecruiterDashboardMainForm()
        {
            InitializeComponent();

            // Load main form
            this.Load += (s, e) => RecruiterMainForm_Load();

            // Event handlers

            // Control Filter Change
            //comboBoxCompaniesFilter.SelectedIndexChanged += (s, e) => FilterJobList();
            //radioButtonActiveApplications.CheckedChanged += (s, e) => FilterJobList();

            // Control listbox selection


            // Button CLick Listeners

            // Update recruitment process for selected role
            UpdateApplicationProgressForm updateApplicationProgressForm;
            //buttonUpdateRole.Click += (s, e) => AddOrUpdateForm<Class>(updateApplicationProgressForm = new UpdateApplicationProgressForm(role));

            // Backup button event handler
            //buttonBackupDB.Click += (s,e) => BackupDataSetToXML(DataSet);
        }

        /// <summary>
        /// Initializes default parameters for Filter and Recruiter Dashboard 
        /// </summary>
        private void RecruiterMainForm_Load() {

            //Initialize Form Settings
            InitializeFiltersSettings();
            InitializeDashboardSettings();
        }

        /// <summary>
        /// Sets all default control behaviour of the Dashboard in the form
        /// Clears all labels
        /// </summary>
        private void InitializeDashboardSettings() {
            //Recruiter Dashboard Settings
            // Set all output labels to blank
            labelSelectedRoleOutput.ResetText();
            labelSalaryOutput.ResetText();
            labelNumberOfRoundsOutput.ResetText();
            labelCurrentRoundOutput.ResetText();
            labelNumberOfCandidatesOutput.ResetText();
            labelDateRoleOpenedOutput.ResetText();
            labelDateRoleFinalizesOutput.ResetText();
            labelSalaryOutput.ResetText();
            labelRoleDescriptionOutput.ResetText();
        }

        /// <summary>
        /// Sets all default control behaviour of theFilters in the form
        /// </summary>
        private void InitializeFiltersSettings() {
           
            //Filter Settings
            // Set radiobutton to All
            radioButtonActiveApplications.Checked = true;

            //Fill Combobox
            FillCompaniesComboBox();

            // Fill roles listbox
            FillRolesListBox();       
        }

        /// <summary>
        /// Fills the combobox with a list of unique companies present in the database
        /// </summary>
        private void FillCompaniesComboBox() {


            //Fills combobox with distinct companies

            //using (RecruitmentEntities context = Controller<RecruiterEntities, DbSet>.SetContext())
            //{
            //var items = context.Companies.Select(c => new
            //{
            //    company = c.CompanyName
            //}).Distinct()
            //.AsEnumerable().Select(c => new
            //{
            //    displayMember = String.Format(c.company)
            //});

            //comboBoxCompaniesFilter.DisplayMember = "displayMember";
            //comboBoxCompaniesFilter.DataSource = items.ToList();

            // Default is none selected
            //comboBoxCompaniesFilter.SelectedIndex = -1;
            //}
        }

        /// <summary>
        /// Fills the listbox with all the posotions available according to filter selected
        /// </summary>
        private void FillRolesListBox() {
            //filters by active roles using unit of work
            // using (Entities context = Controller<Entities, DbSet>.SetContext())
            // {
            //var rolesbyStatus = context.Roles.Where(x => x.Status == "active");

            //listBoxJobPositions.DataSource = relesByCompany.ToList();

            //Fills listbox
            List<string> MyList = new List<string>();
            MyList.Add("Job1");
            MyList.Add("Job2");

            listBoxJobPositions.DataSource = MyList;
        //}
            // Set role listbox to have no jobs selected
            listBoxJobPositions.SelectedIndex = -1;
        }

        /// <summary>
        /// Filter listbox based on radiobutton 
        /// and combobox selection (if applicable)
        /// </summary>
        private void FilterJobList() {

            // Resets listbox to no item selected
            //sets role variable to empty
            //Empties all labels in Dashboard
            listBoxJobPositions.SelectedIndex = -1;
            this.role = "";
            InitializeDashboardSettings();

            if (comboBoxCompaniesFilter.SelectedItem != null) {
                string selectedCompany = comboBoxCompaniesFilter.SelectedItem.ToString();
                labelStatus.Text = selectedCompany;
            }


           // using (Entities context = Controller<Entities, DbSet>.SetContext())
           // {
                if (radioButtonActiveApplications.Checked == true)
                {
                    if (comboBoxCompaniesFilter.SelectedItem.ToString() != "")
                    {
                        //var rolesbyCompanyAndStatus = context.Roles.Where(x => x.Company.CompanyName == selectedCompany && x => x.Status == "active");

                        //listBoxJobPositions.DataSource = rolesbyCompanyAndStatus.ToList();
                    }
                    else
                    {
                        FillRolesListBox();
                    }
                }
                if (radioButtonFinalizedApplications.Checked == true)
                {

                    if (comboBoxCompaniesFilter.SelectedItem.ToString() != "")
                    {
                        //var rolesbyCompanyAndStatus = context.Roles.Where(x => x.Company.CompanyName == selectedCompany && x => x.Status == "finalized");

                        //listBoxJobPositions.DataSource = rolesByCompany.ToList();
                    }
                    var selectedStatus = "finalized";
                    //var rolesbyStatus = context.Roles.Where(x => x.Status == selectedStatus);

                    //listBoxJobPositions.DataSource = rolesByStatus.ToList();

              //  }
            }
        }

        private void UpdateDashboard() {
            this.role = listBoxJobPositions.SelectedItem.ToString();

            //Not sure, must test this
            //if (!(listBox1.SelectedItem is Department department))
            //    return;
            //label1.Text = department.DepartmentCode;
            //label2.Text = department.DepartmentName;

            labelSelectedRoleOutput.Text = role;
            //labelStatusOutput.Text = ;
            labelNumberOfRoundsOutput.ResetText();
            labelCurrentRoundOutput.ResetText();
            labelNumberOfCandidatesOutput.ResetText();
            labelDateRoleOpenedOutput.ResetText();
            labelDateRoleFinalizesOutput.ResetText();
            labelSalaryOutput.ResetText();
            labelRoleDescriptionOutput.ResetText();
            //}
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
