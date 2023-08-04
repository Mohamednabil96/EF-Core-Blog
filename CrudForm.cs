using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class CrudForm : Form
    {
        private BlogContext _context;
        private DbSet<Post> _posts;
        int userId = Form2.currentUserId;

        public CrudForm()
        {
            InitializeComponent();
            _context = new BlogContext();
        }

        private void Crud_Load(object sender, EventArgs e)
        {
            updateBtn.Visible = false;
            deleteBtn.Visible = false;

            _context = new BlogContext();
            _posts = _context.Posts;

            using (var context = new BlogContext())
            {
                postDataGridView.DataSource = context.Posts.Where(n => n.AuthorId == userId).ToList();
                DataGridViewColumn column = new DataGridViewTextBoxColumn();
                column.DataPropertyName = "PostTitle";
                column.HeaderText = "Title";
                postDataGridView.Columns.Add(column);
                postDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            Post p = new Post
            {
                PostTitle = titleTextBox.Text,
                PostBrief = briefTextBox.Text,
                PostDesc = descTextBox.Text,
                PostDate = DateTime.Now,
                BlogId = 1,
                AuthorId = 1
            };

            _posts.Add(p);
            _context.SaveChanges();

            titleTextBox.Text = briefTextBox.Text = descTextBox.Text = " ";
            
            MessageBox.Show("Post added successfully!");

            postDataGridView.DataSource = _context.Posts.Where(n => n.AuthorId == userId).ToList();
            postDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            
            addBtn.Visible = false;
            updateBtn.Visible = true;
            deleteBtn.Visible = true;
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            Post p = _context.Posts.Where(n => n.AuthorId == userId).SingleOrDefault();

            p.PostTitle = titleTextBox.Text;
            p.PostBrief = briefTextBox.Text;
            p.PostDesc = descTextBox.Text;

            titleTextBox.Text = briefTextBox.Text = descTextBox.Text = " ";

            MessageBox.Show("Post updated successfully!");

            _context.SaveChanges();
            postDataGridView.DataSource = _context.Posts.Where(n => n.AuthorId == userId).ToList();

            addBtn.Visible = true;
            updateBtn.Visible = false;
            deleteBtn.Visible = false;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure ??", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Post p = _context.Posts.Where(n => n.AuthorId == userId).SingleOrDefault();

                titleTextBox.Text = briefTextBox.Text = descTextBox.Text = " ";
                MessageBox.Show("Post deleted successfully!");

                _posts.Remove(p);

                _context.SaveChanges();
                postDataGridView.DataSource = _context.Posts.Where(n => n.AuthorId == userId).ToList();

                addBtn.Visible = true;
                updateBtn.Visible = false;
                deleteBtn.Visible = false;
            }
        }
    }
}
