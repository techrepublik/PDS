using PDSSystem.dal.classes;
using PDSSystem.dal.data;
using PDSSystem.dal.man;
using System;
using System.Windows.Forms;

namespace PDSSystem.form
{
    public partial class EducationForm : Form
    {
        public int PersonnelNo { get; set; }
        public Education Education { get; set; }

        public EducationForm()
        {
            InitializeComponent();
        }

        private void EducationForm_Load(object sender, EventArgs e)
        {
            LoadInitRecord();
            InitLoadYearGraduated(); //year graduated
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            educationLevelNoComboBox.Focus();
            LoadInitRecord();
            modifieddateLabel1.Text = DateTime.Now.ToString();
        }

        private void LoadInitRecord()
        {
            Cursor.Current = Cursors.WaitCursor;
            schoolNameBindingSource.DataSource = SchoolNameManagement.GetAll();
            degreeBindingSource.DataSource = DegreesManagement.GetAll();

            if (Education == null) return;
            educationBindingSource.DataSource = Education;
            Cursor.Current = Cursors.Default;
        }

        private void InitLoadYearGraduated()
        {
            yearGraduatedComboBox.Items.Clear();
            for (int i = 0; i < 50; i++)
            {
                yearGraduatedComboBox.Items.Add(DateTime.Now.Year - i);
            }
        }

        private void educationBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (educationBindingSource != null)
            {
                if (PersonnelNo > 0)
                {
                    Validate();
                    ((Education)educationBindingSource.Current).PersonnelNo = PersonnelNo;
                    ((Education)educationBindingSource.Current).modifieddate = DateTime.Now;
                    educationBindingSource.EndEdit();
                    var iResult = EducationManagement.Save((Education)educationBindingSource.Current);
                    if (iResult > 0)
                    {
                        MessageBox.Show(@"Record was successfully saved.", @"Save", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        educationLevelNoComboBox.Focus();
                    }
                    else
                    {
                        MessageBox.Show(@"Error occurred in saving.", @"Save", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(@"Please select personnel.", @"Save", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                }
            }
        }

        private void educationBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (educationBindingSource != null)
                educationBindingNavigatorSaveItem.Enabled = true;
        }
    }
}
