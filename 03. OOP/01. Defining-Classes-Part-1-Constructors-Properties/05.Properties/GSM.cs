
namespace Properties
{
    using System;
    using System.Text;
    public class GSM
    {
        //Instances
        public Battery Battery = new Battery();
        public Display Display = new Display();

        //Fields
        private string model;
        private string manufacturer;
        private decimal? price;
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

        public decimal? Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Price should be a positive number!");
                }
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

        public GSM(string model, string manufacturer, decimal? price = null, string owner = null)
        {
            //The constructor is calling the property (for Price), 
            //not the field, to perform a data validation through the property nand the field
            this.model = model;
            this.manufacturer = manufacturer;
            this.Price = price;
            this.owner = owner;
        }
        //Method
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(model);
            result.Append(manufacturer);
            result.Append(price);
            result.Append(owner);

            return result.ToString();
        }
    }
}
