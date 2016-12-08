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

        public WizardForm()
        {
            InitializeComponent();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (jTabWizard1.SelectedIndex <= jTabWizard1.TabCount)
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
                    
                    break;
                case 1:
                    label2.BorderStyle = BorderStyle.FixedSingle;
                    break;
                case 2:
                    label3.BorderStyle = BorderStyle.FixedSingle;
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    break;
                case 8:
                    break;
                case 9:
                    break;
                default:
                    break;
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
