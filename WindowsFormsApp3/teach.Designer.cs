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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(309, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добро пожаловать в систему, учитель";
            // 
            // create_but
            // 
            this.create_but.Location = new System.Drawing.Point(248, 395);
            this.create_but.Name = "create_but";
            this.create_but.Size = new System.Drawing.Size(319, 43);
            this.create_but.TabIndex = 1;
            this.create_but.Text = "Создать ученика";
            this.create_but.UseVisualStyleBackColor = true;
            this.create_but.Click += new System.EventHandler(this.button1_Click);
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(61, 126);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(187, 20);
            this.login.TabIndex = 2;
            this.login.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pasword
            // 
            this.pasword.Location = new System.Drawing.Point(61, 190);
            this.pasword.Name = "pasword";
            this.pasword.Size = new System.Drawing.Size(187, 20);
            this.pasword.TabIndex = 3;
            this.pasword.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // login_label
            // 
            this.login_label.AutoSize = true;
            this.login_label.Location = new System.Drawing.Point(58, 94);
            this.login_label.Name = "login_label";
            this.login_label.Size = new System.Drawing.Size(81, 13);
            this.login_label.TabIndex = 4;
            this.login_label.Text = "Введите логин";
            this.login_label.Click += new System.EventHandler(this.login_label_Click);
            // 
            // pasword_label
            // 
            this.pasword_label.AutoSize = true;
            this.pasword_label.Location = new System.Drawing.Point(58, 160);
            this.pasword_label.Name = "pasword_label";
            this.pasword_label.Size = new System.Drawing.Size(88, 13);
            this.pasword_label.TabIndex = 5;
            this.pasword_label.Text = "Введите пароль";
            this.pasword_label.Click += new System.EventHandler(this.pasword_label_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(65, 238);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(176, 17);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Поддтвердите, что это ученик";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // create_final
            // 
            this.create_final.Location = new System.Drawing.Point(248, 342);
            this.create_final.Name = "create_final";
            this.create_final.Size = new System.Drawing.Size(318, 47);
            this.create_final.TabIndex = 7;
            this.create_final.Text = "Создать ученика";
            this.create_final.UseVisualStyleBackColor = true;
            this.create_final.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // teach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.create_final);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.pasword_label);
            this.Controls.Add(this.login_label);
            this.Controls.Add(this.pasword);
            this.Controls.Add(this.login);
            this.Controls.Add(this.create_but);
            this.Controls.Add(this.label1);
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
    }
}