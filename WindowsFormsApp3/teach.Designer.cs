﻿namespace WindowsFormsApp1
{
    partial class teach
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
            this.create_but = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.TextBox();
            this.pasword = new System.Windows.Forms.TextBox();
            this.login_label = new System.Windows.Forms.Label();
            this.pasword_label = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.create_final = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.family = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.otchestvo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.class_num = new System.Windows.Forms.ComboBox();
            this.class_let = new System.Windows.Forms.ComboBox();
            this.leaveBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(412, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добро пожаловать в систему, учитель";
            // 
            // create_but
            // 
            this.create_but.Location = new System.Drawing.Point(331, 486);
            this.create_but.Margin = new System.Windows.Forms.Padding(4);
            this.create_but.Name = "create_but";
            this.create_but.Size = new System.Drawing.Size(425, 53);
            this.create_but.TabIndex = 1;
            this.create_but.Text = "Создать ученика";
            this.create_but.UseVisualStyleBackColor = true;
            this.create_but.Click += new System.EventHandler(this.button1_Click);
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(81, 53);
            this.login.Margin = new System.Windows.Forms.Padding(4);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(248, 22);
            this.login.TabIndex = 2;
            this.login.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pasword
            // 
            this.pasword.Location = new System.Drawing.Point(81, 101);
            this.pasword.Margin = new System.Windows.Forms.Padding(4);
            this.pasword.Name = "pasword";
            this.pasword.Size = new System.Drawing.Size(248, 22);
            this.pasword.TabIndex = 3;
            this.pasword.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // login_label
            // 
            this.login_label.AutoSize = true;
            this.login_label.Location = new System.Drawing.Point(77, 33);
            this.login_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.login_label.Name = "login_label";
            this.login_label.Size = new System.Drawing.Size(104, 17);
            this.login_label.TabIndex = 4;
            this.login_label.Text = "Введите логин";
            this.login_label.Click += new System.EventHandler(this.login_label_Click);
            // 
            // pasword_label
            // 
            this.pasword_label.AutoSize = true;
            this.pasword_label.Location = new System.Drawing.Point(77, 81);
            this.pasword_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pasword_label.Name = "pasword_label";
            this.pasword_label.Size = new System.Drawing.Size(114, 17);
            this.pasword_label.TabIndex = 5;
            this.pasword_label.Text = "Введите пароль";
            this.pasword_label.Click += new System.EventHandler(this.pasword_label_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(81, 359);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(231, 21);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Поддтвердите, что это ученик";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // create_final
            // 
            this.create_final.Location = new System.Drawing.Point(331, 421);
            this.create_final.Margin = new System.Windows.Forms.Padding(4);
            this.create_final.Name = "create_final";
            this.create_final.Size = new System.Drawing.Size(424, 58);
            this.create_final.TabIndex = 7;
            this.create_final.Text = "Создать ученика";
            this.create_final.UseVisualStyleBackColor = true;
            this.create_final.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Имя";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(81, 149);
            this.name.Margin = new System.Windows.Forms.Padding(4);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(248, 22);
            this.name.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 177);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Фамилия";
            // 
            // family
            // 
            this.family.Location = new System.Drawing.Point(81, 197);
            this.family.Margin = new System.Windows.Forms.Padding(4);
            this.family.Name = "family";
            this.family.Size = new System.Drawing.Size(248, 22);
            this.family.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 225);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Отчество";
            // 
            // otchestvo
            // 
            this.otchestvo.Location = new System.Drawing.Point(81, 245);
            this.otchestvo.Margin = new System.Windows.Forms.Padding(4);
            this.otchestvo.Name = "otchestvo";
            this.otchestvo.Size = new System.Drawing.Size(248, 22);
            this.otchestvo.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 273);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Класс";
            // 
            // class_num
            // 
            this.class_num.FormattingEnabled = true;
            this.class_num.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.class_num.Location = new System.Drawing.Point(81, 293);
            this.class_num.Margin = new System.Windows.Forms.Padding(4);
            this.class_num.Name = "class_num";
            this.class_num.Size = new System.Drawing.Size(248, 24);
            this.class_num.TabIndex = 15;
            // 
            // class_let
            // 
            this.class_let.FormattingEnabled = true;
            this.class_let.Items.AddRange(new object[] {
            "А",
            "Б"});
            this.class_let.Location = new System.Drawing.Point(81, 326);
            this.class_let.Margin = new System.Windows.Forms.Padding(4);
            this.class_let.Name = "class_let";
            this.class_let.Size = new System.Drawing.Size(248, 24);
            this.class_let.TabIndex = 16;
            // 
            // leaveBtn
            // 
            this.leaveBtn.Location = new System.Drawing.Point(880, 45);
            this.leaveBtn.Name = "leaveBtn";
            this.leaveBtn.Size = new System.Drawing.Size(75, 327);
            this.leaveBtn.TabIndex = 17;
            this.leaveBtn.Text = "выйти";
            this.leaveBtn.UseVisualStyleBackColor = true;
            this.leaveBtn.Click += new System.EventHandler(this.leaveBtn_Click);
            // 
            // teach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.leaveBtn);
            this.Controls.Add(this.class_let);
            this.Controls.Add(this.class_num);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.otchestvo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.family);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.create_final);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.pasword_label);
            this.Controls.Add(this.login_label);
            this.Controls.Add(this.pasword);
            this.Controls.Add(this.login);
            this.Controls.Add(this.create_but);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "teach";
            this.Text = "teach";
            this.Load += new System.EventHandler(this.teach_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button create_but;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.TextBox pasword;
        private System.Windows.Forms.Label login_label;
        private System.Windows.Forms.Label pasword_label;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button create_final;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox family;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox otchestvo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox class_num;
        private System.Windows.Forms.ComboBox class_let;
        private System.Windows.Forms.Button leaveBtn;
    }
}