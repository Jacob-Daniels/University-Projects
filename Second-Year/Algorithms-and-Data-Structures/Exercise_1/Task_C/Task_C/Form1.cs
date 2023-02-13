using System;
using System.Collections.Generic;

namespace Task_C
{
    public partial class Form1 : Form
    {
        private LinkedList<Book> booksList = new LinkedList<Book>();

        public void ErrorMessage(string error)
        {
            // display error message on forms label
            errorLabel.Text = "" + error;
        }

        public void ClearInputBoxes()
        {
            // Clear data from input box
            titleTextbox.Clear();
            authorTextbox.Clear();
            isbnTextbox.Clear();
            ErrorMessage("");
        }

        public bool CheckValidInput()
        {
            // Check input is not empty
            if (titleTextbox.Text == "" || authorTextbox.Text == "" || isbnTextbox.Text == "")
            {
                ErrorMessage("Error: Please fill out all input boxes");
                return false;
            }
            // Check isbn is 13 digits long
            if (isbnTextbox.TextLength != 13)
            {
                ErrorMessage("Error: ISBN must be 13 digits");
                return false;
            }
            return true;
        }

        public void ListboxDisplay()
        {
            // Clear listbox
            bookListbox.Items.Clear();

            // Display total books in list
            bookListbox.Items.Add("Number of books: " + booksList.NumberOfItems().ToString());

            // Display books in listbox
            string[] values = booksList.DisplayList().Split('\n');
            foreach (string value in values)
            {
                bookListbox.Items.Add(value);
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Check default radio button on load
            insertRadioButton.Checked = true;
            errorLabel.Text = "";
            bookListbox.Items.Add("Number of books: 0");
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            // Input validation
            if (!CheckValidInput())
            {
                return;
            }
            // Get input and instantiate book
            Book book = new Book(titleTextbox.Text, authorTextbox.Text, isbnTextbox.Text);
            // Check book exists in list already
            if (booksList.IsItemPresent(book))
            {
                if (removeRadioButton.Checked)
                {
                    // Remove book from list
                    booksList.Remove(book);

                    // Clear data from input box
                    isbnTextbox.Clear();
                    ErrorMessage("");
                }
                else
                {
                    ErrorMessage("Error: The ISBN number is already in the list!");
                }
            } else
            {
                // Check radiobutton
                if (insertRadioButton.Checked)
                {
                    // Add book to list
                    booksList.Add(book);
                    ClearInputBoxes();
                }
                else if (appendRadioButton.Checked)
                {
                    // Append book to list
                    booksList.AppendItem(book);
                    ClearInputBoxes();
                } else
                {
                    ErrorMessage("Error: The ISBN number is not in the list!");
                }
            }
            // Display text in listbox
            ListboxDisplay();
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            // Sort list
            booksList.SortList();
            ListboxDisplay();
        }

        // Forms validation and appreance
        private void removeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Disable text boxes when selected and format text to inform user
            if (removeRadioButton.Checked)
            {
                ClearInputBoxes();
                titleTextbox.TextAlign = HorizontalAlignment.Center;
                authorTextbox.TextAlign = HorizontalAlignment.Center;
                titleTextbox.Text = "Can only remove using";
                authorTextbox.Text = "isbn number!";
                titleTextbox.Enabled = false;
                authorTextbox.Enabled = false;
            }
            else
            {
                ClearInputBoxes();
                titleTextbox.TextAlign = HorizontalAlignment.Left;
                authorTextbox.TextAlign = HorizontalAlignment.Left;
                titleTextbox.Enabled = true;
                authorTextbox.Enabled = true;
            }
        }

        private void isbnTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Is char is digit or backspace and string less than 13 
            if ((char.IsDigit(e.KeyChar) && isbnTextbox.Text.Length < 13 || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void authorTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check char is not digit
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            } else
            {
                e.Handled = false;
            }
        }

        private void titleTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void authorTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void isbnTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void bookListbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void insertRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void appendRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void errorLabel_Click(object sender, EventArgs e)
        {

        }
        private void isbnTextbox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}