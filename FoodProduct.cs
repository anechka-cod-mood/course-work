using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class FoodProduct : Product
    {
        public string NutritionInfo { get; set; }

        public FoodProduct(string name, double price, string firm, DateTime expirationDate, string nutritionInfo)
            : base(name, price, firm, expirationDate)
        {
            this.NutritionInfo = nutritionInfo;
        }

        public FoodProduct()
        {

        }
        public FoodProduct(int NutritionInfo)
        {

            NutritionInfo = 1;
        }

        //public FoodProduct(string nutritionInfo)
        //{
        //    NutritionInfo = 123;
        //}
        // Дополнительные свойства или методы, если необходимо

        public override string ToString()
        {
            return $"FoodProduct: {Name}, Price: {Price:C}, Firm: {Firm}, Expiration Date: {ExpirationDate.ToShortDateString()}, Nutrition Information: {NutritionInfo}";
        }
    }
}
