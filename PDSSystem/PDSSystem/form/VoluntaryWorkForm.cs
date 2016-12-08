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
    public partial class VoluntaryWorkForm : Form
    {
        public int PersonnelNo { get; set; }
        public Voluntary Voluntary { get; set; }
        public VoluntaryWorkForm()
        {
            InitializeComponent();
        }

        private void voluntaryBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (voluntaryBindingSource != null)
                voluntaryBindingNavigatorSaveItem.Enabled = true;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            voluntaryOrganizationTextBox.Focus();
        }

        private void voluntaryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (voluntaryBindingSource != null)
            {
                Validate();
                ((Voluntary)voluntaryBindingSource.Current).PersonnelNo = PersonnelNo;
                voluntaryBindingSource.EndEdit();
                var iResult = VoluntaryManagement.Save((Voluntary)voluntaryBindingSource.Current);
                if (iResult > 0)
                {
                    MessageBox.Show(@"Record was successfully saved.", @"Save", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    voluntaryOrganizationTextBox.Focus();
                }
                else
                {
                    MessageBox.Show(@"Error occurred in saving.", @"Save", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void VoluntaryWorkForm_Load(object sender, EventArgs e)
        {
            if (Voluntary == null) return;
            voluntaryBindingSource.DataSource = Voluntary;
        }
    }
}
