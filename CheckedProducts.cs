using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class CheckedProducts
    {
        public List<FoodProduct> SpoiledPr { get; set; }
        public List<FoodProduct> FreshPr { get; set; }

        public CheckedProducts()
        {
            this.SpoiledPr = new List<FoodProduct>();
            this.FreshPr = new List<FoodProduct>();
        }

        
        public void check_products(Storage storage)
        {
            foreach (FoodProduct foodProduct in storage.Products)
            {
                if (foodProduct.ExpirationDate <= DateTime.Now)
                {
                    this.SpoiledPr.Add(foodProduct);
                }
                else
                {
                    this.FreshPr.Add(foodProduct);
                }
            }
           
        }

       
    }
}
