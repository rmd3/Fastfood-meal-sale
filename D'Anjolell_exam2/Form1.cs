using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D_Anjolell_exam2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Declare Variables
            string pizzaName = "";
            string pizzaDesc = "";
            double pizzaPrice = 0;
            int pizzaAmt = 0;
            string burgName = "";
            string burgDesc = "";
            double burgPrice = 0;
            string hotName = "";
            string hotDesc = "";
            string tacoName = "";
            string[] sandInfo = {"Sandwich", "Tomato, Cheese, Lettuce sandwich", "5.05", "10"};
            Product Pizza = new Product(pizzaName, pizzaDesc, pizzaPrice, pizzaAmt);
            Product Burger = new Product(burgName, burgDesc, burgPrice);
            Product Hotdog = new Product(hotName, hotDesc);
            Product Taco = new Product(tacoName);
            Product Sandwich = new Product();

            //Adding missing product info
            Burger.Quantity = 17;
            Hotdog.Price = 4.85;
            Hotdog.Quantity = 20;
            Taco.Description = "Taco with tomato and lettuce";
            Taco.Price = 4.35;
            Taco.Quantity = 23;
            Sandwich.Name = sandInfo[0];
            Sandwich.Description = sandInfo[1];
            Sandwich.Price = double.Parse(sandInfo[2]);
            Sandwich.Quantity = int.Parse(sandInfo[3]);

            //Displaying product info
            lblPizzaName.Text = Pizza.Name;
            lblPizzaDesc.Text = Pizza.Description;
            lblPizzaPrice.Text = Pizza.Price.ToString();
            txtPizzaAmt.Text = Pizza.Quantity.ToString();
            lblBurgName.Text = Burger.Name;
            lblBurgDesc.Text = Burger.Description;
            lblBurgPrice.Text = Burger.Price.ToString();
            txtBurgAmt.Text = Burger.Quantity.ToString();
            lblHotName.Text = Hotdog.Name;
            lblHotDesc.Text = Hotdog.Description;
            lblHotPrice.Text = Hotdog.Price.ToString();
            txtHotAmt.Text = Hotdog.Quantity.ToString();
            lblTacoName.Text = Taco.Name;
            lblTacoDesc.Text = Taco.Description;
            lblTacoPrice.Text = Taco.Price.ToString();
            txtTacoAmt.Text = Taco.Quantity.ToString();
            lblSandName.Text = Sandwich.Name;
            lblSandDesc.Text = Sandwich.Description;
            lblSandPrice.Text = Sandwich.Price.ToString();
            txtSandAmt.Text = Sandwich.Quantity.ToString();
        }

        //Declare Global Variables
        public double pizzaTotal = 0;
        public double tacoTotal = 0;
        public double hotTotal = 0;
        public double burgTotal = 0;
        public double sandTotal = 0;

        private void btnPizza_Click(object sender, EventArgs e)
        {
            //Declare Variable
            int pizzaAmt = int.Parse(txtPizzaAmt.Text);

            //If else statement in case there is no more pizza
            if (pizzaAmt > 0) 
            {
                //Acumulates and displays total
                pizzaTotal += double.Parse(lblPizzaPrice.Text);
                txtPizzaTotal.Text = pizzaTotal.ToString("0.00");
                
                //Decreases amount of pizzas
                pizzaAmt -= 1;
                txtPizzaAmt.Text = pizzaAmt.ToString();
            }
            else
            {
                //Disable button when there is no more
                btnPizza.Enabled = false;
            }
        }

        private void btnTaco_Click(object sender, EventArgs e)
        {
            //Declare Variable
            int tacoAmt = int.Parse(txtTacoAmt.Text);

            if (tacoAmt > 0)
            {
                //Acumulates and displays total
                tacoTotal += double.Parse(lblTacoPrice.Text);
                txtTacoTotal.Text = tacoTotal.ToString("0.00");

                //Decreases amount of tacos
                tacoAmt -= 1;
                txtTacoAmt.Text = tacoAmt.ToString();
            }
            else
            {
                //Disable button when there is no more
                btnTaco.Enabled = false;
            }
        }

        private void btnHot_Click(object sender, EventArgs e)
        {
            //Declare Variable
            int hotAmt = int.Parse(txtHotAmt.Text);

            if (hotAmt > 0)
            {
                //Acumulates and displays total
                hotTotal += double.Parse(lblHotPrice.Text);
                txtHotTotal.Text = hotTotal.ToString("0.00");

                //Decreases amount of hotdogs
                hotAmt -= 1;
                txtHotAmt.Text = hotAmt.ToString();
            }
            else
            {
                //Disable button when there is no more
                btnHot.Enabled = false;
            }
        }

        private void btnBurg_Click(object sender, EventArgs e)
        {
            //Declare Variable
            int burgAmt = int.Parse(txtBurgAmt.Text);

            if (burgAmt > 0)
            {
                //Acumulates and displays total
                burgTotal += double.Parse(lblBurgPrice.Text);
                txtBurgTotal.Text = burgTotal.ToString("0.00");

                //Decreases amount of burgers
                burgAmt -= 1;
                txtBurgAmt.Text = burgAmt.ToString();
            }
            else
            {
                //Disable button when there is no more
                btnBurg.Enabled = false;
            }
        }

        private void btnSand_Click(object sender, EventArgs e)
        {
            //Declare Variable
            int sandAmt = int.Parse(txtSandAmt.Text);

            if (sandAmt > 0)
            {
                //Acumulates and displays total
                sandTotal += double.Parse(lblSandPrice.Text);
                txtSandTotal.Text = sandTotal.ToString("0.00");

                //Decreases amount of sandwiches
                sandAmt -= 1;
                txtSandAmt.Text = sandAmt.ToString();
            }
            else
            {
                //Disable button when there is no more
                btnSand.Enabled = false;
            }
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            //Disables all "Add" buttons
            btnPizza.Enabled = false;
            btnTaco.Enabled = false;
            btnHot.Enabled = false;
            btnBurg.Enabled = false;
            btnSand.Enabled = false;

            //Accumulates and displays order total and tax
            double grandTotal = pizzaTotal + tacoTotal + hotTotal + burgTotal + sandTotal;
            double orderTax = grandTotal * .11;
            grandTotal += orderTax;
            txtTax.Text = orderTax.ToString("0.00");
            txtTotal.Text = grandTotal.ToString("0.00");
        }
    }
}
