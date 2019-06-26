﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Car
    {         
        private string model;
        private Engine engine;
        private Cargo cargo;
        private Tire[] tires;

        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }
        public Tire[] Tires { get; set; }

        public Car(string model, Engine engine,Cargo cargo, Tire[] tires)
        {
            this.Model = model;
            this.Engine = engine;
            this.Cargo = cargo;
            this.Tires = tires;
        }

        public override string ToString()
        {
            return $"{Model} {Engine} {Cargo} {Tires}";
        }
    }
}
