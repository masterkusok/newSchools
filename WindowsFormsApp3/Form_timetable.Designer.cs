namespace WindowsFormsApp3
{
    partial class Form_timetable
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.day_of_the_weer = new System.Windows.Forms.GroupBox();
            this.lesson6 = new System.Windows.Forms.Label();
            this.lesson5 = new System.Windows.Forms.Label();
            this.lesson4 = new System.Windows.Forms.Label();
            this.lesson3 = new System.Windows.Forms.Label();
            this.lesson2 = new System.Windows.Forms.Label();
            this.lesson1 = new System.Windows.Forms.Label();
            this.day_of_the_weer.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(326, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Расписание";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Выберите день недели",
            "Понедельник",
            "Вторник",
            "Среда",
            "Четверг",
            "Пятница",
            "Суббота"});
            this.comboBox1.Location = new System.Drawing.Point(233, 72);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(303, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(674, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(560, 67);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 32);
            this.button2.TabIndex = 3;
            this.button2.Text = "Применить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // day_of_the_weer
            // 
            this.day_of_the_weer.Controls.Add(this.lesson6);
            this.day_of_the_weer.Controls.Add(this.lesson5);
            this.day_of_the_weer.Controls.Add(this.lesson4);
            this.day_of_the_weer.Controls.Add(this.lesson3);
            this.day_of_the_weer.Controls.Add(this.lesson2);
            this.day_of_the_weer.Controls.Add(this.lesson1);
            this.day_of_the_weer.Location = new System.Drawing.Point(253, 149);
            this.day_of_the_weer.Name = "day_of_the_weer";
            this.day_of_the_weer.Size = new System.Drawing.Size(271, 247);
            this.day_of_the_weer.TabIndex = 4;
            this.day_of_the_weer.TabStop = false;
            // 
            // lesson6
            // 
            this.lesson6.AutoSize = true;
            this.lesson6.Location = new System.Drawing.Point(84, 209);
            this.lesson6.Name = "lesson6";
            this.lesson6.Size = new System.Drawing.Size(0, 17);
            this.lesson6.TabIndex = 5;
            // 
            // lesson5
            // 
            this.lesson5.AutoSize = true;
            this.lesson5.Location = new System.Drawing.Point(84, 169);
            this.lesson5.Name = "lesson5";
            this.lesson5.Size = new System.Drawing.Size(0, 17);
            this.lesson5.TabIndex = 4;
            // 
            // lesson4
            // 
            this.lesson4.AutoSize = true;
            this.lesson4.Location = new System.Drawing.Point(84, 129);
            this.lesson4.Name = "lesson4";
            this.lesson4.Size = new System.Drawing.Size(0, 17);
            this.lesson4.TabIndex = 3;
            // 
            // lesson3
            // 
            this.lesson3.AutoSize = true;
            this.lesson3.Location = new System.Drawing.Point(84, 96);
            this.lesson3.Name = "lesson3";
            this.lesson3.Size = new System.Drawing.Size(0, 17);
            this.lesson3.TabIndex = 2;
            // 
            // lesson2
            // 
            this.lesson2.AutoSize = true;
            this.lesson2.Location = new System.Drawing.Point(84, 62);
            this.lesson2.Name = "lesson2";
            this.lesson2.Size = new System.Drawing.Size(0, 17);
            this.lesson2.TabIndex = 1;
            // 
            // lesson1
            // 
            this.lesson1.AutoSize = true;
            this.lesson1.Location = new System.Drawing.Point(84, 30);
            this.lesson1.Name = "lesson1";
            this.lesson1.Size = new System.Drawing.Size(0, 17);
            this.lesson1.TabIndex = 0;
            // 
            // Form_timetable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.day_of_the_weer);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form_timetable";
            this.Text = "Form_timetable";
            this.Load += new System.EventHandler(this.Form_timetable_Load);
            this.day_of_the_weer.ResumeLayout(false);
            this.day_of_the_weer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox day_of_the_weer;
        private System.Windows.Forms.Label lesson6;
        private System.Windows.Forms.Label lesson5;
        private System.Windows.Forms.Label lesson4;
        private System.Windows.Forms.Label lesson3;
        private System.Windows.Forms.Label lesson2;
        private System.Windows.Forms.Label lesson1;
    }
}