using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkGUI1.Model
{
    internal class productModel
    {

        static List<productModel> products = new List<productModel>();
        public int invNumber { get; set; }
        public String date { get; set; }
        public int unknown { get; set; }
        public String itemName { get; set; }
        public int count { get; set; }
        public double price { get; set; }


        public void Save()
        {
            // System.Windows.Forms.MessageBox.Show("db connected
            products.Add(this);
            
           
        }

        public List<productModel> GetProducts()
        {
            return products;
        }
    }
}
