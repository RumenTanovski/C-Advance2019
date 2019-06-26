using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HealthyHeaven
{
    public class Restaurant
    {
        private List<Salad> data;
        public string Name { get; set; }

        public Restaurant(string name)
        {
            this.Name = name;
            data = new List<Salad>();
        }

    //• Method Add(Salad salad) – adds an entity to the data
    //• Method Buy(string name) – removes a salad by given name, if such exists, and returns boolean
    //• Mehod GetHealthiestSalad() – returns the healthiest salad
    //• Method GenerateMenu() - returns a string in the following format:

        public void Add(Salad salad)
        {
            this.data.Add(salad);
        }

        public bool Buy(string name)
        {
            var currentSalad = data.FirstOrDefault(x => x.Name == name);
            if (currentSalad == null)
            {
                return false;
            }
            else
            {
                data.Remove(currentSalad);
                return true;
            }
        }

        public Salad GetHealthiestSalad()
        {
            return this.data.OrderBy(x => x.GetTotalCalories()).FirstOrDefault();
        }

        public string GenerateMenu()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.Name} have {this.data.Count} salads:");
            sb.Append(string.Join(Environment.NewLine, this.data));
            return sb.ToString();
        }

    }
}
