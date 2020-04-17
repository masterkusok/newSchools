using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form_profile : Form
    {
        string loginlogin;
        public Form_profile(string login)
        { 
            InitializeComponent();
            loginlogin = login;
            string Name, Surname, Otches, Class;
            using (StreamReader sw = new StreamReader("Users/students/" + login + ".txt"))
            {
                Name = sw.ReadLine();
                Surname = sw.ReadLine();
                Otches = sw.ReadLine();
                Class = sw.ReadLine();
                sw.Close();
            }

            sName.Text = "Имя - " + Name;
            sSurname.Text = "Фамилия - " + Surname;
            sOtchestv.Text = "Отчество - " + Otches;
            sClass.Text = "класс  - " + Class;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            studentForm sf = new studentForm(loginlogin);
            sf.Show();
            this.Hide();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
