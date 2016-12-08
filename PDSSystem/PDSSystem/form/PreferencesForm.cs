using PDSSystem.dal.data;
using PDSSystem.dal.man;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDSSystem.form
{
    public partial class PreferencesForm : Form
    {

        enum Tab
        {
            school,
            degree
        };

        Tab _tabChoice;
        public PreferencesForm()
        {
            InitializeComponent();
        }

        private void schoolNameDataGridView_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (schoolNameBindingSource == null) return;
            if (schoolNameDataGridView.Rows.Count <= 1) return;
            if (!schoolNameDataGridView.IsCurrentRowDirty) return;
            Validate();
            schoolNameBindingSource.EndEdit();
            var iResult = SchoolNameManagement.Save((SchoolName)schoolNameBindingSource.Current);
            //toolStripStatusLabel1.Text = iResult > 0 ? @"Unit saved successfully." : @"Error occurred when saving Unit.";
        }

        private void degreeDataGridView_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (degreeBindingSource == null) return;
            if (degreeDataGridView.Rows.Count <= 1) return;
            if (!degreeDataGridView.IsCurrentRowDirty) return;
            Validate();
            degreeBindingSource.EndEdit();
            var iResult = DegreesManagement.Save((Degree)degreeBindingSource.Current);
        }

        private void DeleteSchool()
        {
            if (schoolNameBindingSource != null)
            {
                var dResult = MessageBox.Show(@"Delete current record?", @"Delete", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (dResult == DialogResult.Yes)
                {
                    if (SchoolNameManagement.Delete(((SchoolName)schoolNameBindingSource.Current).SchoolNo))
                    {
                        MessageBox.Show(@"Record was deleted successfully.", @"Delete", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        schoolNameBindingSource.RemoveCurrent();
                    }
                    else
                    {
                        MessageBox.Show(@"Error on delete operation.", @"Delete", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        schoolNameDataGridView.Focus();
                    }
                }
            }
        }

        private void DeleteDegree()
        {
            if (degreeBindingSource != null)
            {
                var dResult = MessageBox.Show(@"Delete current record?", @"Delete", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (dResult == DialogResult.Yes)
                {
                    if (DegreesManagement.Delete(((Degree)degreeBindingSource.Current).DegreeNo))
                    {
                        MessageBox.Show(@"Record was deleted successfully.", @"Delete", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        degreeBindingSource.RemoveCurrent();
                    }
                    else
                    {
                        MessageBox.Show(@"Error on delete operation.", @"Delete", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        degreeDataGridView.Focus();
                    }
                }
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            switch (_tabChoice)
            {
                case Tab.school:
                    DeleteSchool();
                    break;
                case Tab.degree:
                    DeleteDegree();
                    break;
                default:
                    break;
            }
            Cursor.Current = Cursors.Default;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            switch (e.TabPageIndex)
            {
                case 0:
                    _tabChoice = Tab.school;
                    break;
                case 1:
                    _tabChoice = Tab.degree;
                    break;
                default:
                    break;
            }
        }

        private void PreferencesForm_Load(object sender, EventArgs e)
        {
            LoadInitRecords();
        }

        private void LoadInitRecords()
        {
            Cursor.Current = Cursors.WaitCursor;
            schoolNameBindingSource.DataSource = SchoolNameManagement.GetAll();
            degreeBindingSource.DataSource = DegreesManagement.GetAll();
            Cursor.Current = Cursors.Default;
        }
    }
}
