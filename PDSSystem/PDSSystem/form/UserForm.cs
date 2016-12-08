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
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void userBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (userBindingSource != null)
            {
                userBindingNavigatorSaveItem.Enabled = true;
            }

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            userNameTextBox.Focus();
        }

        private void userBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (userBindingSource != null)
            {
                Validate();
                userBindingSource.EndEdit();
                var iResult = UserManagement.Save((User)userBindingSource.Current);
                if (iResult > 0)
                {
                    MessageBox.Show(@"Record was successfully saved.", @"Save", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    userNameTextBox.Focus();
                }
                else
                {
                    MessageBox.Show(@"Error occurred in saving.", @"Save", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            userBindingSource.DataSource = UserManagement.GetAll();
            Cursor.Current = Cursors.Default;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            DeleteUser();
            Cursor.Current = Cursors.Default;
        }

        private void DeleteUser()
        {
            if (userBindingSource != null)
            {
                var dResult = MessageBox.Show(@"Delete current record?", @"Delete", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (dResult == DialogResult.Yes)
                {
                    if (UserManagement.Delete(((User)userBindingSource.Current).UserNo))
                    {
                        MessageBox.Show(@"Record was deleted successfully.", @"Delete", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        userBindingSource.RemoveCurrent();
                    }
                    else
                    {
                        MessageBox.Show(@"Error on delete operation.", @"Delete", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        userDataGridView.Focus();
                    }
                }
            }
        }
    }
}
