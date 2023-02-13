using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Exercise_1
{
    public partial class Form1 : Form
    {
        private static Queue myQueue = new Queue();
        private static Label[] arrayLabels = new Label[10];
        private static Label[] headLabels = new Label[10];
        private static Label[] tailLabels = new Label[10];

        // Methods
        private void ErrorMessage(string error)
        {
            // Display arror in GUI
            errorTextBox.Text = "Error:" + Environment.NewLine + error;
        }

        public bool CheckString()
        {
            // Check for input
            if (inputBox.Text == "")
            {
                ErrorMessage("No Input!");
                return false;
            }
            // Check input is only letters & space
            if (!Regex.IsMatch(inputBox.Text, @"^[a-zA-Z\s]+$"))
            {
                ErrorMessage("Input must only contain letters or space");
                return false;
            } else if (Regex.IsMatch(inputBox.Text, @"^[\s]+$"))
            {
                // Prevent text from being only whitespace (spaces)
                ErrorMessage("Input must contain letters");
                return false;
            }
            return true;
        }

        private void UpdateTable()
        {
            // Update labels on GUI
            for (int i = 0; i < myQueue.namesQueue.Length; i++)
            {
                // Input labels
                if (myQueue.namesQueue[i] == null)
                {
                    arrayLabels[i].Text = "";
                }
                else
                {
                    arrayLabels[i].Text = myQueue.namesQueue[i];
                }
                // Head label
                if (myQueue.Head == i)
                {
                    headLabels[i].Text = "Head";
                }
                else
                {
                    headLabels[i].Text = null;
                }
                // Tail label
                if (myQueue.Tail == i)
                {
                    tailLabels[i].Text = "Tail";
                }
                else
                {
                    tailLabels[i].Text = null;
                }
            }
        }

        // Form Methods
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            addRadiobutton.Checked = true;
            // Assign all labels from the table into array to later assign data to
            for (int i = 0; i < arrayLabels.Length; i++)
            {
                // Input labels
                string labelName = "arrayLabel" + i;
                Label inputLabel = Controls.Find(labelName, true).FirstOrDefault() as Label;
                if (inputLabel != null)
                {
                    arrayLabels[i] = inputLabel;
                }
                // Head labels
                string hlName = "headLabel" + i;
                Label headLabel = Controls.Find(hlName, true).FirstOrDefault() as Label;
                if (headLabel != null)
                {
                    headLabels[i] = headLabel;
                }
                // Tail labels
                string tlName = "tailLabel" + i;
                Label tailLabel = Controls.Find(tlName, true).FirstOrDefault() as Label;
                if (tailLabel != null)
                {
                    tailLabels[i] = tailLabel;
                }
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            // Check radio buttons
            if (addRadiobutton.Checked)
            {
                if (CheckString())
                {
                    // Add name if list is not full
                    if (!myQueue.IsFull())
                    {
                        errorTextBox.Clear();
                        myQueue.Enqueue(inputBox.Text);
                        inputBox.Clear();
                    }
                    else
                    {
                        ErrorMessage("Queue is full!");
                    }
                }
            }
            else if (removeRadiobutton.Checked)
            {
                // Remove from queue
                if (!myQueue.IsEmpty())
                {
                    errorTextBox.Text = "Removed: " + myQueue.Dequeue();
                }
                else
                {
                    ErrorMessage("Queue is empty!");
                }
            }
            else if (reverseRadiobutton.Checked)
            {
                // Check value was selected in combobox
                if (reverseCombobox.SelectedItem != null)
                {
                    // Convert the selected object from the combobox into an integer to reverse queue
                    myQueue.ReverseOrder(Convert.ToInt32(reverseCombobox.SelectedItem));
                }
            }
            // Update table and counter
            UpdateTable();
            queueCountLabel.Text = "Queue count: " + myQueue.TotalNames;
        }

        private void removeRadiobutton_CheckedChanged(object sender, EventArgs e)
        {
            // Change values of input text box if 'RemoveRadiobutton' is selected
            if (removeRadiobutton.Checked)
            {
                inputBox.Clear();
                inputBox.ReadOnly = true;
            }
            else
            {
                inputBox.ReadOnly = false;
            }
        }

        private void reverseRadiobutton_CheckedChanged(object sender, EventArgs e)
        {
            // Clear combo box and assign values available to reverse the queue
            reverseCombobox.Items.Clear();
            if (reverseRadiobutton.Checked)
            {
                for (int i = 2; i <= myQueue.TotalNames; i++)
                {
                    reverseCombobox.Items.Add(i);
                }
                inputBox.Visible = false;
                reverseCombobox.Visible = true;
            }
            else
            {
                inputBox.Visible = true;
                reverseCombobox.Visible = false;
            }
        }

        private void inputBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void addRadiobutton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void errorTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void queueCountLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void reverseCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}