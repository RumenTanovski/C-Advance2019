using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    public class Car
    {
        private string make;
        private string model;
        private int year;
        private double fuelQuantity;
        private double fuelConsumption;

        public double FuelConsumption
        {
            get { return this.fuelConsumption; }
            set { this.fuelConsumption = value; }
        }
        
        public double FuelQuantity
        {
            get { return this.fuelQuantity; }
            set { this.fuelQuantity = value; }
        }

        public string Make
        {
            get
            {
                return this.make;
            }
            set
            {
                this.make = value;
            }
        }

        public string Model
        {
            get { return model; }
            set { this.model = value; }
        }

        public int Year
        {
            get { return year; }
            set { this.year = value; }
        }

        public void Drive(double distance)
        {
            bool canContinue = this.fuelQuantity - ((distance/100)
                * this.fuelConsumption) >= 0;
            if (canContinue)
            {
                this.fuelQuantity -= (distance/100) * this.fuelConsumption;
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }

        public string WhoAmI()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Make: {this.make}");
            sb.AppendLine($"Model: {this.model}");
            sb.AppendLine($"Year: {this.year}");
            sb.AppendLine($"Fuel: {this.fuelQuantity:F2}L");
            return sb.ToString();
        }
    }
}
