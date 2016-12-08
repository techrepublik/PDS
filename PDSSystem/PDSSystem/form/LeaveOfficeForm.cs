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
using PDSSystem.dal.man;

namespace PDSSystem.form
{
    public partial class LeaveOfficeForm : Form
    {
        public LeaveOffice LeaveOffice { get; set; }
        public LeaveOfficeForm()
        {
            InitializeComponent();
        }

        private void leaveOfficeBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (leaveOfficeBindingSource != null)
                leaveOfficeBindingNavigatorSaveItem.Enabled = true;
        }

        private void LeaveOfficeForm_Load(object sender, EventArgs e)
        {

        }

        private void leaveOfficeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (leaveOfficeBindingSource != null)
            {
                Validate();
                leaveOfficeBindingSource.EndEdit();
                var iResult = LeaveOfficeManagement.Save((LeaveOffice)leaveOfficeBindingSource.Current);
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
        }
    }
}
