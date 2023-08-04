using Microsoft.EntityFrameworkCore;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Task_day3.Models;

namespace Task_day3
{
    public partial class Form1 : Form
    {
        BlogContext BlogContext = new BlogContext();
        public Form1()
        {
            InitializeComponent();
            pictureBox1.ImageLocation = @"C:\Users\JOO TECH\Desktop\ITI Tasks\Advanced C# Tasks\Task_day3\img\1.png";
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {

            var authors = BlogContext.Authors.ToList();
            for (int i = 0; i < authors.Count; i++)
            {
                if (UsernameTextBox.Text == authors[i].AuthorUsername)
                {
                    MessageBox.Show("Registration Failed, USername already exists!");
                }
            }

            using (var context = new BlogContext())
            {

                var author = new Author
                {
                    AuthorName = AuthorNameTextBox.Text,
                    AuthorUsername = UsernameTextBox.Text,
                    AuthorPassword = PasswordTextBox.Text,
                    AuthorAge = int.Parse(AgeTextBox.Text)

                };
                var imageData = ImageToByteArray(pictureBox1.Image);
                author.AuthorPhoto = Convert.ToBase64String(imageData);

                context.Authors.Add(author);
                context.SaveChanges();
            }
            MessageBox.Show("Registration Successful!");

            Form2 loginForm = new Form2();
            loginForm.Show();
            this.Hide();
        }

        private byte[] ImageToByteArray(Image img)
        {
            using (var stream = new MemoryStream())
            {
                img.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                return stream.ToArray();
            }
        }

        private void buttonphoto_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png, *.bmp) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png; *.bmp";
                openFileDialog.Title = "Select a photo";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Form2 loginForm = new Form2();
            loginForm.Show();
            this.Hide();
        }
    }
}