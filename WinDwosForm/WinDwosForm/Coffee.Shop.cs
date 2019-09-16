using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinDwosForm
{
    public partial class Coffee : Form
    {
        const int arraySize = 100;
        string[] CustomerName = new string[arraySize];
        string[] CustomerContact = new string[arraySize];
        string[] CustomerAddress = new string[arraySize];
        string[] Order = new string[arraySize];
        int[] Quantity = new int[arraySize];
        double[] Price = new double[arraySize];
        string Result;
        int Index = 0;
        public Coffee()
        {
            InitializeComponent();
          
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (Index < arraySize)
            {
                if (nameTextBox.Text != "" && contactTextBox.Text != "" && addressTextBox.Text != "" && comboBoxItem.Text != "")
                {
                    CustomerName[Index] = nameTextBox.Text;
                    CustomerContact[Index] = contactTextBox.Text;
                    CustomerAddress[Index] = addressTextBox.Text;
                    Order[Index] = comboBoxItem.Text;
                    Quantity[Index] = Convert.ToInt32(quantityTextBox.Text);
                    Price[Index] = Quantity[Index] * PiceCount(comboBoxItem.Text);
                    CustomerInformation(Index);
                    Index++;
                }
                else
                {
                    MessageBox.Show("Please input correct number");
                }
            }
            else
            {
                MessageBox.Show("Disk Full");
            }
        }

        private double PiceCount(string item)
        {
            if (item == "Black")
            {
                return 120;
            }
            else if (item == "Cold")
            {
                return 100;
            }
            else if (item == "Hot")
            {
                return 90;
            }
            else if (item == "Regular")
            {
                return 80;
            }
            else
            {
                return 0;
            }
        }

        private void CustomerInformation(int indexCount)
        {
            Result = "";
            for (int i = 0; i <= indexCount; i++)
            {
                Result += "\n\n Person Number: " + i + "\n Name: " + CustomerName[i] + "\n Contact No: " + CustomerContact[i] +
                    "\n Addesess: " + CustomerAddress[i] + "\n Item: " + Order[i] + "\n Quantity: " + Quantity[i] + "\n Total Price: " + Price[i] + "\n \n";
            }

            richTextBoxShow.Text = "Customer Information.. " + Result;
        }

     
    }
}