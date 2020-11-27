namespace RecruitmentDashboardForm
{
    partial class RecruiterDashboardMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelFilters = new System.Windows.Forms.Label();
            this.labelDashboard = new System.Windows.Forms.Label();
            this.groupBoxApplicationStatusFilters = new System.Windows.Forms.GroupBox();
            this.radioButtonFinalizedApplications = new System.Windows.Forms.RadioButton();
            this.radioButtonActiveApplications = new System.Windows.Forms.RadioButton();
            this.labelCompanies = new System.Windows.Forms.Label();
            this.comboBoxCompaniesFilter = new System.Windows.Forms.ComboBox();
            this.labelSelectaRole = new System.Windows.Forms.Label();
            this.listBoxJobPositions = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonBackupDB = new System.Windows.Forms.Button();
            this.buttonUpdateRole = new System.Windows.Forms.Button();
            this.dataGridViewCompanyInformation = new System.Windows.Forms.DataGridView();
            this.labelCompanyInformation = new System.Windows.Forms.Label();
            this.labelRoleDescriptionOutput = new System.Windows.Forms.Label();
            this.labelRoleDescription = new System.Windows.Forms.Label();
            this.labelSelectedRoleOutput = new System.Windows.Forms.Label();
            this.labelSelectedPosition = new System.Windows.Forms.Label();
            this.labelStatusDateOutput = new System.Windows.Forms.Label();
            this.labelStatusDate = new System.Windows.Forms.Label();
            this.labelDateRoleSubmittedOutput = new System.Windows.Forms.Label();
            this.labelDateSubmitted = new System.Windows.Forms.Label();
            this.dataGridViewPerksOutput = new System.Windows.Forms.DataGridView();
            this.labelPerks = new System.Windows.Forms.Label();
            this.labelSalaryOutput = new System.Windows.Forms.Label();
            this.labelSalary = new System.Windows.Forms.Label();
            this.labelNumberOfCandidatesOutput = new System.Windows.Forms.Label();
            this.labelNumberOfCandidates = new System.Windows.Forms.Label();
            this.labelCurrentRoundOutput = new System.Windows.Forms.Label();
            this.labelCurrentRound = new System.Windows.Forms.Label();
            this.labelNumberOfRoundsOutput = new System.Windows.Forms.Label();
            this.labelNumberOfRounds = new System.Windows.Forms.Label();
            this.labelStatusOutput = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.groupBoxApplicationStatusFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompanyInformation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPerksOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // labelFilters
            // 
            this.labelFilters.AutoSize = true;
            this.labelFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilters.Location = new System.Drawing.Point(105, 21);
            this.labelFilters.Name = "labelFilters";
            this.labelFilters.Size = new System.Drawing.Size(67, 24);
            this.labelFilters.TabIndex = 0;
            this.labelFilters.Text = "Filters";
            // 
            // labelDashboard
            // 
            this.labelDashboard.AutoSize = true;
            this.labelDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDashboard.Location = new System.Drawing.Point(733, 21);
            this.labelDashboard.Name = "labelDashboard";
            this.labelDashboard.Size = new System.Drawing.Size(202, 24);
            this.labelDashboard.TabIndex = 1;
            this.labelDashboard.Text = "Recruiter Dashboard";
            // 
            // groupBoxApplicationStatusFilters
            // 
            this.groupBoxApplicationStatusFilters.Controls.Add(this.radioButtonFinalizedApplications);
            this.groupBoxApplicationStatusFilters.Controls.Add(this.radioButtonActiveApplications);
            this.groupBoxApplicationStatusFilters.Location = new System.Drawing.Point(19, 61);
            this.groupBoxApplicationStatusFilters.Name = "groupBoxApplicationStatusFilters";
            this.groupBoxApplicationStatusFilters.Size = new System.Drawing.Size(240, 57);
            this.groupBoxApplicationStatusFilters.TabIndex = 2;
            this.groupBoxApplicationStatusFilters.TabStop = false;
            this.groupBoxApplicationStatusFilters.Text = "Application Status";
            // 
            // radioButtonFinalizedApplications
            // 
            this.radioButtonFinalizedApplications.AutoSize = true;
            this.radioButtonFinalizedApplications.Location = new System.Drawing.Point(135, 24);
            this.radioButtonFinalizedApplications.Name = "radioButtonFinalizedApplications";
            this.radioButtonFinalizedApplications.Size = new System.Drawing.Size(66, 17);
            this.radioButtonFinalizedApplications.TabIndex = 1;
            this.radioButtonFinalizedApplications.TabStop = true;
            this.radioButtonFinalizedApplications.Text = "Finalized";
            this.radioButtonFinalizedApplications.UseVisualStyleBackColor = true;
            // 
            // radioButtonActiveApplications
            // 
            this.radioButtonActiveApplications.AutoSize = true;
            this.radioButtonActiveApplications.Location = new System.Drawing.Point(37, 23);
            this.radioButtonActiveApplications.Name = "radioButtonActiveApplications";
            this.radioButtonActiveApplications.Size = new System.Drawing.Size(55, 17);
            this.radioButtonActiveApplications.TabIndex = 0;
            this.radioButtonActiveApplications.TabStop = true;
            this.radioButtonActiveApplications.Text = "Active";
            this.radioButtonActiveApplications.UseVisualStyleBackColor = true;
            // 
            // labelCompanies
            // 
            this.labelCompanies.AutoSize = true;
            this.labelCompanies.Location = new System.Drawing.Point(19, 143);
            this.labelCompanies.Name = "labelCompanies";
            this.labelCompanies.Size = new System.Drawing.Size(59, 13);
            this.labelCompanies.TabIndex = 3;
            this.labelCompanies.Text = "Companies";
            // 
            // comboBoxCompaniesFilter
            // 
            this.comboBoxCompaniesFilter.FormattingEnabled = true;
            this.comboBoxCompaniesFilter.Location = new System.Drawing.Point(85, 139);
            this.comboBoxCompaniesFilter.Name = "comboBoxCompaniesFilter";
            this.comboBoxCompaniesFilter.Size = new System.Drawing.Size(174, 21);
            this.comboBoxCompaniesFilter.TabIndex = 4;
            // 
            // labelSelectaRole
            // 
            this.labelSelectaRole.AutoSize = true;
            this.labelSelectaRole.Location = new System.Drawing.Point(22, 182);
            this.labelSelectaRole.Name = "labelSelectaRole";
            this.labelSelectaRole.Size = new System.Drawing.Size(71, 13);
            this.labelSelectaRole.TabIndex = 5;
            this.labelSelectaRole.Text = "Select a Role";
            // 
            // listBoxJobPositions
            // 
            this.listBoxJobPositions.FormattingEnabled = true;
            this.listBoxJobPositions.Location = new System.Drawing.Point(27, 197);
            this.listBoxJobPositions.Name = "listBoxJobPositions";
            this.listBoxJobPositions.Size = new System.Drawing.Size(232, 433);
            this.listBoxJobPositions.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1155, 527);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 24);
            this.label3.TabIndex = 44;
            this.label3.Text = "Admin Tools";
            // 
            // buttonBackupDB
            // 
            this.buttonBackupDB.Location = new System.Drawing.Point(1138, 566);
            this.buttonBackupDB.Name = "buttonBackupDB";
            this.buttonBackupDB.Size = new System.Drawing.Size(168, 52);
            this.buttonBackupDB.TabIndex = 45;
            this.buttonBackupDB.Text = "Backup Database";
            this.buttonBackupDB.UseVisualStyleBackColor = true;
            // 
            // buttonUpdateRole
            // 
            this.buttonUpdateRole.Location = new System.Drawing.Point(378, 407);
            this.buttonUpdateRole.Name = "buttonUpdateRole";
            this.buttonUpdateRole.Size = new System.Drawing.Size(168, 52);
            this.buttonUpdateRole.TabIndex = 69;
            this.buttonUpdateRole.Text = "Update Applicantion Progress";
            this.buttonUpdateRole.UseVisualStyleBackColor = true;
            // 
            // dataGridViewCompanyInformation
            // 
            this.dataGridViewCompanyInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCompanyInformation.Location = new System.Drawing.Point(930, 348);
            this.dataGridViewCompanyInformation.Name = "dataGridViewCompanyInformation";
            this.dataGridViewCompanyInformation.Size = new System.Drawing.Size(357, 110);
            this.dataGridViewCompanyInformation.TabIndex = 68;
            // 
            // labelCompanyInformation
            // 
            this.labelCompanyInformation.AutoSize = true;
            this.labelCompanyInformation.Location = new System.Drawing.Point(930, 332);
            this.labelCompanyInformation.Name = "labelCompanyInformation";
            this.labelCompanyInformation.Size = new System.Drawing.Size(106, 13);
            this.labelCompanyInformation.TabIndex = 67;
            this.labelCompanyInformation.Text = "Company Information";
            // 
            // labelRoleDescriptionOutput
            // 
            this.labelRoleDescriptionOutput.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelRoleDescriptionOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelRoleDescriptionOutput.Location = new System.Drawing.Point(625, 160);
            this.labelRoleDescriptionOutput.Name = "labelRoleDescriptionOutput";
            this.labelRoleDescriptionOutput.Size = new System.Drawing.Size(264, 298);
            this.labelRoleDescriptionOutput.TabIndex = 66;
            // 
            // labelRoleDescription
            // 
            this.labelRoleDescription.AutoSize = true;
            this.labelRoleDescription.Location = new System.Drawing.Point(622, 144);
            this.labelRoleDescription.Name = "labelRoleDescription";
            this.labelRoleDescription.Size = new System.Drawing.Size(85, 13);
            this.labelRoleDescription.TabIndex = 65;
            this.labelRoleDescription.Text = "Role Description";
            // 
            // labelSelectedRoleOutput
            // 
            this.labelSelectedRoleOutput.BackColor = System.Drawing.SystemColors.Control;
            this.labelSelectedRoleOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelSelectedRoleOutput.Location = new System.Drawing.Point(470, 79);
            this.labelSelectedRoleOutput.Name = "labelSelectedRoleOutput";
            this.labelSelectedRoleOutput.Size = new System.Drawing.Size(197, 23);
            this.labelSelectedRoleOutput.TabIndex = 64;
            // 
            // labelSelectedPosition
            // 
            this.labelSelectedPosition.AutoSize = true;
            this.labelSelectedPosition.BackColor = System.Drawing.SystemColors.Control;
            this.labelSelectedPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectedPosition.Location = new System.Drawing.Point(358, 84);
            this.labelSelectedPosition.Name = "labelSelectedPosition";
            this.labelSelectedPosition.Size = new System.Drawing.Size(87, 13);
            this.labelSelectedPosition.TabIndex = 63;
            this.labelSelectedPosition.Text = "Selected Role";
            // 
            // labelStatusDateOutput
            // 
            this.labelStatusDateOutput.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelStatusDateOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelStatusDateOutput.Location = new System.Drawing.Point(450, 321);
            this.labelStatusDateOutput.Name = "labelStatusDateOutput";
            this.labelStatusDateOutput.Size = new System.Drawing.Size(111, 23);
            this.labelStatusDateOutput.TabIndex = 62;
            this.labelStatusDateOutput.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelStatusDate
            // 
            this.labelStatusDate.AutoSize = true;
            this.labelStatusDate.Location = new System.Drawing.Point(358, 326);
            this.labelStatusDate.Name = "labelStatusDate";
            this.labelStatusDate.Size = new System.Drawing.Size(63, 13);
            this.labelStatusDate.TabIndex = 61;
            this.labelStatusDate.Text = "Status Date";
            // 
            // labelDateRoleSubmittedOutput
            // 
            this.labelDateRoleSubmittedOutput.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelDateRoleSubmittedOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDateRoleSubmittedOutput.Location = new System.Drawing.Point(450, 285);
            this.labelDateRoleSubmittedOutput.Name = "labelDateRoleSubmittedOutput";
            this.labelDateRoleSubmittedOutput.Size = new System.Drawing.Size(111, 23);
            this.labelDateRoleSubmittedOutput.TabIndex = 60;
            this.labelDateRoleSubmittedOutput.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelDateSubmitted
            // 
            this.labelDateSubmitted.AutoSize = true;
            this.labelDateSubmitted.Location = new System.Drawing.Point(358, 290);
            this.labelDateSubmitted.Name = "labelDateSubmitted";
            this.labelDateSubmitted.Size = new System.Drawing.Size(80, 13);
            this.labelDateSubmitted.TabIndex = 59;
            this.labelDateSubmitted.Text = "Date Submitted";
            // 
            // dataGridViewPerksOutput
            // 
            this.dataGridViewPerksOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPerksOutput.Location = new System.Drawing.Point(930, 160);
            this.dataGridViewPerksOutput.Name = "dataGridViewPerksOutput";
            this.dataGridViewPerksOutput.Size = new System.Drawing.Size(357, 157);
            this.dataGridViewPerksOutput.TabIndex = 58;
            // 
            // labelPerks
            // 
            this.labelPerks.AutoSize = true;
            this.labelPerks.Location = new System.Drawing.Point(930, 144);
            this.labelPerks.Name = "labelPerks";
            this.labelPerks.Size = new System.Drawing.Size(34, 13);
            this.labelPerks.TabIndex = 57;
            this.labelPerks.Text = "Perks";
            // 
            // labelSalaryOutput
            // 
            this.labelSalaryOutput.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelSalaryOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelSalaryOutput.Location = new System.Drawing.Point(450, 357);
            this.labelSalaryOutput.Name = "labelSalaryOutput";
            this.labelSalaryOutput.Size = new System.Drawing.Size(111, 23);
            this.labelSalaryOutput.TabIndex = 56;
            this.labelSalaryOutput.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelSalary
            // 
            this.labelSalary.AutoSize = true;
            this.labelSalary.Location = new System.Drawing.Point(358, 362);
            this.labelSalary.Name = "labelSalary";
            this.labelSalary.Size = new System.Drawing.Size(77, 13);
            this.labelSalary.TabIndex = 55;
            this.labelSalary.Text = "Salary (annual)";
            // 
            // labelNumberOfCandidatesOutput
            // 
            this.labelNumberOfCandidatesOutput.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelNumberOfCandidatesOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelNumberOfCandidatesOutput.Location = new System.Drawing.Point(494, 249);
            this.labelNumberOfCandidatesOutput.Name = "labelNumberOfCandidatesOutput";
            this.labelNumberOfCandidatesOutput.Size = new System.Drawing.Size(67, 23);
            this.labelNumberOfCandidatesOutput.TabIndex = 54;
            this.labelNumberOfCandidatesOutput.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelNumberOfCandidates
            // 
            this.labelNumberOfCandidates.AutoSize = true;
            this.labelNumberOfCandidates.Location = new System.Drawing.Point(358, 254);
            this.labelNumberOfCandidates.Name = "labelNumberOfCandidates";
            this.labelNumberOfCandidates.Size = new System.Drawing.Size(112, 13);
            this.labelNumberOfCandidates.TabIndex = 53;
            this.labelNumberOfCandidates.Text = "Number of Candidates";
            // 
            // labelCurrentRoundOutput
            // 
            this.labelCurrentRoundOutput.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelCurrentRoundOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCurrentRoundOutput.Location = new System.Drawing.Point(494, 213);
            this.labelCurrentRoundOutput.Name = "labelCurrentRoundOutput";
            this.labelCurrentRoundOutput.Size = new System.Drawing.Size(67, 23);
            this.labelCurrentRoundOutput.TabIndex = 52;
            this.labelCurrentRoundOutput.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelCurrentRound
            // 
            this.labelCurrentRound.AutoSize = true;
            this.labelCurrentRound.Location = new System.Drawing.Point(358, 218);
            this.labelCurrentRound.Name = "labelCurrentRound";
            this.labelCurrentRound.Size = new System.Drawing.Size(76, 13);
            this.labelCurrentRound.TabIndex = 51;
            this.labelCurrentRound.Text = "Current Round";
            // 
            // labelNumberOfRoundsOutput
            // 
            this.labelNumberOfRoundsOutput.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelNumberOfRoundsOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelNumberOfRoundsOutput.Location = new System.Drawing.Point(494, 177);
            this.labelNumberOfRoundsOutput.Name = "labelNumberOfRoundsOutput";
            this.labelNumberOfRoundsOutput.Size = new System.Drawing.Size(67, 23);
            this.labelNumberOfRoundsOutput.TabIndex = 50;
            this.labelNumberOfRoundsOutput.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelNumberOfRounds
            // 
            this.labelNumberOfRounds.AutoSize = true;
            this.labelNumberOfRounds.Location = new System.Drawing.Point(358, 182);
            this.labelNumberOfRounds.Name = "labelNumberOfRounds";
            this.labelNumberOfRounds.Size = new System.Drawing.Size(96, 13);
            this.labelNumberOfRounds.TabIndex = 49;
            this.labelNumberOfRounds.Text = "Number of Rounds";
            // 
            // labelStatusOutput
            // 
            this.labelStatusOutput.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelStatusOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelStatusOutput.Location = new System.Drawing.Point(427, 141);
            this.labelStatusOutput.Name = "labelStatusOutput";
            this.labelStatusOutput.Size = new System.Drawing.Size(134, 23);
            this.labelStatusOutput.TabIndex = 48;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(358, 146);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(62, 13);
            this.labelStatus.TabIndex = 47;
            this.labelStatus.Text = "Role Status";
            // 
            // RecruiterDashboardMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 645);
            this.Controls.Add(this.buttonUpdateRole);
            this.Controls.Add(this.dataGridViewCompanyInformation);
            this.Controls.Add(this.labelCompanyInformation);
            this.Controls.Add(this.labelRoleDescriptionOutput);
            this.Controls.Add(this.labelRoleDescription);
            this.Controls.Add(this.labelSelectedRoleOutput);
            this.Controls.Add(this.labelSelectedPosition);
            this.Controls.Add(this.labelStatusDateOutput);
            this.Controls.Add(this.labelStatusDate);
            this.Controls.Add(this.labelDateRoleSubmittedOutput);
            this.Controls.Add(this.labelDateSubmitted);
            this.Controls.Add(this.dataGridViewPerksOutput);
            this.Controls.Add(this.labelPerks);
            this.Controls.Add(this.labelSalaryOutput);
            this.Controls.Add(this.labelSalary);
            this.Controls.Add(this.labelNumberOfCandidatesOutput);
            this.Controls.Add(this.labelNumberOfCandidates);
            this.Controls.Add(this.labelCurrentRoundOutput);
            this.Controls.Add(this.labelCurrentRound);
            this.Controls.Add(this.labelNumberOfRoundsOutput);
            this.Controls.Add(this.labelNumberOfRounds);
            this.Controls.Add(this.labelStatusOutput);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.buttonBackupDB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBoxJobPositions);
            this.Controls.Add(this.labelSelectaRole);
            this.Controls.Add(this.comboBoxCompaniesFilter);
            this.Controls.Add(this.labelCompanies);
            this.Controls.Add(this.groupBoxApplicationStatusFilters);
            this.Controls.Add(this.labelDashboard);
            this.Controls.Add(this.labelFilters);
            this.Name = "RecruiterDashboardMainForm";
            this.Text = "Form1";
            this.groupBoxApplicationStatusFilters.ResumeLayout(false);
            this.groupBoxApplicationStatusFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompanyInformation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPerksOutput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFilters;
        private System.Windows.Forms.Label labelDashboard;
        private System.Windows.Forms.GroupBox groupBoxApplicationStatusFilters;
        private System.Windows.Forms.RadioButton radioButtonFinalizedApplications;
        private System.Windows.Forms.RadioButton radioButtonActiveApplications;
        private System.Windows.Forms.Label labelCompanies;
        private System.Windows.Forms.ComboBox comboBoxCompaniesFilter;
        private System.Windows.Forms.Label labelSelectaRole;
        private System.Windows.Forms.ListBox listBoxJobPositions;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonBackupDB;
        private System.Windows.Forms.Button buttonUpdateRole;
        private System.Windows.Forms.DataGridView dataGridViewCompanyInformation;
        private System.Windows.Forms.Label labelCompanyInformation;
        private System.Windows.Forms.Label labelRoleDescriptionOutput;
        private System.Windows.Forms.Label labelRoleDescription;
        private System.Windows.Forms.Label labelSelectedRoleOutput;
        private System.Windows.Forms.Label labelSelectedPosition;
        private System.Windows.Forms.Label labelStatusDateOutput;
        private System.Windows.Forms.Label labelStatusDate;
        private System.Windows.Forms.Label labelDateRoleSubmittedOutput;
        private System.Windows.Forms.Label labelDateSubmitted;
        private System.Windows.Forms.DataGridView dataGridViewPerksOutput;
        private System.Windows.Forms.Label labelPerks;
        private System.Windows.Forms.Label labelSalaryOutput;
        private System.Windows.Forms.Label labelSalary;
        private System.Windows.Forms.Label labelNumberOfCandidatesOutput;
        private System.Windows.Forms.Label labelNumberOfCandidates;
        private System.Windows.Forms.Label labelCurrentRoundOutput;
        private System.Windows.Forms.Label labelCurrentRound;
        private System.Windows.Forms.Label labelNumberOfRoundsOutput;
        private System.Windows.Forms.Label labelNumberOfRounds;
        private System.Windows.Forms.Label labelStatusOutput;
        private System.Windows.Forms.Label labelStatus;
    }
}

