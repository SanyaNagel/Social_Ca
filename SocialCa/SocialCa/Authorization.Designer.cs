namespace SocialCa
{
    partial class Authorization
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
            this.input_B = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.login_TB = new System.Windows.Forms.TextBox();
            this.pasword_TB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.registration_B = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // input_B
            // 
            this.input_B.Location = new System.Drawing.Point(59, 124);
            this.input_B.Name = "input_B";
            this.input_B.Size = new System.Drawing.Size(111, 23);
            this.input_B.TabIndex = 0;
            this.input_B.Text = "Вход";
            this.input_B.UseVisualStyleBackColor = true;
            this.input_B.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Логин";
            // 
            // login_TB
            // 
            this.login_TB.Location = new System.Drawing.Point(59, 36);
            this.login_TB.Name = "login_TB";
            this.login_TB.Size = new System.Drawing.Size(111, 20);
            this.login_TB.TabIndex = 2;
            // 
            // pasword_TB
            // 
            this.pasword_TB.Location = new System.Drawing.Point(59, 83);
            this.pasword_TB.Name = "pasword_TB";
            this.pasword_TB.Size = new System.Drawing.Size(111, 20);
            this.pasword_TB.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Пароль";
            // 
            // registration_B
            // 
            this.registration_B.Location = new System.Drawing.Point(59, 153);
            this.registration_B.Name = "registration_B";
            this.registration_B.Size = new System.Drawing.Size(111, 23);
            this.registration_B.TabIndex = 5;
            this.registration_B.Text = "Регистрация";
            this.registration_B.UseVisualStyleBackColor = true;
            this.registration_B.Click += new System.EventHandler(this.registration_B_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Вывод:";
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 196);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.registration_B);
            this.Controls.Add(this.pasword_TB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.login_TB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.input_B);
            this.Name = "Authorization";
            this.Text = "Authorization";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button input_B;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox login_TB;
        private System.Windows.Forms.TextBox pasword_TB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button registration_B;
        private System.Windows.Forms.Label label3;
    }
}