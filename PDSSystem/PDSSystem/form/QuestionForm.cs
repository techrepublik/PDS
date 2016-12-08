using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using PDSSystem.dal.data;
using PDSSystem.dal.man;

namespace PDSSystem.form
{
    public partial class QuestionForm : Form
    {
        public int PersonnelNo { get; set; }
        public Question Question { get; set; }
        public QuestionForm()
        {
            InitializeComponent();
        }

        private void QuestionForm_Load(object sender, EventArgs e)
        {
            if (Question == null) return;
            questionBindingSource.DataSource = Question;
        }

        private void questionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if(questionBindingSource != null)
            {
                Validate();
                ((Question)questionBindingSource.Current).PersonnelNo = PersonnelNo;
                questionBindingSource.EndEdit();
                var iResult = QuestionManagement.Save((Question)questionBindingSource.Current);
                if (iResult > 0)
                {
                    MessageBox.Show(@"Record was successfully saved.", @"Save", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    //q36A_YesCheckBox.Focus();
                }
                else
                {
                    MessageBox.Show(@"Error occurred in saving.", @"Save", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void questionBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (questionBindingSource != null) 
                questionBindingNavigatorSaveItem.Enabled = true;
        }
    }
}
