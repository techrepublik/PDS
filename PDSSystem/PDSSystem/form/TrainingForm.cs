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
    public partial class TrainingForm : Form
    {
        public int PersonnelNo { get; set; }
        public Training Training { get; set; }
        public TrainingForm()
        {
            InitializeComponent();
        }

        private void TrainingForm_Load(object sender, EventArgs e)
        {
            if (Training == null) return;
            trainingBindingSource.DataSource = Training;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            trainingNameTextBox.Focus();
        }

        private void trainingBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (trainingBindingSource != null)
            {
                Validate();
                ((Training)trainingBindingSource.Current).PersonnelNo = PersonnelNo;
                trainingBindingSource.EndEdit();
                var iResult = TrainingManagement.Save((Training)trainingBindingSource.Current);
                if (iResult > 0)
                {
                    MessageBox.Show(@"Record was successfully saved.", @"Save", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    trainingNameTextBox.Focus();
                }
                else
                {
                    MessageBox.Show(@"Error occurred in saving.", @"Save", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void trainingBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (trainingBindingSource != null)
                trainingBindingNavigatorSaveItem.Enabled = true;
        }
    }
}
