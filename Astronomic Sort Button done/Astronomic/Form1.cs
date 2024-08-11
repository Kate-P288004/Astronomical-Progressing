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
        private int[] dataArray = new int[24];

        public Form1()
        {
            InitializeComponent();
            InitializeDataArray();
            DisplayDataArray();

        }
        private void InitializeDataArray()
        {
            Random rand = new Random();
            for (int i = 0; i < dataArray.Length; i++)
            {
                dataArray[i] = rand.Next(10, 91); // Random integers between 10 and 90
            }
        }
        private void UpdateListBox()

        {
          listBoxData.Items.Clear();

            foreach (var item in dataArray)

            {
                listBoxData.Items.Add(item);
            }

        }
        private void DisplayDataArray()

        {
            listBoxData.Items.Clear();
            for (int i = 0; i < dataArray.Length; i++)
            {
                listBoxData.Items.Add($"Hour {i + 1}: {dataArray[i]}");
            }

        }

        private void BubbleSort(int[] array)

        {

            int n = array.Length;

            for (int i = 0; i < n - 1; i++)

            {

                for (int j = 0; j < n - i - 1; j++)

                {

                    if (array[j] > array[j + 1])

                    {

                        int temp = array[j];

                        array[j] = array[j + 1];

                        array[j + 1] = temp;

                    }

                }

            }

        }

        private void buttonSort_Click(object sender, EventArgs e)
        {

            BubbleSort(dataArray);

            UpdateListBox();

            MessageBox.Show("Data sorted successfully.");

        }

        

            


        private void buttonSearch_Click(object sender, EventArgs e)
        {

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {

        }

        private void listBoxData_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEditIndex_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEditValue_TextChanged(object sender, EventArgs e)
        {

        }
    }
}




