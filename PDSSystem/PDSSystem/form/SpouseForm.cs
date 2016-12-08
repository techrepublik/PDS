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
    public partial class SpouseForm : Form
    {
        public int PersonnelNo { get; set; }
        public Spous Spouse { get; set; }
        public SpouseForm()
        {
            InitializeComponent();
        }

        private void spousBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (spousBindingSource != null)
                spousBindingNavigatorSaveItem.Enabled = true;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            spouseFirstNameTextBox.Focus();
        }

        private void spousBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            saveSpouse();
            Cursor.Current = Cursors.Default;
        }

        private void saveSpouse()
        {
            var listChildren = new List<Children>();
            if ((childrenBindingSource != null) && (childrenDataGridView != null))
            {
                foreach (Children item in childrenBindingSource)
                {
                    var c = new Children
                    {
                        ChildrenNo = item.ChildrenNo,
                        ChildrenLastName = item.ChildrenLastName,
                        ChildrenFirstName = item.ChildrenFirstName,
                        ChildrenMiddleName = item.ChildrenMiddleName,
                        ChildrenBirthDate = item.ChildrenBirthDate,
                        SpouseNo = item.SpouseNo
                    };

                    listChildren.Add(c);
                }
            }

            if (spousBindingSource != null)
            {
                Validate();
                ((Spous)spousBindingSource.Current).PersonnelNo = PersonnelNo;
                spousBindingSource.EndEdit();
                var iResult = SpouseManagement.Save((Spous)spousBindingSource.Current);
                if (iResult > 0)
                {
                    var iCount = 0;
                    foreach (var item in listChildren)
                    {
                        var c = new Children
                        {
                            ChildrenNo = item.ChildrenNo,
                            ChildrenLastName = item.ChildrenLastName,
                            ChildrenFirstName = item.ChildrenFirstName,
                            ChildrenMiddleName = item.ChildrenMiddleName,
                            ChildrenBirthDate = item.ChildrenBirthDate,
                            modifieddate = DateTime.Now,
                            SpouseNo = iResult
                        };

                        if (ChildrenManagement.Save(c) > 0)
                            iCount += 1;
                    }

                    if (listChildren.Count == iCount)
                    {
                        MessageBox.Show(@"Record was successfully saved.", @"Save", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                        spouseSurNameTextBox.Focus();
                    }
                    else
                    {
                        MessageBox.Show(@"There was problem on the children record on saving.", @"Save", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show(@"Error occurred in saving.", @"Save", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }

        }

        private void SpouseForm_Load(object sender, EventArgs e)
        {
            bindingNavigatorDeleteItem.Enabled = false;
            if (Spouse == null) return;
            spousBindingSource.DataSource = Spouse;
            childrenBindingSource.DataSource = ChildrenManagement.GetAll(Spouse.SpouseNo);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            DeleteChildren();
        }

        private void DeleteChildren()
        {
            if (childrenBindingSource?.Current == null) return;
                var dResult = MessageBox.Show(@"Delete Children's current record?", @"Delete", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (dResult == DialogResult.Yes)
                {
                    if (ChildrenManagement.Delete(((Children)childrenBindingSource.Current).ChildrenNo))
                    {
                        MessageBox.Show(@"Record was deleted successfully.", @"Delete", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        childrenBindingSource.RemoveCurrent();
                    }
                    else
                    {
                        MessageBox.Show(@"Error on delete operation.", @"Delete", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        childrenDataGridView.Focus();
                    }
                }
        }

        private void childrenDataGridView_Enter(object sender, EventArgs e)
        {
            bindingNavigatorDeleteItem.Enabled = true;
        }

        private void childrenDataGridView_Leave(object sender, EventArgs e)
        {
            bindingNavigatorDeleteItem.Enabled = false;
        }
    }
}
