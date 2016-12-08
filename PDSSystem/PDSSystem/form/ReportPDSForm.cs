using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using PDSSystem.dal.classes;
using PDSSystem.dal.data;
using PDSSystem.dal.man;
using PDSSystem.dal.quer;

namespace PDSSystem.form
{
    public partial class ReportPDSForm : Form
    {
        public int PersonnelNo { get; set; }
        public Personnel Personnel { get; set; }
        public ReportPDSForm()
        {
            InitializeComponent();
        }

        private void ReportPDSForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            PersonnelBindingSource.DataSource = PersonnelManagement.GetA(PersonnelNo);
            EducationObjBindingSource.DataSource = StaticClass.ListEducation(PersonnelNo);
            EligibilityBindingSource.DataSource = EligibilityManagement.GetAll(PersonnelNo);
            ExperiencyBindingSource.DataSource = ExperienceManagement.GetAll(PersonnelNo);
            VoluntaryBindingSource.DataSource = VoluntaryManagement.GetAll(PersonnelNo);
            TrainingBindingSource.DataSource = TrainingManagement.GetAll(PersonnelNo);
            SpousBindingSource.DataSource = SpouseManagement.GetA(PersonnelNo);
            SkillBindingSource.DataSource = SkillManagement.GetAll(PersonnelNo);
            OrganizationBindingSource.DataSource = OrganizationManagement.GetAll(PersonnelNo);
            DistinctionBindingSource.DataSource = DistinctionManagement.GetAll(PersonnelNo);
            QuestionBindingSource.DataSource = QuestionManagement.GetAll(PersonnelNo);
            ReferenceBindingSource.DataSource = ReferencesManagement.GetAll(PersonnelNo);
            DetailBindingSource.DataSource = Details.GetAll(PersonnelNo);

            if (SpousBindingSource?.Current == null) return;
            ChildrenObjBindingSource.DataSource = StaticClass.ListChildren(((Spous)SpousBindingSource.Current).SpouseNo);

            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;

            this.reportViewer1.RefreshReport();
        }

        private void SpousBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            //if (SpousBindingSource?.Current == null) return; 
            //ChildrenObjBindingSource.DataSource = ((Spous) SpousBindingSource.Current).SpouseNo;
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (textBox1.Text.Length > 0)
            {
                Personnel = PersonnelManagement.GetA(textBox1.Text);
                if (Personnel != null)
                {
                    PersonnelNo = Personnel.PersonnelNo;
                    LoadData();
                }
                else
                {
                    MessageBox.Show(@"Record not found. Please try again.", @"Search", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    textBox1.Focus();
                }
            }
            Cursor.Current = Cursors.Default;
        }
    }
}
