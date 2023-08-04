namespace Task_day3
{
    partial class CrudForm
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
            deleteBtn = new System.Windows.Forms.Button();
            updateBtn = new System.Windows.Forms.Button();
            addBtn = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            descTextBox = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            briefTextBox = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            titleTextBox = new System.Windows.Forms.TextBox();
            postDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)postDataGridView).BeginInit();
            SuspendLayout();
            // 
            // deleteBtn
            // 
            deleteBtn.BackColor = System.Drawing.Color.Red;
            deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            deleteBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            deleteBtn.ForeColor = System.Drawing.SystemColors.Control;
            deleteBtn.Location = new System.Drawing.Point(579, 521);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new System.Drawing.Size(94, 29);
            deleteBtn.TabIndex = 19;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = false;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.BackColor = System.Drawing.Color.Green;
            updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            updateBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            updateBtn.ForeColor = System.Drawing.SystemColors.Control;
            updateBtn.Location = new System.Drawing.Point(191, 521);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new System.Drawing.Size(94, 29);
            updateBtn.TabIndex = 18;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = false;
            updateBtn.Click += UpdateBtn_Click;
            // 
            // addBtn
            // 
            addBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            addBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            addBtn.ForeColor = System.Drawing.SystemColors.Control;
            addBtn.Location = new System.Drawing.Point(380, 521);
            addBtn.Name = "addBtn";
            addBtn.Size = new System.Drawing.Size(94, 29);
            addBtn.TabIndex = 17;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(234, 444);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(85, 20);
            label3.TabIndex = 16;
            label3.Text = "Description";
            // 
            // descTextBox
            // 
            descTextBox.Location = new System.Drawing.Point(352, 444);
            descTextBox.Name = "descTextBox";
            descTextBox.Size = new System.Drawing.Size(178, 27);
            descTextBox.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(234, 374);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(40, 20);
            label2.TabIndex = 14;
            label2.Text = "Brief";
            // 
            // briefTextBox
            // 
            briefTextBox.Location = new System.Drawing.Point(352, 374);
            briefTextBox.Name = "briefTextBox";
            briefTextBox.Size = new System.Drawing.Size(178, 27);
            briefTextBox.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(234, 307);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(38, 20);
            label1.TabIndex = 12;
            label1.Text = "Title";
            // 
            // titleTextBox
            // 
            titleTextBox.Location = new System.Drawing.Point(352, 307);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.Size = new System.Drawing.Size(178, 27);
            titleTextBox.TabIndex = 11;
            // 
            // postDataGridView
            // 
            postDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            postDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            postDataGridView.Location = new System.Drawing.Point(0, 0);
            postDataGridView.Name = "postDataGridView";
            postDataGridView.RowHeadersWidth = 51;
            postDataGridView.RowTemplate.Height = 29;
            postDataGridView.Size = new System.Drawing.Size(800, 273);
            postDataGridView.TabIndex = 10;
            // 
            // Crud
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 576);
            Controls.Add(deleteBtn);
            Controls.Add(updateBtn);
            Controls.Add(addBtn);
            Controls.Add(label3);
            Controls.Add(descTextBox);
            Controls.Add(label2);
            Controls.Add(briefTextBox);
            Controls.Add(label1);
            Controls.Add(titleTextBox);
            Controls.Add(postDataGridView);
            Name = "Crud";
            Text = "Crud";
            Load += Crud_Load;
            ((System.ComponentModel.ISupportInitialize)postDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox descTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox briefTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.DataGridView postDataGridView;
    }
}