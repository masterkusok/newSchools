namespace WindowsFormsApp1
{
    partial class Form_profile
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
            this.sName = new System.Windows.Forms.Label();
            this.sSurname = new System.Windows.Forms.Label();
            this.sOtchestv = new System.Windows.Forms.Label();
            this.sClass = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(324, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Профиль";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // sName
            // 
            this.sName.AutoSize = true;
            this.sName.Location = new System.Drawing.Point(72, 79);
            this.sName.Name = "sName";
            this.sName.Size = new System.Drawing.Size(46, 17);
            this.sName.TabIndex = 1;
            this.sName.Text = "label2";
            // 
            // sSurname
            // 
            this.sSurname.AutoSize = true;
            this.sSurname.Location = new System.Drawing.Point(72, 155);
            this.sSurname.Name = "sSurname";
            this.sSurname.Size = new System.Drawing.Size(46, 17);
            this.sSurname.TabIndex = 2;
            this.sSurname.Text = "label3";
            // 
            // sOtchestv
            // 
            this.sOtchestv.AutoSize = true;
            this.sOtchestv.Location = new System.Drawing.Point(71, 219);
            this.sOtchestv.Name = "sOtchestv";
            this.sOtchestv.Size = new System.Drawing.Size(46, 17);
            this.sOtchestv.TabIndex = 3;
            this.sOtchestv.Text = "label4";
            // 
            // sClass
            // 
            this.sClass.AutoSize = true;
            this.sClass.Location = new System.Drawing.Point(71, 283);
            this.sClass.Name = "sClass";
            this.sClass.Size = new System.Drawing.Size(46, 17);
            this.sClass.TabIndex = 4;
            this.sClass.Text = "label5";
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(683, 56);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 312);
            this.backBtn.TabIndex = 5;
            this.backBtn.Text = "назад";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // Form_profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.sClass);
            this.Controls.Add(this.sOtchestv);
            this.Controls.Add(this.sSurname);
            this.Controls.Add(this.sName);
            this.Controls.Add(this.label1);
            this.Name = "Form_profile";
            this.Text = "Form_profile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label sName;
        private System.Windows.Forms.Label sSurname;
        private System.Windows.Forms.Label sOtchestv;
        private System.Windows.Forms.Label sClass;
        private System.Windows.Forms.Button backBtn;
    }
}