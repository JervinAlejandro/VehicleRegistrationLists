using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// CR = Client Requirement
// PR = Program Requirement

// Jervin Alejandro
// Date 09 November 2021
// Version 1.1
// Vehicle Registration
// Program allows user to add, delete, edit, tag, reset registration plates. Additionally, the program can save the data to a text file
// Furthermore, the program can also open a text file that contains registration plates
// Registration plates are displayed on the listbox

namespace Lists
{
    public partial class Lists : Form
    {
        public Lists()
        {
            InitializeComponent();
        }
        // PR: The prototype must use a List<> data structure of data type “string”.
        List<string> RegoPlate = new List<string>();
        // Temp list to check if Registration Plates are already tagged
        List<string> isTagged = new List<string>();

        #region FUNCTIONS
        // PR: Display all added/removed/edited items from the list
        // PR: List is sorted aplhabetically using List sort method
        private void DisplayList()
        {
            listDisplay.Items.Clear();
            RegoPlate.Sort();
            foreach (var rego in RegoPlate)
            {
                listDisplay.Items.Add(rego);
            }
        }
        // Load demo_##.txt file by default
        private void Lists_Load(object sender, EventArgs e)
        {
            string fileName = "demo_##.txt";

            using (Stream openFile = File.Open(fileName, FileMode.Open))
            {
                BinaryFormatter binFormat = new BinaryFormatter();
                while (openFile.Position < openFile.Length)
                {
                    RegoPlate.Add((string)binFormat.Deserialize(openFile));
                }
            }
            DisplayList();

        }
        // PR: Selected data is displayed in the TextBox on the right
        private void listDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {

            // Terinary Operater = Condition ? Statement 1 : Statement 2;
            var cond = listDisplay.SelectedIndex > -1 ? singleDataTextBox.Text = listDisplay.SelectedItem.ToString() : null;
        }
        // Prevent user from pressing ENTER key
        private void textBoxInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Terinary Operater = Condition ? Statement 1 : Statement 2;
            bool cond = e.KeyChar == (char)Keys.Enter ? e.Handled = true : e.Handled = false;

        }
        // Prevent user from entering any text or numbers
        private void singleDataTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Terinary Operater = Condition ? Statement 1 : Statement 2;
            bool cond = !char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Enter || (char.IsDigit(e.KeyChar))) 
                ? e.Handled = true : e.Handled = false;

        }
        // Clear textbox and focus cursor in Text box
        private void ccTextBox()
        {
            // Clear textbox
            // Cursor focus on textbox
            textBoxInput.Clear();
            textBoxInput.Select();
        }
        #endregion FUNCTIONS
        
        #region BUTTONS_1
        // CR: Add new rego plate
        // PR: User can type data value into the textbox
        // PR: Clear textbox and focus cursor in the textbox when data is added
        // PR: Generate error message if textbox is empty
        private void addButton_Click(object sender, EventArgs e)
        {

           // Terinary Operator = Condition ? Statement : Statement;
           // Condition1: Check if textbox is not empty and Registration Plate does not exist
           // Condition2: If Registration plate exist
           int stmnt = !string.IsNullOrEmpty(textBoxInput.Text) && !RegoPlate.Contains(textBoxInput.Text) ? stmnt = 1 
                : RegoPlate.Contains(textBoxInput.Text) ? stmnt = 2 : stmnt = 3;
           switch (stmnt)
           {
               case 1:
                   RegoPlate.Add(textBoxInput.Text);
                   toolStripStatusLabel1.Text = "Add Success";
                   ccTextBox();
                   DisplayList();
                   break;
               case 2:
                    MessageBox.Show("Add Fail");
                    toolStripStatusLabel1.Text = "Registration Plate already exist";
                    ccTextBox();
                    break;
                case 3:
                    MessageBox.Show("Add Fail");
                    toolStripStatusLabel1.Text = "Text box is empty";
                    ccTextBox();
                    break;
            }
        }
        // CR: Delete an existing rego plate
        // PR: Two methods to remove registration plate from the list 
        // PR: Clear textbox and focus cursor in the textbox when data is removed
        // PR: Remove by double clicking data item from the ListBox
        private void listDisplay_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            toolStripStatusLabel1.Text = "Remove Success";
            RegoPlate.Remove(singleDataTextBox.Text);
            singleDataTextBox.Clear();
            DisplayList();
        }
        // PR: Remove by entering the rego plate information into the TextBox
        private void deleteButton_Click(object sender, EventArgs e)
        {
            // Terinary Operator Condition ? Statement : Statement;
            // Condition1: Check if textbox is not empty and registration plate exist
            // Condition2: If registration does not exist
            int stmnt = !string.IsNullOrEmpty(textBoxInput.Text) && RegoPlate.Contains(textBoxInput.Text) ? stmnt = 1 : 
                !string.IsNullOrEmpty(textBoxInput.Text) && !RegoPlate.Contains(textBoxInput.Text) ? stmnt = 2 : stmnt = 3;

            switch (stmnt)
            {
                case 1:
                    RegoPlate.Remove(textBoxInput.Text);
                    toolStripStatusLabel1.Text = "Remove Success";
                    ccTextBox();
                    DisplayList();
                    break;
                case 2:
                    MessageBox.Show("Remove Fail");
                    toolStripStatusLabel1.Text = "Registration Plate does not exist";
                    ccTextBox();
                    break;
                case 3:
                    MessageBox.Show("Remove Fail");
                    toolStripStatusLabel1.Text = "Text box is empty";
                    ccTextBox();
                    break;
            }


        }
        // CR: Edit or update an existing rego plate
        // PR: Select an item from the ListBox to edit
        // PR: Clear textbox and focus cursor in the textbox when data is edited 
        // Change Registration plate in the list
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            // Temp variable
            string stmnt;
            // Terinary Operator Condition ? Statement : Statement;
            // Check if text box is not empty and item is selected
            var checkCond = !string.IsNullOrEmpty(textBoxInput.Text) && listDisplay.SelectedIndex > -1 ? stmnt = "1" : stmnt = "2";
            // If input already exist in the list and if nothing is selected
            var checkCond2 = RegoPlate.Contains(textBoxInput.Text) ? stmnt = "3" : !string.IsNullOrEmpty(textBoxInput.Text) && listDisplay.SelectedIndex < 0 ? stmnt = "4": null;

            switch (stmnt)
            {
                case "1":
                    RegoPlate[listDisplay.SelectedIndex] = textBoxInput.Text;
                    toolStripStatusLabel1.Text = "Edit Success";
                    ccTextBox();
                    DisplayList();
                    break;
                case "2":
                    MessageBox.Show("Edit Fail");
                    toolStripStatusLabel1.Text = "Text box is empty";
                    ccTextBox();
                    break;
                case "3":
                    MessageBox.Show("Edit Fail");
                    toolStripStatusLabel1.Text = "Registration Plate already exist";
                    ccTextBox();
                    break;
                case "4":
                    MessageBox.Show("Edit Fail");
                    toolStripStatusLabel1.Text = "No Registration Plate is selected";
                    ccTextBox();
                    break;
            }

        }
        #endregion BUTTONS_1

        #region BUTTONS_2
        // CR: Tag a specific rego plate for future investigation
        // PR: Add "z" before the rego plate to mark a rego plate
        private void buttonTag_Click(object sender, EventArgs e)
        {
            // Terinary Operator = Condition ? Statement : Statement;
            // Condition1: Check if item is selected has not yet been tagged
            // Condition2: If no item is selected
            int stmnt = listDisplay.SelectedIndex > -1 && !isTagged.Contains(RegoPlate[listDisplay.SelectedIndex]) ? stmnt = 1 
                : listDisplay.SelectedIndex < 0 ? stmnt = 2: stmnt = 3;

            switch (stmnt)
            {
                case 1:
                    RegoPlate[listDisplay.SelectedIndex] = "Z " + singleDataTextBox.Text;
                    isTagged.Add(RegoPlate[listDisplay.SelectedIndex]);
                    toolStripStatusLabel1.Text = "Tag Success";
                    DisplayList();
                    break;
                case 2:
                    MessageBox.Show("Tag Fail");
                    toolStripStatusLabel1.Text = "No Registration Plate is selected";
                    ccTextBox();
                    break;
                case 3:
                    MessageBox.Show("Tag Fail");
                    toolStripStatusLabel1.Text = "Registration plate already tagged";
                    ccTextBox();
                    break;
            }

        }
        // CR: Binary Search for a specific rego plate
        // PR: Locate a particular registration plate using a binary search algorithm
        private void searchButton_Click(object sender, EventArgs e)
        {
            // Terinary Operator = Condition ? Statement : Statement;
            // Condition1: Check If the registration plate exists. If there is no registration plate, the textbox is empty.
            // Condition2: If the textbox is not empty, there is no registration plate.
            int condition = RegoPlate.BinarySearch(textBoxInput.Text) >= 0 ? condition = 1 
                : !string.IsNullOrEmpty(textBoxInput.Text) ? condition = 2 : condition = 3;
            switch (condition)
            {
                case 1:
                    listDisplay.SelectedItem = textBoxInput.Text;
                    toolStripStatusLabel1.Text = "Search Success";
                    ccTextBox();
                    break;
                case 2:
                    MessageBox.Show("Search Fail");
                    toolStripStatusLabel1.Text = "Registration Plate does not exist";
                    ccTextBox();
                    break;
                case 3:
                    MessageBox.Show("Search Fail");
                    toolStripStatusLabel1.Text = "Text box is empty";
                    ccTextBox();
                    break;
            }

        }
        // CR: Linear Search for a specific rego plate
        // PR: Locate a particular registration plate using a linear search algorithm
        private void buttonLinSearch_Click(object sender, EventArgs e)
        {
            // Terinary Operator = Condition ? Statement : Statement;
            // Condition1: Check If the registration plate exists. If there is no registration plate, the textbox is empty.
            // Condition2: If the textbox is not empty, there is no registration plate.
            int condition = RegoPlate.Contains(textBoxInput.Text)? condition = 1 
                : !string.IsNullOrEmpty(textBoxInput.Text) ? condition = 2 : condition = 3;

            switch (condition)
            {
                case 1:
                    listDisplay.SelectedItem = textBoxInput.Text;
                    toolStripStatusLabel1.Text = "Search Success";
                    ccTextBox();
                    break;
                case 2:
                    MessageBox.Show("Search Fail");
                    toolStripStatusLabel1.Text = "Registration Plate does not exist";
                    ccTextBox();
                    break;
                case 3:
                    MessageBox.Show("Search Fail");
                    toolStripStatusLabel1.Text = "Text box is empty";
                    ccTextBox();
                    break;
            }

        }
        // CR: Save data to text file
        // Open saved text file
        #endregion Buttons_2

        #region BUTTONS_3
        private void openButton_Click(object sender, EventArgs e)
        {
            string fileName = "demo_nn.txt";
            OpenFileDialog OpenText = new OpenFileDialog();
            DialogResult sr = OpenText.ShowDialog();
            if (sr == DialogResult.OK)
            {
                fileName = OpenText.FileName;
                try
                {
                    RegoPlate.Clear();
                    using (Stream stream = File.Open(fileName, FileMode.Open))
                    {
                        BinaryFormatter binaryFormatter = new BinaryFormatter();
                        while (stream.Position < stream.Length)
                        {
                            RegoPlate.Add((string)binaryFormatter.Deserialize(stream));
                        }
                    }
                    DisplayList();
                }
                catch (IOException)
                {
                    MessageBox.Show("Cannot Open File");
                }
            }
            
        }
        // CR: Open Text File and Load data
        // PR: User can select different data from pre-saved files
        private void saveButton_Click(object sender, EventArgs e)
        {
            string fileName = "demo_##.txt";
            SaveFileDialog SaveText = new SaveFileDialog();
            DialogResult sr = SaveText.ShowDialog();
            if (sr == DialogResult.Cancel)
            {
                SaveText.FileName = fileName;
            }
            if (sr == DialogResult.OK)
            {
                fileName = SaveText.FileName;
            }
            try
            {
                using (Stream stream = File.Open(fileName, FileMode.Create))
                {
                    BinaryFormatter binaryFormatter = new BinaryFormatter();
                    foreach (var item in RegoPlate)
                    {
                        binaryFormatter.Serialize(stream, item);
                    }
                }
            }
            catch (IOException)
            {
                MessageBox.Show("Cannot Save File");
            }
        }
        // CR: Reset button to remove all rego plate data from the List<>
        // PR: RESET button to erase all items from the List<>
        // PR: Clear ListBox, Textbox and RegoPlate<> when button is pressed
        private void buttonReset_Click(object sender, EventArgs e)
        {
            RegoPlate.Clear();
            textBoxInput.Clear();
            singleDataTextBox.Clear();
            DisplayList();
        }
        #endregion BUTTONS_3

    }
}
