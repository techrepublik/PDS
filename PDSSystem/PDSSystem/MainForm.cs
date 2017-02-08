using System;
using System.Windows.Forms;
using PDSSystem.dal.data;
using PDSSystem.form;

namespace PDSSystem
{
    public partial class MainForm : Form
    {
        public User User { get; set; }
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //toolStripStatusLabel1.Text = String.Format(@"WELCOME {0}",User.UserName);
        }

        private void pDSListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new SummaryListForm
            {
                MdiParent = this,
                WindowState = FormWindowState.Maximized
            };
            f.Show();
        }

        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new PreferencesForm
            {
                MaximizeBox = false,
                MinimizeBox = false,
                StartPosition = FormStartPosition.CenterScreen,
                FormBorderStyle = FormBorderStyle.FixedSingle
            };
            f.ShowDialog();
        }

        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new UserForm
            {
                MaximizeBox = false,
                MinimizeBox = false,
                StartPosition = FormStartPosition.CenterScreen,
                FormBorderStyle = FormBorderStyle.FixedSingle
            };
            f.ShowDialog();
        }

        private void updatePDSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new ReportPDSForm
            {
                MdiParent = this,
                WindowState = FormWindowState.Maximized
            };
            f.Show();
        }

        private void toolStripButtonPDSList_Click(object sender, EventArgs e)
        {
            var f = new SummaryListForm
            {
                MdiParent = this,
                WindowState = FormWindowState.Maximized
            };
            f.Show();
        }

        private void toolStripButtonBarcode_Click(object sender, EventArgs e)
        {
            var f = new ReportPDSForm
            {
                MdiParent = this,
                WindowState = FormWindowState.Maximized
            };
            f.Show();
        }

        private void wizardFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new WizardForm
            {
                MdiParent = this,
                WindowState = FormWindowState.Maximized
            };
            f.Show();
        }

        private void leavePreferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new LeavePreferencesForm
            {
                MaximizeBox = false,
                MinimizeBox = false,
                StartPosition = FormStartPosition.CenterScreen,
                FormBorderStyle = FormBorderStyle.FixedSingle,
            };
            f.ShowDialog();
        }

        private void listOfLeaveApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new LeaveForm
            {
                MdiParent = this,
                WindowState = FormWindowState.Maximized
            };
            f.Show();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            var f = new WizardForm
            {
                MdiParent = this,
                WindowState = FormWindowState.Maximized
            };
            f.Show();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.UserClosing) return;
            if (MessageBox.Show(@"Are you sure want to exit?",
                @"PDS System",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Information) == DialogResult.OK)
                Environment.Exit(1);
            else
                e.Cancel = true; // to don't close form is user change his mind
        }
    }
}
