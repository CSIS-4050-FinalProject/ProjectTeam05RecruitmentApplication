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
            this.labelJobFilters = new System.Windows.Forms.Label();
            this.labelDashboard = new System.Windows.Forms.Label();
            this.groupBoxRoleStatusFilters = new System.Windows.Forms.GroupBox();
            this.radioButtonFinalizedApplications = new System.Windows.Forms.RadioButton();
            this.radioButtonActiveApplications = new System.Windows.Forms.RadioButton();
            this.labelCompanies = new System.Windows.Forms.Label();
            this.comboBoxCompaniesFilter = new System.Windows.Forms.ComboBox();
            this.labelSelectaRole = new System.Windows.Forms.Label();
            this.listBoxJobPositions = new System.Windows.Forms.ListBox();
            this.labelAdminTools = new System.Windows.Forms.Label();
            this.buttonBackupDB = new System.Windows.Forms.Button();
            this.buttonUpdateApplication = new System.Windows.Forms.Button();
            this.labelCompanyInformation = new System.Windows.Forms.Label();
            this.labelSelectedRoleOutput = new System.Windows.Forms.Label();
            this.labelSelectedPosition = new System.Windows.Forms.Label();
            this.dataGridViewPerksOutput = new System.Windows.Forms.DataGridView();
            this.labelPerks = new System.Windows.Forms.Label();
            this.labelSalaryOutput = new System.Windows.Forms.Label();
            this.labelSalary = new System.Windows.Forms.Label();
            this.labelNumberOfCandidatesOutput = new System.Windows.Forms.Label();
            this.labelNumberOfCandidates = new System.Windows.Forms.Label();
            this.labelNumberOfRoundsOutput = new System.Windows.Forms.Label();
            this.labelNumberOfRounds = new System.Windows.Forms.Label();
            this.labelRoleStatusOutput = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelCompanyName = new System.Windows.Forms.Label();
            this.labelHiringDepartment = new System.Windows.Forms.Label();
            this.labelHiringManager = new System.Windows.Forms.Label();
            this.labelCompanySize = new System.Windows.Forms.Label();
            this.labelCompanyNameOutput = new System.Windows.Forms.Label();
            this.labelHiringDepartmentOutput = new System.Windows.Forms.Label();
            this.labelHiringManagerOutput = new System.Windows.Forms.Label();
            this.labelCompanySizeOutput = new System.Windows.Forms.Label();
            this.dataGridViewApplicationDetails = new System.Windows.Forms.DataGridView();
            this.labelApplicationDetails = new System.Windows.Forms.Label();
            this.labelRoleInformation = new System.Windows.Forms.Label();
            this.labelHowToMainForm = new System.Windows.Forms.Label();
            this.labelMainFormStep1 = new System.Windows.Forms.Label();
            this.labelMainFormStep2 = new System.Windows.Forms.Label();
            this.labelStep1Details = new System.Windows.Forms.Label();
            this.labelStep2Details = new System.Windows.Forms.Label();
            this.labelSep3Details = new System.Windows.Forms.Label();
            this.labelMainFormStep3 = new System.Windows.Forms.Label();
            this.labelStep4Details = new System.Windows.Forms.Label();
            this.labelStep4 = new System.Windows.Forms.Label();
            this.groupBoxRoleStatusFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPerksOutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewApplicationDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // labelJobFilters
            // 
            this.labelJobFilters.AutoSize = true;
            this.labelJobFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJobFilters.Location = new System.Drawing.Point(36, 50);
            this.labelJobFilters.Name = "labelJobFilters";
            this.labelJobFilters.Size = new System.Drawing.Size(116, 24);
            this.labelJobFilters.TabIndex = 0;
            this.labelJobFilters.Text = "Role Filters";
            // 
            // labelDashboard
            // 
            this.labelDashboard.AutoSize = true;
            this.labelDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDashboard.Location = new System.Drawing.Point(725, 9);
            this.labelDashboard.Name = "labelDashboard";
            this.labelDashboard.Size = new System.Drawing.Size(202, 24);
            this.labelDashboard.TabIndex = 1;
            this.labelDashboard.Text = "Recruiter Dashboard";
            // 
            // groupBoxRoleStatusFilters
            // 
            this.groupBoxRoleStatusFilters.Controls.Add(this.radioButtonFinalizedApplications);
            this.groupBoxRoleStatusFilters.Controls.Add(this.radioButtonActiveApplications);
            this.groupBoxRoleStatusFilters.Location = new System.Drawing.Point(6, 93);
            this.groupBoxRoleStatusFilters.Name = "groupBoxRoleStatusFilters";
            this.groupBoxRoleStatusFilters.Size = new System.Drawing.Size(188, 57);
            this.groupBoxRoleStatusFilters.TabIndex = 2;
            this.groupBoxRoleStatusFilters.TabStop = false;
            this.groupBoxRoleStatusFilters.Text = "Role Status";
            // 
            // radioButtonFinalizedApplications
            // 
            this.radioButtonFinalizedApplications.AutoSize = true;
            this.radioButtonFinalizedApplications.Location = new System.Drawing.Point(101, 24);
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
            this.radioButtonActiveApplications.Location = new System.Drawing.Point(19, 24);
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
            this.labelCompanies.Location = new System.Drawing.Point(6, 175);
            this.labelCompanies.Name = "labelCompanies";
            this.labelCompanies.Size = new System.Drawing.Size(59, 13);
            this.labelCompanies.TabIndex = 3;
            this.labelCompanies.Text = "Companies";
            // 
            // comboBoxCompaniesFilter
            // 
            this.comboBoxCompaniesFilter.FormattingEnabled = true;
            this.comboBoxCompaniesFilter.Location = new System.Drawing.Point(72, 171);
            this.comboBoxCompaniesFilter.Name = "comboBoxCompaniesFilter";
            this.comboBoxCompaniesFilter.Size = new System.Drawing.Size(122, 21);
            this.comboBoxCompaniesFilter.TabIndex = 4;
            // 
            // labelSelectaRole
            // 
            this.labelSelectaRole.AutoSize = true;
            this.labelSelectaRole.Location = new System.Drawing.Point(9, 214);
            this.labelSelectaRole.Name = "labelSelectaRole";
            this.labelSelectaRole.Size = new System.Drawing.Size(71, 13);
            this.labelSelectaRole.TabIndex = 5;
            this.labelSelectaRole.Text = "Select a Role";
            // 
            // listBoxJobPositions
            // 
            this.listBoxJobPositions.FormattingEnabled = true;
            this.listBoxJobPositions.Location = new System.Drawing.Point(14, 229);
            this.listBoxJobPositions.Name = "listBoxJobPositions";
            this.listBoxJobPositions.Size = new System.Drawing.Size(159, 433);
            this.listBoxJobPositions.TabIndex = 6;
            // 
            // labelAdminTools
            // 
            this.labelAdminTools.AutoSize = true;
            this.labelAdminTools.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdminTools.Location = new System.Drawing.Point(1272, 569);
            this.labelAdminTools.Name = "labelAdminTools";
            this.labelAdminTools.Size = new System.Drawing.Size(128, 24);
            this.labelAdminTools.TabIndex = 44;
            this.labelAdminTools.Text = "Admin Tools";
            // 
            // buttonBackupDB
            // 
            this.buttonBackupDB.Location = new System.Drawing.Point(1255, 608);
            this.buttonBackupDB.Name = "buttonBackupDB";
            this.buttonBackupDB.Size = new System.Drawing.Size(168, 52);
            this.buttonBackupDB.TabIndex = 45;
            this.buttonBackupDB.Text = "Backup Database";
            this.buttonBackupDB.UseVisualStyleBackColor = true;
            // 
            // buttonUpdateApplication
            // 
            this.buttonUpdateApplication.Location = new System.Drawing.Point(1044, 111);
            this.buttonUpdateApplication.Name = "buttonUpdateApplication";
            this.buttonUpdateApplication.Size = new System.Drawing.Size(168, 52);
            this.buttonUpdateApplication.TabIndex = 69;
            this.buttonUpdateApplication.Text = "Update Applicantion";
            this.buttonUpdateApplication.UseVisualStyleBackColor = true;
            // 
            // labelCompanyInformation
            // 
            this.labelCompanyInformation.AutoSize = true;
            this.labelCompanyInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCompanyInformation.Location = new System.Drawing.Point(303, 303);
            this.labelCompanyInformation.Name = "labelCompanyInformation";
            this.labelCompanyInformation.Size = new System.Drawing.Size(125, 13);
            this.labelCompanyInformation.TabIndex = 67;
            this.labelCompanyInformation.Text = "Company Information";
            // 
            // labelSelectedRoleOutput
            // 
            this.labelSelectedRoleOutput.BackColor = System.Drawing.SystemColors.Control;
            this.labelSelectedRoleOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelSelectedRoleOutput.Location = new System.Drawing.Point(405, 119);
            this.labelSelectedRoleOutput.Name = "labelSelectedRoleOutput";
            this.labelSelectedRoleOutput.Size = new System.Drawing.Size(134, 23);
            this.labelSelectedRoleOutput.TabIndex = 64;
            this.labelSelectedRoleOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSelectedPosition
            // 
            this.labelSelectedPosition.AutoSize = true;
            this.labelSelectedPosition.BackColor = System.Drawing.SystemColors.Control;
            this.labelSelectedPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectedPosition.Location = new System.Drawing.Point(303, 125);
            this.labelSelectedPosition.Name = "labelSelectedPosition";
            this.labelSelectedPosition.Size = new System.Drawing.Size(87, 13);
            this.labelSelectedPosition.TabIndex = 63;
            this.labelSelectedPosition.Text = "Selected Role";
            // 
            // dataGridViewPerksOutput
            // 
            this.dataGridViewPerksOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPerksOutput.Location = new System.Drawing.Point(228, 491);
            this.dataGridViewPerksOutput.Name = "dataGridViewPerksOutput";
            this.dataGridViewPerksOutput.Size = new System.Drawing.Size(306, 169);
            this.dataGridViewPerksOutput.TabIndex = 58;
            // 
            // labelPerks
            // 
            this.labelPerks.AutoSize = true;
            this.labelPerks.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPerks.Location = new System.Drawing.Point(228, 475);
            this.labelPerks.Name = "labelPerks";
            this.labelPerks.Size = new System.Drawing.Size(39, 13);
            this.labelPerks.TabIndex = 57;
            this.labelPerks.Text = "Perks";
            // 
            // labelSalaryOutput
            // 
            this.labelSalaryOutput.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelSalaryOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelSalaryOutput.Location = new System.Drawing.Point(405, 267);
            this.labelSalaryOutput.Name = "labelSalaryOutput";
            this.labelSalaryOutput.Size = new System.Drawing.Size(134, 23);
            this.labelSalaryOutput.TabIndex = 56;
            this.labelSalaryOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSalary
            // 
            this.labelSalary.AutoSize = true;
            this.labelSalary.Location = new System.Drawing.Point(318, 272);
            this.labelSalary.Name = "labelSalary";
            this.labelSalary.Size = new System.Drawing.Size(77, 13);
            this.labelSalary.TabIndex = 55;
            this.labelSalary.Text = "Salary (annual)";
            // 
            // labelNumberOfCandidatesOutput
            // 
            this.labelNumberOfCandidatesOutput.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelNumberOfCandidatesOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelNumberOfCandidatesOutput.Location = new System.Drawing.Point(405, 233);
            this.labelNumberOfCandidatesOutput.Name = "labelNumberOfCandidatesOutput";
            this.labelNumberOfCandidatesOutput.Size = new System.Drawing.Size(134, 23);
            this.labelNumberOfCandidatesOutput.TabIndex = 54;
            this.labelNumberOfCandidatesOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelNumberOfCandidates
            // 
            this.labelNumberOfCandidates.AutoSize = true;
            this.labelNumberOfCandidates.Location = new System.Drawing.Point(287, 239);
            this.labelNumberOfCandidates.Name = "labelNumberOfCandidates";
            this.labelNumberOfCandidates.Size = new System.Drawing.Size(112, 13);
            this.labelNumberOfCandidates.TabIndex = 53;
            this.labelNumberOfCandidates.Text = "Number of Candidates";
            // 
            // labelNumberOfRoundsOutput
            // 
            this.labelNumberOfRoundsOutput.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelNumberOfRoundsOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelNumberOfRoundsOutput.Location = new System.Drawing.Point(405, 196);
            this.labelNumberOfRoundsOutput.Name = "labelNumberOfRoundsOutput";
            this.labelNumberOfRoundsOutput.Size = new System.Drawing.Size(134, 23);
            this.labelNumberOfRoundsOutput.TabIndex = 50;
            this.labelNumberOfRoundsOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelNumberOfRounds
            // 
            this.labelNumberOfRounds.AutoSize = true;
            this.labelNumberOfRounds.Location = new System.Drawing.Point(299, 204);
            this.labelNumberOfRounds.Name = "labelNumberOfRounds";
            this.labelNumberOfRounds.Size = new System.Drawing.Size(96, 13);
            this.labelNumberOfRounds.TabIndex = 49;
            this.labelNumberOfRounds.Text = "Number of Rounds";
            // 
            // labelRoleStatusOutput
            // 
            this.labelRoleStatusOutput.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelRoleStatusOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelRoleStatusOutput.Location = new System.Drawing.Point(405, 160);
            this.labelRoleStatusOutput.Name = "labelRoleStatusOutput";
            this.labelRoleStatusOutput.Size = new System.Drawing.Size(134, 23);
            this.labelRoleStatusOutput.TabIndex = 48;
            this.labelRoleStatusOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(328, 170);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(62, 13);
            this.labelStatus.TabIndex = 47;
            this.labelStatus.Text = "Role Status";
            // 
            // labelCompanyName
            // 
            this.labelCompanyName.AutoSize = true;
            this.labelCompanyName.Location = new System.Drawing.Point(313, 336);
            this.labelCompanyName.Name = "labelCompanyName";
            this.labelCompanyName.Size = new System.Drawing.Size(82, 13);
            this.labelCompanyName.TabIndex = 72;
            this.labelCompanyName.Text = "Company Name";
            // 
            // labelHiringDepartment
            // 
            this.labelHiringDepartment.AutoSize = true;
            this.labelHiringDepartment.Location = new System.Drawing.Point(307, 373);
            this.labelHiringDepartment.Name = "labelHiringDepartment";
            this.labelHiringDepartment.Size = new System.Drawing.Size(92, 13);
            this.labelHiringDepartment.TabIndex = 73;
            this.labelHiringDepartment.Text = "Hiring Department";
            // 
            // labelHiringManager
            // 
            this.labelHiringManager.AutoSize = true;
            this.labelHiringManager.Location = new System.Drawing.Point(316, 409);
            this.labelHiringManager.Name = "labelHiringManager";
            this.labelHiringManager.Size = new System.Drawing.Size(79, 13);
            this.labelHiringManager.TabIndex = 74;
            this.labelHiringManager.Text = "Hiring Manager";
            // 
            // labelCompanySize
            // 
            this.labelCompanySize.AutoSize = true;
            this.labelCompanySize.Location = new System.Drawing.Point(321, 445);
            this.labelCompanySize.Name = "labelCompanySize";
            this.labelCompanySize.Size = new System.Drawing.Size(74, 13);
            this.labelCompanySize.TabIndex = 75;
            this.labelCompanySize.Text = "Company Size";
            // 
            // labelCompanyNameOutput
            // 
            this.labelCompanyNameOutput.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelCompanyNameOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCompanyNameOutput.Location = new System.Drawing.Point(405, 326);
            this.labelCompanyNameOutput.Name = "labelCompanyNameOutput";
            this.labelCompanyNameOutput.Size = new System.Drawing.Size(134, 23);
            this.labelCompanyNameOutput.TabIndex = 76;
            this.labelCompanyNameOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelHiringDepartmentOutput
            // 
            this.labelHiringDepartmentOutput.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelHiringDepartmentOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelHiringDepartmentOutput.Location = new System.Drawing.Point(405, 363);
            this.labelHiringDepartmentOutput.Name = "labelHiringDepartmentOutput";
            this.labelHiringDepartmentOutput.Size = new System.Drawing.Size(134, 23);
            this.labelHiringDepartmentOutput.TabIndex = 77;
            this.labelHiringDepartmentOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelHiringManagerOutput
            // 
            this.labelHiringManagerOutput.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelHiringManagerOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelHiringManagerOutput.Location = new System.Drawing.Point(405, 399);
            this.labelHiringManagerOutput.Name = "labelHiringManagerOutput";
            this.labelHiringManagerOutput.Size = new System.Drawing.Size(134, 23);
            this.labelHiringManagerOutput.TabIndex = 78;
            this.labelHiringManagerOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCompanySizeOutput
            // 
            this.labelCompanySizeOutput.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelCompanySizeOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCompanySizeOutput.Location = new System.Drawing.Point(405, 435);
            this.labelCompanySizeOutput.Name = "labelCompanySizeOutput";
            this.labelCompanySizeOutput.Size = new System.Drawing.Size(134, 23);
            this.labelCompanySizeOutput.TabIndex = 79;
            this.labelCompanySizeOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridViewApplicationDetails
            // 
            this.dataGridViewApplicationDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewApplicationDetails.Location = new System.Drawing.Point(571, 169);
            this.dataGridViewApplicationDetails.Name = "dataGridViewApplicationDetails";
            this.dataGridViewApplicationDetails.Size = new System.Drawing.Size(641, 491);
            this.dataGridViewApplicationDetails.TabIndex = 80;
            // 
            // labelApplicationDetails
            // 
            this.labelApplicationDetails.AutoSize = true;
            this.labelApplicationDetails.Location = new System.Drawing.Point(568, 153);
            this.labelApplicationDetails.Name = "labelApplicationDetails";
            this.labelApplicationDetails.Size = new System.Drawing.Size(94, 13);
            this.labelApplicationDetails.TabIndex = 81;
            this.labelApplicationDetails.Text = "Application Details";
            // 
            // labelRoleInformation
            // 
            this.labelRoleInformation.AutoSize = true;
            this.labelRoleInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRoleInformation.Location = new System.Drawing.Point(372, 50);
            this.labelRoleInformation.Name = "labelRoleInformation";
            this.labelRoleInformation.Size = new System.Drawing.Size(162, 24);
            this.labelRoleInformation.TabIndex = 84;
            this.labelRoleInformation.Text = "Role Information";
            // 
            // labelHowToMainForm
            // 
            this.labelHowToMainForm.AutoSize = true;
            this.labelHowToMainForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHowToMainForm.Location = new System.Drawing.Point(1251, 76);
            this.labelHowToMainForm.Name = "labelHowToMainForm";
            this.labelHowToMainForm.Size = new System.Drawing.Size(190, 20);
            this.labelHowToMainForm.TabIndex = 90;
            this.labelHowToMainForm.Text = "How To Use This Form";
            // 
            // labelMainFormStep1
            // 
            this.labelMainFormStep1.AutoSize = true;
            this.labelMainFormStep1.Location = new System.Drawing.Point(1255, 117);
            this.labelMainFormStep1.Name = "labelMainFormStep1";
            this.labelMainFormStep1.Size = new System.Drawing.Size(38, 13);
            this.labelMainFormStep1.TabIndex = 91;
            this.labelMainFormStep1.Text = "Step 1";
            // 
            // labelMainFormStep2
            // 
            this.labelMainFormStep2.AutoSize = true;
            this.labelMainFormStep2.Location = new System.Drawing.Point(1255, 202);
            this.labelMainFormStep2.Name = "labelMainFormStep2";
            this.labelMainFormStep2.Size = new System.Drawing.Size(38, 13);
            this.labelMainFormStep2.TabIndex = 92;
            this.labelMainFormStep2.Text = "Step 2";
            // 
            // labelStep1Details
            // 
            this.labelStep1Details.Location = new System.Drawing.Point(1314, 117);
            this.labelStep1Details.Name = "labelStep1Details";
            this.labelStep1Details.Size = new System.Drawing.Size(145, 71);
            this.labelStep1Details.TabIndex = 93;
            this.labelStep1Details.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelStep2Details
            // 
            this.labelStep2Details.Location = new System.Drawing.Point(1314, 201);
            this.labelStep2Details.Name = "labelStep2Details";
            this.labelStep2Details.Size = new System.Drawing.Size(145, 71);
            this.labelStep2Details.TabIndex = 94;
            this.labelStep2Details.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelSep3Details
            // 
            this.labelSep3Details.Location = new System.Drawing.Point(1314, 294);
            this.labelSep3Details.Name = "labelSep3Details";
            this.labelSep3Details.Size = new System.Drawing.Size(145, 43);
            this.labelSep3Details.TabIndex = 96;
            this.labelSep3Details.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelMainFormStep3
            // 
            this.labelMainFormStep3.AutoSize = true;
            this.labelMainFormStep3.Location = new System.Drawing.Point(1255, 295);
            this.labelMainFormStep3.Name = "labelMainFormStep3";
            this.labelMainFormStep3.Size = new System.Drawing.Size(38, 13);
            this.labelMainFormStep3.TabIndex = 95;
            this.labelMainFormStep3.Text = "Step 3";
            // 
            // labelStep4Details
            // 
            this.labelStep4Details.Location = new System.Drawing.Point(1314, 356);
            this.labelStep4Details.Name = "labelStep4Details";
            this.labelStep4Details.Size = new System.Drawing.Size(145, 71);
            this.labelStep4Details.TabIndex = 98;
            this.labelStep4Details.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelStep4
            // 
            this.labelStep4.AutoSize = true;
            this.labelStep4.Location = new System.Drawing.Point(1255, 357);
            this.labelStep4.Name = "labelStep4";
            this.labelStep4.Size = new System.Drawing.Size(38, 13);
            this.labelStep4.TabIndex = 97;
            this.labelStep4.Text = "Step 4";
            // 
            // RecruiterDashboardMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1474, 673);
            this.Controls.Add(this.labelStep4Details);
            this.Controls.Add(this.labelStep4);
            this.Controls.Add(this.labelSep3Details);
            this.Controls.Add(this.labelMainFormStep3);
            this.Controls.Add(this.labelStep2Details);
            this.Controls.Add(this.labelStep1Details);
            this.Controls.Add(this.labelMainFormStep2);
            this.Controls.Add(this.labelMainFormStep1);
            this.Controls.Add(this.labelHowToMainForm);
            this.Controls.Add(this.labelRoleInformation);
            this.Controls.Add(this.labelApplicationDetails);
            this.Controls.Add(this.dataGridViewApplicationDetails);
            this.Controls.Add(this.labelCompanySizeOutput);
            this.Controls.Add(this.labelHiringManagerOutput);
            this.Controls.Add(this.labelHiringDepartmentOutput);
            this.Controls.Add(this.labelCompanyNameOutput);
            this.Controls.Add(this.labelCompanySize);
            this.Controls.Add(this.labelHiringManager);
            this.Controls.Add(this.labelHiringDepartment);
            this.Controls.Add(this.labelCompanyName);
            this.Controls.Add(this.buttonUpdateApplication);
            this.Controls.Add(this.labelCompanyInformation);
            this.Controls.Add(this.labelSelectedRoleOutput);
            this.Controls.Add(this.labelSelectedPosition);
            this.Controls.Add(this.dataGridViewPerksOutput);
            this.Controls.Add(this.labelPerks);
            this.Controls.Add(this.labelSalaryOutput);
            this.Controls.Add(this.labelSalary);
            this.Controls.Add(this.labelNumberOfCandidatesOutput);
            this.Controls.Add(this.labelNumberOfCandidates);
            this.Controls.Add(this.labelNumberOfRoundsOutput);
            this.Controls.Add(this.labelNumberOfRounds);
            this.Controls.Add(this.labelRoleStatusOutput);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.buttonBackupDB);
            this.Controls.Add(this.labelAdminTools);
            this.Controls.Add(this.listBoxJobPositions);
            this.Controls.Add(this.labelSelectaRole);
            this.Controls.Add(this.comboBoxCompaniesFilter);
            this.Controls.Add(this.labelCompanies);
            this.Controls.Add(this.groupBoxRoleStatusFilters);
            this.Controls.Add(this.labelDashboard);
            this.Controls.Add(this.labelJobFilters);
            this.Name = "RecruiterDashboardMainForm";
            this.Text = "Form1";
            this.groupBoxRoleStatusFilters.ResumeLayout(false);
            this.groupBoxRoleStatusFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPerksOutput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewApplicationDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelJobFilters;
        private System.Windows.Forms.Label labelDashboard;
        private System.Windows.Forms.GroupBox groupBoxRoleStatusFilters;
        private System.Windows.Forms.RadioButton radioButtonFinalizedApplications;
        private System.Windows.Forms.RadioButton radioButtonActiveApplications;
        private System.Windows.Forms.Label labelCompanies;
        private System.Windows.Forms.ComboBox comboBoxCompaniesFilter;
        private System.Windows.Forms.Label labelSelectaRole;
        private System.Windows.Forms.ListBox listBoxJobPositions;
        private System.Windows.Forms.Label labelAdminTools;
        private System.Windows.Forms.Button buttonBackupDB;
        private System.Windows.Forms.Button buttonUpdateApplication;
        private System.Windows.Forms.Label labelCompanyInformation;
        private System.Windows.Forms.Label labelSelectedRoleOutput;
        private System.Windows.Forms.Label labelSelectedPosition;
        private System.Windows.Forms.DataGridView dataGridViewPerksOutput;
        private System.Windows.Forms.Label labelPerks;
        private System.Windows.Forms.Label labelSalaryOutput;
        private System.Windows.Forms.Label labelSalary;
        private System.Windows.Forms.Label labelNumberOfCandidatesOutput;
        private System.Windows.Forms.Label labelNumberOfCandidates;
        private System.Windows.Forms.Label labelNumberOfRoundsOutput;
        private System.Windows.Forms.Label labelNumberOfRounds;
        private System.Windows.Forms.Label labelRoleStatusOutput;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelCompanyName;
        private System.Windows.Forms.Label labelHiringDepartment;
        private System.Windows.Forms.Label labelHiringManager;
        private System.Windows.Forms.Label labelCompanySize;
        private System.Windows.Forms.Label labelCompanyNameOutput;
        private System.Windows.Forms.Label labelHiringDepartmentOutput;
        private System.Windows.Forms.Label labelHiringManagerOutput;
        private System.Windows.Forms.Label labelCompanySizeOutput;
        private System.Windows.Forms.DataGridView dataGridViewApplicationDetails;
        private System.Windows.Forms.Label labelApplicationDetails;
        private System.Windows.Forms.Label labelRoleInformation;
        private System.Windows.Forms.Label labelHowToMainForm;
        private System.Windows.Forms.Label labelMainFormStep1;
        private System.Windows.Forms.Label labelMainFormStep2;
        private System.Windows.Forms.Label labelStep1Details;
        private System.Windows.Forms.Label labelStep2Details;
        private System.Windows.Forms.Label labelSep3Details;
        private System.Windows.Forms.Label labelMainFormStep3;
        private System.Windows.Forms.Label labelStep4Details;
        private System.Windows.Forms.Label labelStep4;
    }
}

