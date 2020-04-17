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
    public partial class Form_diary : Form
    {
        string loginlogin;
        public Form_diary(string login)
        {
            InitializeComponent();
            loginlogin = login;
        }

        private void Form_diary_Load(object sender, EventArgs e)
        {

        }

        private void backBtn_Click_1(object sender, EventArgs e)
        {
            studentForm sf = new studentForm(loginlogin);
            sf.Show();
            this.Hide();
            this.Close();
        }
    }
}
