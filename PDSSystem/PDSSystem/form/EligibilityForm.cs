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
    public partial class EligibilityForm : Form
    {
        public int PersonnelNo { get; set; }
        public Eligibility Eligibility { get; set; }
        public EligibilityForm()
        {
            InitializeComponent();
        }

        private void EligibilityForm_Load(object sender, EventArgs e)
        {
            if (Eligibility == null) return;
            eligibilityBindingSource.DataSource = Eligibility;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            eligibilityNameTextBox.Focus();
        }

        private void eligibilityBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (eligibilityBindingSource != null)
                eligibilityBindingNavigatorSaveItem.Enabled = true;
        }

        private void eligibilityBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (eligibilityBindingSource != null)
            {
                Validate();
                ((Eligibility)eligibilityBindingSource.Current).PersonnelNo = PersonnelNo;
                eligibilityBindingSource.EndEdit();
                var iResult = EligibilityManagement.Save((Eligibility)eligibilityBindingSource.Current);
                if (iResult > 0)
                {
                    MessageBox.Show(@"Record was successfully saved.", @"Save", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    eligibilityNameTextBox.Focus();
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
