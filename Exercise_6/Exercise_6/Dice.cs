using System;

namespace Exercise_6
{
    public class Dice
    {
        // Create a die with default minimum sides;
        public Dice()
        {
            this.sides = minSides;
        }

        // Create a die with specified number of sides, ensuring sides is in the expected min and max range
        public Dice(int sides)
        {
            if(sides < minSides)
            {
                setNumberOfSides(minSides);
                return;
            }
            if (sides > maxSides)
            {
                setNumberOfSides(maxSides);
                return;
            }

            this.sides = sides;
            
        }

        private readonly int minSides = 4;
        private readonly int maxSides = 20;
        private int sides = 0;

        // static to avoid multiple calls in quick succession from returning the same result
        static Random randomNumberGenerator = new Random();
        private int randomNumber = 0;

        public int rollDie()
        {
            // Generate a random number between 1 and the number of sides inclusive
            randomNumber = randomNumberGenerator.Next(1, sides + 1);

            return randomNumber;
        }

        public int getNumberOfSides()
        {
            return this.sides;
        }

        public void setNumberOfSides(int sides)
        {
            this.sides = sides;
        }

        public int getRandomNumber()
        {
            return this.randomNumber;
        }
    }
}
