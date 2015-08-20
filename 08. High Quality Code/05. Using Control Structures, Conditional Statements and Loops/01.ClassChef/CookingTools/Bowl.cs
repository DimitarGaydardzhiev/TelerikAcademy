namespace CookingTools
{
    using System.Collections.Generic;

    public class Bowl
    {
        private List<Vegetable> items;

        public Bowl()
        {
            this.Items = new List<Vegetable>();
        }

        public List<Vegetable> Items
        {
            get
            {
                return this.items;
            }

            set
            {
                this.items = value;
            }
        }

        public void Add(Vegetable vegetable)
        {
            this.Items.Add(vegetable);
        }

        public override string ToString()
        {
            return string.Join(", ", this.Items);
        }
    }
}
