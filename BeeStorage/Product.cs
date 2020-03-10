using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeStorage
{
    class Product 
    {
        private int product_id;
        private string name_of_product;
        private string company_name;
        
        public void fill_data(int id, string name, string name_c)
        {
            set_name(name);
            set_id(id);
            set_company_name(name_c);
        }
        ///Setter///
        private void set_name(string name)
        {
            this.name_of_product = name;
        }
        private void set_id(int id)
        {
            this.product_id = id;
        }
        private void set_company_name(string name_c)
        {
            this.company_name = name_c;
        }
        ///Getter///
        public int get_id()
        {
            return this.product_id;
        }
        public string get_product_name()
        {
            return name_of_product;
        }
        public string get_company_name()
        {
            return company_name;
        }
       
    }
}
