
namespace CallPrice
{
    using System;
    using System.Collections.Generic;
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
        private List<Calls> callHistory = new List<Calls>();

        //Static fields

        private static GSM iPhone4S = new GSM ("Model: Iphone4S\n", "Manufacturer: Apple");

        //Static properties

        public static GSM IPhone4S
        {
            get
            {
                return GSM.iPhone4S;
            }
        }

        //Properties

        public List<Calls> CallHistory
        {
            get
            {
                return this.callHistory;
            }
        }
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
        //Methods
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(model);
            result.Append(manufacturer);
            result.Append(price);
            result.Append(owner);

            return result.ToString();
        }
        //Adding calls in the history (by making an instance of the class Calls)
        public void AddCalls(DateTime dateAndTime, string dialedPhoneNumber, double duration)
        {
            Calls call = new Calls(dateAndTime, dialedPhoneNumber, duration);
            callHistory.Add(call);
        }

        public void DeleteCalls(string dialedPhoneNumber)
        {
            for (int i = 0; i < callHistory.Count; i++)
            {
                if (callHistory[i].DialedPhoneNumber == dialedPhoneNumber)
                {
                    callHistory.RemoveAt(i);
                }
            }
        }

        public void ClearHistory()
        {
            callHistory.Clear();
        }

        public void TotalPrice(double pricePerMinute)
        {
            double wholeTime = 0;

            for (int i = 0; i < callHistory.Count; i++)
            {
                wholeTime += callHistory[i].Duration;
            }

            double result = wholeTime*pricePerMinute;
            Console.WriteLine("Total price of calls is: {0}", result);
        }
    }
}
