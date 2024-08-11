using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Astronomic
{
    public partial class Form1 : Form
    {
        // Array to store hourly data for neutrino interactions
        private int[] dataArray = new int[24];

        // Labels to display error and success messages
        private Label labelErrorMessage;
        private Label labelSuccessMessage;

        // Constructor for the form, initializes components and sets up the UI
        public Form1()
        {
            InitializeComponent();
            InitializeLabels(); // Initialize the error and success labels
            InitializeDataArray(); // Populate the data array with random values
            DisplayDataArray(); // Display the data array in the list box
        }

        // Method to initialize the data array with random values between 10 and 90
        private void InitializeDataArray()
        {
            Random rand = new Random();
            for (int i = 0; i < dataArray.Length; i++)
            {
                dataArray[i] = rand.Next(10, 91); // Random integers between 10 and 90
            }
        }

        // Method to refresh the list box with the current contents of the data array
        private void UpdateListBox()
        {
            listBoxData.Items.Clear(); // Clear any existing items in the list box

            foreach (var item in dataArray)
            {
                listBoxData.Items.Add(item);
            }
        }

        // Method to initialize the labels for error and success messages
        private void InitializeLabels()
        {
            // Initialize labelErrorMessage
            labelErrorMessage = new Label
            {
                AutoSize = true,
                Location = new System.Drawing.Point(40, 350), // Adjust location as needed
                Name = "labelErrorMessage",
                ForeColor = System.Drawing.Color.Red // Set the text color to red
            };
            this.Controls.Add(labelErrorMessage);

            // Initialize labelSuccessMessage
            labelSuccessMessage = new Label
            {
                AutoSize = true,
                Location = new System.Drawing.Point(40, 370), // Adjust location as needed
                Name = "labelSuccessMessage",
                ForeColor = System.Drawing.Color.Blue // Set the text color to blue
            };
            this.Controls.Add(labelSuccessMessage);
        }

        // Method to display the current contents of the data array in the list box with labels for each hour
        private void DisplayDataArray()
        {
            listBoxData.Items.Clear(); // Clear any existing items in the list box
            for (int i = 0; i < dataArray.Length; i++)
            {
                // Add each hour's data to the list box, formatting it with the hour number
                listBoxData.Items.Add($"Hour {i + 1}: {dataArray[i]}");
            }
        }

        // Method to sort the data array using the Bubble Sort algorithm
        private void BubbleSort(int[] array)
        {
            int n = array.Length; // Get the length of the array

            // Outer loop: iterate over the array elements
            for (int i = 0; i < n - 1; i++)
            {
                // Inner loop: compare adjacent elements and swap if necessary
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        // Swap the elements if they are out of order
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }

        // Event handler for the "Sort" button click event
        private void buttonSort_Click(object sender, EventArgs e)
        {
            BubbleSort(dataArray); // Sort the data array using the Bubble Sort algorithm
            UpdateListBox(); // Update the list box to reflect the sorted data
            MessageBox.Show("Data sorted successfully."); // Display a message to the user indicating successful sorting
        }

        // Event handler for the "Search" button click event
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            int searchValue;
            // Try to parse the search input as an integer
            if (int.TryParse(textBoxSearch.Text, out searchValue))
            {
                // Search for the value in the data array
                int index = Array.IndexOf(dataArray, searchValue);
                MessageBox.Show(index >= 0 ? $"Value found at hour {index + 1}." : "Value not found.");
            }
            else
            {
                // Display an error message if the input is not a valid integer
                MessageBox.Show("Please enter a valid integer.");
            }
        }

        // Event handler for the "Edit" button click event
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            int index, newValue;
            // Try to parse the index and new value from the input fields
            if (int.TryParse(textBoxEditIndex.Text, out index) && int.TryParse(textBoxEditValue.Text, out newValue))
            {
                if (index >= 1 && index <= 24)
                {
                    dataArray[index - 1] = newValue; // Update the array at the specified index (0-based array)
                    UpdateListBox(); // Refresh the list box to show the updated value
                    labelErrorMessage.Text = ""; // Clear any previous error messages
                    labelSuccessMessage.Text = $"Value at hour {index} updated successfully."; // Display success message
                }
                else
                {
                    // Display an error message if the index is out of range
                    labelErrorMessage.Text = "Index must be between 1 and 24.";
                    labelSuccessMessage.Text = "";
                }
            }
            else
            {
                // Display an error message if the inputs are not valid integers
                labelErrorMessage.Text = "Please enter valid integers.";
                labelSuccessMessage.Text = "";
            }
        }

        private void listBoxData_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Placeholder for handling selection changes in the list box
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            // Placeholder for handling text changes in the search box
        }

        private void textBoxEditIndex_TextChanged(object sender, EventArgs e)
        {
            // Placeholder for handling text changes in the edit index box
        }

        private void textBoxEditValue_TextChanged(object sender, EventArgs e)
        {
            // Placeholder for handling text changes in the edit value box
        }
    } // End of Form1 class
} // End of Astronomic namespace
