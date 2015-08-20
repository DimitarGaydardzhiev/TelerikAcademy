﻿
namespace _01.DefineClass
{
    using System;
    public class GSM
    {
        //Instances
        public Battery Battery = new Battery();
        public Display Display = new Display();

        //Fields
        private string model;
        private string manufacturer;
        private decimal price;
        private string owner;

        //Properties
        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                this.model = value;
            }
        }

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                this.manufacturer = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                this.price = value;
            }
        }

        public string Owner
        {
            get
            {
                return this.owner;
            }
            set
            {
                this.owner = value;
            }
        }
    }
}
