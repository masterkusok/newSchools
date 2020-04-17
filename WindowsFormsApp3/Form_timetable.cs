using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace WindowsFormsApp3
{
    public partial class Form_timetable : Form
    {
        string loginlogin;
        public Form_timetable(string login)
        {
            InitializeComponent();
            loginlogin = login;
        }

        private void Form_timetable_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            studentForm j = new studentForm(loginlogin);
            this.Hide();
            j.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] Days = new string[8]{"","Русский язык", "Математика", "Физика", 
                "Биология", "Технология", "Обществознание", "Английский язык"};
            day_of_the_weer.Text = comboBox1.Text;
            if(comboBox1.Text == "Понедельник")
            {   
                lesson1.Text = Days[1];
                lesson2.Text = Days[4];
                lesson3.Text = Days[7];
                lesson4.Text = Days[3];
                lesson5.Text = Days[5];
                lesson6.Text = Days[2];
            }
            if (comboBox1.Text == "Вторник")
            {
                lesson1.Text = Days[5];
                lesson2.Text = Days[2];
                lesson3.Text = Days[3];
                lesson4.Text = Days[3];
                lesson5.Text = Days[7];
                lesson6.Text = Days[1];
            }
            if (comboBox1.Text == "Среда")
            {
                lesson1.Text = Days[1];
                lesson2.Text = Days[6];
                lesson3.Text = Days[5];
                lesson4.Text = Days[3];
                lesson5.Text = Days[1];
                lesson6.Text = Days[0];
            }
            if (comboBox1.Text == "Четверг")
            {
                lesson1.Text = Days[3];
                lesson2.Text = Days[2];
                lesson3.Text = Days[1];
                lesson4.Text = Days[3];
                lesson5.Text = Days[5];
                lesson6.Text = Days[7];
            }
            if (comboBox1.Text == "Пятница")
            {
                lesson1.Text = Days[4];
                lesson2.Text = Days[3];
                lesson3.Text = Days[6];
                lesson4.Text = Days[1];
                lesson5.Text = Days[2];
                lesson6.Text = Days[0];
            }
            if (comboBox1.Text == "Суббота")
            {
                lesson1.Text = Days[3];
                lesson2.Text = Days[5];
                lesson3.Text = Days[7];
                lesson4.Text = Days[1];
                lesson5.Text = Days[4];
                lesson6.Text = Days[5];
            }
            if(comboBox1.Text =="Выберите день недели"||comboBox1.Text=="")
            {
                MessageBox.Show("Выберите день недели");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
