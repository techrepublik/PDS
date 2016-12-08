using PDSSystem.dal.classes;
using PDSSystem.dal.data;
using PDSSystem.dal.man;
using PDSSystem.dal.quer;
using System;
using System.Windows.Forms;

namespace PDSSystem.form
{
    public partial class LeaveForm : Form
    {
        public LeaveObj LeaveObj { get; set; }
        public int PersonnelNo { get; set; }

        LeaveAppForm _leaveAppForm;
        public LeaveForm()
        {
            InitializeComponent();
        }

        private void LeaveForm_Load(object sender, EventArgs e)
        {
            initControls();
            initRecord();
        }

        private void initControls()
        {
            foreach (var item in UtilityManager.util.UtilClass.FillMonth())
            {
                toolStripComboBoxMonth.Items.Add(item.ToString());
            }
            toolStripComboBoxMonth.SelectedIndex = DateTime.Now.Month;

            foreach (var item in UtilityManager.util.UtilClass.FillYear())
            {
                toolStripComboBoxYear.Items.Add(item.ToString());
            }
            toolStripComboBoxYear.SelectedIndex = 0;
        }

        private void initRecord()
        {
            var iMonth = 0;
            var iYear = 0;
            if (toolStripComboBoxMonth.SelectedIndex < 0) return;
            if (toolStripComboBoxYear.SelectedIndex < 0) return;
            iMonth = toolStripComboBoxMonth.SelectedIndex;
            iYear = Convert.ToInt16(toolStripComboBoxYear.Text);

            Cursor.Current = Cursors.WaitCursor;
            leaveObjBindingSource.DataSource = StaticClass.ListLeaveApplication(iMonth, iYear);
            Cursor.Current = Cursors.Default;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _leaveAppForm = new LeaveAppForm
            {
                MaximizeBox = false,
                MinimizeBox = false,
                StartPosition = FormStartPosition.CenterScreen,
                FormBorderStyle = FormBorderStyle.FixedSingle,
                LeaveApplication = LeaveObj
            };
            _leaveAppForm.ShowDialog();
        }

        private void toolStripComboBoxMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            initRecord();
        }

        private void toolStripComboBoxYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            initRecord();
        }

        private void leaveObjBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (leaveObjBindingSource == null) return;
            if (leaveObjBindingSource.CurrencyManager == null) return;
            LeaveObj = (LeaveObj)leaveObjBindingSource.Current;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            initRecord();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            DeleteLeave();
        }

        private void DeleteLeave()
        {
            if (leaveObjBindingSource != null)
            {
                var dResult = MessageBox.Show(@"Delete current record?", @"Delete", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (dResult == DialogResult.Yes)
                {
                    if (LeaveApplicationManagement.Delete(((LeaveApplication)leaveObjBindingSource.Current).LeaveApplicationNo))
                    {
                        MessageBox.Show(@"Record was deleted successfully.", @"Delete", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        leaveObjBindingSource.RemoveCurrent();
                    }
                    else
                    {
                        MessageBox.Show(@"Error on delete operation.", @"Delete", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        leaveObjDataGridView.Focus();
                    }
                }
            }
        }

        private void leaveObjDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
