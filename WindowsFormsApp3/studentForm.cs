using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class studentForm : Form
    {
        string loginlogin;
        public studentForm(string login)
        {
            InitializeComponent();
            loginlogin = login;
        }

        private void bprofile_Click(object sender, EventArgs e)
        {
            Form_profile f = new Form_profile(loginlogin);
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void bdiary_Click(object sender, EventArgs e)
        {
            Form_diary d = new Form_diary(loginlogin);
            this.Hide();
            d.ShowDialog();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bexit_Click(object sender, EventArgs e)
        {
            loginForm lf = new loginForm();
            lf.Show();
            this.Hide();
            this.Close();
        }
    }
}
