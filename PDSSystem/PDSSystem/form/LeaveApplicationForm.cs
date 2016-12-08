using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PDSSystem.dal.data;
using PDSSystem.dal.classes;
using PDSSystem.dal.man;
using PDSSystem.dal.quer;

namespace PDSSystem.form
{
    public partial class LeaveApplicationForm : Form
    {
        public LeaveObj LeaveObj { get; set; }

        string _spent;
        public LeaveApplicationForm()
        {
            InitializeComponent();
        }

        private void leaveOfficeDataGridView_Click(object sender, EventArgs e)
        {
        
        }

        private void leaveApplicationDataGridView_Click(object sender, EventArgs e)
        {
          
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            
        }

        private void LeaveApplicationForm_Load(object sender, EventArgs e)
        {
            initRecord();
        }

        private void initRecord()
        {
            Cursor.Current = Cursors.WaitCursor;
            employeeObjBindingSource.DataSource = StaticClass.ListEmployee();
            leafBindingSource.DataSource = LeaveManagement.GetAll();
            leaveTypeBindingSource.DataSource = LeaveTypeManagement.GetAll();

            if (LeaveObj == null) return;
            LeaveApplication leaveApp = (LeaveApplication)LeaveObj;
            leaveApplicationBindingSource.DataSource = leaveApp;
            Cursor.Current = Cursors.Default;
        }

        private void dateAppliedDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            dateAppliedDateTimePicker.Format = DateTimePickerFormat.Short;
        }

        private void leaveStartDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            leaveStartDateTimePicker.Format = DateTimePickerFormat.Short;
        }

        private void leaveEndDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            leaveEndDateTimePicker.Format = DateTimePickerFormat.Short;
        }

        private void leaveApplicationBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            SaveLeaveApplication();
        }

        private void SaveLeaveApplication()
        {
            Validate();
            if (checkNull()) return;
            ((LeaveApplication)leaveApplicationBindingSource.Current).LeaveSpent = _spent;
            leaveApplicationBindingSource.EndEdit();
            var iResult = LeaveApplicationManagement.Save((LeaveApplication)leaveApplicationBindingSource.Current);
            if (iResult > 0)
            {
                MessageBox.Show(@"Record was successfully saved.", @"Save", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                personnelNoComboBox.Focus();
            }
            else
            {
                MessageBox.Show(@"Error occurred in saving.", @"Save", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private bool checkNull()
        {
            if (leaveApplicationBindingSource == null) return true;
            if (leaveApplicationBindingSource.Current == null) return true;

            if (((LeaveApplication)leaveApplicationBindingSource.Current).PersonnelNo == null)
            {
                personnelNoComboBox.Focus();
                MessageBox.Show(@"Please select a Personnel.", @"Select Personnel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            } else
            if (((LeaveApplication)leaveApplicationBindingSource.Current).DateApplied == null)
            {
                dateAppliedDateTimePicker.Focus();
                MessageBox.Show(@"Please select a valid date.", @"Date Applied", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            } else
            if (((LeaveApplication)leaveApplicationBindingSource.Current).LeaveStart == null)
            {
                leaveStartDateTimePicker.Focus();
                MessageBox.Show(@"Please select a valid date.", @"Leave Start Date", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            } else
            if (((LeaveApplication)leaveApplicationBindingSource.Current).LeaveEnd == null)
            {
                leaveEndDateTimePicker.Focus();
                MessageBox.Show(@"Please select a valid date.", @"Leave End Date", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            } else
            {
                return false;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            _spent = @"Philippines - Vacation Leave";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            _spent = @"Abroad - Vacation Leave";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            _spent = @"Hospital - Sick Leave";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            _spent = @"Abroad - Sick Leave";
        }

        private void leaveApplicationBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (leaveApplicationBindingSource != null)
                leaveApplicationBindingNavigatorSaveItem.Enabled = true;
        }

        private void bindingNavigatorAddNewItem_Click_1(object sender, EventArgs e)
        {
            recommendationComboBox.SelectedIndex = 0;
            commutationComboBox.SelectedIndex = 0;
        }
    }
}
