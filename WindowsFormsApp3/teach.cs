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
    public partial class teach : Form
    {
        string loginlog;
        public teach(string login)
        {
            InitializeComponent();
            loginlog = login;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            create_but.Hide();
            login_label.Show();
            login.Show();
            pasword.Show();
            pasword_label.Show();
            radioButton1.Show();
            create_final.Show();
            name.Show();
            family.Show();
            otchestvo.Show();
            class_let.Show();
            class_num.Show();
            label2.Show();
            label3.Show();
            label4.Show();
            label5.Show();
        }

        private void login_label_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pasword_label_Click(object sender, EventArgs e)
        {

        }

        private void teach_Load(object sender, EventArgs e)
        {
            login_label.Hide();
            pasword_label.Hide();
            login.Hide();
            pasword.Hide();
            radioButton1.Hide();
            create_final.Hide();
            name.Hide();
            family.Hide();
            otchestvo.Hide();
            class_let.Hide();
            class_num.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string student = "";
            if (radioButton1.Checked)
            {
                student = "2";
            }
        
            File.AppendAllText("Users/database.txt", login.Text + "\r\n");
            File.AppendAllText("Users/database.txt", pasword.Text + "\r\n");
            File.AppendAllText("Users/database.txt", student + "\r\n");

            using (StreamWriter FW = new StreamWriter("Users/students/" + login.Text + ".txt"))

            {
                FW.WriteLine(name.Text);
                FW.WriteLine(family.Text);
                FW.WriteLine(otchestvo.Text);
                FW.WriteLine(class_num.Text + class_let.Text);
                FW.Close();
            }
        }

        private void leaveBtn_Click(object sender, EventArgs e)
        {
            loginForm lf = new loginForm();
            lf.Show();
            this.Hide();
            this.Close();
        }
    }
}
