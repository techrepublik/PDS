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
    public partial class LeaveCreditForm : Form
    {
        public LeaveCreditForm()
        {
            InitializeComponent();
        }

        private void LeaveCreditForm_Load(object sender, EventArgs e)
        {
            initcontrols();
        }

        private void initcontrols()
        {
            foreach (var item in UtilityManager.util.UtilClass.FillMonth())
            {
                comboBox1.Items.Add(item.ToString());
            }
            comboBox1.SelectedIndex = DateTime.Now.Month;

            foreach (var item in UtilityManager.util.UtilClass.FillYear())
            {
                comboBox2.Items.Add(item.ToString());
            }
            comboBox2.SelectedIndex = 0;
        }
    }
}
