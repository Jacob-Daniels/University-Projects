using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_C
{
    public partial class Form1 : Form
    {
        ComputerLab computerLab = new ComputerLab();
        
        public void UpdateDisplay(string error)
        {
            // Update max requests label
            maxRequestsLabel.Text = "Max requests: " + computerLab.GreedySort();
            // Update listbox
            IDListbox.Items.Clear();
            foreach (Request req in computerLab.GetRequests())
            {
                // Get request details and add to listbox
                string requestDetails = $"ID: {req.GetID()}\tStart time: {req.GetStartTime()}\tEnd time: {req.GetEndTime()}\n";
                IDListbox.Items.Add(requestDetails);
            }
            
            // Update error panel
            ErrorMessage(error);
        }

        public void ErrorMessage(string error)
        {
            // Set error textbox and display panel
            if (error != "")
            {
                errorMessageLabel.Text = error;
                errorPanel.Visible = true;
            } else
            {
                errorPanel.Visible = false;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region Add brief data
            // Add preset data to list
            computerLab.AddRequest(new Request(0001, "12:00", "13:45"));
            computerLab.AddRequest(new Request(0002, "12:30", "12:45"));
            computerLab.AddRequest(new Request(0003, "16:30", "16:45"));
            computerLab.AddRequest(new Request(0004, "13:40", "15:35"));
            computerLab.AddRequest(new Request(0005, "12:10", "14:30"));
            computerLab.AddRequest(new Request(0006, "12:05", "15:10"));
            #endregion
            // Error panel
            errorPanel.Visible = false;
            // Set timers
            startTimePicker.Format = DateTimePickerFormat.Custom;
            startTimePicker.CustomFormat = "HH:mm";
            startTimePicker.Value = DateTime.Now.Date;
            endTimePicker.Format = DateTimePickerFormat.Custom;
            endTimePicker.CustomFormat = "HH:mm";
            endTimePicker.Value = DateTime.Now.Date;
            // Update display
            UpdateDisplay("");
        }
        private void submitButton_Click(object sender, EventArgs e)
        {
            // Check ID
            if (IDTextbox.Text.Length != 4)
            {
                ErrorMessage("ID must be 4 digits long!");
                return;
            } else if (computerLab.ContainsRequest(Int32.Parse(IDTextbox.Text)))
            {
                ErrorMessage($"Request already exists with ID: {IDTextbox.Text}");
                return;
            }
            // Get time values
            string startTimer = startTimePicker.Value.ToString().Substring(11, 5);
            string endTimer = endTimePicker.Value.ToString().Substring(11, 5);
            // Convert to floats and check time difference
            double startFloat = Convert.ToDouble(startTimer.Replace(':', '.'));
            double endFloat = Convert.ToDouble(endTimer.Replace(':', '.'));
            if (Math.Abs(startFloat - endFloat) >= 4)
            {
                ErrorMessage("Request must be less than 4 hours!");
                return;
            } else if (Math.Abs(startFloat - endFloat) == 0)
            {
                ErrorMessage("Request cannot take 0 minutes to complete!");
                return;
            }
            
            // Create request
            computerLab.AddRequest(new Request(Int32.Parse(IDTextbox.Text), startTimer, endTimer));

            // Sort list and update display
            IDTextbox.Clear();
            UpdateDisplay("");
        }

        private void IDTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Text validation
            if (char.IsDigit(e.KeyChar) && IDTextbox.Text.Length < 4 || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            } else
            {
                e.Handled = true;
            }
        }

        // Sort buttons
        private void IDSortButton_Click(object sender, EventArgs e)
        {
            computerLab.SortbyID(0, computerLab.GetRequests().Count() - 1);
            UpdateDisplay("");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            computerLab.SortbyStartTime(0, computerLab.GetRequests().Count() - 1);
            UpdateDisplay("");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            computerLab.SortbyEndtime(0, computerLab.GetRequests().Count() - 1);
            UpdateDisplay("");
        }
    }
}
