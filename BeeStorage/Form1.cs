using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeeStorage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            fill_product_list();
            show_list();
            
        }
        public void fill_product_list()
        { 
            Program.fruits_vegetables_list.Add(new Fruits_Vegetables(10, "Apple"));
            Program.fruits_vegetables_list[Program.fruits_vegetables_list.Count - 1].fill_data(1,"Apple 1", "A");
            Program.water_list.Add(new Water(4, "Cola"));
            Program.water_list[Program.water_list.Count - 1].fill_data(2, "Coca-Cola", "C");
        }
        public void show_list()
        {
            
            foreach (Fruits_Vegetables i in Program.fruits_vegetables_list)
            {
                listBox1.Items.Add(i.get_amount() + " " + i.get_amount_type()  +" " + i.get_product_name());
            }
            foreach (Water i in Program.water_list)
            {
                listBox1.Items.Add(i.get_amount() + " " + i.get_amount_type() + " " + i.get_product_name());
            }
            
        }
    }
}
