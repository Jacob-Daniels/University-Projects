using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Task_A
{
    public partial class Form1 : Form
    {
        public Graph<string> graph = new Graph<string>();

        // Methods
        private void UpdateDisplay()
        {
            // Update Node & Edge counter labels
            totalNodesLabel.Text = "Total Nodes: " + graph.NumNodesGraph();
            totalEdgesLabel.Text = "Total Edges: " + graph.NumEdgesGraph();
            // Update nodes listbox
            string[] displayNodes = graph.DisplayNodes().Split(',');
            graphListbox.Items.Clear();
            foreach (string n in displayNodes)
            {
                graphListbox.Items.Add(n);
            }
            // Clear edges list box
            nodeListbox.Items.Clear();
        }
        void UpdateErrorMessage(string error)
        {
            // Display the error message on GUI, if it is populated
            errorLabel.Text = error;
            if (error == "")
            {
                errorPanel.Visible = false;
            } else
            {
                errorPanel.Visible = true;
            }
        }

        // Form Methods
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
            // Validation
            if (newnodeTextbox.Text == "")
            {
                UpdateErrorMessage("Input box must not be empty!");
            } else if (graph.GetNodeByID(newnodeTextbox.Text) != null)
            {
                UpdateErrorMessage("Node already exists in the graph.\nTry a different input!");
            }
            else if (newnodeTextbox.Text != "")
            {
                // Insert new node to graph
                graph.AddNode(newnodeTextbox.Text);
                newnodeTextbox.Clear();
                UpdateErrorMessage("");
            }
            // Update display
            UpdateDisplay();
        }

        private void addEdgeButton_Click(object sender, EventArgs e)
        {
            // Validation
            if (fromTextbox.Text == "" || toTextbox.Text == "")
            { 
                UpdateErrorMessage("Input box must not be empty!");
            }
            else if (graph.GetNodeByID(fromTextbox.Text) == null)
            {
                UpdateErrorMessage($"Input '{fromTextbox.Text}', does not exist in graph");
            }
            else if (graph.GetNodeByID(toTextbox.Text) == null)
            {
                UpdateErrorMessage($"Input '{toTextbox.Text}', does not exist in graph");
            } else if (graph.IsAdjacent(graph.GetNodeByID(fromTextbox.Text), graph.GetNodeByID(toTextbox.Text)))
            {
                UpdateErrorMessage($"Node already contains edge '{toTextbox.Text}'.");
            }
            else
            {
                // Add edge from one node to another
                UpdateErrorMessage("");
                graph.AddEdge(fromTextbox.Text, toTextbox.Text);
                fromTextbox.Clear();
                toTextbox.Clear();
            }
            // Update display
            UpdateDisplay();
        }

        private void graphListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (graphListbox.SelectedIndex < 0 || graphListbox.GetItemText(graphListbox.SelectedItem) == "") { return; }
            // Display edges of selected item
            string selItem = graphListbox.GetItemText(graphListbox.SelectedItem);
            // Find selected item in graph
            if (graph.ContainsGraph(graph.GetNodeByID(selItem)))
            {
                // Display edges of node in edges listbox
                string[] displayEdges = graph.DisplayEdges(graph.GetNodeByID(selItem)).Split(',');
                nodeListbox.Items.Clear();
                foreach (string n in displayEdges)
                {
                    nodeListbox.Items.Add(n);
                }
            }
        }
        private void TextboxValidation(TextBox currentTextbox, KeyPressEventArgs e)
        {
            // Textbox validation ( Only allow characters and spaces - NO digits / special chars)
            var textValidation = new Regex(@"^[a-zA-Z\s]*$");
            if (textValidation.IsMatch(e.KeyChar.ToString()) && currentTextbox.Text.Length < 10 || e.KeyChar == (char)Keys.Back) { e.Handled = false; } else { e.Handled = true; }
        }

        private void newnodeTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextboxValidation(newnodeTextbox, e);
        }

        private void fromTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextboxValidation(fromTextbox, e);
        }

        private void toTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextboxValidation(toTextbox, e);
        }
    }
}
