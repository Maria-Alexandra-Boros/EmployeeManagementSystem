
namespace EmployeeManagementSystem
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.exit = new System.Windows.Forms.Label();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.login_username = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.login_password = new System.Windows.Forms.TextBox();
            this.login_showPassword = new System.Windows.Forms.CheckBox();
            this.login_button = new System.Windows.Forms.Button();
            this.RegisterAccLabel = new System.Windows.Forms.Label();
            this.login_signup = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(105)))), ((int)(((byte)(122)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.login_signup);
            this.panel1.Controls.Add(this.RegisterAccLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(457, 704);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.exit.Location = new System.Drawing.Point(957, 9);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(32, 36);
            this.exit.TabIndex = 1;
            this.exit.Text = "X";
            this.exit.Click += new System.EventHandler(this.Xbutton_Click);
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Cambria Math", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginLabel.Location = new System.Drawing.Point(477, 45);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(326, 206);
            this.LoginLabel.TabIndex = 2;
            this.LoginLabel.Text = "Login Account";
            this.LoginLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Tahoma", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.Location = new System.Drawing.Point(489, 218);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(145, 33);
            this.UsernameLabel.TabIndex = 3;
            this.UsernameLabel.Text = "Username:";
            this.UsernameLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // login_username
            // 
            this.login_username.Font = new System.Drawing.Font("Tahoma", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_username.Location = new System.Drawing.Point(495, 267);
            this.login_username.Multiline = true;
            this.login_username.Name = "login_username";
            this.login_username.Size = new System.Drawing.Size(450, 40);
            this.login_username.TabIndex = 4;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Tahoma", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(489, 355);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(138, 33);
            this.PasswordLabel.TabIndex = 5;
            this.PasswordLabel.Text = "Password:";
            this.PasswordLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // login_password
            // 
            this.login_password.Font = new System.Drawing.Font("Tahoma", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_password.Location = new System.Drawing.Point(495, 400);
            this.login_password.Multiline = true;
            this.login_password.Name = "login_password";
            this.login_password.Size = new System.Drawing.Size(450, 40);
            this.login_password.TabIndex = 6;
            // 
            // login_showPassword
            // 
            this.login_showPassword.AutoSize = true;
            this.login_showPassword.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_showPassword.Location = new System.Drawing.Point(734, 455);
            this.login_showPassword.Name = "login_showPassword";
            this.login_showPassword.Size = new System.Drawing.Size(211, 33);
            this.login_showPassword.TabIndex = 7;
            this.login_showPassword.Text = "Show Password";
            this.login_showPassword.UseVisualStyleBackColor = true;
            // 
            // login_button
            // 
            this.login_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(166)))), ((int)(((byte)(43)))));
            this.login_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_button.FlatAppearance.BorderSize = 0;
            this.login_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(192)))), ((int)(((byte)(204)))));
            this.login_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(192)))), ((int)(((byte)(204)))));
            this.login_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_button.Font = new System.Drawing.Font("Tahoma", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.login_button.Location = new System.Drawing.Point(500, 510);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(156, 68);
            this.login_button.TabIndex = 8;
            this.login_button.Text = "LOGIN";
            this.login_button.UseVisualStyleBackColor = false;
            this.login_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // RegisterAccLabel
            // 
            this.RegisterAccLabel.AutoSize = true;
            this.RegisterAccLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterAccLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RegisterAccLabel.Location = new System.Drawing.Point(103, 575);
            this.RegisterAccLabel.Name = "RegisterAccLabel";
            this.RegisterAccLabel.Size = new System.Drawing.Size(245, 29);
            this.RegisterAccLabel.TabIndex = 0;
            this.RegisterAccLabel.Text = "Register your account";
            // 
            // login_signup
            // 
            this.login_signup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(166)))), ((int)(((byte)(43)))));
            this.login_signup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_signup.FlatAppearance.BorderSize = 0;
            this.login_signup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(192)))), ((int)(((byte)(204)))));
            this.login_signup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(192)))), ((int)(((byte)(204)))));
            this.login_signup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_signup.Font = new System.Drawing.Font("Tahoma", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_signup.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.login_signup.Location = new System.Drawing.Point(74, 616);
            this.login_signup.Name = "login_signup";
            this.login_signup.Size = new System.Drawing.Size(305, 52);
            this.login_signup.TabIndex = 9;
            this.login_signup.Text = "SIGN UP";
            this.login_signup.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 269);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(412, 35);
            this.label1.TabIndex = 10;
            this.label1.Text = "Employee Management System";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EmployeeManagementSystem.Properties.Resources.Design_fără_titlu__3_;
            this.pictureBox1.Location = new System.Drawing.Point(144, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1001, 704);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.login_showPassword);
            this.Controls.Add(this.login_password);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.login_username);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.TextBox login_username;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox login_password;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button login_signup;
        private System.Windows.Forms.Label RegisterAccLabel;
        private System.Windows.Forms.CheckBox login_showPassword;
        private System.Windows.Forms.Button login_button;
    }
}

