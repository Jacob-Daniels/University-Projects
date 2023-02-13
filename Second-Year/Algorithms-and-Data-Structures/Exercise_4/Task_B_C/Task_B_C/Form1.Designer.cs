namespace Task_B_C
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
            this.insertPanel = new System.Windows.Forms.Panel();
            this.insertButton = new System.Windows.Forms.Button();
            this.codeTextbox = new System.Windows.Forms.TextBox();
            this.insertLabel = new System.Windows.Forms.Label();
            this.insertTitleLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.airpotListbox = new System.Windows.Forms.ListBox();
            this.directListbox = new System.Windows.Forms.ListBox();
            this.allConnectionsListbox = new System.Windows.Forms.ListBox();
            this.indirectListbox = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.airportLabel = new System.Windows.Forms.Label();
            this.directLabel = new System.Windows.Forms.Label();
            this.indirectLabel = new System.Windows.Forms.Label();
            this.allConnectionsLabel = new System.Windows.Forms.Label();
            this.errorPanel = new System.Windows.Forms.Panel();
            this.errorLabel = new System.Windows.Forms.Label();
            this.errorTitleLabel = new System.Windows.Forms.Label();
            this.connectionPanel = new System.Windows.Forms.Panel();
            this.connectButton = new System.Windows.Forms.Button();
            this.toAirportTextbox = new System.Windows.Forms.TextBox();
            this.fromAirportTextbox = new System.Windows.Forms.TextBox();
            this.toAirportLabel = new System.Windows.Forms.Label();
            this.fromAirportLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.selectAirportPanel = new System.Windows.Forms.Panel();
            this.selectButton = new System.Windows.Forms.Button();
            this.selectTextbox = new System.Windows.Forms.TextBox();
            this.selectLabel = new System.Windows.Forms.Label();
            this.selectTitleLabel = new System.Windows.Forms.Label();
            this.removePanel = new System.Windows.Forms.Panel();
            this.removeButton = new System.Windows.Forms.Button();
            this.removeTextbox = new System.Windows.Forms.TextBox();
            this.removeLabel = new System.Windows.Forms.Label();
            this.removeTitleLabel = new System.Windows.Forms.Label();
            this.nodesLabel = new System.Windows.Forms.Label();
            this.edgesLabel = new System.Windows.Forms.Label();
            this.insertPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.errorPanel.SuspendLayout();
            this.connectionPanel.SuspendLayout();
            this.selectAirportPanel.SuspendLayout();
            this.removePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // insertPanel
            // 
            this.insertPanel.Controls.Add(this.insertButton);
            this.insertPanel.Controls.Add(this.codeTextbox);
            this.insertPanel.Controls.Add(this.insertLabel);
            this.insertPanel.Location = new System.Drawing.Point(22, 105);
            this.insertPanel.Name = "insertPanel";
            this.insertPanel.Size = new System.Drawing.Size(388, 54);
            this.insertPanel.TabIndex = 0;
            // 
            // insertButton
            // 
            this.insertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertButton.Location = new System.Drawing.Point(222, 6);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(156, 40);
            this.insertButton.TabIndex = 4;
            this.insertButton.Text = "Insert airport";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // codeTextbox
            // 
            this.codeTextbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.codeTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeTextbox.Location = new System.Drawing.Point(127, 11);
            this.codeTextbox.Name = "codeTextbox";
            this.codeTextbox.Size = new System.Drawing.Size(89, 31);
            this.codeTextbox.TabIndex = 3;
            this.codeTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.codeTextbox_KeyPress);
            // 
            // insertLabel
            // 
            this.insertLabel.AutoSize = true;
            this.insertLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertLabel.Location = new System.Drawing.Point(3, 14);
            this.insertLabel.Name = "insertLabel";
            this.insertLabel.Size = new System.Drawing.Size(122, 25);
            this.insertLabel.TabIndex = 2;
            this.insertLabel.Text = "Enter code:";
            // 
            // insertTitleLabel
            // 
            this.insertTitleLabel.AutoSize = true;
            this.insertTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertTitleLabel.Location = new System.Drawing.Point(25, 73);
            this.insertTitleLabel.Name = "insertTitleLabel";
            this.insertTitleLabel.Size = new System.Drawing.Size(304, 29);
            this.insertTitleLabel.TabIndex = 1;
            this.insertTitleLabel.Text = "Insert Airport by IATA code:";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(363, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(346, 42);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Airport Connections";
            // 
            // airpotListbox
            // 
            this.airpotListbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.airpotListbox.FormattingEnabled = true;
            this.airpotListbox.ItemHeight = 24;
            this.airpotListbox.Location = new System.Drawing.Point(3, 68);
            this.airpotListbox.Name = "airpotListbox";
            this.airpotListbox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.airpotListbox.Size = new System.Drawing.Size(141, 532);
            this.airpotListbox.TabIndex = 3;
            // 
            // directListbox
            // 
            this.directListbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.directListbox.FormattingEnabled = true;
            this.directListbox.ItemHeight = 24;
            this.directListbox.Location = new System.Drawing.Point(373, 68);
            this.directListbox.Name = "directListbox";
            this.directListbox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.directListbox.Size = new System.Drawing.Size(141, 532);
            this.directListbox.TabIndex = 4;
            // 
            // allConnectionsListbox
            // 
            this.allConnectionsListbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allConnectionsListbox.FormattingEnabled = true;
            this.allConnectionsListbox.HorizontalScrollbar = true;
            this.allConnectionsListbox.ItemHeight = 24;
            this.allConnectionsListbox.Location = new System.Drawing.Point(151, 68);
            this.allConnectionsListbox.Name = "allConnectionsListbox";
            this.allConnectionsListbox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.allConnectionsListbox.Size = new System.Drawing.Size(216, 532);
            this.allConnectionsListbox.TabIndex = 5;
            // 
            // indirectListbox
            // 
            this.indirectListbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indirectListbox.FormattingEnabled = true;
            this.indirectListbox.HorizontalScrollbar = true;
            this.indirectListbox.ItemHeight = 24;
            this.indirectListbox.Location = new System.Drawing.Point(521, 68);
            this.indirectListbox.Name = "indirectListbox";
            this.indirectListbox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.indirectListbox.Size = new System.Drawing.Size(218, 532);
            this.indirectListbox.TabIndex = 6;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.airportLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.directLabel, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.indirectListbox, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.indirectLabel, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.allConnectionsListbox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.directListbox, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.allConnectionsLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.airpotListbox, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(565, 73);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.41009F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.5899F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(742, 626);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // airportLabel
            // 
            this.airportLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.airportLabel.AutoSize = true;
            this.airportLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.airportLabel.Location = new System.Drawing.Point(31, 20);
            this.airportLabel.Name = "airportLabel";
            this.airportLabel.Size = new System.Drawing.Size(86, 25);
            this.airportLabel.TabIndex = 8;
            this.airportLabel.Text = "Airports";
            this.airportLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // directLabel
            // 
            this.directLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.directLabel.AutoSize = true;
            this.directLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.directLabel.Location = new System.Drawing.Point(378, 7);
            this.directLabel.Name = "directLabel";
            this.directLabel.Size = new System.Drawing.Size(132, 50);
            this.directLabel.TabIndex = 8;
            this.directLabel.Text = "Direct Connections";
            this.directLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // indirectLabel
            // 
            this.indirectLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.indirectLabel.AutoSize = true;
            this.indirectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indirectLabel.Location = new System.Drawing.Point(526, 20);
            this.indirectLabel.Name = "indirectLabel";
            this.indirectLabel.Size = new System.Drawing.Size(208, 25);
            this.indirectLabel.TabIndex = 8;
            this.indirectLabel.Text = "Indirect Connections";
            this.indirectLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // allConnectionsLabel
            // 
            this.allConnectionsLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.allConnectionsLabel.AutoSize = true;
            this.allConnectionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allConnectionsLabel.Location = new System.Drawing.Point(193, 20);
            this.allConnectionsLabel.Name = "allConnectionsLabel";
            this.allConnectionsLabel.Size = new System.Drawing.Size(132, 25);
            this.allConnectionsLabel.TabIndex = 8;
            this.allConnectionsLabel.Text = "Connections";
            this.allConnectionsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorPanel
            // 
            this.errorPanel.Controls.Add(this.errorLabel);
            this.errorPanel.Controls.Add(this.errorTitleLabel);
            this.errorPanel.Location = new System.Drawing.Point(22, 596);
            this.errorPanel.Name = "errorPanel";
            this.errorPanel.Size = new System.Drawing.Size(517, 103);
            this.errorPanel.TabIndex = 8;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.errorLabel.Location = new System.Drawing.Point(5, 38);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(328, 25);
            this.errorLabel.TabIndex = 10;
            this.errorLabel.Text = "Hide this panel, until error occurs";
            // 
            // errorTitleLabel
            // 
            this.errorTitleLabel.AutoSize = true;
            this.errorTitleLabel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.errorTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.errorTitleLabel.Location = new System.Drawing.Point(3, 0);
            this.errorTitleLabel.Name = "errorTitleLabel";
            this.errorTitleLabel.Size = new System.Drawing.Size(73, 29);
            this.errorTitleLabel.TabIndex = 9;
            this.errorTitleLabel.Text = "Error:";
            // 
            // connectionPanel
            // 
            this.connectionPanel.Controls.Add(this.connectButton);
            this.connectionPanel.Controls.Add(this.toAirportTextbox);
            this.connectionPanel.Controls.Add(this.fromAirportTextbox);
            this.connectionPanel.Controls.Add(this.toAirportLabel);
            this.connectionPanel.Controls.Add(this.fromAirportLabel);
            this.connectionPanel.Location = new System.Drawing.Point(19, 209);
            this.connectionPanel.Name = "connectionPanel";
            this.connectionPanel.Size = new System.Drawing.Size(429, 112);
            this.connectionPanel.TabIndex = 9;
            // 
            // connectButton
            // 
            this.connectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectButton.Location = new System.Drawing.Point(238, 29);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(182, 40);
            this.connectButton.TabIndex = 5;
            this.connectButton.Text = "Connect airports";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // toAirportTextbox
            // 
            this.toAirportTextbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.toAirportTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toAirportTextbox.Location = new System.Drawing.Point(143, 57);
            this.toAirportTextbox.Name = "toAirportTextbox";
            this.toAirportTextbox.Size = new System.Drawing.Size(89, 31);
            this.toAirportTextbox.TabIndex = 7;
            this.toAirportTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.toAirportTextbox_KeyPress);
            // 
            // fromAirportTextbox
            // 
            this.fromAirportTextbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.fromAirportTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromAirportTextbox.Location = new System.Drawing.Point(143, 14);
            this.fromAirportTextbox.Name = "fromAirportTextbox";
            this.fromAirportTextbox.Size = new System.Drawing.Size(89, 31);
            this.fromAirportTextbox.TabIndex = 5;
            this.fromAirportTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fromAirportTextbox_KeyPress);
            // 
            // toAirportLabel
            // 
            this.toAirportLabel.AutoSize = true;
            this.toAirportLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toAirportLabel.Location = new System.Drawing.Point(27, 60);
            this.toAirportLabel.Name = "toAirportLabel";
            this.toAirportLabel.Size = new System.Drawing.Size(110, 25);
            this.toAirportLabel.TabIndex = 6;
            this.toAirportLabel.Text = "To airport:";
            // 
            // fromAirportLabel
            // 
            this.fromAirportLabel.AutoSize = true;
            this.fromAirportLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromAirportLabel.Location = new System.Drawing.Point(3, 17);
            this.fromAirportLabel.Name = "fromAirportLabel";
            this.fromAirportLabel.Size = new System.Drawing.Size(134, 25);
            this.fromAirportLabel.TabIndex = 5;
            this.fromAirportLabel.Text = "From airport:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(435, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "Direct connection between two airports:";
            // 
            // selectAirportPanel
            // 
            this.selectAirportPanel.Controls.Add(this.selectButton);
            this.selectAirportPanel.Controls.Add(this.selectTextbox);
            this.selectAirportPanel.Controls.Add(this.selectLabel);
            this.selectAirportPanel.Location = new System.Drawing.Point(19, 371);
            this.selectAirportPanel.Name = "selectAirportPanel";
            this.selectAirportPanel.Size = new System.Drawing.Size(429, 61);
            this.selectAirportPanel.TabIndex = 11;
            // 
            // selectButton
            // 
            this.selectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectButton.Location = new System.Drawing.Point(226, 9);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(194, 40);
            this.selectButton.TabIndex = 8;
            this.selectButton.Text = "View connections";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // selectTextbox
            // 
            this.selectTextbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.selectTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectTextbox.Location = new System.Drawing.Point(131, 14);
            this.selectTextbox.Name = "selectTextbox";
            this.selectTextbox.Size = new System.Drawing.Size(89, 31);
            this.selectTextbox.TabIndex = 8;
            this.selectTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.selectTextbox_KeyPress);
            // 
            // selectLabel
            // 
            this.selectLabel.AutoSize = true;
            this.selectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectLabel.Location = new System.Drawing.Point(3, 17);
            this.selectLabel.Name = "selectLabel";
            this.selectLabel.Size = new System.Drawing.Size(122, 25);
            this.selectLabel.TabIndex = 8;
            this.selectLabel.Text = "Enter code:";
            // 
            // selectTitleLabel
            // 
            this.selectTitleLabel.AutoSize = true;
            this.selectTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectTitleLabel.Location = new System.Drawing.Point(22, 339);
            this.selectTitleLabel.Name = "selectTitleLabel";
            this.selectTitleLabel.Size = new System.Drawing.Size(282, 29);
            this.selectTitleLabel.TabIndex = 12;
            this.selectTitleLabel.Text = "View airport connections:";
            // 
            // removePanel
            // 
            this.removePanel.Controls.Add(this.removeButton);
            this.removePanel.Controls.Add(this.removeTextbox);
            this.removePanel.Controls.Add(this.removeLabel);
            this.removePanel.Location = new System.Drawing.Point(19, 485);
            this.removePanel.Name = "removePanel";
            this.removePanel.Size = new System.Drawing.Size(404, 56);
            this.removePanel.TabIndex = 13;
            // 
            // removeButton
            // 
            this.removeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeButton.Location = new System.Drawing.Point(228, 7);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(169, 40);
            this.removeButton.TabIndex = 9;
            this.removeButton.Text = "Remove airport";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // removeTextbox
            // 
            this.removeTextbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.removeTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeTextbox.Location = new System.Drawing.Point(134, 12);
            this.removeTextbox.Name = "removeTextbox";
            this.removeTextbox.Size = new System.Drawing.Size(89, 31);
            this.removeTextbox.TabIndex = 9;
            this.removeTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.removeTextbox_KeyPress);
            // 
            // removeLabel
            // 
            this.removeLabel.AutoSize = true;
            this.removeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeLabel.Location = new System.Drawing.Point(6, 15);
            this.removeLabel.Name = "removeLabel";
            this.removeLabel.Size = new System.Drawing.Size(122, 25);
            this.removeLabel.TabIndex = 9;
            this.removeLabel.Text = "Enter code:";
            // 
            // removeTitleLabel
            // 
            this.removeTitleLabel.AutoSize = true;
            this.removeTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeTitleLabel.Location = new System.Drawing.Point(19, 453);
            this.removeTitleLabel.Name = "removeTitleLabel";
            this.removeTitleLabel.Size = new System.Drawing.Size(216, 29);
            this.removeTitleLabel.TabIndex = 14;
            this.removeTitleLabel.Text = "Remove an airport:";
            // 
            // nodesLabel
            // 
            this.nodesLabel.AutoSize = true;
            this.nodesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nodesLabel.Location = new System.Drawing.Point(802, 24);
            this.nodesLabel.Name = "nodesLabel";
            this.nodesLabel.Size = new System.Drawing.Size(164, 25);
            this.nodesLabel.TabIndex = 15;
            this.nodesLabel.Text = "Total Airports: 0";
            // 
            // edgesLabel
            // 
            this.edgesLabel.AutoSize = true;
            this.edgesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edgesLabel.Location = new System.Drawing.Point(1043, 24);
            this.edgesLabel.Name = "edgesLabel";
            this.edgesLabel.Size = new System.Drawing.Size(210, 25);
            this.edgesLabel.TabIndex = 16;
            this.edgesLabel.Text = "Total Connections: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1319, 719);
            this.Controls.Add(this.edgesLabel);
            this.Controls.Add(this.nodesLabel);
            this.Controls.Add(this.removeTitleLabel);
            this.Controls.Add(this.removePanel);
            this.Controls.Add(this.selectTitleLabel);
            this.Controls.Add(this.selectAirportPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.connectionPanel);
            this.Controls.Add(this.errorPanel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.insertTitleLabel);
            this.Controls.Add(this.insertPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.insertPanel.ResumeLayout(false);
            this.insertPanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.errorPanel.ResumeLayout(false);
            this.errorPanel.PerformLayout();
            this.connectionPanel.ResumeLayout(false);
            this.connectionPanel.PerformLayout();
            this.selectAirportPanel.ResumeLayout(false);
            this.selectAirportPanel.PerformLayout();
            this.removePanel.ResumeLayout(false);
            this.removePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel insertPanel;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.TextBox codeTextbox;
        private System.Windows.Forms.Label insertLabel;
        private System.Windows.Forms.Label insertTitleLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.ListBox airpotListbox;
        private System.Windows.Forms.ListBox directListbox;
        private System.Windows.Forms.ListBox allConnectionsListbox;
        private System.Windows.Forms.ListBox indirectListbox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label indirectLabel;
        private System.Windows.Forms.Label directLabel;
        private System.Windows.Forms.Label allConnectionsLabel;
        private System.Windows.Forms.Label airportLabel;
        private System.Windows.Forms.Panel errorPanel;
        private System.Windows.Forms.Label errorTitleLabel;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Panel connectionPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox toAirportTextbox;
        private System.Windows.Forms.TextBox fromAirportTextbox;
        private System.Windows.Forms.Label toAirportLabel;
        private System.Windows.Forms.Label fromAirportLabel;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Panel selectAirportPanel;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.TextBox selectTextbox;
        private System.Windows.Forms.Label selectLabel;
        private System.Windows.Forms.Label selectTitleLabel;
        private System.Windows.Forms.Panel removePanel;
        private System.Windows.Forms.Label removeTitleLabel;
        private System.Windows.Forms.Label removeLabel;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.TextBox removeTextbox;
        private System.Windows.Forms.Label nodesLabel;
        private System.Windows.Forms.Label edgesLabel;
    }
}

