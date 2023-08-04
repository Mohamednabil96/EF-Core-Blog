
using System.Drawing;
using System.Windows.Forms;

namespace Task_day3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            RegisterBtn = new Button();
            lblName = new Label();
            AuthorNameTextBox = new TextBox();
            UsernameTextBox = new TextBox();
            label2 = new Label();
            PasswordTextBox = new TextBox();
            label3 = new Label();
            AgeTextBox = new TextBox();
            label4 = new Label();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            buttonphoto = new Button();
            label1 = new Label();
            btnLogin = new Button();
            label6 = new Label();
            labelWarning = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // RegisterBtn
            // 
            RegisterBtn.BackColor = Color.Green;
            RegisterBtn.FlatStyle = FlatStyle.Flat;
            RegisterBtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            RegisterBtn.ForeColor = SystemColors.ControlLightLight;
            RegisterBtn.Location = new Point(78, 451);
            RegisterBtn.Name = "RegisterBtn";
            RegisterBtn.Size = new Size(115, 46);
            RegisterBtn.TabIndex = 0;
            RegisterBtn.Text = "Register";
            RegisterBtn.UseVisualStyleBackColor = false;
            RegisterBtn.Click += RegisterBtn_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.Location = new Point(78, 130);
            lblName.Name = "lblName";
            lblName.Size = new Size(75, 31);
            lblName.TabIndex = 1;
            lblName.Text = "Name";
            // 
            // AuthorNameTextBox
            // 
            AuthorNameTextBox.Location = new Point(265, 141);
            AuthorNameTextBox.Name = "AuthorNameTextBox";
            AuthorNameTextBox.Size = new Size(183, 27);
            AuthorNameTextBox.TabIndex = 2;
            // 
            // UsernameTextBox
            // 
            UsernameTextBox.Location = new Point(265, 209);
            UsernameTextBox.Name = "UsernameTextBox";
            UsernameTextBox.Size = new Size(183, 27);
            UsernameTextBox.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(78, 198);
            label2.Name = "label2";
            label2.Size = new Size(117, 31);
            label2.TabIndex = 3;
            label2.Text = "Username";
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(265, 355);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(183, 27);
            PasswordTextBox.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(78, 351);
            label3.Name = "label3";
            label3.Size = new Size(110, 31);
            label3.TabIndex = 5;
            label3.Text = "Password";
            // 
            // AgeTextBox
            // 
            AgeTextBox.Location = new Point(265, 280);
            AgeTextBox.Name = "AgeTextBox";
            AgeTextBox.Size = new Size(183, 27);
            AgeTextBox.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(78, 274);
            label4.Name = "label4";
            label4.Size = new Size(55, 31);
            label4.TabIndex = 9;
            label4.Text = "Age";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(561, 243);
            label5.Name = "label5";
            label5.Size = new Size(74, 31);
            label5.TabIndex = 7;
            label5.Text = "Photo";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(658, 141);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(196, 241);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // buttonphoto
            // 
            buttonphoto.BackColor = SystemColors.ActiveCaption;
            buttonphoto.FlatStyle = FlatStyle.Flat;
            buttonphoto.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonphoto.Location = new Point(884, 224);
            buttonphoto.Name = "buttonphoto";
            buttonphoto.Size = new Size(94, 50);
            buttonphoto.TabIndex = 12;
            buttonphoto.Text = "Choose a photo";
            buttonphoto.UseVisualStyleBackColor = false;
            buttonphoto.Click += buttonphoto_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(384, 26);
            label1.Name = "label1";
            label1.Size = new Size(252, 41);
            label1.TabIndex = 13;
            label1.Text = "REGISTER FORM";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Navy;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = SystemColors.ControlLightLight;
            btnLogin.Location = new Point(884, 451);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 46);
            btnLogin.TabIndex = 14;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Underline, GraphicsUnit.Point);
            label6.Location = new Point(686, 461);
            label6.Name = "label6";
            label6.Size = new Size(168, 25);
            label6.TabIndex = 15;
            label6.Text = "Already Registered?";
            // 
            // labelWarning
            // 
            labelWarning.AutoSize = true;
            labelWarning.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelWarning.Location = new Point(265, 461);
            labelWarning.Name = "labelWarning";
            labelWarning.Size = new Size(0, 23);
            labelWarning.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 535);
            Controls.Add(labelWarning);
            Controls.Add(label6);
            Controls.Add(btnLogin);
            Controls.Add(label1);
            Controls.Add(buttonphoto);
            Controls.Add(pictureBox1);
            Controls.Add(AgeTextBox);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(PasswordTextBox);
            Controls.Add(label3);
            Controls.Add(UsernameTextBox);
            Controls.Add(label2);
            Controls.Add(AuthorNameTextBox);
            Controls.Add(lblName);
            Controls.Add(RegisterBtn);
            Name = "Form1";
            Text = "Register";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button RegisterBtn;
        private Label lblName;
        private TextBox AuthorNameTextBox;
        private TextBox UsernameTextBox;
        private Label label2;
        private TextBox PasswordTextBox;
        private Label label3;
        private TextBox AgeTextBox;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox1;
        private Button buttonphoto;
        private Label label1;
        private Button btnLogin;
        private Label label6;
        private Label labelWarning;
    }
}