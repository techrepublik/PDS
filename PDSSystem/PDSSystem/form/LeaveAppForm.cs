using PDSSystem.dal.data;
using PDSSystem.dal.man;
using PDSSystem.dal.quer;
using System;
using System.Windows.Forms;

namespace PDSSystem.form
{
    public partial class LeaveAppForm : Form
    {
        public LeaveApplication LeaveApplication { get; set; }

        string _spent;
        public LeaveAppForm()
        {
            InitializeComponent();
        }

        private void LeaveAppForm_Load(object sender, EventArgs e)
        {
            initRecord();
        }

        private void initRecord()
        {
            Cursor.Current = Cursors.WaitCursor;
            employeeObjBindingSource.DataSource = StaticClass.ListEmployee();
            leafBindingSource.DataSource = LeaveManagement.GetAll();
            leaveTypeBindingSource.DataSource = LeaveTypeManagement.GetAll();

            if (LeaveApplication == null) return;
            //LeaveApplication leaveApp = (LeaveApplication)LeaveObj;
            leaveApplicationBindingSource.DataSource = LeaveApplication;
            updateSpent();
            Cursor.Current = Cursors.Default;
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
            }
            else
            if (((LeaveApplication)leaveApplicationBindingSource.Current).DateApplied == null)
            {
                dateAppliedDateTimePicker.Focus();
                MessageBox.Show(@"Please select a valid date.", @"Date Applied", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            if (((LeaveApplication)leaveApplicationBindingSource.Current).LeaveStart == null)
            {
                leaveStartDateTimePicker.Focus();
                MessageBox.Show(@"Please select a valid date.", @"Leave Start Date", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            if (((LeaveApplication)leaveApplicationBindingSource.Current).LeaveEnd == null)
            {
                leaveEndDateTimePicker.Focus();
                MessageBox.Show(@"Please select a valid date.", @"Leave End Date", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
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
            _spent = @"Outpatient - Sick Leave";
        }

        private void leaveApplicationBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (leaveApplicationBindingSource != null)
                leaveApplicationBindingNavigatorSaveItem.Enabled = true;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            recommendationComboBox.SelectedIndex = 0;
            commutationComboBox.SelectedIndex = 0;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton4.Checked = false;
            radioButton3.Checked = false;
            dateAppliedDateTimePicker.Format = DateTimePickerFormat.Short;
            dateAppliedDateTimePicker.Value = DateTime.Now;

            leaveStartDateTimePicker.Format = DateTimePickerFormat.Custom;
            leaveStartDateTimePicker.CustomFormat = " ";

            leaveEndDateTimePicker.Format = DateTimePickerFormat.Custom;
            leaveEndDateTimePicker.CustomFormat = " ";

            personnelNoComboBox.Focus();
        }

        private void leaveApplicationBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            SaveLeaveApplication();
        }

        private void updateSpent()
        {
            if (LeaveApplication == null) return;
            switch (LeaveApplication.LeaveSpent.Substring(0,3).ToUpper())
            {
                case "PHI":
                    radioButton1.Checked = true;
                    break;
                case "ABR":
                    radioButton2.Checked = true;
                    break;
                case "HOS":
                    radioButton4.Checked = true;
                    break;
                case "OUT":
                    radioButton3.Checked = true;
                    break;
                default:
                    break;
            }
        }

        private void leaveEndDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            leaveEndDateTimePicker.Format = DateTimePickerFormat.Short;
            computeDays();
        }

        private void computeDays()
        {
            if (leaveStartDateTimePicker.Value == null) return;
            if (leaveEndDateTimePicker.Value == null) return;

            var days = leaveEndDateTimePicker.Value.Day - leaveStartDateTimePicker.Value.Day;
            leaveDaysTextBox.Text = days.ToString();
        }

        private void leaveStartDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            leaveStartDateTimePicker.Format = DateTimePickerFormat.Short;
            computeDays();
        }

        private void dateAppliedDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            dateAppliedDateTimePicker.Format = DateTimePickerFormat.Short;
        }

        private void leaveEndDateTimePicker_Leave(object sender, EventArgs e)
        {
            //computeDays();
        }

        private void leaveStartDateTimePicker_Leave(object sender, EventArgs e)
        {
            //computeDays();
        }
    }
}
