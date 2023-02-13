namespace Task_A
{
    partial class Form1
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
            this.inputLabel = new System.Windows.Forms.Label();
            this.newnodeTextbox = new System.Windows.Forms.TextBox();
            this.graphListbox = new System.Windows.Forms.ListBox();
            this.nodeListbox = new System.Windows.Forms.ListBox();
            this.graphListLabel = new System.Windows.Forms.Label();
            this.nodeListLabel = new System.Windows.Forms.Label();
            this.insertButton = new System.Windows.Forms.Button();
            this.edgeLabel = new System.Windows.Forms.Label();
            this.insertPanel = new System.Windows.Forms.Panel();
            this.edgePanel = new System.Windows.Forms.Panel();
            this.addEdgeButton = new System.Windows.Forms.Button();
            this.toTextbox = new System.Windows.Forms.TextBox();
            this.fromTextbox = new System.Windows.Forms.TextBox();
            this.toLabel = new System.Windows.Forms.Label();
            this.fromLabel = new System.Windows.Forms.Label();
            this.insertLabel = new System.Windows.Forms.Label();
            this.totalNodesLabel = new System.Windows.Forms.Label();
            this.totalEdgesLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.errorPanel = new System.Windows.Forms.Panel();
            this.errorLabel = new System.Windows.Forms.Label();
            this.errorTitleLabel = new System.Windows.Forms.Label();
            this.insertPanel.SuspendLayout();
            this.edgePanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.errorPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputLabel.Location = new System.Drawing.Point(10, 15);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(149, 25);
            this.inputLabel.TabIndex = 0;
            this.inputLabel.Text = "Enter node ID:";
            // 
            // newnodeTextbox
            // 
            this.newnodeTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newnodeTextbox.Location = new System.Drawing.Point(165, 12);
            this.newnodeTextbox.Name = "newnodeTextbox";
            this.newnodeTextbox.Size = new System.Drawing.Size(228, 31);
            this.newnodeTextbox.TabIndex = 1;
            this.newnodeTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.newnodeTextbox_KeyPress);
            // 
            // graphListbox
            // 
            this.graphListbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.graphListbox.FormattingEnabled = true;
            this.graphListbox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.graphListbox.ItemHeight = 20;
            this.graphListbox.Location = new System.Drawing.Point(10, 45);
            this.graphListbox.Name = "graphListbox";
            this.graphListbox.Size = new System.Drawing.Size(256, 464);
            this.graphListbox.TabIndex = 3;
            this.graphListbox.SelectedIndexChanged += new System.EventHandler(this.graphListbox_SelectedIndexChanged);
            // 
            // nodeListbox
            // 
            this.nodeListbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nodeListbox.FormattingEnabled = true;
            this.nodeListbox.ItemHeight = 20;
            this.nodeListbox.Location = new System.Drawing.Point(278, 45);
            this.nodeListbox.Name = "nodeListbox";
            this.nodeListbox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.nodeListbox.Size = new System.Drawing.Size(235, 464);
            this.nodeListbox.TabIndex = 4;
            // 
            // graphListLabel
            // 
            this.graphListLabel.AutoSize = true;
            this.graphListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.graphListLabel.Location = new System.Drawing.Point(70, 17);
            this.graphListLabel.Name = "graphListLabel";
            this.graphListLabel.Size = new System.Drawing.Size(135, 25);
            this.graphListLabel.TabIndex = 5;
            this.graphListLabel.Text = "List of nodes";
            // 
            // nodeListLabel
            // 
            this.nodeListLabel.AutoSize = true;
            this.nodeListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nodeListLabel.Location = new System.Drawing.Point(298, 17);
            this.nodeListLabel.Name = "nodeListLabel";
            this.nodeListLabel.Size = new System.Drawing.Size(194, 25);
            this.nodeListLabel.TabIndex = 6;
            this.nodeListLabel.Text = "List of direct edges";
            // 
            // insertButton
            // 
            this.insertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertButton.Location = new System.Drawing.Point(399, 8);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(139, 41);
            this.insertButton.TabIndex = 7;
            this.insertButton.Text = "Insert Node";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // edgeLabel
            // 
            this.edgeLabel.AutoSize = true;
            this.edgeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edgeLabel.Location = new System.Drawing.Point(28, 163);
            this.edgeLabel.Name = "edgeLabel";
            this.edgeLabel.Size = new System.Drawing.Size(406, 29);
            this.edgeLabel.TabIndex = 8;
            this.edgeLabel.Text = "Add direct edge between two nodes:";
            // 
            // insertPanel
            // 
            this.insertPanel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.insertPanel.Controls.Add(this.insertButton);
            this.insertPanel.Controls.Add(this.inputLabel);
            this.insertPanel.Controls.Add(this.newnodeTextbox);
            this.insertPanel.Location = new System.Drawing.Point(26, 57);
            this.insertPanel.Name = "insertPanel";
            this.insertPanel.Size = new System.Drawing.Size(547, 60);
            this.insertPanel.TabIndex = 9;
            // 
            // edgePanel
            // 
            this.edgePanel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.edgePanel.Controls.Add(this.addEdgeButton);
            this.edgePanel.Controls.Add(this.toTextbox);
            this.edgePanel.Controls.Add(this.fromTextbox);
            this.edgePanel.Controls.Add(this.toLabel);
            this.edgePanel.Controls.Add(this.fromLabel);
            this.edgePanel.Location = new System.Drawing.Point(26, 195);
            this.edgePanel.Name = "edgePanel";
            this.edgePanel.Size = new System.Drawing.Size(547, 107);
            this.edgePanel.TabIndex = 10;
            // 
            // addEdgeButton
            // 
            this.addEdgeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEdgeButton.Location = new System.Drawing.Point(399, 28);
            this.addEdgeButton.Name = "addEdgeButton";
            this.addEdgeButton.Size = new System.Drawing.Size(139, 41);
            this.addEdgeButton.TabIndex = 4;
            this.addEdgeButton.Text = "Add Edge";
            this.addEdgeButton.UseVisualStyleBackColor = true;
            this.addEdgeButton.Click += new System.EventHandler(this.addEdgeButton_Click);
            // 
            // toTextbox
            // 
            this.toTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toTextbox.Location = new System.Drawing.Point(165, 56);
            this.toTextbox.Name = "toTextbox";
            this.toTextbox.Size = new System.Drawing.Size(228, 31);
            this.toTextbox.TabIndex = 3;
            this.toTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.toTextbox_KeyPress);
            // 
            // fromTextbox
            // 
            this.fromTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromTextbox.Location = new System.Drawing.Point(165, 12);
            this.fromTextbox.Name = "fromTextbox";
            this.fromTextbox.Size = new System.Drawing.Size(228, 31);
            this.fromTextbox.TabIndex = 2;
            this.fromTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fromTextbox_KeyPress);
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toLabel.Location = new System.Drawing.Point(10, 62);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(119, 25);
            this.toLabel.TabIndex = 1;
            this.toLabel.Text = "Enter ID to:";
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromLabel.Location = new System.Drawing.Point(10, 15);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(149, 25);
            this.fromLabel.TabIndex = 0;
            this.fromLabel.Text = "Enter ID from: ";
            // 
            // insertLabel
            // 
            this.insertLabel.AutoSize = true;
            this.insertLabel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.insertLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertLabel.Location = new System.Drawing.Point(28, 29);
            this.insertLabel.Name = "insertLabel";
            this.insertLabel.Size = new System.Drawing.Size(139, 29);
            this.insertLabel.TabIndex = 8;
            this.insertLabel.Text = "Insert node:";
            // 
            // totalNodesLabel
            // 
            this.totalNodesLabel.AutoSize = true;
            this.totalNodesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalNodesLabel.Location = new System.Drawing.Point(13, 512);
            this.totalNodesLabel.Name = "totalNodesLabel";
            this.totalNodesLabel.Size = new System.Drawing.Size(152, 25);
            this.totalNodesLabel.TabIndex = 11;
            this.totalNodesLabel.Text = "Total Nodes: 0";
            // 
            // totalEdgesLabel
            // 
            this.totalEdgesLabel.AutoSize = true;
            this.totalEdgesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalEdgesLabel.Location = new System.Drawing.Point(281, 512);
            this.totalEdgesLabel.Name = "totalEdgesLabel";
            this.totalEdgesLabel.Size = new System.Drawing.Size(151, 25);
            this.totalEdgesLabel.TabIndex = 9;
            this.totalEdgesLabel.Text = "Total Edges: 0";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel3.Controls.Add(this.nodeListbox);
            this.panel3.Controls.Add(this.totalEdgesLabel);
            this.panel3.Controls.Add(this.graphListbox);
            this.panel3.Controls.Add(this.totalNodesLabel);
            this.panel3.Controls.Add(this.graphListLabel);
            this.panel3.Controls.Add(this.nodeListLabel);
            this.panel3.Location = new System.Drawing.Point(714, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(530, 546);
            this.panel3.TabIndex = 12;
            // 
            // errorPanel
            // 
            this.errorPanel.Controls.Add(this.errorLabel);
            this.errorPanel.Controls.Add(this.errorTitleLabel);
            this.errorPanel.Location = new System.Drawing.Point(26, 350);
            this.errorPanel.Name = "errorPanel";
            this.errorPanel.Size = new System.Drawing.Size(547, 171);
            this.errorPanel.TabIndex = 13;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.errorLabel.Location = new System.Drawing.Point(10, 47);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(328, 25);
            this.errorLabel.TabIndex = 15;
            this.errorLabel.Text = "Hide this panel, until error occurs";
            // 
            // errorTitleLabel
            // 
            this.errorTitleLabel.AutoSize = true;
            this.errorTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.errorTitleLabel.Location = new System.Drawing.Point(2, 1);
            this.errorTitleLabel.Name = "errorTitleLabel";
            this.errorTitleLabel.Size = new System.Drawing.Size(73, 29);
            this.errorTitleLabel.TabIndex = 14;
            this.errorTitleLabel.Text = "Error:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1256, 567);
            this.Controls.Add(this.errorPanel);
            this.Controls.Add(this.edgeLabel);
            this.Controls.Add(this.insertLabel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.edgePanel);
            this.Controls.Add(this.insertPanel);
            this.Name = "Form1";
            this.Text = "Graph";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.insertPanel.ResumeLayout(false);
            this.insertPanel.PerformLayout();
            this.edgePanel.ResumeLayout(false);
            this.edgePanel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.errorPanel.ResumeLayout(false);
            this.errorPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.TextBox newnodeTextbox;
        private System.Windows.Forms.ListBox graphListbox;
        private System.Windows.Forms.ListBox nodeListbox;
        private System.Windows.Forms.Label graphListLabel;
        private System.Windows.Forms.Label nodeListLabel;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.Label edgeLabel;
        private System.Windows.Forms.Panel insertPanel;
        private System.Windows.Forms.Panel edgePanel;
        private System.Windows.Forms.Label insertLabel;
        private System.Windows.Forms.Label totalNodesLabel;
        private System.Windows.Forms.Label totalEdgesLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button addEdgeButton;
        private System.Windows.Forms.TextBox toTextbox;
        private System.Windows.Forms.TextBox fromTextbox;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.Panel errorPanel;
        private System.Windows.Forms.Label errorTitleLabel;
        private System.Windows.Forms.Label errorLabel;
    }
}

