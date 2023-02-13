using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Task_B_C
{
    public partial class Form1 : Form
    {
        private Graph<string> graph = new Graph<string>();

        private void UpdateDisplay()
        {
            // Total nodes & edges labels
            nodesLabel.Text = "Total Airports: " + graph.NumNodesGraph();
            edgesLabel.Text = "Total Connections: " + graph.NumEdgesGraph();
            // Airport listbox
            string[] displayNodes = graph.DisplayNodes().Split(',');
            airpotListbox.Items.Clear();
            foreach (string n in displayNodes)
            {
                airpotListbox.Items.Add(n);
            }
            // Update connections display
            UpdateConnectionsDisplay();
            // Reset error message
            UpdateErrorMessage("");
        }

        private void UpdateErrorMessage(string error)
        {
            // Display the error panel on screen
            errorLabel.Text = error;
            if (error == "")
            {
                errorPanel.Visible = false;
            } else
            {
                errorPanel.Visible = true;
            }
        }

        public void UpdateConnectionsDisplay()
        {
            // Clear listbox
            allConnectionsListbox.Items.Clear();
            directListbox.Items.Clear();
            indirectListbox.Items.Clear();
            if (graph.GetNodeByID(selectTextbox.Text) != null)
            {
                // Display direct connections/edges
                allConnectionsListbox.Items.Add("Direct Connections:");
                string[] edges = graph.DisplayEdges(graph.GetNodeByID(selectTextbox.Text)).Split(',');
                foreach (string n in edges)
                {
                    allConnectionsListbox.Items.Add(n);
                    directListbox.Items.Add(n);
                }
                // Display indirect connections/edges
                allConnectionsListbox.Items.Add("Indirect Connections:");
                string path = "", currPath = "";
                graph.DisplayIndirectEdges(graph.GetNodeByID(selectTextbox.Text), ref path, currPath);
                string[] indirectEdges = path.Split(',');
                foreach (string n in indirectEdges)
                {
                    allConnectionsListbox.Items.Add(n);
                    indirectListbox.Items.Add(n);
                }
            }
        }

        // Form methods
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateErrorMessage("");
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            // Input validation (produce error message then return)
            if (graph.GetNodeByID(codeTextbox.Text) != null)
            {
                UpdateErrorMessage("Airport already in system!");
                return;
            }
            if (codeTextbox.Text.Length != 3)
            {
                UpdateErrorMessage("Airport code must be 3 unique characters long!");
                return;
            }
            // Add node to graph and update display
            graph.AddNode(codeTextbox.Text);
            codeTextbox.Clear();
            UpdateDisplay();
        }
        private void connectButton_Click(object sender, EventArgs e)
        {
            // Input validation (produces error message and returns)
            if (fromAirportTextbox.Text.Length != 3 || toAirportTextbox.Text.Length != 3)
            {
                // Input length
                UpdateErrorMessage("Airport code must be 3 characters long!");
                return;
            }
            if (graph.GetNodeByID(fromAirportTextbox.Text) == null || graph.GetNodeByID(toAirportTextbox.Text) == null)
            {
                // Check airport exists
                UpdateErrorMessage("Check both of the airports exist in the graph!");
                return;
            }
            if (graph.IsAdjacentByID(fromAirportTextbox.Text, toAirportTextbox.Text))
            {
                UpdateErrorMessage($"Airport '{fromAirportTextbox.Text}' is already connected to '{toAirportTextbox.Text}'.");
                return;
            }
            graph.AddEdge(fromAirportTextbox.Text, toAirportTextbox.Text);
            fromAirportTextbox.Clear();
            toAirportTextbox.Clear();
            UpdateDisplay();
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            // Input Validation
            if (selectTextbox.Text.Length != 3)
            {
                UpdateErrorMessage("Airport code must be 3 characters long!");
                return;
            }
            if (graph.GetNodeByID(selectTextbox.Text) == null)
            {
                UpdateErrorMessage("Airport is not in system!");
                return;
            }
            // Display the connections for the selected airport
            UpdateDisplay();
            selectTextbox.Clear();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            // Input validation
            if (removeTextbox.Text.Length != 3)
            {
                UpdateErrorMessage("Airport code must be 3 characters long!");
                return;
            }
            if (graph.GetNodeByID(removeTextbox.Text) == null)
            {
                UpdateErrorMessage("Airport is not in system!");
                return;
            }
            // Remove node from graph
            graph.RemoveNodeByID(removeTextbox.Text);
            removeTextbox.Clear();
            UpdateDisplay();
        }

        private void InputCodeValidation(TextBox currentTextbox, KeyPressEventArgs e)
        {
            // Input validation (only allow letters and 3 characters)
            if (char.IsLetter(e.KeyChar) && currentTextbox.Text.Length < 3 || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void codeTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputCodeValidation(codeTextbox, e);
        }
        private void toAirportTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputCodeValidation(toAirportTextbox, e);
        }
        private void fromAirportTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputCodeValidation(fromAirportTextbox, e);
        }
        private void selectTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputCodeValidation(selectTextbox, e);
        }
        private void removeTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputCodeValidation(removeTextbox, e);
        }
    }
}
