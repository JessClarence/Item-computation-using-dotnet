using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/* Quiz1
 * Name: Jess Clarence I. Arreza 
   Teacher: Jay Al Gallenero */

namespace Quiz2

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void priceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void item1_Click(object sender, EventArgs e)
        {
            priceTextBox.Text = "12.00";
            dcTextBox.Text = "0.00";
        }

        private void item2_Click(object sender, EventArgs e)
        {
            priceTextBox.Text = "20.25";
            dcTextBox.Text = "5.00";
        }

        private void item3_Click(object sender, EventArgs e)
        {
            priceTextBox.Text = "100.00";
            dcTextBox.Text = "7.00";
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            priceTextBox.Clear();
            dcTextBox.Clear();
            qtyTextBox.Clear();
            vatAmTextBox.Clear();
            vat12TextBox.Clear();
            totalAmountTextBox.Clear();
        }

        private void computeBtn_Click(object sender, EventArgs e)
        {
           
            if(priceTextBox.Text == "" || dcTextBox.Text == "")
            {
                MessageBox.Show("Please Store Items");
            }
            else if (qtyTextBox.Text == "")
            {
                MessageBox.Show("Put quantity");
            }
            else
            {
                float price = float.Parse(priceTextBox.Text),
                      discount = (float.Parse(dcTextBox.Text) / 100),
                      quantity = float.Parse(qtyTextBox.Text);



                float vat_amount_12 = (price + (price * discount) * quantity) * (float)0.05;
                float vat_amount = (quantity * (price * discount)) - vat_amount_12;
                float total_amount = (price + (price * discount) * quantity);

                vatAmTextBox.Text = vat_amount.ToString();
                vat12TextBox.Text = vat_amount_12.ToString();
                totalAmountTextBox.Text = total_amount.ToString(); ;

            }
           
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}



