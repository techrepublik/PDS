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

namespace PDSSystem
{
    public partial class LoginForm : Form
    {
        public User User { get; set; }
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text.Length > 0) && (textBox2.Text.Length) > 0)
            {
                User = UserManagement.ValiDateUser(textBox1.Text, textBox2.Text);
                if (User != null)
                {
                    var f = new MainForm
                    {
                        WindowState = FormWindowState.Maximized,
                        User = User
                    };
                    f.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(@"Incorrect Username and Password. Please try again.", @"Login", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    textBox1.Focus();
                }
            }
            else
            {
                MessageBox.Show(@"Empty username or password. Please try again.", @"Login", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                textBox1.Focus();
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
