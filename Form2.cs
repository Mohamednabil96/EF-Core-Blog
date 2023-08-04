using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task_day3.Models;

namespace Task_day3
{
    public partial class Form2 : Form
    {
        public static int currentUserId { get; set; }
        public Form2()
        {
            InitializeComponent();
        }


        private void LoginButton_Click_1(object sender, EventArgs e)
        {
            using (var context = new BlogContext())
            {
                var author = context.Authors.FirstOrDefault(a => a.AuthorUsername == UsernameTextBox.Text && a.AuthorPassword == PasswordTextBox.Text); 
                if (author != null)
                {
                    MessageBox.Show("Login Successful!");
                    currentUserId = author.AuthorId;
                    CrudForm blogform = new CrudForm();
                    blogform.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password.");
                }
            }
        }

    }
}
