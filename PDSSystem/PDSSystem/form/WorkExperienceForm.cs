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
    public partial class WorkExperienceForm : Form
    {
        public int PersonnelNo { get; set; }
        public Experiency Experience { get; set; }
        public WorkExperienceForm()
        {
            InitializeComponent();
        }

        private void WorkExperienceForm_Load(object sender, EventArgs e)
        {
            if (Experience == null) return;
            experiencyBindingSource.DataSource = Experience;
        }

        private void experiencyBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (experiencyBindingSource != null)
                experiencyBindingNavigatorSaveItem.Enabled = true;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            experienceDate1DateTimePicker.Focus();
        }

        private void experiencyBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (experiencyBindingSource != null)
            {
                Validate();
                ((Experiency)experiencyBindingSource.Current).PersonnelNo = PersonnelNo;
                experiencyBindingSource.EndEdit();
                var iResult = ExperienceManagement.Save((Experiency)experiencyBindingSource.Current);
                if (iResult > 0)
                {
                    MessageBox.Show(@"Record was successfully saved.", @"Save", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    experienceDate1DateTimePicker.Focus();
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
