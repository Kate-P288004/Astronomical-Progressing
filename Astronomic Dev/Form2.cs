using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


// Miguel, Kate, Mitchell - Team Astronomical Progressing
// Date: 20/08/24
// Version: 1.0
// Astronomical Processing - Sprint One
// This Windows Prototype Application is designed to record and process hourly neutrino interactions for a local observatory. 
// It allows users to input, edit, sort, and search data within a 24-hour period. The application meets client requirements for functionality 
// and adheres to CITEMS coding standards. 
// Inputs: Hourly neutrino interaction data
// Processes: Data input, sorting (Bubble Sort), searching (Binary Search), editing, and validation
// Outputs: Display of processed data, error and success messages to the user




namespace Astronomic
{
    public partial class Form1 : Form
    {
        // The maximum number of elements (hours per day)
        private const int max = 24;

        // Struct to store hourly data and corresponding hour
        private struct HourlyData
        {
            public int Hour;
            public int Data;

            public HourlyData(int hour, int data)
            {
                Hour = hour;
                Data = data;
            }
        }

        // Array to store hourly data for neutrino interactions
        private HourlyData[] dataArray = new HourlyData[max];
        private int nextEmpty = 0; // Tracks the next empty index for adding data
        private Random rnd = new Random(); // Random number generator for filling data

        // Labels to display error and success messages
        private Label labelErrorMessage;
        private Label labelSuccessMessage;

        // Constructor for the form, initializes components and sets up the UI
        public Form1()
        {
            InitializeComponent();
            InitializeLabels(); // Initialize the error and success labels
            DisplayDataArray(); // Display the data array in the list box (initially empty)
        }

        // Method to initialize the data array with random values between 10 and 90
        private void InitializeDataArray()
        {
            for (int i = 0; i < max; i++)
            {
                dataArray[i] = new HourlyData(i + 1, rnd.Next(10, 91)); // Random integers between 10 and 90
            }
            nextEmpty = max; // After filling, nextEmpty is set to max
        }

        // Method to refresh the list box with the current contents of the data array
        private void UpdateListBox()
        {
            listBoxData.Items.Clear(); // Clear any existing items in the list box

            foreach (var item in dataArray)
            {
                listBoxData.Items.Add(item.Data); // Only display the Data values in the list box
            }
        }

        // Method to initialize the labels for error and success messages
        private void InitializeLabels()
        {
            // Initialize labelErrorMessage
            labelErrorMessage = new Label
            {
                AutoSize = true,
                Location = new System.Drawing.Point(40, 600), // Adjust location as needed
                Name = "labelErrorMessage",
                ForeColor = System.Drawing.Color.Red, // Set the text color to red
                Font = new Font("Arial", 12, FontStyle.Bold), // Set font to bold
            };
            this.Controls.Add(labelErrorMessage);

            // Initialize labelSuccessMessage
            labelSuccessMessage = new Label
            {
                AutoSize = true,
                Location = new System.Drawing.Point(40, 620), // Adjust location as needed
                Name = "labelSuccessMessage",
                ForeColor = System.Drawing.Color.Purple, // Set the text color to purple
                Font = new Font("Arial", 12, FontStyle.Bold), // Set font to bold
                Text = ""
            };
            this.Controls.Add(labelSuccessMessage);
        }
        // Method to display the current contents of the data array in the list box
        private void DisplayDataArray()
        {
            listBoxData.Items.Clear(); // Clear any existing items in the list box
            for (int i = 0; i < nextEmpty; i++)
            {
                listBoxData.Items.Add(dataArray[i].Data); // Display only the data values
            }
        }

        // Method to sort the data array using the Bubble Sort algorithm
        private void BubbleSort(HourlyData[] array)
        {
            int n = array.Length; // Get the length of the array

            // Outer loop: iterate over the array elements
            for (int i = 0; i < n - 1; i++)
            {
                // Inner loop: compare adjacent elements and swap if necessary
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array[j].Data > array[j + 1].Data)
                    {
                        // Swap the elements if they are out of order
                        HourlyData temp = array[j];
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

            // Update the success message label
            labelSuccessMessage.Text = "DATA SORTED SUCCESSFULLY."; // Set the success message text in uppercase and bold
        }


        // Event handler for the "Search" button click event
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            int searchValue;
            // Try to parse the search input as an integer
            if (int.TryParse(textBoxSearch.Text, out searchValue))
            {
                // Search for the value in the data array
                int index = Array.FindIndex(dataArray, d => d.Data == searchValue);

                if (index >= 0)
                {
                    labelSuccessMessage.Text = $"VALUE FOUND AT INDEX {index + 1}.";
                    labelSuccessMessage.ForeColor = Color.Green;
                    labelErrorMessage.Text = ""; // Clear any previous error message
                }
                else
                {
                    labelErrorMessage.Text = "VALUE NOT FOUND.";
                    labelErrorMessage.ForeColor = Color.Red;
                    labelSuccessMessage.Text = ""; // Clear any previous success message
                }
            }
            else
            {
                // Display an error message if the input is not a valid integer
                labelErrorMessage.Text = "PLEASE ENTER A VALID INTEGER.";
                labelErrorMessage.ForeColor = Color.Red;
                labelSuccessMessage.Text = ""; // Clear any previous success message
            }
        }

        // Event handler for the "Edit" button click event
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            int index, newValue;
            // Try to parse the index and new value from the input fields
            if (int.TryParse(textBoxEditIndex.Text, out index) && int.TryParse(textBoxEditValue.Text, out newValue))
            {
                if (index >= 1 && index <= max)
                {
                    dataArray[index - 1].Data = newValue; // Update the array at the specified index (0-based array)
                    UpdateListBox(); // Refresh the list box to show the updated value
                    labelErrorMessage.Text = ""; // Clear any previous error messages
                    labelSuccessMessage.Text = $"VALUE AT INDEX {index} UPDATED SUCCESSFULLY."; // Display success message
                }
                else
                {
                    // Display an error message if the index is out of range
                    labelErrorMessage.Text = $"INDEX MUST BE BETWEEN 1 AND {max}.";
                    labelSuccessMessage.Text = "";
                }
            }
            else
            {
                // Display an error message if the inputs are not valid integers
                labelErrorMessage.Text = "PlEASE ENTER VALID INTEGERS.";
                labelSuccessMessage.Text = "";
            }
        }

        // Event handler for the "Fill" button click event
        private void btnFill_Click(object sender, EventArgs e)
        {
            // Fill the array with random data
            InitializeDataArray();
            DisplayDataArray();
            labelSuccessMessage.Text = "ARRAY FILLED SUCCESSFULLY.";
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

        private void Form1_Load(object sender, EventArgs e)
        {
            //For handling form load event
        }

        private void lblEditIndex_Click(object sender, EventArgs e)
        {
            // For handling clicks on the edit index label
        }
    } // End of Form1 class
} // End of Astronomic namespace