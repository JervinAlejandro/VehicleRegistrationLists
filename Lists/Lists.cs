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


namespace Lists
{
    public partial class Lists : Form
    {
        public Lists()
        {
            InitializeComponent();
        }
        List<string> RegoPlate = new List<string>();

        #region FUNCTIONS
        private void DisplayList()
        {
            listDisplay.Items.Clear();
            RegoPlate.Sort();
            foreach (var rego in RegoPlate)
            {
                listDisplay.Items.Add(rego);
            }
        }
        private void Lists_Load(object sender, EventArgs e)
        {
            string fileName = "demo_01.txt";

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
        private void listDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listDisplay.SelectedIndex > -1 )
            {
                singleDataTextBox.Text = listDisplay.SelectedItem.ToString();
            }  
        }

        // Prevent user from pressing ENTER key
        private void textBoxInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
            }
        }

        // Prevent user from entering any text or numbers
        private void singleDataTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Enter) || (char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        #endregion FUNCTIONS

        #region BUTTONS
        private void addButton_Click(object sender, EventArgs e)
        {      
            if (!String.IsNullOrEmpty(textBoxInput.Text) && !RegoPlate.Contains(textBoxInput.Text))
            {
                RegoPlate.Add(textBoxInput.Text);
                textBoxInput.Clear();
                textBoxInput.Select();
                DisplayList();
            }
            else
            {
                MessageBox.Show("ADD Fail");
            }
           
        }

        // Delete Method 1
        private void listDisplay_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Delete Success");
            RegoPlate.Remove(singleDataTextBox.Text);
            singleDataTextBox.Clear();
            DisplayList();
        }

        // Delete Method 2
        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxInput.Text) && RegoPlate.Contains(textBoxInput.Text) )
            {
                RegoPlate.Remove(textBoxInput.Text);
                textBoxInput.Clear();
                textBoxInput.Select();
                DisplayList();

            }
            else
            {
                MessageBox.Show("DELETE Fail");
            }
            
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listDisplay.SelectedIndex > -1 && !String.IsNullOrEmpty(textBoxInput.Text))
            {
                RegoPlate[listDisplay.SelectedIndex] = textBoxInput.Text;
                textBoxInput.Clear();
                textBoxInput.Select();
                DisplayList();
            }
            else
            {
                MessageBox.Show("EDIT Fail");
            }

        }

        // Binary Search
        private void searchButton_Click(object sender, EventArgs e)
        {
            DisplayList();
            if (RegoPlate.BinarySearch(textBoxInput.Text) >= 0) // >= 0 is a comparator
            {
                listDisplay.SelectedItem = textBoxInput.Text;
                MessageBox.Show("Found");
                textBoxInput.Clear();
            }
            else
            {
                MessageBox.Show("Not Found");
                textBoxInput.Clear();
                textBoxInput.Select();
            }
            
        }

        // Linear Search
        private void buttonLinSearch_Click(object sender, EventArgs e)
        {

        }

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

        private void saveButton_Click(object sender, EventArgs e)
        {
            string fileName = "demo_nn.txt";
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

        private void buttonReset_Click(object sender, EventArgs e)
        {
            RegoPlate.Clear();
            textBoxInput.Clear();
            DisplayList();
        }


        #endregion BUTTONS


    }
}
