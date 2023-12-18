using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{

    public struct Storage
    {
        public List<FoodProduct> Products { get; set; }

        public Storage(List<FoodProduct> products) {
           
            Products = products;
            
        }

        public void AddProduct(FoodProduct product)
        {
            Products.Add(product);
        }
    }
}
