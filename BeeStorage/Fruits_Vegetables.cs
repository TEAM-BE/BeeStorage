using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeStorage
{
    class Fruits_Vegetables : Product
    {
        private const string amount_type = "KG";
        private double amount;
        private string type_of_products;
        public Fruits_Vegetables(double amount, string type_of_product)
        {
            this.amount = amount;
            this.type_of_products = type_of_product;
        }
        /*public void fill_data(double amount, string type_of_product)
        {
            this.amount = amount;
            this.type_of_products = type_of_product;
        }*/
        ///Getter///
        public double get_amount()
        {
            return amount;
        }
        public string get_type_of_pr()
        {
            return type_of_products;
        }
        public string get_amount_type()
        {
            return amount_type;
        }
    }
}
