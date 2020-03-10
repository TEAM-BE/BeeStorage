using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeeStorage
{
    
    static class Program
    {
        public static List<Product> product_list = new List<Product>();
        public static List<Fruits_Vegetables> fruits_vegetables_list = new List<Fruits_Vegetables>();
        public static List<Water> water_list = new List<Water>();

        [STAThread]
        
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
