using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
     public class Product
    {
        private double price;
        private string name;
        public static readonly Color BackColor;

        public string Name { get => name; set {
                if (char.IsUpper(value[0]))
                {
                    name = value;
                } else
                {
                    name = char.ToUpper(value[0]) + value.Substring(1);
                }
            } }
        public double Price { get => price; set => price = value * 92.42; }
         //public string Firm { get => firm; set => firm = value; }
        
        
        //public string Name => name;
        //public double Price => price;
        //public string Firm => firm;

        //public string Name { get; set; }
       // public double Price { get; set  }
        public string Firm { get; set; }
        public DateTime ExpirationDate { get; set; }


        static Product()
        {
            Product.BackColor = Color.Orange;
        }

        public Product(string name, double price, string firm, DateTime expirationDate)
        {
            this.Name = name;
            this.Price = price;
            this.Firm = firm;
            this.ExpirationDate = expirationDate;
            
        }

        public Product()
        {
            Name = "Название продукта";
            Price = 1;
            Firm = "Фирма продукта";
            ExpirationDate = DateTime.Now;
            
        }
    }
    //public class FoodProduct : Product
    //{
    //    public string NutritionInfo { get; set; }

    //    public FoodProduct(string name, double price, string firm, DateTime expirationDate, string nutritionInfo)
    //        : base(name, price, firm, expirationDate)
    //    {
    //        this.NutritionInfo = nutritionInfo;
    //    }
    //    public FoodProduct (int NutritionInfo) {
            
    //        NutritionInfo = 1;
    //}

    //    //public FoodProduct(string nutritionInfo)
    //    //{
    //    //    NutritionInfo = 123;
    //    //}
    //    // Дополнительные свойства или методы, если необходимо

    //    public override string ToString()
    //    {
    //        return $"FoodProduct: {Name}, Price: {Price:C}, Firm: {Firm}, Expiration Date: {ExpirationDate.ToShortDateString()}, Nutrition Information: {NutritionInfo}";
    //    }
    //}
}
