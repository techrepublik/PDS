namespace PDSSystem.form
{
    partial class ReportPDSForm
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource7 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource8 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource9 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource10 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource11 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource12 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource13 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource14 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonGo = new System.Windows.Forms.Button();
            this.PersonnelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SpousBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EducationObjBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ChildrenObjBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EligibilityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ExperiencyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.VoluntaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TrainingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SkillBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DistinctionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.OrganizationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QuestionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReferenceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PersonnelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpousBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EducationObjBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChildrenObjBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EligibilityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExperiencyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VoluntaryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrainingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SkillBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DistinctionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrganizationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuestionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReferenceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetailBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "PersonnelData";
            reportDataSource1.Value = this.PersonnelBindingSource;
            reportDataSource2.Name = "SpouseData";
            reportDataSource2.Value = this.SpousBindingSource;
            reportDataSource3.Name = "EducationData";
            reportDataSource3.Value = this.EducationObjBindingSource;
            reportDataSource4.Name = "ChildrenData";
            reportDataSource4.Value = this.ChildrenObjBindingSource;
            reportDataSource5.Name = "EligibilityData";
            reportDataSource5.Value = this.EligibilityBindingSource;
            reportDataSource6.Name = "WorkExperienceData";
            reportDataSource6.Value = this.ExperiencyBindingSource;
            reportDataSource7.Name = "VoluntaryData";
            reportDataSource7.Value = this.VoluntaryBindingSource;
            reportDataSource8.Name = "TrainingData";
            reportDataSource8.Value = this.TrainingBindingSource;
            reportDataSource9.Name = "SkillData";
            reportDataSource9.Value = this.SkillBindingSource;
            reportDataSource10.Name = "DistinctionData";
            reportDataSource10.Value = this.DistinctionBindingSource;
            reportDataSource11.Name = "OrganizationData";
            reportDataSource11.Value = this.OrganizationBindingSource;
            reportDataSource12.Name = "QuestionData";
            reportDataSource12.Value = this.QuestionBindingSource;
            reportDataSource13.Name = "ReferencesData";
            reportDataSource13.Value = this.ReferenceBindingSource;
            reportDataSource14.Name = "DetailData";
            reportDataSource14.Value = this.DetailBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource7);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource8);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource9);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource10);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource11);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource12);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource13);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource14);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PDSSystem.report.PDSReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 71);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(795, 378);
            this.reportViewer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonGo);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(795, 71);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search Agency ID No/Barcode:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(16, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(274, 26);
            this.textBox1.TabIndex = 1;
            // 
            // buttonGo
            // 
            this.buttonGo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGo.Location = new System.Drawing.Point(297, 30);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(97, 26);
            this.buttonGo.TabIndex = 2;
            this.buttonGo.Text = "Search";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // PersonnelBindingSource
            // 
            this.PersonnelBindingSource.DataSource = typeof(PDSSystem.dal.data.Personnel);
            // 
            // SpousBindingSource
            // 
            this.SpousBindingSource.DataSource = typeof(PDSSystem.dal.data.Spous);
            this.SpousBindingSource.CurrentChanged += new System.EventHandler(this.SpousBindingSource_CurrentChanged);
            // 
            // EducationObjBindingSource
            // 
            this.EducationObjBindingSource.DataSource = typeof(PDSSystem.dal.classes.EducationObj);
            // 
            // ChildrenObjBindingSource
            // 
            this.ChildrenObjBindingSource.DataSource = typeof(PDSSystem.dal.classes.ChildrenObj);
            // 
            // EligibilityBindingSource
            // 
            this.EligibilityBindingSource.DataSource = typeof(PDSSystem.dal.data.Eligibility);
            // 
            // ExperiencyBindingSource
            // 
            this.ExperiencyBindingSource.DataSource = typeof(PDSSystem.dal.data.Experiency);
            // 
            // VoluntaryBindingSource
            // 
            this.VoluntaryBindingSource.DataSource = typeof(PDSSystem.dal.data.Voluntary);
            // 
            // TrainingBindingSource
            // 
            this.TrainingBindingSource.DataSource = typeof(PDSSystem.dal.data.Training);
            // 
            // SkillBindingSource
            // 
            this.SkillBindingSource.DataSource = typeof(PDSSystem.dal.data.Skill);
            // 
            // DistinctionBindingSource
            // 
            this.DistinctionBindingSource.DataSource = typeof(PDSSystem.dal.data.Distinction);
            // 
            // OrganizationBindingSource
            // 
            this.OrganizationBindingSource.DataSource = typeof(PDSSystem.dal.data.Organization);
            // 
            // QuestionBindingSource
            // 
            this.QuestionBindingSource.DataSource = typeof(PDSSystem.dal.data.Question);
            // 
            // ReferenceBindingSource
            // 
            this.ReferenceBindingSource.DataSource = typeof(PDSSystem.dal.data.Reference);
            // 
            // DetailBindingSource
            // 
            this.DetailBindingSource.DataSource = typeof(PDSSystem.dal.data.Detail);
            // 
            // ReportPDSForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 449);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel1);
            this.Name = "ReportPDSForm";
            this.Text = "Report PDS Form";
            this.Load += new System.EventHandler(this.ReportPDSForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PersonnelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpousBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EducationObjBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChildrenObjBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EligibilityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExperiencyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VoluntaryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrainingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SkillBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DistinctionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrganizationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuestionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReferenceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetailBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PersonnelBindingSource;
        private System.Windows.Forms.BindingSource SpousBindingSource;
        private System.Windows.Forms.BindingSource EducationObjBindingSource;
        private System.Windows.Forms.BindingSource ChildrenObjBindingSource;
        private System.Windows.Forms.BindingSource EligibilityBindingSource;
        private System.Windows.Forms.BindingSource ExperiencyBindingSource;
        private System.Windows.Forms.BindingSource VoluntaryBindingSource;
        private System.Windows.Forms.BindingSource TrainingBindingSource;
        private System.Windows.Forms.BindingSource SkillBindingSource;
        private System.Windows.Forms.BindingSource DistinctionBindingSource;
        private System.Windows.Forms.BindingSource OrganizationBindingSource;
        private System.Windows.Forms.BindingSource QuestionBindingSource;
        private System.Windows.Forms.BindingSource ReferenceBindingSource;
        private System.Windows.Forms.BindingSource DetailBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.TextBox textBox1;
    }
}