// Mahay Thi Win, Sprint One
// Date: 30/04/2025
// Version: 1
// Astronomical Processing – Neutrino Data Handler
// This Windows Forms application processes 24 hourly neutrino readings. 
// Users can view, sort, search, and edit these values.
// 
// Inputs: Randomly generated neutrino readings (10–90), user inputs for search and edit
// Processes: Populate array, display values in ListBox, sort values using Bubble Sort,
//            search using Binary Search, allow selection and editing of individual values
// Outputs: Updated data displayed in ListBox and status messages shown to the user

using System;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Astronomical_Processing
{
    public partial class Form1 : Form
    {
        // Declare array to hold 24 hourly neutrino readings
        int[] neutrinoData = new int[24];

        // Random number generator to simulate data stream
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();// Standard WinForms setup
            InitializeData();// Fill the array with random values
        }

        // Method to fill the array with random integers between 10 and 90
        void InitializeData()
        {
            for (int i = 0; i < 24; i++)
            {
                neutrinoData[i] = rnd.Next(10, 91); // 10 to 90
            }
            DisplayData(); // Show the data in the ListBox
        }

        // Method to display all values from the array into the ListBox
        void DisplayData()
        {
            lstNeutrinoData.Items.Clear();


            foreach (int value in neutrinoData)
            {
                lstNeutrinoData.Items.Add(value);
            }
        }

        // Event triggered when the "Sort" button is clicked
        private void btnSort_Click_1(object sender, EventArgs e)
        {
            // Bubble Sort algorithm to sort the array in ascending order
            for (int i = 0; i < neutrinoData.Length - 1; i++)
            {
                for (int j = 0; j < neutrinoData.Length - i - 1; j++)
                {
                    if (neutrinoData[j] > neutrinoData[j + 1])
                    {
                        // Swap the values
                        int temp = neutrinoData[j];
                        neutrinoData[j] = neutrinoData[j + 1];
                        neutrinoData[j + 1] = temp;
                    }
                }
            }

            lblStatusMessage.Text = "Data sorted."; // Show message
            DisplayData(); // Refresh the ListBox

        }

        // Event triggered when the "Search" button is clicked
        private void btnSearch_Click_1(object sender, EventArgs e)
        {

            // Validate input
            if (txtSearch.Text == "")
            {
                lblStatusMessage.Text = "Search box is empty!";
                return;
            }

            int searchValue;

            // Try converting the input to an integer
            if (!int.TryParse(txtSearch.Text, out searchValue))
            {
                lblStatusMessage.Text = "Invalid input!";
                return;
            }

            // Perform binary search
            bool result = BinarySearch(neutrinoData, searchValue);
            if (!result)
            {
                lblStatusMessage.Text = "Value not found.";
                lstNeutrinoData.ClearSelected();
            }
            else
            {
                lblStatusMessage.Text = $"Value found using binary search.";
                lstNeutrinoData.SelectedIndex = Array.IndexOf(neutrinoData, searchValue);
            }
        }

        // Binary Search method - works only on sorted arrays
        bool BinarySearch(int[] data, int target)
        {
            var sortedData = data.OrderBy(x => x).ToList();
            int low = 0;
            int high = sortedData.Count - 1;

            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (sortedData[mid] == target)
                    return true; // Found it
                else if (sortedData[mid] < target)
                    low = mid + 1; // Search right half
                else
                    high = mid - 1;// Search left half
            }

            return false; // Not found

        }

        // Event triggered when the "Sequential Search " button is clicked


        // Event triggered when the "Apply Edit" button is clicked
        private void btnApplyEdit_Click_1(object sender, EventArgs e)
        {
            // Check if user selected an item from the ListBox
            if (lstNeutrinoData.SelectedIndex == -1)
            {
                lblStatusMessage.Text = "Please select a value to edit.";
                return;
            }

            int newValue;
            // Validate new value input
            if (!int.TryParse(txtEdit.Text, out newValue))
            {
                lblStatusMessage.Text = "Invalid input!";
                return;
            }

            // Update the selected index in the array

            neutrinoData[lstNeutrinoData.SelectedIndex] = newValue;
            DisplayData(); // Refresh the ListBox
            lstNeutrinoData.SelectedIndex = Array.IndexOf(neutrinoData, newValue);
            lblStatusMessage.Text = "Value updated."; // Show success message
        }

        private void lstNeutrinoData_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstNeutrinoData.SelectedIndex == -1)
            {
                txtEdit.Text = "";
            }
            else
            {
                txtEdit.Text = neutrinoData.GetValue(lstNeutrinoData.SelectedIndex)?.ToString();
            }
        }

        // Event triggered when the "Sequential Search " button is clicked

        private void btnSequentialSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSequentialSearch.Text))
            {
                lblStatusMessage.Text = "Search box is empty!";
                return;
            }

            int searchValue;
            if (!int.TryParse(txtSequentialSearch.Text, out searchValue))
            {
                lblStatusMessage.Text = "Invalid input!";
                return;
            }

            bool found = SequentialSearch(neutrinoData, searchValue);
            if (found)
            {
                lblStatusMessage.Text = " Value found using sequential search.";

            }

            else
            {
                lblStatusMessage.Text = " Value not found using sequential search.";
                lstNeutrinoData.ClearSelected();
            }
        }

        // Sequential Search method

        bool SequentialSearch(int[] data, int target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == target)
                {
                    lstNeutrinoData.SelectedIndex = i; // Highlight found item
                    return true;
                }
            }
            return false; // value not found
        }

        //Mid-Extreme Method

        double CalculateMidExtreme(int[] data)
        {
            int min = data[0];
            int max = data[0];

            for (int i = 1; i < data.Length; i++)
            {
                if (data[i] < min)
                    min = data[i];
                if (data[i] > max)
                    max = data[i];

            }

            double midExtreme = (min + max) / 2.0;
            return Math.Round(midExtreme, 2); // Round to 2 decimal places

        }

        // Event trigerred when MidExtreme button is clicked
        private void btnMidExtreme_Click(object sender, EventArgs e)
        {
            double result = CalculateMidExtreme(neutrinoData);
            txtMidExtreme.Text = result.ToString("F2"); // Display in text box with 2 decimal places
            lblStatusMessage.Text = "Mid-Extreme Calculated.";
        }

        // Mode method

        int CalculateMode(int[] data)
        {
            int mode = data[0];
            int maxCount = 0;
            for (int i = 0; i < data.Length; i++)
            {
                int count = 0;

                for (int j = 0; j < data.Length; j++)
                {
                    if (data[j] == data[i])
                        count++;
                }

                if (count > maxCount)
                {
                    maxCount = count;
                    mode = data[i];
                }
            }

            return mode;
        }

        //Event triggered when btnMode is clicked
        private void btnMode_Click(object sender, EventArgs e)
        {
            int result = CalculateMode(neutrinoData);
            txtMode.Text = result.ToString(); // show result
            lblStatusMessage.Text = " Mode calculated.";
        }

        //Calculate Average Method

        double CalculateAverage(int[] data)
        {
            int sum = 0;

            for (int i = 0; i < data.Length; i++)
            {
                sum += data[i];
            }
            double average = (double)sum / data.Length;
            return Math.Round(average, 2); // Round to 2 decimal places
        }

        //Event trigerred when btnAverage is clicked
        private void btnAverage_Click(object sender, EventArgs e)
        {
            double result = CalculateAverage(neutrinoData);
            txtAverage.Text = result.ToString("F2"); // Display with 2 decimal places
            lblStatusMessage.Text = "Average calculated";
        }

        //Calculate Range method

        int CalculateRange(int[] data)
        {
            int min = data[0];
            int max = data[0];

            for (int i = 1; i < data.Length; i++)
            {
                if (data[i] < min)
                    min = data[i];
                if (data[i] > max)
                    max = data[i];
            }

            return max - min;

        }

        //Event triggered when btnRange is clicked
        private void btnRange_Click(object sender, EventArgs e)
        {
            int result= CalculateRange(neutrinoData);
            txtRange.Text = result.ToString();
            lblStatusMessage.Text = " Range calculated";
        }
    }
}