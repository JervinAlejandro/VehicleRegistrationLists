
namespace Lists
{
    partial class Lists
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lists));
            this.listDisplay = new System.Windows.Forms.ListBox();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonLinSearch = new System.Windows.Forms.Button();
            this.buttonTag = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.singleDataTextBox = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // listDisplay
            // 
            this.listDisplay.FormattingEnabled = true;
            this.listDisplay.Location = new System.Drawing.Point(12, 103);
            this.listDisplay.Name = "listDisplay";
            this.listDisplay.Size = new System.Drawing.Size(151, 251);
            this.listDisplay.TabIndex = 0;
            this.toolTip1.SetToolTip(this.listDisplay, "List of Registration Plates");
            this.listDisplay.SelectedIndexChanged += new System.EventHandler(this.listDisplay_SelectedIndexChanged);
            this.listDisplay.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listDisplay_MouseDoubleClick);
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(12, 12);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(275, 20);
            this.textBoxInput.TabIndex = 1;
            this.toolTip1.SetToolTip(this.textBoxInput, "Enter Registration Plate(one number, three letters, three numbers(Standard WA reg" +
        "o plate format))");
            this.textBoxInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxInput_KeyPress);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(12, 38);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(121, 52);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "ENTER";
            this.toolTip1.SetToolTip(this.addButton, "Add Registration Plate to list");
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(155, 38);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(132, 23);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "DELETE";
            this.toolTip1.SetToolTip(this.deleteButton, "Remove Selected Registration Plate from the List");
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(187, 171);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(100, 23);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "BIN SEARCH";
            this.toolTip1.SetToolTip(this.searchButton, "Search a particular Registration Plate in binary search method");
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(187, 276);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(100, 23);
            this.openButton.TabIndex = 5;
            this.openButton.Text = "OPEN";
            this.toolTip1.SetToolTip(this.openButton, "Open a text file");
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(187, 247);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(100, 23);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "SAVE";
            this.toolTip1.SetToolTip(this.saveButton, "Save file to text format");
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(155, 67);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(132, 23);
            this.buttonEdit.TabIndex = 7;
            this.buttonEdit.Text = "EDIT";
            this.toolTip1.SetToolTip(this.buttonEdit, "Change the selected Registration Plate on the list.");
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonLinSearch
            // 
            this.buttonLinSearch.Location = new System.Drawing.Point(187, 200);
            this.buttonLinSearch.Name = "buttonLinSearch";
            this.buttonLinSearch.Size = new System.Drawing.Size(100, 23);
            this.buttonLinSearch.TabIndex = 8;
            this.buttonLinSearch.Text = "LIN SEARCH";
            this.toolTip1.SetToolTip(this.buttonLinSearch, "Search a particular Registration Plate in linear search method");
            this.buttonLinSearch.UseVisualStyleBackColor = true;
            this.buttonLinSearch.Click += new System.EventHandler(this.buttonLinSearch_Click);
            // 
            // buttonTag
            // 
            this.buttonTag.Location = new System.Drawing.Point(187, 129);
            this.buttonTag.Name = "buttonTag";
            this.buttonTag.Size = new System.Drawing.Size(100, 23);
            this.buttonTag.TabIndex = 10;
            this.buttonTag.Text = "TAG";
            this.toolTip1.SetToolTip(this.buttonTag, "Flag a Registration Plate for future inspection");
            this.buttonTag.UseVisualStyleBackColor = true;
            this.buttonTag.Click += new System.EventHandler(this.buttonTag_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(187, 362);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(100, 23);
            this.buttonReset.TabIndex = 11;
            this.buttonReset.Text = "RESET";
            this.toolTip1.SetToolTip(this.buttonReset, "Remove all registration plate in the list");
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // singleDataTextBox
            // 
            this.singleDataTextBox.Location = new System.Drawing.Point(187, 103);
            this.singleDataTextBox.Name = "singleDataTextBox";
            this.singleDataTextBox.Size = new System.Drawing.Size(100, 20);
            this.singleDataTextBox.TabIndex = 12;
            this.singleDataTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.singleDataTextBox, "Display Registration Plate");
            this.singleDataTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.singleDataTextBox_KeyPress);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip.Location = new System.Drawing.Point(0, 388);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(299, 22);
            this.statusStrip.TabIndex = 13;
            this.statusStrip.Text = "-";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(12, 17);
            this.toolStripStatusLabel1.Text = "-";
            // 
            // Lists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 410);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.singleDataTextBox);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonTag);
            this.Controls.Add(this.buttonLinSearch);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.listDisplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Lists";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vehicle Registration";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Lists_FormClosing);
            this.Load += new System.EventHandler(this.Lists_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listDisplay;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonLinSearch;
        private System.Windows.Forms.Button buttonTag;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.TextBox singleDataTextBox;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

