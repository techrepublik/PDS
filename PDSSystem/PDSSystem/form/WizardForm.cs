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
    public partial class WizardForm : Form
    {

        private string _surname;
        private string _firstName;
        private string _middleName;
        private string _suffixName;
        public WizardForm()
        {
            InitializeComponent();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (jTabWizard1.SelectedIndex < jTabWizard1.TabCount)
            {
                jTabWizard1.SelectTab(jTabWizard1.SelectedIndex + 1);
                selectTab();
            }
            
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (jTabWizard1.SelectedIndex > 0)
            {
                jTabWizard1.SelectTab(jTabWizard1.SelectedIndex - 1);
                selectTab();
            }
            
        }

        private void selectTab()
        {
            switch (jTabWizard1.SelectedIndex)
            {
                case 0:
                    label1.BorderStyle = BorderStyle.FixedSingle;
                    label2.BorderStyle = BorderStyle.None;
                    label3.BorderStyle = BorderStyle.None;
                    label4.BorderStyle = BorderStyle.None;
                    label5.BorderStyle = BorderStyle.None;
                    label6.BorderStyle = BorderStyle.None;
                    label7.BorderStyle = BorderStyle.None;
                    label8.BorderStyle = BorderStyle.None;
                    label9.BorderStyle = BorderStyle.None;
                    label10.BorderStyle = BorderStyle.None;
                    break;
                case 1:
                    label1.BorderStyle = BorderStyle.None;
                    label2.BorderStyle = BorderStyle.FixedSingle;
                    label3.BorderStyle = BorderStyle.None;
                    label4.BorderStyle = BorderStyle.None;
                    label5.BorderStyle = BorderStyle.None;
                    label6.BorderStyle = BorderStyle.None;
                    label7.BorderStyle = BorderStyle.None;
                    label8.BorderStyle = BorderStyle.None;
                    label9.BorderStyle = BorderStyle.None;
                    label10.BorderStyle = BorderStyle.None;
                    break;
                case 2:
                    label1.BorderStyle = BorderStyle.None;
                    label2.BorderStyle = BorderStyle.None;
                    label3.BorderStyle = BorderStyle.FixedSingle;
                    label4.BorderStyle = BorderStyle.None;
                    label5.BorderStyle = BorderStyle.None;
                    label6.BorderStyle = BorderStyle.None;
                    label7.BorderStyle = BorderStyle.None;
                    label8.BorderStyle = BorderStyle.None;
                    label9.BorderStyle = BorderStyle.None;
                    label10.BorderStyle = BorderStyle.None;
                    break;
                case 3:
                    label1.BorderStyle = BorderStyle.None;
                    label2.BorderStyle = BorderStyle.None;
                    label3.BorderStyle = BorderStyle.None;
                    label4.BorderStyle = BorderStyle.FixedSingle;
                    label5.BorderStyle = BorderStyle.None;
                    label6.BorderStyle = BorderStyle.None;
                    label7.BorderStyle = BorderStyle.None;
                    label8.BorderStyle = BorderStyle.None;
                    label9.BorderStyle = BorderStyle.None;
                    label10.BorderStyle = BorderStyle.None;
                    break;
                case 4:
                    label1.BorderStyle = BorderStyle.None;
                    label2.BorderStyle = BorderStyle.None;
                    label3.BorderStyle = BorderStyle.None;
                    label4.BorderStyle = BorderStyle.None;
                    label5.BorderStyle = BorderStyle.FixedSingle;
                    label6.BorderStyle = BorderStyle.None;
                    label7.BorderStyle = BorderStyle.None;
                    label8.BorderStyle = BorderStyle.None;
                    label9.BorderStyle = BorderStyle.None;
                    label10.BorderStyle = BorderStyle.None;
                    break;
                case 5:
                    label1.BorderStyle = BorderStyle.None;
                    label2.BorderStyle = BorderStyle.None;
                    label3.BorderStyle = BorderStyle.None;
                    label4.BorderStyle = BorderStyle.None;
                    label5.BorderStyle = BorderStyle.None;
                    label6.BorderStyle = BorderStyle.FixedSingle;
                    label7.BorderStyle = BorderStyle.None;
                    label8.BorderStyle = BorderStyle.None;
                    label9.BorderStyle = BorderStyle.None;
                    label10.BorderStyle = BorderStyle.None;
                    break;
                case 6:
                    label1.BorderStyle = BorderStyle.None;
                    label2.BorderStyle = BorderStyle.None;
                    label3.BorderStyle = BorderStyle.None;
                    label4.BorderStyle = BorderStyle.None;
                    label5.BorderStyle = BorderStyle.None;
                    label6.BorderStyle = BorderStyle.None;
                    label7.BorderStyle = BorderStyle.FixedSingle;
                    label8.BorderStyle = BorderStyle.None;
                    label9.BorderStyle = BorderStyle.None;
                    label10.BorderStyle = BorderStyle.None;
                    break;
                case 7:
                    label1.BorderStyle = BorderStyle.None;
                    label2.BorderStyle = BorderStyle.None;
                    label3.BorderStyle = BorderStyle.None;
                    label4.BorderStyle = BorderStyle.None;
                    label5.BorderStyle = BorderStyle.None;
                    label6.BorderStyle = BorderStyle.None;
                    label7.BorderStyle = BorderStyle.None;
                    label8.BorderStyle = BorderStyle.FixedSingle;
                    label9.BorderStyle = BorderStyle.None;
                    label10.BorderStyle = BorderStyle.None;
                    break;
                case 8:
                    label1.BorderStyle = BorderStyle.None;
                    label2.BorderStyle = BorderStyle.None;
                    label3.BorderStyle = BorderStyle.None;
                    label4.BorderStyle = BorderStyle.None;
                    label5.BorderStyle = BorderStyle.None;
                    label6.BorderStyle = BorderStyle.None;
                    label7.BorderStyle = BorderStyle.None;
                    label8.BorderStyle = BorderStyle.None;
                    label9.BorderStyle = BorderStyle.FixedSingle;
                    label10.BorderStyle = BorderStyle.None;
                    break;
                default:
                    break;
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void WizardForm_Load(object sender, EventArgs e)
        {
            label1.BorderStyle = BorderStyle.FixedSingle;
        }

        private void getName()
        {
            labelName.Text = String.Format("{0}, {1} {2}", _surname.ToUpper(), _firstName, _middleName);
        }

        private void surNameTextBox_TextChanged(object sender, EventArgs e)
        {
            _surname = surNameTextBox.Text;
            getName();
        }

        private void firstNameTextBox_TextChanged(object sender, EventArgs e)
        {
            _firstName = firstNameTextBox.Text;
            getName();
        }

        private void middleNameTextBox_TextChanged(object sender, EventArgs e)
        {
            _middleName = middleNameTextBox.Text;
            getName();
        }
    }
}
