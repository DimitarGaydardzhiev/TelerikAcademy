namespace CookingTools
{
    public abstract class Vegetable
    {
        private bool isCut;
        private bool isPeeled;

        public Vegetable()
        {
            this.IsCut = false;
            this.IsPeeled = false;
        }

        public bool IsCut 
        {
            get
            {
                return this.isCut;
            }

            set
            {
                this.isCut = value;
            }
        }

        public bool IsPeeled
        {
            get
            {
                return this.isPeeled;
            }

            set
            {
                this.isPeeled = value;
            }
        }

        public void Cut()
        {
            this.IsCut = true;
        }

        public void Peel()
        {
            this.IsPeeled = true;
        }
    }
}
