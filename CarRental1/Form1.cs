using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            try
            {
                string owner = txtOwner.Text;
                string customerName = txtCustomer.Text;
                double cost = Convert.ToDouble(txtCost.Text);
                //string dateRented = picker_Rent.Value.ToString();
                var dateRented = picker_Rent.Value;
                string idNumber = txtID.Text;

                // VAR DECKARATION, VARIABLE WILL ACCEPT AND BECOME DATA TYPE OF ASSIGNED VALUE
                var car = cboxCar.Text;
                var dateReturn = pickerReturn.Value;

                var isValid = true;
                //Adding validation to the form input

                //if (customerName == null || dateRented == null || car == null )
                if (String.IsNullOrEmpty(customerName) || (dateRented) == null || String.IsNullOrEmpty(car))
                {
                    isValid = false;
                    MessageBox.Show("Incomplete Entry");

                }
                if (dateReturn > dateRented)
                {
                    isValid = false;
                    MessageBox.Show("Incomplete Entry");
                }

                //if (isValid == true)
                if (isValid)
                {
                    MessageBox.Show($"Customer Name: {customerName}\n\r" +
                    $"Cost: ${cost}\n\r" +
                    $"Owner: {owner}\n\r" +
                    $"ID Number: {idNumber}\n\r" +
                    $"Type of Car: {car}\n\r" +
                    $"Rented Date: {dateRented}\n\r" +
                    $"Return Date: {dateReturn}\n\r");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
            

        }
    }
}
