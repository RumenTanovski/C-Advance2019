using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HealthyHeaven
{
    public class Salad
    {
    //• int GetTotalCalories() – returns the sum of all vegetable calories in the salad
    //• int GetProductCount() - returns the number of products
    //• void Add(Vegetable product) – adds an entity to the products
    //• Override ToString() – by the format bellow:

        private List<Vegetable> products;

        public List<Vegetable> Products { get; set; }
        public string Name { get; set; }

        public Salad(string name)
        {
            this.Name = name;
            products = new List<Vegetable>();
        }

        public int GetTotalCalories()
        {                    
            return this.products.Sum(p => p.Calories);
        }

        public int GetProductCount()
        {
            return this.products.Count();
        }

        public void Add(Vegetable product)
        {
            this.products.Add(product);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            int totalCalories = this.GetTotalCalories();
            int productCount = this.GetProductCount();
            sb.AppendLine($"* Salad {this.Name} is {totalCalories} calories and have {productCount} products:");

            sb.Append(string.Join(Environment.NewLine, this.products));
            return sb.ToString();
        }

    }
}
