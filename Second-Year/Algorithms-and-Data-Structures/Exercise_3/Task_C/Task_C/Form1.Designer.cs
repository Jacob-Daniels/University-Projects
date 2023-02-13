namespace Task_C
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
            this.IDLabel = new System.Windows.Forms.Label();
            this.startLabel = new System.Windows.Forms.Label();
            this.endLabel = new System.Windows.Forms.Label();
            this.requestLabel = new System.Windows.Forms.Label();
            this.requestPanel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.IDSortButton = new System.Windows.Forms.Button();
            this.startTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endTimePicker = new System.Windows.Forms.DateTimePicker();
            this.IDTextbox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.IDListbox = new System.Windows.Forms.ListBox();
            this.displayPanel = new System.Windows.Forms.Panel();
            this.maxRequestsLabel = new System.Windows.Forms.Label();
            this.displayLabel = new System.Windows.Forms.Label();
            this.errorPanel = new System.Windows.Forms.Panel();
            this.errorMessageLabel = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.requestPanel.SuspendLayout();
            this.displayPanel.SuspendLayout();
            this.errorPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDLabel.Location = new System.Drawing.Point(23, 61);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(97, 25);
            this.IDLabel.TabIndex = 0;
            this.IDLabel.Text = "Insert ID:";
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startLabel.Location = new System.Drawing.Point(11, 108);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(109, 25);
            this.startLabel.TabIndex = 1;
            this.startLabel.Text = "Start time:";
            // 
            // endLabel
            // 
            this.endLabel.AutoSize = true;
            this.endLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endLabel.Location = new System.Drawing.Point(18, 155);
            this.endLabel.Name = "endLabel";
            this.endLabel.Size = new System.Drawing.Size(102, 25);
            this.endLabel.TabIndex = 2;
            this.endLabel.Text = "End time:";
            // 
            // requestLabel
            // 
            this.requestLabel.AutoSize = true;
            this.requestLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requestLabel.Location = new System.Drawing.Point(3, 9);
            this.requestLabel.Name = "requestLabel";
            this.requestLabel.Size = new System.Drawing.Size(182, 29);
            this.requestLabel.TabIndex = 3;
            this.requestLabel.Text = "Enter a request:";
            // 
            // requestPanel
            // 
            this.requestPanel.Controls.Add(this.button2);
            this.requestPanel.Controls.Add(this.button1);
            this.requestPanel.Controls.Add(this.IDSortButton);
            this.requestPanel.Controls.Add(this.startTimePicker);
            this.requestPanel.Controls.Add(this.endTimePicker);
            this.requestPanel.Controls.Add(this.IDTextbox);
            this.requestPanel.Controls.Add(this.submitButton);
            this.requestPanel.Controls.Add(this.requestLabel);
            this.requestPanel.Controls.Add(this.IDLabel);
            this.requestPanel.Controls.Add(this.endLabel);
            this.requestPanel.Controls.Add(this.startLabel);
            this.requestPanel.Location = new System.Drawing.Point(12, 32);
            this.requestPanel.Name = "requestPanel";
            this.requestPanel.Size = new System.Drawing.Size(532, 362);
            this.requestPanel.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(330, 296);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(190, 40);
            this.button2.TabIndex = 15;
            this.button2.Text = "Sort by end time";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(330, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 40);
            this.button1.TabIndex = 14;
            this.button1.Text = "Sort by start time";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // IDSortButton
            // 
            this.IDSortButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDSortButton.Location = new System.Drawing.Point(330, 204);
            this.IDSortButton.Name = "IDSortButton";
            this.IDSortButton.Size = new System.Drawing.Size(190, 40);
            this.IDSortButton.TabIndex = 13;
            this.IDSortButton.Text = "Sort by ID";
            this.IDSortButton.UseVisualStyleBackColor = true;
            this.IDSortButton.Click += new System.EventHandler(this.IDSortButton_Click);
            // 
            // startTimePicker
            // 
            this.startTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.startTimePicker.Location = new System.Drawing.Point(126, 103);
            this.startTimePicker.Name = "startTimePicker";
            this.startTimePicker.ShowUpDown = true;
            this.startTimePicker.Size = new System.Drawing.Size(96, 31);
            this.startTimePicker.TabIndex = 12;
            this.startTimePicker.Value = new System.DateTime(2023, 1, 11, 0, 0, 0, 0);
            // 
            // endTimePicker
            // 
            this.endTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.endTimePicker.Location = new System.Drawing.Point(126, 150);
            this.endTimePicker.Name = "endTimePicker";
            this.endTimePicker.ShowUpDown = true;
            this.endTimePicker.Size = new System.Drawing.Size(96, 31);
            this.endTimePicker.TabIndex = 11;
            this.endTimePicker.Value = new System.DateTime(2023, 1, 11, 0, 0, 0, 0);
            // 
            // IDTextbox
            // 
            this.IDTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDTextbox.Location = new System.Drawing.Point(126, 58);
            this.IDTextbox.Name = "IDTextbox";
            this.IDTextbox.Size = new System.Drawing.Size(101, 31);
            this.IDTextbox.TabIndex = 5;
            this.IDTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IDTextbox_KeyPress);
            // 
            // submitButton
            // 
            this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.Location = new System.Drawing.Point(22, 204);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(205, 40);
            this.submitButton.TabIndex = 4;
            this.submitButton.Text = "Submit request";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // IDListbox
            // 
            this.IDListbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDListbox.FormattingEnabled = true;
            this.IDListbox.ItemHeight = 18;
            this.IDListbox.Location = new System.Drawing.Point(18, 58);
            this.IDListbox.Name = "IDListbox";
            this.IDListbox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.IDListbox.Size = new System.Drawing.Size(460, 418);
            this.IDListbox.TabIndex = 5;
            // 
            // displayPanel
            // 
            this.displayPanel.Controls.Add(this.maxRequestsLabel);
            this.displayPanel.Controls.Add(this.displayLabel);
            this.displayPanel.Controls.Add(this.IDListbox);
            this.displayPanel.Location = new System.Drawing.Point(550, 32);
            this.displayPanel.Name = "displayPanel";
            this.displayPanel.Size = new System.Drawing.Size(503, 512);
            this.displayPanel.TabIndex = 6;
            // 
            // maxRequestsLabel
            // 
            this.maxRequestsLabel.AutoSize = true;
            this.maxRequestsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxRequestsLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.maxRequestsLabel.Location = new System.Drawing.Point(312, 30);
            this.maxRequestsLabel.Name = "maxRequestsLabel";
            this.maxRequestsLabel.Size = new System.Drawing.Size(166, 25);
            this.maxRequestsLabel.TabIndex = 14;
            this.maxRequestsLabel.Text = "Max requests: 0";
            // 
            // displayLabel
            // 
            this.displayLabel.AutoSize = true;
            this.displayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayLabel.Location = new System.Drawing.Point(13, 9);
            this.displayLabel.Name = "displayLabel";
            this.displayLabel.Size = new System.Drawing.Size(181, 29);
            this.displayLabel.TabIndex = 6;
            this.displayLabel.Text = "List of requests:";
            // 
            // errorPanel
            // 
            this.errorPanel.Controls.Add(this.errorMessageLabel);
            this.errorPanel.Controls.Add(this.errorLabel);
            this.errorPanel.Location = new System.Drawing.Point(12, 400);
            this.errorPanel.Name = "errorPanel";
            this.errorPanel.Size = new System.Drawing.Size(453, 144);
            this.errorPanel.TabIndex = 7;
            // 
            // errorMessageLabel
            // 
            this.errorMessageLabel.AutoSize = true;
            this.errorMessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorMessageLabel.ForeColor = System.Drawing.Color.Red;
            this.errorMessageLabel.Location = new System.Drawing.Point(17, 58);
            this.errorMessageLabel.Name = "errorMessageLabel";
            this.errorMessageLabel.Size = new System.Drawing.Size(70, 25);
            this.errorMessageLabel.TabIndex = 1;
            this.errorMessageLabel.Text = "label1";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(11, 14);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(73, 29);
            this.errorLabel.TabIndex = 0;
            this.errorLabel.Text = "Error:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1065, 556);
            this.Controls.Add(this.errorPanel);
            this.Controls.Add(this.displayPanel);
            this.Controls.Add(this.requestPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.requestPanel.ResumeLayout(false);
            this.requestPanel.PerformLayout();
            this.displayPanel.ResumeLayout(false);
            this.displayPanel.PerformLayout();
            this.errorPanel.ResumeLayout(false);
            this.errorPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.Label endLabel;
        private System.Windows.Forms.Label requestLabel;
        private System.Windows.Forms.Panel requestPanel;
        private System.Windows.Forms.TextBox IDTextbox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.DateTimePicker endTimePicker;
        private System.Windows.Forms.DateTimePicker startTimePicker;
        private System.Windows.Forms.ListBox IDListbox;
        private System.Windows.Forms.Panel displayPanel;
        private System.Windows.Forms.Label displayLabel;
        private System.Windows.Forms.Panel errorPanel;
        private System.Windows.Forms.Label errorMessageLabel;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label maxRequestsLabel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button IDSortButton;
    }
}

