using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaShop
{
    public partial class Form1 : Form
    {
        private double price;
        private Boolean makeYourOwn;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pizzaShopDBDataSet);

        }

        private void pizzaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pizzaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pizzaShopDBDataSet);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pizzaShopDBDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.pizzaShopDBDataSet.Customers);
            // TODO: This line of code loads data into the 'pizzaShopDBDataSet.Pizza' table. You can move, or remove it, as needed.
            this.pizzaTableAdapter.Fill(this.pizzaShopDBDataSet.Pizza);
            lsbxPSize.SelectedIndex = 0;
            lsbxPSauce.SelectedIndex = 0;
            lsbxPBase.SelectedIndex = 0;

        }

        private void btnPNSrch_Click(object sender, EventArgs e)
        {
            this.customersTableAdapter.NumSearch(this.pizzaShopDBDataSet.Customers, phoneNumberTextBox.Text);
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            this.customersTableAdapter.Fill(this.pizzaShopDBDataSet.Customers);
        }

        private void lsbxPName_SelectedIndexChanged(object sender, EventArgs e)
        {
            makeYourOwn = false;
            string newline = Environment.NewLine;

            switch (lsbxPName.SelectedItem.ToString()) { 
                case "Indian Apache":
                    txbxPDetails.Text = "Toppings: Tandoori Chicken, Green peppers, Onion" + newline + "Cheese: Mozzarella" + newline + "Sauce: Curry Sauce";
                    lsbxPSauce.SelectedItem = "Curry sauce";
                    break;
                case "Mexican Pepper Volcano":
                    txbxPDetails.Text = "Toppings: Chilli Shake, Beef Balls, Cajun Chicken, Grenn peppers, Jalapenos" + newline + "Cheese: Mozzarella" + newline + "Sauce: BBQ Sauce";
                    lsbxPSauce.SelectedItem = "BBQ sauce";
                    break;
                case "All Day Breakfast":
                    txbxPDetails.Text = "Toppings: Mushrooms, Bacon, Sausage, Onion, Tomatoes" + newline + "Cheese: Mozzarella" + newline + "Sauce: Original";
                    lsbxPSauce.SelectedItem = "Original";
                    break;
                case "MAKE YOUR OWN":
                    txbxPDetails.Text = "Please choose from the options below and the check boxes on the right.";
                    lsbxPSauce.SelectedItem = "Original";
                    makeYourOwn = true;
                    break;
            }
            calculatePrice();
        }

        private void calculatePrice() {
            price = 0;
            double psnPrice = 8;
            double smlPrice = 12;
            double medPrice = 16;
            double lrgPrice = 21.5;

            double psnTop = 1;
            double smlTop = 1.25;
            double medTop = 1.5;
            double lrgTop = 1.75;

            if (makeYourOwn) {
                psnPrice = 5;
                smlPrice = 8;
                medPrice = 12;
                lrgPrice = 16;
            }

            int topCount = 0;

            foreach (CheckBox item in gpbxPExTop.Controls) {
                if (item.Checked) {
                    topCount++;
                }
            }

            switch (lsbxPSize.SelectedItem.ToString()){
                case "Personal":
                    price = psnPrice + (psnTop * topCount);
                    break;
                case "Small":
                    price = smlPrice + (smlTop * topCount);
                    break;
                case "Medium":
                    price = medPrice + (medTop * topCount);
                    break;
                case "Large":
                    price = lrgPrice + (lrgTop * topCount);
                    break;
                //default:
                    //MessageBox.Show("Please select a size");
                   // break;
            }
            lblPPriceAmount.Text = string.Format("{0:C}", price * (int)(numericUpDownPQuan.Value));
        }

        private void lsbxPSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            calculatePrice();
        }

        private void btnPReset_Click(object sender, EventArgs e)
        {
            resetAll();
        }

        private void numericUpDownPQuan_ValueChanged(object sender, EventArgs e)
        {
            calculatePrice();
        }

        private void aCheckboxHasChanged(object sender, EventArgs e)
        {
            calculatePrice();
        }

        private void btnPPlaceOrder_Click(object sender, EventArgs e)
        {
            string allToppings = string.Empty;

            foreach (CheckBox item in gpbxPExTop.Controls) 
            {
                if (item.Checked)
                {
                    allToppings += item.Text + ",";
                }
            }

            //MessageBox.Show(idTextBox1.Text + "\n" + lsbxPName.Text + "\n" + lsbxPSize.Text + "\n" + lsbxPBase.Text + "\n" + allToppings + "\n" + txbxPSpecial.Text + "\n" + (int)numericUpDownPQuan.Value + "\n" + (decimal)(price*((int)numericUpDownPQuan.Value)));

            pizzaTableAdapter.Insert(
                int.Parse(idTextBox1.Text),
                lsbxPName.Text,
                lsbxPSize.Text,
                lsbxPBase.Text,
                lsbxPSauce.Text,
                allToppings,
                txbxPSpecial.Text,
                (int)numericUpDownPQuan.Value,
                (decimal)(price*((int)numericUpDownPQuan.Value)));

            pizzaTableAdapter.Fill(pizzaShopDBDataSet.Pizza);
            resetAll();
        }

        private void resetAll() {
            lsbxPName.SelectedIndex = 0;
            lsbxPSize.SelectedIndex = 0;
            lsbxPBase.SelectedIndex = 0;
            lsbxPSauce.SelectedIndex = 0;
            numericUpDownPQuan.Value = 1;

            foreach (CheckBox item in gpbxPExTop.Controls)
            {
                item.Checked = false;
            }        
        }
    }
}