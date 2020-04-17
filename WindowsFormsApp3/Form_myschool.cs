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
    public partial class Form_myschool : Form
    {
        public string loginlogin;
        public static String[] classi = new String[40] { "Абаткин Максим", "Анастасенко Николай", "Арфин Григорий", "Асеева Кристина",
            "Бровина Нина", "Бородина Валерия", "Горбачов Иван", "Гулянов Кирилл", "Гловарёв Сергей", "Гурова Алёна", "Воронцов Илья",
            "Иванов Дмитрий", "Горбушкин Даниил", "Волненко Егор", "Драмова Валентина", "Абрамов Никита", "Петров Павел", "Сидорова Мария",
            "Кручинин Юрий", "Рожков Артём", "Тополев Вадим", "Городной Пётр", "Эрнандес Александр", "Вароненко Ангелина", "Носов Антон",
            "Перилов Глеб", "Фролов Василий", "Вахненко Алина", "Кузнецов Алексей", "Печорин Богдан", "Печкин Артур", "Звукова Елизавета",
            "Терешкова Галина", "Васнецова Дарья", "Тронов Владимир", "Тарасенко Константин", "Кротов Виталий", "Баринов Виктор", "Жабина Анна",
            "Костина Софья" };
        public Form_myschool(string login)
        {
            InitializeComponent();
            loginlogin = login;
        if(comboBox1.Text == "1" && comboBox2.Text == "а")
            {
                name1.Text = classi[0];
                name2.Text = classi[1];
                name3.Text = classi[2];
                name4.Text = classi[3];
                name5.Text = classi[4];
            }
            if(comboBox1.Text == "1" && comboBox2.Text == "б")
            {
                name1.Text = classi[5];
                name2.Text = classi[6];
                name3.Text = classi[7];
                name4.Text = classi[8];
                name5.Text = classi[9];
            }
            if(comboBox1.Text == "2" && comboBox2.Text == "а")
            {
                name1.Text = classi[10];
                name2.Text = classi[11];
                name3.Text = classi[12];
                name4.Text = classi[13];
                name5.Text = classi[14];
            }
            if(comboBox1.Text == "2" && comboBox2.Text == "б")
            {
                name1.Text = classi[15];
                name2.Text = classi[16];
                name3.Text = classi[17];
                name4.Text = classi[18];
                name5.Text = classi[19];
            }
            if(comboBox1.Text == "3" && comboBox2.Text == "а")
            {
                name1.Text = classi[20];
                name2.Text = classi[21];
                name3.Text = classi[22];
                name4.Text = classi[23];
                name5.Text = classi[24];
            }
            if(comboBox1.Text == "3" && comboBox2.Text == "б")
            {
                name1.Text = classi[25];
                name2.Text = classi[26];
                name3.Text = classi[27];
                name4.Text = classi[28];
                name5.Text = classi[29];
            }
            if(comboBox1.Text == "4" && comboBox2.Text == "а")
            {
                name1.Text = classi[30];
                name2.Text = classi[31];
                name3.Text = classi[32];
                name4.Text = classi[33];
                name5.Text = classi[34];
            }
            if(comboBox1.Text == "4" && comboBox2.Text == "б")
            {
                name1.Text = classi[35];
                name2.Text = classi[36];
                name3.Text = classi[37];
                name4.Text = classi[38];
                name5.Text = classi[39];
            }

        }

        

        private void Form_myschool_Load(object sender, EventArgs e)
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
            groupBox1.Text = comboBox1.Text + comboBox2.Text;
            if (comboBox1.Text == "1" && comboBox2.Text == "а")
            {  
                name1.Text = classi[0];
                name2.Text = classi[1];
                name3.Text = classi[2];
                name4.Text = classi[3];
                name5.Text = classi[4];
            }
            if (comboBox1.Text == "1" && comboBox2.Text == "б")
            {
                name1.Text = classi[5];
                name2.Text = classi[6];
                name3.Text = classi[7];
                name4.Text = classi[8];
                name5.Text = classi[9];
            }
            if (comboBox1.Text == "2" && comboBox2.Text == "а")
            {
                name1.Text = classi[10];
                name2.Text = classi[11];
                name3.Text = classi[12];
                name4.Text = classi[13];
                name5.Text = classi[14];
            }
            if (comboBox1.Text == "2" && comboBox2.Text == "б")
            {
                name1.Text = classi[15];
                name2.Text = classi[16];
                name3.Text = classi[17];
                name4.Text = classi[18];
                name5.Text = classi[19];
            }
            if (comboBox1.Text == "3" && comboBox2.Text == "а")
            {
                name1.Text = classi[20];
                name2.Text = classi[21];
                name3.Text = classi[22];
                name4.Text = classi[23];
                name5.Text = classi[24];
            }
            if (comboBox1.Text == "3" && comboBox2.Text == "б")
            {
                name1.Text = classi[25];
                name2.Text = classi[26];
                name3.Text = classi[27];
                name4.Text = classi[28];
                name5.Text = classi[29];
            }
            if (comboBox1.Text == "4" && comboBox2.Text == "а")
            {
                name1.Text = classi[30];
                name2.Text = classi[31];
                name3.Text = classi[32];
                name4.Text = classi[33];
                name5.Text = classi[34];
            }
            if (comboBox1.Text == "4" && comboBox2.Text == "б")
            {
                name1.Text = classi[35];
                name2.Text = classi[36];
                name3.Text = classi[37];
                name4.Text = classi[38];
                name5.Text = classi[39];
            }




        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
