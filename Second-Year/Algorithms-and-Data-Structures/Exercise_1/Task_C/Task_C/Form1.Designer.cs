namespace Task_C
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.Label();
            this.isbnLabel = new System.Windows.Forms.Label();
            this.titleTextbox = new System.Windows.Forms.TextBox();
            this.authorTextbox = new System.Windows.Forms.TextBox();
            this.isbnTextbox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.bookListbox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sortButton = new System.Windows.Forms.Button();
            this.insertRadioButton = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.appendRadioButton = new System.Windows.Forms.RadioButton();
            this.removeRadioButton = new System.Windows.Forms.RadioButton();
            this.editBooksLabel = new System.Windows.Forms.Label();
            this.sortBooksLabel = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.Location = new System.Drawing.Point(12, 16);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(103, 28);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Book Title:";
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.authorLabel.Location = new System.Drawing.Point(12, 61);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(127, 28);
            this.authorLabel.TabIndex = 1;
            this.authorLabel.Text = "Book Author:";
            // 
            // isbnLabel
            // 
            this.isbnLabel.AutoSize = true;
            this.isbnLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.isbnLabel.Location = new System.Drawing.Point(12, 104);
            this.isbnLabel.Name = "isbnLabel";
            this.isbnLabel.Size = new System.Drawing.Size(108, 28);
            this.isbnLabel.TabIndex = 2;
            this.isbnLabel.Text = "Book ISBN:";
            // 
            // titleTextbox
            // 
            this.titleTextbox.BackColor = System.Drawing.SystemColors.Window;
            this.titleTextbox.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleTextbox.Location = new System.Drawing.Point(145, 10);
            this.titleTextbox.Name = "titleTextbox";
            this.titleTextbox.Size = new System.Drawing.Size(257, 34);
            this.titleTextbox.TabIndex = 3;
            this.titleTextbox.TextChanged += new System.EventHandler(this.titleTextbox_TextChanged);
            // 
            // authorTextbox
            // 
            this.authorTextbox.BackColor = System.Drawing.SystemColors.Window;
            this.authorTextbox.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.authorTextbox.Location = new System.Drawing.Point(145, 55);
            this.authorTextbox.Name = "authorTextbox";
            this.authorTextbox.Size = new System.Drawing.Size(257, 34);
            this.authorTextbox.TabIndex = 4;
            this.authorTextbox.TextChanged += new System.EventHandler(this.authorTextbox_TextChanged);
            this.authorTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.authorTextbox_KeyPress);
            // 
            // isbnTextbox
            // 
            this.isbnTextbox.BackColor = System.Drawing.SystemColors.Window;
            this.isbnTextbox.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.isbnTextbox.Location = new System.Drawing.Point(145, 101);
            this.isbnTextbox.Name = "isbnTextbox";
            this.isbnTextbox.Size = new System.Drawing.Size(257, 34);
            this.isbnTextbox.TabIndex = 5;
            this.isbnTextbox.TextChanged += new System.EventHandler(this.isbnTextbox_TextChanged);
            this.isbnTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.isbnTextbox_KeyPress);
            this.isbnTextbox.Validating += new System.ComponentModel.CancelEventHandler(this.isbnTextbox_Validating);
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.SystemColors.Window;
            this.submitButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.submitButton.Location = new System.Drawing.Point(156, 215);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(179, 56);
            this.submitButton.TabIndex = 6;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // bookListbox
            // 
            this.bookListbox.FormattingEnabled = true;
            this.bookListbox.ItemHeight = 15;
            this.bookListbox.Location = new System.Drawing.Point(480, 51);
            this.bookListbox.Name = "bookListbox";
            this.bookListbox.Size = new System.Drawing.Size(515, 424);
            this.bookListbox.TabIndex = 7;
            this.bookListbox.SelectedIndexChanged += new System.EventHandler(this.bookListbox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(660, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 37);
            this.label1.TabIndex = 8;
            this.label1.Text = "List of books";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sortButton
            // 
            this.sortButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sortButton.Location = new System.Drawing.Point(12, 14);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(212, 56);
            this.sortButton.TabIndex = 9;
            this.sortButton.Text = "Sort by ISBN";
            this.sortButton.UseVisualStyleBackColor = true;
            this.sortButton.Click += new System.EventHandler(this.sortButton_Click);
            // 
            // insertRadioButton
            // 
            this.insertRadioButton.AutoSize = true;
            this.insertRadioButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.insertRadioButton.Location = new System.Drawing.Point(61, 164);
            this.insertRadioButton.Name = "insertRadioButton";
            this.insertRadioButton.Size = new System.Drawing.Size(78, 32);
            this.insertRadioButton.TabIndex = 13;
            this.insertRadioButton.TabStop = true;
            this.insertRadioButton.Text = "Insert";
            this.insertRadioButton.UseVisualStyleBackColor = true;
            this.insertRadioButton.CheckedChanged += new System.EventHandler(this.insertRadioButton_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.sortButton);
            this.panel1.Location = new System.Drawing.Point(12, 441);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 84);
            this.panel1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.appendRadioButton);
            this.panel2.Controls.Add(this.removeRadioButton);
            this.panel2.Controls.Add(this.submitButton);
            this.panel2.Controls.Add(this.insertRadioButton);
            this.panel2.Controls.Add(this.titleLabel);
            this.panel2.Controls.Add(this.authorLabel);
            this.panel2.Controls.Add(this.isbnLabel);
            this.panel2.Controls.Add(this.isbnTextbox);
            this.panel2.Controls.Add(this.titleTextbox);
            this.panel2.Controls.Add(this.authorTextbox);
            this.panel2.Location = new System.Drawing.Point(12, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(456, 292);
            this.panel2.TabIndex = 15;
            // 
            // appendRadioButton
            // 
            this.appendRadioButton.AutoSize = true;
            this.appendRadioButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.appendRadioButton.Location = new System.Drawing.Point(198, 164);
            this.appendRadioButton.Name = "appendRadioButton";
            this.appendRadioButton.Size = new System.Drawing.Size(100, 32);
            this.appendRadioButton.TabIndex = 15;
            this.appendRadioButton.TabStop = true;
            this.appendRadioButton.Text = "Append";
            this.appendRadioButton.UseVisualStyleBackColor = true;
            this.appendRadioButton.CheckedChanged += new System.EventHandler(this.appendRadioButton_CheckedChanged);
            // 
            // removeRadioButton
            // 
            this.removeRadioButton.AutoSize = true;
            this.removeRadioButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.removeRadioButton.Location = new System.Drawing.Point(331, 164);
            this.removeRadioButton.Name = "removeRadioButton";
            this.removeRadioButton.Size = new System.Drawing.Size(100, 32);
            this.removeRadioButton.TabIndex = 14;
            this.removeRadioButton.TabStop = true;
            this.removeRadioButton.Text = "Remove";
            this.removeRadioButton.UseVisualStyleBackColor = true;
            this.removeRadioButton.CheckedChanged += new System.EventHandler(this.removeRadioButton_CheckedChanged);
            // 
            // editBooksLabel
            // 
            this.editBooksLabel.AutoSize = true;
            this.editBooksLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editBooksLabel.Location = new System.Drawing.Point(12, 11);
            this.editBooksLabel.Name = "editBooksLabel";
            this.editBooksLabel.Size = new System.Drawing.Size(189, 37);
            this.editBooksLabel.TabIndex = 16;
            this.editBooksLabel.Text = "Edit books list:";
            // 
            // sortBooksLabel
            // 
            this.sortBooksLabel.AutoSize = true;
            this.sortBooksLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sortBooksLabel.Location = new System.Drawing.Point(10, 401);
            this.sortBooksLabel.Name = "sortBooksLabel";
            this.sortBooksLabel.Size = new System.Drawing.Size(191, 37);
            this.sortBooksLabel.TabIndex = 17;
            this.sortBooksLabel.Text = "Sort books list:";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(480, 497);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(65, 28);
            this.errorLabel.TabIndex = 19;
            this.errorLabel.Text = "label3";
            this.errorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.errorLabel.Click += new System.EventHandler(this.errorLabel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1030, 600);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.sortBooksLabel);
            this.Controls.Add(this.editBooksLabel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bookListbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label titleLabel;
        private Label authorLabel;
        private Label isbnLabel;
        private TextBox titleTextbox;
        private TextBox authorTextbox;
        private TextBox isbnTextbox;
        private Button submitButton;
        public ListBox bookListbox;
        private Label label1;
        private Button sortButton;
        private RadioButton insertRadioButton;
        private Panel panel1;
        private Panel panel2;
        private RadioButton appendRadioButton;
        private RadioButton removeRadioButton;
        private Label editBooksLabel;
        private Label sortBooksLabel;
        private Label errorLabel;
    }
}