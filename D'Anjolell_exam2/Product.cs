using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_Anjolell_exam2
{
    class Product
    {
        //Declare Variables
        private string _name, _description;
        private int _quantity;
        private double _price;

        public Product(string pizzaName, string pizzaDesc, double pizzaPrice, int pizzaAmt)
        {
            //Constructor that sets variables to values of the product Pizza
            _name = "Pizza";
            _description = "18-inch Veggie Pizza";
            _price = 8.55;
            _quantity = 15;
            return;
        }

        public Product(string burgName, string burgDesc, double burgPrice)
        {
            //Constructor that sets variables to values of the product Cheeseburger
            _name = "Cheeseburger";
            _description = "Double cheesburger with toppings";
            _price = 6.25;
            return;
        }

        public Product(string hotName, string hotDesc)
        {
            //Constructor that sets variables to values of the product Hotdog
            _name = "Hotdog";
            _description = "Hotdog with mustard";
            return;
        }

        public Product(string tacoName)
        {
            //Constructor that sets variables to values of the product Taco
            _name = "Taco";
            return;
        }

        public Product()
        {
            //Constructor that sets all variables to default values
            _name = "";
            _description = "";
            _price = 0;
            _quantity = 0;
            return;
        }

        public string Name
        {
            //Getter and setter for name variable
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public string Description
        {
            //Getter and setter for description variable
            get
            {
                return _description;
            }
            set
            {
                _description = value;
            }
        }

        public double Price
        {
            //Getter and setter for price variable
            get
            {
                return _price;
            }
            set
            {
                _price = value;
            }
        }

        public int Quantity
        {
            //Getter and setter for quantity variable
            get
            {
                return _quantity;
            }
            set
            {
                _quantity = value;
            }
        }
    }
}
