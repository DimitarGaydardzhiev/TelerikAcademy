namespace Cook
{
    using System;
    using CookingTools;

    public class Chef
    {
        public Bowl Cook()
        {
            Potato potato = this.GetPotato();
            this.Peel(potato);
            this.Cut(potato);

            Carrot carrot = this.GetCarrot();
            this.Peel(carrot);
            this.Cut(carrot);
            
            Bowl bowl = this.GetBowl();
            bowl.Add(carrot);
            bowl.Add(potato);

            return bowl;
        }

        private Bowl GetBowl()
        {
            return new Bowl();
        }

        private Carrot GetCarrot()
        {
            return new Carrot();
        }

        private void Cut(Vegetable vegetable)
        {
            vegetable.Cut();
        }

        private void Peel(Vegetable vegetable)
        {
            vegetable.Peel();
        }

        private Potato GetPotato()
        {
            return new Potato();
        }
    }
}
