using PDSSystem.dal.quer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PDSSystem.dal.man;
using PDSSystem.dal.data;
using PDSSystem.dal.classes;

namespace PDSSystem.form
{
    public partial class SummaryListForm : Form
    {
        public Personnel Personnel { get; set; }
        public Spous Spouse { get; set; }
        public EducationObj Education { get; set; }
        public Eligibility Eligibility { get; set; }
        public Experiency Experience { get; set; }
        public Voluntary Voluntary { get; set; }
        public Training Training { get; set; }
        public Question Question { get; set; }

        EmployeeListForm _empForm;
        SpouseForm _spoForm;
        EducationForm _eduForm;
        EligibilityForm _eliForm;
        WorkExperienceForm _worForm;
        VoluntaryWorkForm _volForm;
        TrainingForm _traForm;
        QuestionForm _queForm;
        ReportPDSForm _rptForm;
        
        enum Tab
        {
            personnel,
            family,
            education,
            civilService,
            work,
            voluntary,
            training,
            other1,
            other2,
            orgnization,
            skill,
            distinction,
            question,
            reference,
            detail
        }

        Tab _tabChoice;

        public SummaryListForm()
        {
            InitializeComponent();
        }

        private void SummaryListForm_Load(object sender, EventArgs e)
        {
            LoadListPersonnel();
            
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            switch (_tabChoice)
            {
                case Tab.personnel:
                    Personnel = ((Personnel)personnelBindingSource.Current);
                    _empForm = new EmployeeListForm
                    {
                        Personnel = Personnel,
                        FormBorderStyle = FormBorderStyle.FixedSingle,
                        MinimizeBox = false,
                        MaximizeBox = false,
                        StartPosition = FormStartPosition.CenterScreen
                    };
                    if (personnelBindingSource.Current == null) return;
                    _empForm.ShowDialog();
                    break;
                case Tab.family:
                    Spouse = ((Spous)spousBindingSource.Current);
                    _spoForm = new SpouseForm
                    {
                        Spouse = Spouse,
                        FormBorderStyle = FormBorderStyle.FixedSingle,
                        MinimizeBox = false,
                        MaximizeBox = false,
                        StartPosition = FormStartPosition.CenterScreen,
                        PersonnelNo = ((Personnel)personnelBindingSource.Current).PersonnelNo,
                    };
                    _spoForm.ShowDialog();
                    break;
                case Tab.education:
                    Education = ((EducationObj)educationObjBindingSource.Current);
                    _eduForm = new EducationForm
                    {
                        Education = Education,
                        FormBorderStyle = FormBorderStyle.FixedSingle,
                        MinimizeBox = false,
                        MaximizeBox = false,
                        StartPosition = FormStartPosition.CenterScreen,
                        PersonnelNo = ((Personnel)personnelBindingSource.Current).PersonnelNo
                    };
                    _eduForm.ShowDialog();
                    break;
                case Tab.civilService:
                    Eligibility = ((Eligibility)eligibilityBindingSource.Current);
                    _eliForm = new EligibilityForm
                    {
                        Eligibility = Eligibility,
                        FormBorderStyle = FormBorderStyle.FixedSingle,
                        MinimizeBox = false,
                        MaximizeBox = false,
                        StartPosition = FormStartPosition.CenterScreen,
                        PersonnelNo = ((Personnel)personnelBindingSource.Current).PersonnelNo
                    };
                    _eliForm.ShowDialog();
                    break;
                case Tab.work:
                    Experience = ((Experiency)experiencyBindingSource.Current);
                    _worForm = new WorkExperienceForm
                    {
                        Experience = Experience,
                        FormBorderStyle = FormBorderStyle.FixedSingle,
                        MinimizeBox = false,
                        MaximizeBox = false,
                        StartPosition = FormStartPosition.CenterScreen,
                        PersonnelNo = ((Personnel)personnelBindingSource.Current).PersonnelNo
                    };
                    _worForm.ShowDialog();
                    break;
                case Tab.voluntary:
                    Voluntary = ((Voluntary)voluntaryBindingSource.Current);
                    _volForm = new VoluntaryWorkForm
                    {
                        Voluntary = Voluntary,
                        FormBorderStyle = FormBorderStyle.FixedSingle,
                        MinimizeBox = false,
                        MaximizeBox = false,
                        StartPosition = FormStartPosition.CenterScreen,
                        PersonnelNo = ((Personnel)personnelBindingSource.Current).PersonnelNo
                    };
                    _volForm.ShowDialog();
                    break;
                case Tab.training:
                    Training = ((Training)trainingBindingSource.Current);
                    _traForm = new TrainingForm
                    {
                        Training = Training,
                        FormBorderStyle = FormBorderStyle.FixedSingle,
                        MinimizeBox = false,
                        MaximizeBox = false,
                        StartPosition = FormStartPosition.CenterScreen,
                        PersonnelNo = ((Personnel)personnelBindingSource.Current).PersonnelNo
                    };
                    _traForm.ShowDialog();
                    break;
                case Tab.other1:
                    break;
                case Tab.other2:
                    break;
                default:
                    break;
            }
        }

        private void LoadListPersonnel()
        {
            Cursor.Current = Cursors.WaitCursor;
            personnelBindingSource.DataSource = StaticClass.ListPersonnel();
            Cursor.Current = Cursors.Default;
        }

        private void LoadInitPersonnelRelatedRecord()
        {
            Cursor.Current = Cursors.WaitCursor;
            var pNo = ((Personnel)personnelBindingSource.Current).PersonnelNo;
            if (pNo > 0)
            {
                eligibilityBindingSource.DataSource = EligibilityManagement.GetAll(pNo);
                experiencyBindingSource.DataSource = ExperienceManagement.GetAll(pNo);
                voluntaryBindingSource.DataSource = VoluntaryManagement.GetAll(pNo);
                trainingBindingSource.DataSource = TrainingManagement.GetAll(pNo);
                educationObjBindingSource.DataSource = StaticClass.ListEducation(pNo);
                spousBindingSource.DataSource = SpouseManagement.GetAll(pNo);
                skillBindingSource.DataSource = SkillManagement.GetAll(pNo);
                organizationBindingSource.DataSource = OrganizationManagement.GetAll(pNo);
                distinctionBindingSource.DataSource = DistinctionManagement.GetAll(pNo);
                questionBindingSource.DataSource = QuestionManagement.GetAll(pNo);
                referenceBindingSource.DataSource = ReferencesManagement.GetAll(pNo);
                detailBindingSource.DataSource = Details.GetAll(pNo);
            }
            Cursor.Current = Cursors.Default;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            switch (_tabChoice)
            {
                case Tab.personnel:
                    DeletePersonnel();
                    break;
                case Tab.family:
                    DeleteSpouse();
                    break;
                case Tab.education:
                    DeleteEducation();
                    break;
                case Tab.civilService:
                    DeleteEligibilty();
                    break;
                case Tab.work:
                    DeleteWorkExperience();
                    break;
                case Tab.voluntary:
                    DeleteVoluntary();
                    break;
                case Tab.training:
                    DeleteTraining();
                    break;
                case Tab.other1:
                    break;
                case Tab.other2:
                    break;
                case Tab.skill:
                    DeleteSkill();
                    break;
                case Tab.distinction:
                    DeleteDistinction();
                    break;
                case Tab.orgnization:
                    DeleteOrganization();
                    break;
                case Tab.question:
                    DeleteQuestion();
                        break;
                case Tab.reference:
                        break;
                case Tab.detail:
                        break;
                    default:
                        break;
            }
            Cursor.Current = Cursors.Default;
        }

        private void DeleteQuestion()
        {
            var dResult = MessageBox.Show(@"Delete Question current record?", @"Delete", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (dResult == DialogResult.Yes)
            {
                if (QuestionManagement.Delete(((Question)questionBindingSource.Current).QuestionNo))
                {
                    MessageBox.Show(@"Record was deleted successfully.", @"Delete", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    questionBindingSource.RemoveCurrent();
                }
                else
                {
                    MessageBox.Show(@"Error on delete operation.", @"Delete", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    questionDataGridView.Focus();
                }
            }
        }
        private void DeleteOrganization()
        {
            var dResult = MessageBox.Show(@"Delete Organization current record?", @"Delete", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (dResult == DialogResult.Yes)
            {
                if (OrganizationManagement.Delete(((Organization)organizationBindingSource.Current).OrganizationNo))
                {
                    MessageBox.Show(@"Record was deleted successfully.", @"Delete", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    organizationBindingSource.RemoveCurrent();
                }
                else
                {
                    MessageBox.Show(@"Error on delete operation.", @"Delete", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    organizationDataGridView.Focus();
                }
            }
        }

        private void DeleteDistinction()
        {
            var dResult = MessageBox.Show(@"Delete Distinction current record?", @"Delete", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (dResult == DialogResult.Yes)
            {
                if (DistinctionManagement.Delete(((Distinction)distinctionBindingSource.Current).DistinctionNo))
                {
                    MessageBox.Show(@"Record was deleted successfully.", @"Delete", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    distinctionBindingSource.RemoveCurrent();
                }
                else
                {
                    MessageBox.Show(@"Error on delete operation.", @"Delete", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    distinctionDataGridView.Focus();
                }
            }
        }
        private void DeleteSkill()
        {
            var dResult = MessageBox.Show(@"Delete Skill current record?", @"Delete", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (dResult == DialogResult.Yes)
            {
                if (SkillManagement.Delete(((Skill)skillBindingSource.Current).SkillNo))
                {
                    MessageBox.Show(@"Record was deleted successfully.", @"Delete", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    skillBindingSource.RemoveCurrent();
                }
                else
                {
                    MessageBox.Show(@"Error on delete operation.", @"Delete", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    skillDataGridView.Focus();
                }
            }
        }
        private void DeleteTraining()
        {
            var dResult = MessageBox.Show(@"Delete Training current record?", @"Delete", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (dResult == DialogResult.Yes)
            {
                if (TrainingManagement.Delete(((Training) trainingBindingSource.Current).TrainingNo))
                {
                    MessageBox.Show(@"Record was deleted successfully.", @"Delete", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    trainingBindingSource.RemoveCurrent();
                }
                else
                {
                    MessageBox.Show(@"Error on delete operation.", @"Delete", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    trainingDataGridView.Focus();
                }
            }
        }

        private void DeleteVoluntary()
        {
            var dResult = MessageBox.Show(@"Delete Voluntary current record?", @"Delete", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (dResult == DialogResult.Yes)
            {
                if (VoluntaryManagement.Delete(((Voluntary) voluntaryBindingSource.Current).VoluntaryNo))
                {
                    MessageBox.Show(@"Record was deleted successfully.", @"Delete", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    voluntaryBindingSource.RemoveCurrent();
                }
                else
                {
                    MessageBox.Show(@"Error on delete operation.", @"Delete", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    voluntaryDataGridView.Focus();
                }
            }
        }

        private void DeleteWorkExperience()
        {
            var dResult = MessageBox.Show(@"Delete Work Experience current record?", @"Delete", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (dResult == DialogResult.Yes)
            {
                if (ExperienceManagement.Delete(((Experiency) experiencyBindingSource.Current).ExperienceNo))
                {
                    MessageBox.Show(@"Record was deleted successfully.", @"Delete", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    experiencyBindingSource.RemoveCurrent();
                }
                else
                {
                    MessageBox.Show(@"Error on delete operation.", @"Delete", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    experiencyDataGridView.Focus();
                }
            }
        }

        private void DeleteEligibilty()
        {
            var dResult = MessageBox.Show(@"Delete Civil Service Eligibilty current record?", @"Delete", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (dResult == DialogResult.Yes)
            {
                if (EligibilityManagement.Delete(((Eligibility) eligibilityBindingSource.Current).EligibilityNo))
                {
                    MessageBox.Show(@"Record was deleted successfully.", @"Delete", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    eligibilityBindingSource.RemoveCurrent();
                }
                else
                {
                    MessageBox.Show(@"Error on delete operation.", @"Delete", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    eligibilityDataGridView.Focus();
                }
            }
        }

        private void DeleteEducation()
        {
            var dResult = MessageBox.Show(@"Delete Education current record?", @"Delete", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (dResult == DialogResult.Yes)
            {
                if (EducationManagement.Delete(((Education) educationObjBindingSource.Current).EducationNo))
                {
                    MessageBox.Show(@"Record was deleted successfully.", @"Delete", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    educationObjBindingSource.RemoveCurrent();
                }
                else
                {
                    MessageBox.Show(@"Error on delete operation.", @"Delete", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    educationObjDataGridView.Focus();
                }
            }
        }

        private void DeleteSpouse()
        {
            var dResult = MessageBox.Show(@"Delete Spouse's current record?", @"Delete", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (dResult == DialogResult.Yes)
            {
                if (SpouseManagement.Delete(((Spous) spousBindingSource.Current).SpouseNo))
                {
                    MessageBox.Show(@"Record was deleted successfully.", @"Delete", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    spousBindingSource.RemoveCurrent();
                }
                else
                {
                    MessageBox.Show(@"Error on delete operation.", @"Delete", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    spousDataGridView.Focus();
                }
            }
        }

        private void DeletePersonnel()
        {
            if (personnelBindingSource != null)
            {
                var dResult = MessageBox.Show(@"Delete Personnel's current record?", @"Delete", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (dResult == DialogResult.Yes)
                {
                    if (PersonnelManagement.Delete(((Personnel)personnelBindingSource.Current).PersonnelNo))
                    {
                        MessageBox.Show(@"Record was deleted successfully.", @"Delete", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        personnelBindingSource.RemoveCurrent();
                    }
                    else
                    {
                        MessageBox.Show(@"Error on delete operation.", @"Delete", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        personnelDataGridView.Focus();
                    }
                }
            }
        }

        private void personnelDataGridView_Click(object sender, EventArgs e)
        {
            _tabChoice = Tab.personnel;
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            switch (e.TabPageIndex)
            {
                case 0:
                    _tabChoice = Tab.family;
                    break;
                case 1:
                    _tabChoice = Tab.education;
                    break;
                case 2:
                    _tabChoice = Tab.civilService;
                    break;
                case 3:
                    _tabChoice = Tab.work;
                    break;
                case 4:
                    _tabChoice = Tab.voluntary;
                    break;
                case 5:
                    _tabChoice = Tab.training;
                    break;
                case 6:
                    _tabChoice = Tab.other1;
                    break;
                case 7:
                    _tabChoice = Tab.other2;
                    break;
                default:
                    break;
            }
        }

        private void personnelDataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void personnelBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (personnelBindingSource == null) return;
            if (personnelBindingSource.Current == null) return;
            LoadInitPersonnelRelatedRecord(); //loard related records.
            Personnel = (Personnel)personnelBindingSource.Current;
        }

        private void eligibilityDataGridView_Click(object sender, EventArgs e)
        {
            _tabChoice = Tab.civilService;
        }

        private void experiencyDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void experiencyDataGridView_Click(object sender, EventArgs e)
        {
            _tabChoice = Tab.work;
        }

        private void voluntaryDataGridView_Click(object sender, EventArgs e)
        {
            _tabChoice = Tab.voluntary;
        }

        private void trainingDataGridView_Click(object sender, EventArgs e)
        {
            _tabChoice = Tab.training;
        }

        private void spousBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (spousBindingSource != null)
            {
                if (spousBindingSource.Current != null)
                {
                    Spouse = (Spous)spousBindingSource.Current;
                    childrenBindingSource.DataSource = ChildrenManagement.GetAll(((Spous)spousBindingSource.Current).SpouseNo);
                }
                else
                    childrenBindingSource.DataSource = ChildrenManagement.GetAll(0);
            }
            Cursor.Current = Cursors.Default;
        }

        private void educationObjBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (educationObjBindingSource == null) return;
            if (educationObjBindingSource.Current == null) return;
            Education = (EducationObj)educationObjBindingSource.Current;
        }

        private void eligibilityBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (eligibilityBindingSource == null) return;
            if (eligibilityBindingSource.Current == null) return;
            Eligibility = (Eligibility)eligibilityBindingSource.Current;
        }

        private void experiencyBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (experiencyBindingSource == null) return;
            if (experiencyBindingSource.Current == null) return;
            Experience = (Experiency)experiencyBindingSource.Current;
        }

        private void voluntaryBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (voluntaryBindingSource == null) return;
            if (voluntaryBindingSource.Current == null) return;
            Voluntary = (Voluntary)voluntaryBindingSource.Current;
        }

        private void trainingBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (trainingBindingSource == null) return;
            if (trainingBindingSource.Current == null) return;
            Training = (Training)trainingBindingSource.Current;
        }

        private void skillDataGridView_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (skillBindingSource == null) return;
            if (skillDataGridView.Rows.Count <= 1) return;
            if (!skillDataGridView.IsCurrentRowDirty) return;
            Validate();
            ((Skill)skillBindingSource.Current).PersonnelNo = Personnel.PersonnelNo;
            skillBindingSource.EndEdit();
            var iResult = SkillManagement.Save((Skill)skillBindingSource.Current);
        }

        private void distinctionDataGridView_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (distinctionBindingSource == null) return;
            if (distinctionDataGridView.Rows.Count <= 1) return;
            if (!distinctionDataGridView.IsCurrentRowDirty) return;
            Validate();
            ((Distinction)distinctionBindingSource.Current).PersonnelNo = Personnel.PersonnelNo;
            distinctionBindingSource.EndEdit();
            var iResult = DistinctionManagement.Save((Distinction)distinctionBindingSource.Current);
        }

        private void organizationDataGridView_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (organizationBindingSource == null) return;
            if (organizationDataGridView.Rows.Count <= 1) return;
            if (!organizationDataGridView.IsCurrentRowDirty) return;
            Validate();
            ((Organization)organizationBindingSource.Current).PersonnelNo = Personnel.PersonnelNo;
            organizationBindingSource.EndEdit();
            var iResult = OrganizationManagement.Save((Organization)organizationBindingSource.Current);
        }

        private void referenceDataGridView_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (referenceBindingSource == null) return;
            if (referenceDataGridView.Rows.Count <= 1) return;
            if (!referenceDataGridView.IsCurrentRowDirty) return;
            Validate();
            ((Reference)referenceBindingSource.Current).PersonnelNo = Personnel.PersonnelNo;
            referenceBindingSource.EndEdit();
            var iResult = ReferencesManagement.Save((Reference)referenceBindingSource.Current);
        }

        private void detailDataGridView_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (detailBindingSource == null) return;
            if (detailDataGridView.Rows.Count <= 1) return;
            if (!detailDataGridView.IsCurrentRowDirty) return;
            Validate();
            ((Detail)detailBindingSource.Current).PersonnelNo = Personnel.PersonnelNo;
            detailBindingSource.EndEdit();
            var iResult = Details.Save((Detail)detailBindingSource.Current);
        }

        private void buttonUpdateQuestions_Click(object sender, EventArgs e)
        {
            Question = (Question)questionBindingSource.Current;
            _queForm = new QuestionForm
            {
                Question = Question,
                FormBorderStyle = FormBorderStyle.FixedSingle,
                MinimizeBox = false,
                MaximizeBox = false,
                StartPosition = FormStartPosition.CenterScreen,
                PersonnelNo = ((Personnel)personnelBindingSource.Current).PersonnelNo
            };
            _queForm.ShowDialog();
        }

        private void questionBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (questionBindingSource == null) return;
            if (questionBindingSource.Current == null) return;
            Question = (Question)questionBindingSource.Current;
        }

        private void spousDataGridView_Click(object sender, EventArgs e)
        {
            _tabChoice = Tab.family;
        }

        private void skillDataGridView_Click(object sender, EventArgs e)
        {
            _tabChoice = Tab.skill;
        }

        private void distinctionDataGridView_Click(object sender, EventArgs e)
        {
            _tabChoice = Tab.distinction;
        }

        private void organizationDataGridView_Click(object sender, EventArgs e)
        {
            _tabChoice = Tab.orgnization;
        }

        private void questionDataGridView_Click(object sender, EventArgs e)
        {
            _tabChoice = Tab.question;
        }

        private void referenceDataGridView_Click(object sender, EventArgs e)
        {
            _tabChoice = Tab.reference;
        }

        private void detailDataGridView_Click(object sender, EventArgs e)
        {
            _tabChoice = Tab.detail;
        }

        private void toolStripButtonPrintPDS_Click(object sender, EventArgs e)
        {
            _rptForm = new ReportPDSForm
            {
                //Experience = Experience,
                MinimizeBox = false,
                StartPosition = FormStartPosition.CenterScreen,
                PersonnelNo = ((Personnel)personnelBindingSource.Current).PersonnelNo
            };
            _rptForm.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (toolStripTextBox1.Text.Length > 0) 
                personnelBindingSource.DataSource = PersonnelManagement.GetAll(toolStripTextBox1.Text);
            Cursor.Current = Cursors.Default;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            LoadListPersonnel();
        }

        private void educationObjDataGridView_Click(object sender, EventArgs e)
        {
            _tabChoice = Tab.education;
        }
    }
}
