namespace Exercise_1
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
            this.inputBox = new System.Windows.Forms.TextBox();
            this.inputLabel = new System.Windows.Forms.Label();
            this.addRadiobutton = new System.Windows.Forms.RadioButton();
            this.removeRadiobutton = new System.Windows.Forms.RadioButton();
            this.submitButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tailLabel3 = new System.Windows.Forms.Label();
            this.tailLabel4 = new System.Windows.Forms.Label();
            this.tailLabel2 = new System.Windows.Forms.Label();
            this.tailLabel0 = new System.Windows.Forms.Label();
            this.tailLabel1 = new System.Windows.Forms.Label();
            this.tailLabel8 = new System.Windows.Forms.Label();
            this.tailLabel9 = new System.Windows.Forms.Label();
            this.tailLabel7 = new System.Windows.Forms.Label();
            this.tailLabel5 = new System.Windows.Forms.Label();
            this.headLabel0 = new System.Windows.Forms.Label();
            this.arrayLabel6 = new System.Windows.Forms.Label();
            this.arrayLabel5 = new System.Windows.Forms.Label();
            this.arrayLabel7 = new System.Windows.Forms.Label();
            this.arrayLabel9 = new System.Windows.Forms.Label();
            this.arrayLabel8 = new System.Windows.Forms.Label();
            this.arrayLabel1 = new System.Windows.Forms.Label();
            this.arrayLabel0 = new System.Windows.Forms.Label();
            this.arrayLabel2 = new System.Windows.Forms.Label();
            this.arrayLabel4 = new System.Windows.Forms.Label();
            this.arrayLabel3 = new System.Windows.Forms.Label();
            this.labelElement9 = new System.Windows.Forms.Label();
            this.labelElement8 = new System.Windows.Forms.Label();
            this.labelElement7 = new System.Windows.Forms.Label();
            this.labelElement6 = new System.Windows.Forms.Label();
            this.labelElement5 = new System.Windows.Forms.Label();
            this.labelElement4 = new System.Windows.Forms.Label();
            this.labelElement3 = new System.Windows.Forms.Label();
            this.labelElement2 = new System.Windows.Forms.Label();
            this.labelElement1 = new System.Windows.Forms.Label();
            this.labelElement0 = new System.Windows.Forms.Label();
            this.tailLabel6 = new System.Windows.Forms.Label();
            this.headLabel1 = new System.Windows.Forms.Label();
            this.headLabel2 = new System.Windows.Forms.Label();
            this.headLabel3 = new System.Windows.Forms.Label();
            this.headLabel4 = new System.Windows.Forms.Label();
            this.headLabel5 = new System.Windows.Forms.Label();
            this.headLabel6 = new System.Windows.Forms.Label();
            this.headLabel7 = new System.Windows.Forms.Label();
            this.headLabel8 = new System.Windows.Forms.Label();
            this.headLabel9 = new System.Windows.Forms.Label();
            this.errorTextBox = new System.Windows.Forms.TextBox();
            this.queueLabel = new System.Windows.Forms.Label();
            this.queueCountLabel = new System.Windows.Forms.Label();
            this.reverseRadiobutton = new System.Windows.Forms.RadioButton();
            this.reverseCombobox = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(116, 32);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(242, 23);
            this.inputBox.TabIndex = 0;
            this.inputBox.TextChanged += new System.EventHandler(this.inputBox_TextChanged);
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputLabel.Location = new System.Drawing.Point(26, 32);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(84, 21);
            this.inputLabel.TabIndex = 1;
            this.inputLabel.Text = "Input here:";
            // 
            // addRadiobutton
            // 
            this.addRadiobutton.AutoSize = true;
            this.addRadiobutton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addRadiobutton.Location = new System.Drawing.Point(45, 74);
            this.addRadiobutton.Name = "addRadiobutton";
            this.addRadiobutton.Size = new System.Drawing.Size(56, 25);
            this.addRadiobutton.TabIndex = 2;
            this.addRadiobutton.TabStop = true;
            this.addRadiobutton.Text = "Add";
            this.addRadiobutton.UseVisualStyleBackColor = true;
            this.addRadiobutton.CheckedChanged += new System.EventHandler(this.addRadiobutton_CheckedChanged);
            // 
            // removeRadiobutton
            // 
            this.removeRadiobutton.AutoSize = true;
            this.removeRadiobutton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.removeRadiobutton.Location = new System.Drawing.Point(152, 74);
            this.removeRadiobutton.Name = "removeRadiobutton";
            this.removeRadiobutton.Size = new System.Drawing.Size(85, 25);
            this.removeRadiobutton.TabIndex = 3;
            this.removeRadiobutton.TabStop = true;
            this.removeRadiobutton.Text = "Remove";
            this.removeRadiobutton.UseVisualStyleBackColor = true;
            this.removeRadiobutton.CheckedChanged += new System.EventHandler(this.removeRadiobutton_CheckedChanged);
            // 
            // submitButton
            // 
            this.submitButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.submitButton.Location = new System.Drawing.Point(375, 12);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(106, 67);
            this.submitButton.TabIndex = 4;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Window;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 10;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this.tailLabel3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tailLabel4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tailLabel2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tailLabel0, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tailLabel1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tailLabel8, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tailLabel9, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tailLabel7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tailLabel5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.headLabel0, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.arrayLabel6, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.arrayLabel5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.arrayLabel7, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.arrayLabel9, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.arrayLabel8, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.arrayLabel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.arrayLabel0, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.arrayLabel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.arrayLabel4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.arrayLabel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelElement9, 9, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelElement8, 8, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelElement7, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelElement6, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelElement5, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelElement4, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelElement3, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelElement2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelElement1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelElement0, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tailLabel6, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.headLabel1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.headLabel2, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.headLabel3, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.headLabel4, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.headLabel5, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.headLabel6, 6, 2);
            this.tableLayoutPanel1.Controls.Add(this.headLabel7, 7, 2);
            this.tableLayoutPanel1.Controls.Add(this.headLabel8, 8, 2);
            this.tableLayoutPanel1.Controls.Add(this.headLabel9, 9, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 344);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(905, 238);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // tailLabel3
            // 
            this.tailLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tailLabel3.AutoSize = true;
            this.tailLabel3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tailLabel3.Location = new System.Drawing.Point(315, 209);
            this.tailLabel3.Name = "tailLabel3";
            this.tailLabel3.Size = new System.Drawing.Size(0, 25);
            this.tailLabel3.TabIndex = 44;
            // 
            // tailLabel4
            // 
            this.tailLabel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tailLabel4.AutoSize = true;
            this.tailLabel4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tailLabel4.Location = new System.Drawing.Point(405, 209);
            this.tailLabel4.Name = "tailLabel4";
            this.tailLabel4.Size = new System.Drawing.Size(0, 25);
            this.tailLabel4.TabIndex = 43;
            // 
            // tailLabel2
            // 
            this.tailLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tailLabel2.AutoSize = true;
            this.tailLabel2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tailLabel2.Location = new System.Drawing.Point(225, 209);
            this.tailLabel2.Name = "tailLabel2";
            this.tailLabel2.Size = new System.Drawing.Size(0, 25);
            this.tailLabel2.TabIndex = 42;
            // 
            // tailLabel0
            // 
            this.tailLabel0.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tailLabel0.AutoSize = true;
            this.tailLabel0.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tailLabel0.Location = new System.Drawing.Point(25, 209);
            this.tailLabel0.Name = "tailLabel0";
            this.tailLabel0.Size = new System.Drawing.Size(40, 25);
            this.tailLabel0.TabIndex = 41;
            this.tailLabel0.Text = "Tail";
            this.tailLabel0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tailLabel1
            // 
            this.tailLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tailLabel1.AutoSize = true;
            this.tailLabel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tailLabel1.Location = new System.Drawing.Point(135, 209);
            this.tailLabel1.Name = "tailLabel1";
            this.tailLabel1.Size = new System.Drawing.Size(0, 25);
            this.tailLabel1.TabIndex = 33;
            // 
            // tailLabel8
            // 
            this.tailLabel8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tailLabel8.AutoSize = true;
            this.tailLabel8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tailLabel8.Location = new System.Drawing.Point(765, 209);
            this.tailLabel8.Name = "tailLabel8";
            this.tailLabel8.Size = new System.Drawing.Size(0, 25);
            this.tailLabel8.TabIndex = 32;
            // 
            // tailLabel9
            // 
            this.tailLabel9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tailLabel9.AutoSize = true;
            this.tailLabel9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tailLabel9.Location = new System.Drawing.Point(857, 209);
            this.tailLabel9.Name = "tailLabel9";
            this.tailLabel9.Size = new System.Drawing.Size(0, 25);
            this.tailLabel9.TabIndex = 31;
            // 
            // tailLabel7
            // 
            this.tailLabel7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tailLabel7.AutoSize = true;
            this.tailLabel7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tailLabel7.Location = new System.Drawing.Point(675, 209);
            this.tailLabel7.Name = "tailLabel7";
            this.tailLabel7.Size = new System.Drawing.Size(0, 25);
            this.tailLabel7.TabIndex = 30;
            // 
            // tailLabel5
            // 
            this.tailLabel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tailLabel5.AutoSize = true;
            this.tailLabel5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tailLabel5.Location = new System.Drawing.Point(495, 209);
            this.tailLabel5.Name = "tailLabel5";
            this.tailLabel5.Size = new System.Drawing.Size(0, 25);
            this.tailLabel5.TabIndex = 29;
            // 
            // headLabel0
            // 
            this.headLabel0.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.headLabel0.AutoSize = true;
            this.headLabel0.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headLabel0.Location = new System.Drawing.Point(17, 177);
            this.headLabel0.Name = "headLabel0";
            this.headLabel0.Size = new System.Drawing.Size(56, 25);
            this.headLabel0.TabIndex = 8;
            this.headLabel0.Text = "Head";
            this.headLabel0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // arrayLabel6
            // 
            this.arrayLabel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.arrayLabel6.AutoSize = true;
            this.arrayLabel6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.arrayLabel6.Location = new System.Drawing.Point(585, 121);
            this.arrayLabel6.Name = "arrayLabel6";
            this.arrayLabel6.Size = new System.Drawing.Size(0, 20);
            this.arrayLabel6.TabIndex = 25;
            // 
            // arrayLabel5
            // 
            this.arrayLabel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.arrayLabel5.AutoSize = true;
            this.arrayLabel5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.arrayLabel5.Location = new System.Drawing.Point(495, 121);
            this.arrayLabel5.Name = "arrayLabel5";
            this.arrayLabel5.Size = new System.Drawing.Size(0, 20);
            this.arrayLabel5.TabIndex = 24;
            // 
            // arrayLabel7
            // 
            this.arrayLabel7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.arrayLabel7.AutoSize = true;
            this.arrayLabel7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.arrayLabel7.Location = new System.Drawing.Point(675, 121);
            this.arrayLabel7.Name = "arrayLabel7";
            this.arrayLabel7.Size = new System.Drawing.Size(0, 20);
            this.arrayLabel7.TabIndex = 23;
            // 
            // arrayLabel9
            // 
            this.arrayLabel9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.arrayLabel9.AutoSize = true;
            this.arrayLabel9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.arrayLabel9.Location = new System.Drawing.Point(857, 121);
            this.arrayLabel9.Name = "arrayLabel9";
            this.arrayLabel9.Size = new System.Drawing.Size(0, 20);
            this.arrayLabel9.TabIndex = 22;
            // 
            // arrayLabel8
            // 
            this.arrayLabel8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.arrayLabel8.AutoSize = true;
            this.arrayLabel8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.arrayLabel8.Location = new System.Drawing.Point(765, 121);
            this.arrayLabel8.Name = "arrayLabel8";
            this.arrayLabel8.Size = new System.Drawing.Size(0, 20);
            this.arrayLabel8.TabIndex = 21;
            // 
            // arrayLabel1
            // 
            this.arrayLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.arrayLabel1.AutoSize = true;
            this.arrayLabel1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.arrayLabel1.Location = new System.Drawing.Point(135, 121);
            this.arrayLabel1.Name = "arrayLabel1";
            this.arrayLabel1.Size = new System.Drawing.Size(0, 20);
            this.arrayLabel1.TabIndex = 20;
            // 
            // arrayLabel0
            // 
            this.arrayLabel0.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.arrayLabel0.AutoSize = true;
            this.arrayLabel0.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.arrayLabel0.Location = new System.Drawing.Point(45, 121);
            this.arrayLabel0.Name = "arrayLabel0";
            this.arrayLabel0.Size = new System.Drawing.Size(0, 20);
            this.arrayLabel0.TabIndex = 19;
            // 
            // arrayLabel2
            // 
            this.arrayLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.arrayLabel2.AutoSize = true;
            this.arrayLabel2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.arrayLabel2.Location = new System.Drawing.Point(225, 121);
            this.arrayLabel2.Name = "arrayLabel2";
            this.arrayLabel2.Size = new System.Drawing.Size(0, 20);
            this.arrayLabel2.TabIndex = 18;
            // 
            // arrayLabel4
            // 
            this.arrayLabel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.arrayLabel4.AutoSize = true;
            this.arrayLabel4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.arrayLabel4.Location = new System.Drawing.Point(405, 121);
            this.arrayLabel4.Name = "arrayLabel4";
            this.arrayLabel4.Size = new System.Drawing.Size(0, 20);
            this.arrayLabel4.TabIndex = 17;
            // 
            // arrayLabel3
            // 
            this.arrayLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.arrayLabel3.AutoSize = true;
            this.arrayLabel3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.arrayLabel3.Location = new System.Drawing.Point(315, 121);
            this.arrayLabel3.Name = "arrayLabel3";
            this.arrayLabel3.Size = new System.Drawing.Size(0, 20);
            this.arrayLabel3.TabIndex = 16;
            // 
            // labelElement9
            // 
            this.labelElement9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelElement9.AutoSize = true;
            this.labelElement9.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelElement9.Location = new System.Drawing.Point(840, 29);
            this.labelElement9.Name = "labelElement9";
            this.labelElement9.Size = new System.Drawing.Size(35, 30);
            this.labelElement9.TabIndex = 15;
            this.labelElement9.Text = "10";
            // 
            // labelElement8
            // 
            this.labelElement8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelElement8.AutoSize = true;
            this.labelElement8.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelElement8.Location = new System.Drawing.Point(753, 29);
            this.labelElement8.Name = "labelElement8";
            this.labelElement8.Size = new System.Drawing.Size(24, 30);
            this.labelElement8.TabIndex = 14;
            this.labelElement8.Text = "9";
            // 
            // labelElement7
            // 
            this.labelElement7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelElement7.AutoSize = true;
            this.labelElement7.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelElement7.Location = new System.Drawing.Point(663, 29);
            this.labelElement7.Name = "labelElement7";
            this.labelElement7.Size = new System.Drawing.Size(24, 30);
            this.labelElement7.TabIndex = 13;
            this.labelElement7.Text = "8";
            // 
            // labelElement6
            // 
            this.labelElement6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelElement6.AutoSize = true;
            this.labelElement6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelElement6.Location = new System.Drawing.Point(573, 29);
            this.labelElement6.Name = "labelElement6";
            this.labelElement6.Size = new System.Drawing.Size(24, 30);
            this.labelElement6.TabIndex = 12;
            this.labelElement6.Text = "7";
            // 
            // labelElement5
            // 
            this.labelElement5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelElement5.AutoSize = true;
            this.labelElement5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelElement5.Location = new System.Drawing.Point(483, 29);
            this.labelElement5.Name = "labelElement5";
            this.labelElement5.Size = new System.Drawing.Size(24, 30);
            this.labelElement5.TabIndex = 11;
            this.labelElement5.Text = "6";
            // 
            // labelElement4
            // 
            this.labelElement4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelElement4.AutoSize = true;
            this.labelElement4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelElement4.Location = new System.Drawing.Point(393, 29);
            this.labelElement4.Name = "labelElement4";
            this.labelElement4.Size = new System.Drawing.Size(24, 30);
            this.labelElement4.TabIndex = 10;
            this.labelElement4.Text = "5";
            // 
            // labelElement3
            // 
            this.labelElement3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelElement3.AutoSize = true;
            this.labelElement3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelElement3.Location = new System.Drawing.Point(303, 29);
            this.labelElement3.Name = "labelElement3";
            this.labelElement3.Size = new System.Drawing.Size(24, 30);
            this.labelElement3.TabIndex = 9;
            this.labelElement3.Text = "4";
            // 
            // labelElement2
            // 
            this.labelElement2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelElement2.AutoSize = true;
            this.labelElement2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelElement2.Location = new System.Drawing.Point(213, 29);
            this.labelElement2.Name = "labelElement2";
            this.labelElement2.Size = new System.Drawing.Size(24, 30);
            this.labelElement2.TabIndex = 8;
            this.labelElement2.Text = "3";
            // 
            // labelElement1
            // 
            this.labelElement1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelElement1.AutoSize = true;
            this.labelElement1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelElement1.Location = new System.Drawing.Point(123, 29);
            this.labelElement1.Name = "labelElement1";
            this.labelElement1.Size = new System.Drawing.Size(24, 30);
            this.labelElement1.TabIndex = 7;
            this.labelElement1.Text = "2";
            // 
            // labelElement0
            // 
            this.labelElement0.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelElement0.AutoSize = true;
            this.labelElement0.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelElement0.Location = new System.Drawing.Point(33, 29);
            this.labelElement0.Name = "labelElement0";
            this.labelElement0.Size = new System.Drawing.Size(24, 30);
            this.labelElement0.TabIndex = 6;
            this.labelElement0.Text = "1";
            // 
            // tailLabel6
            // 
            this.tailLabel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tailLabel6.AutoSize = true;
            this.tailLabel6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tailLabel6.Location = new System.Drawing.Point(585, 209);
            this.tailLabel6.Name = "tailLabel6";
            this.tailLabel6.Size = new System.Drawing.Size(0, 25);
            this.tailLabel6.TabIndex = 26;
            // 
            // headLabel1
            // 
            this.headLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.headLabel1.AutoSize = true;
            this.headLabel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headLabel1.Location = new System.Drawing.Point(135, 177);
            this.headLabel1.Name = "headLabel1";
            this.headLabel1.Size = new System.Drawing.Size(0, 25);
            this.headLabel1.TabIndex = 27;
            // 
            // headLabel2
            // 
            this.headLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.headLabel2.AutoSize = true;
            this.headLabel2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headLabel2.Location = new System.Drawing.Point(225, 177);
            this.headLabel2.Name = "headLabel2";
            this.headLabel2.Size = new System.Drawing.Size(0, 25);
            this.headLabel2.TabIndex = 28;
            // 
            // headLabel3
            // 
            this.headLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.headLabel3.AutoSize = true;
            this.headLabel3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headLabel3.Location = new System.Drawing.Point(315, 177);
            this.headLabel3.Name = "headLabel3";
            this.headLabel3.Size = new System.Drawing.Size(0, 25);
            this.headLabel3.TabIndex = 34;
            // 
            // headLabel4
            // 
            this.headLabel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.headLabel4.AutoSize = true;
            this.headLabel4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headLabel4.Location = new System.Drawing.Point(405, 177);
            this.headLabel4.Name = "headLabel4";
            this.headLabel4.Size = new System.Drawing.Size(0, 25);
            this.headLabel4.TabIndex = 35;
            // 
            // headLabel5
            // 
            this.headLabel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.headLabel5.AutoSize = true;
            this.headLabel5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headLabel5.Location = new System.Drawing.Point(495, 177);
            this.headLabel5.Name = "headLabel5";
            this.headLabel5.Size = new System.Drawing.Size(0, 25);
            this.headLabel5.TabIndex = 36;
            // 
            // headLabel6
            // 
            this.headLabel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.headLabel6.AutoSize = true;
            this.headLabel6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headLabel6.Location = new System.Drawing.Point(585, 177);
            this.headLabel6.Name = "headLabel6";
            this.headLabel6.Size = new System.Drawing.Size(0, 25);
            this.headLabel6.TabIndex = 37;
            // 
            // headLabel7
            // 
            this.headLabel7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.headLabel7.AutoSize = true;
            this.headLabel7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headLabel7.Location = new System.Drawing.Point(675, 177);
            this.headLabel7.Name = "headLabel7";
            this.headLabel7.Size = new System.Drawing.Size(0, 25);
            this.headLabel7.TabIndex = 38;
            // 
            // headLabel8
            // 
            this.headLabel8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.headLabel8.AutoSize = true;
            this.headLabel8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headLabel8.Location = new System.Drawing.Point(765, 177);
            this.headLabel8.Name = "headLabel8";
            this.headLabel8.Size = new System.Drawing.Size(0, 25);
            this.headLabel8.TabIndex = 39;
            // 
            // headLabel9
            // 
            this.headLabel9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.headLabel9.AutoSize = true;
            this.headLabel9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headLabel9.Location = new System.Drawing.Point(857, 177);
            this.headLabel9.Name = "headLabel9";
            this.headLabel9.Size = new System.Drawing.Size(0, 25);
            this.headLabel9.TabIndex = 40;
            // 
            // errorTextBox
            // 
            this.errorTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.errorTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.errorTextBox.Location = new System.Drawing.Point(487, 12);
            this.errorTextBox.Multiline = true;
            this.errorTextBox.Name = "errorTextBox";
            this.errorTextBox.ReadOnly = true;
            this.errorTextBox.Size = new System.Drawing.Size(413, 87);
            this.errorTextBox.TabIndex = 6;
            this.errorTextBox.ForeColorChanged += new System.EventHandler(this.Form1_Load);
            this.errorTextBox.TextChanged += new System.EventHandler(this.errorTextBox_TextChanged);
            // 
            // queueLabel
            // 
            this.queueLabel.AutoSize = true;
            this.queueLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.queueLabel.Location = new System.Drawing.Point(354, 292);
            this.queueLabel.Name = "queueLabel";
            this.queueLabel.Size = new System.Drawing.Size(216, 37);
            this.queueLabel.TabIndex = 7;
            this.queueLabel.Text = "Queue of names:";
            // 
            // queueCountLabel
            // 
            this.queueCountLabel.AutoSize = true;
            this.queueCountLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.queueCountLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.queueCountLabel.Location = new System.Drawing.Point(12, 313);
            this.queueCountLabel.Name = "queueCountLabel";
            this.queueCountLabel.Size = new System.Drawing.Size(144, 28);
            this.queueCountLabel.TabIndex = 8;
            this.queueCountLabel.Text = "Queue count: 0";
            this.queueCountLabel.Click += new System.EventHandler(this.queueCountLabel_Click);
            // 
            // reverseRadiobutton
            // 
            this.reverseRadiobutton.AutoSize = true;
            this.reverseRadiobutton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.reverseRadiobutton.Location = new System.Drawing.Point(275, 74);
            this.reverseRadiobutton.Name = "reverseRadiobutton";
            this.reverseRadiobutton.Size = new System.Drawing.Size(83, 25);
            this.reverseRadiobutton.TabIndex = 9;
            this.reverseRadiobutton.TabStop = true;
            this.reverseRadiobutton.Text = "Reverse";
            this.reverseRadiobutton.UseVisualStyleBackColor = true;
            this.reverseRadiobutton.CheckedChanged += new System.EventHandler(this.reverseRadiobutton_CheckedChanged);
            // 
            // reverseCombobox
            // 
            this.reverseCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.reverseCombobox.FormattingEnabled = true;
            this.reverseCombobox.Location = new System.Drawing.Point(116, 32);
            this.reverseCombobox.Name = "reverseCombobox";
            this.reverseCombobox.Size = new System.Drawing.Size(242, 23);
            this.reverseCombobox.TabIndex = 10;
            this.reverseCombobox.Visible = false;
            this.reverseCombobox.SelectedIndexChanged += new System.EventHandler(this.reverseCombobox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(927, 609);
            this.Controls.Add(this.reverseCombobox);
            this.Controls.Add(this.reverseRadiobutton);
            this.Controls.Add(this.queueCountLabel);
            this.Controls.Add(this.queueLabel);
            this.Controls.Add(this.errorTextBox);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.removeRadiobutton);
            this.Controls.Add(this.addRadiobutton);
            this.Controls.Add(this.inputLabel);
            this.Controls.Add(this.inputBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox inputBox;
        private Label inputLabel;
        private RadioButton addRadiobutton;
        private RadioButton removeRadiobutton;
        private Button submitButton;
        private TableLayoutPanel tableLayoutPanel1;
        private Label labelElement9;
        private Label labelElement8;
        private Label labelElement7;
        private Label labelElement6;
        private Label labelElement5;
        private Label labelElement4;
        private Label labelElement3;
        private Label labelElement2;
        private Label labelElement1;
        private Label labelElement0;
        private Label arrayLabel6;
        private Label arrayLabel5;
        private Label arrayLabel7;
        private Label arrayLabel9;
        private Label arrayLabel8;
        private Label arrayLabel1;
        private Label arrayLabel0;
        private Label arrayLabel2;
        private Label arrayLabel4;
        private Label arrayLabel3;
        private TextBox errorTextBox;
        private Label queueLabel;
        private Label headLabel0;
        private Label tailLabel6;
        private Label tailLabel3;
        private Label tailLabel4;
        private Label tailLabel2;
        private Label tailLabel0;
        private Label tailLabel1;
        private Label tailLabel8;
        private Label tailLabel9;
        private Label tailLabel7;
        private Label tailLabel5;
        private Label headLabel1;
        private Label headLabel2;
        private Label headLabel3;
        private Label headLabel4;
        private Label headLabel5;
        private Label headLabel6;
        private Label headLabel7;
        private Label headLabel8;
        private Label headLabel9;
        private Label queueCountLabel;
        private RadioButton reverseRadiobutton;
        private ComboBox reverseCombobox;
    }
}