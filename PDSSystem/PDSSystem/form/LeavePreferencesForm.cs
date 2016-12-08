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

namespace PDSSystem.form
{
    public partial class LeavePreferencesForm : Form
    {
        enum Tab
        {
            type,
            leave
        };

        Tab _tabChoice;
        public LeavePreferencesForm()
        {
            InitializeComponent();
        }

        private void leaveTypeDataGridView_Leave(object sender, EventArgs e)
        {
            
        }

        private void leafDataGridView_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (leafBindingSource == null) return;
            if (leafDataGridView.Rows.Count <= 1) return;
            if (!leafDataGridView.IsCurrentRowDirty) return;
            Validate();
            leafBindingSource.EndEdit();
            var iResult = LeaveManagement.Save((Leaf)leafBindingSource.Current);
        }

        private void leaveTypeDataGridView_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (leaveTypeBindingSource == null) return;
            if (leaveTypeDataGridView.Rows.Count <= 1) return;
            if (!leaveTypeDataGridView.IsCurrentRowDirty) return;
            Validate();
            leaveTypeBindingSource.EndEdit();
            var iResult = LeaveTypeManagement.Save((LeaveType)leaveTypeBindingSource.Current);
        }

        private void LeavePreferencesForm_Load(object sender, EventArgs e)
        {
            LoadInitRecords();
        }

        private void DeleteLeaveType()
        {
            if (leaveTypeBindingSource != null)
            {
                var dResult = MessageBox.Show(@"Delete current record?", @"Delete", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (dResult == DialogResult.Yes)
                {
                    if (LeaveTypeManagement.Delete(((LeaveType)leaveTypeBindingSource.Current).LeaveTypeNo))
                    {
                        MessageBox.Show(@"Record was deleted successfully.", @"Delete", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        leaveTypeBindingSource.RemoveCurrent();
                    }
                    else
                    {
                        MessageBox.Show(@"Error on delete operation.", @"Delete", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        leaveTypeDataGridView.Focus();
                    }
                }
            }
        }

        private void DeleteLeave()
        {
            if (leafBindingSource != null)
            {
                var dResult = MessageBox.Show(@"Delete current record?", @"Delete", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (dResult == DialogResult.Yes)
                {
                    if (LeaveManagement.Delete(((Leaf)leafBindingSource.Current).LeaveNo))
                    {
                        MessageBox.Show(@"Record was deleted successfully.", @"Delete", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        leafBindingSource.RemoveCurrent();
                    }
                    else
                    {
                        MessageBox.Show(@"Error on delete operation.", @"Delete", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        leafDataGridView.Focus();
                    }
                }
            }
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            switch (e.TabPageIndex)
            {
                case 0:
                    _tabChoice = Tab.type;
                    leafBindingNavigator.BindingSource = leaveTypeBindingSource;
                    break;
                case 1:
                    _tabChoice = Tab.leave;
                    leafBindingNavigator.BindingSource = leafBindingSource;
                    break;
                default:
                    break;
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            switch (_tabChoice)
            {
                case Tab.type:
                    DeleteLeaveType();
                    break;
                case Tab.leave:
                    DeleteLeave();
                    break;
                default:
                    break;
            }
            Cursor.Current = Cursors.Default;
        }

        private void leaveTypeDataGridView_Click(object sender, EventArgs e)
        {
            _tabChoice = Tab.type;
            leafBindingNavigator.BindingSource = leaveTypeBindingSource;
        }

        private void leafDataGridView_Click(object sender, EventArgs e)
        {
            _tabChoice = Tab.leave;
            leafBindingNavigator.BindingSource = leafBindingSource;
        }
        private void LoadInitRecords()
        {
            Cursor.Current = Cursors.WaitCursor;
            leafBindingSource.DataSource = LeaveManagement.GetAll();
            leaveTypeBindingSource.DataSource = LeaveTypeManagement.GetAll();
            Cursor.Current = Cursors.Default;
        }
    }
}
