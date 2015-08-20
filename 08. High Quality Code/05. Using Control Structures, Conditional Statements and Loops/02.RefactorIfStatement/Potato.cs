namespace RefactorIfStatement
{
    using System;

    public class Potato
    {
        private bool isRotten;
        private bool isPeeled;

        public Potato()
        {
        }

        public bool IsRotten
        {
            get 
            {
                return this.isRotten;
            }

            set
            {
                this.isRotten = value;
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

        public void Cook()
        {
            Console.WriteLine("The Potato is cooked!");
        }
    }
}
