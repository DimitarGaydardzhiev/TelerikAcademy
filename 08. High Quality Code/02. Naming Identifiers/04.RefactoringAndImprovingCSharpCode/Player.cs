namespace Minesweeper
{
    public class Player
    {
        private string name;
        private int numberOfPoints;

        public Player() 
        {
        }

        public Player(string name, int points)
        {
            this.name = name;
            this.numberOfPoints = points;
        }

        public string Name
        {
            get 
            { 
                return this.name; 
            }

            set 
            { 
                this.name = value; 
            }
        }

        public int NumberOfPoints
        {
            get 
            { 
                return this.numberOfPoints; 
            }

            set 
            { 
                this.numberOfPoints = value; 
            }
        }
    }
}