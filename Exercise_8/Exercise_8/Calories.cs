using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_8
{
    static class Calories
    {
        // fat calories conversion if user enters an int
        public static int fatCalories(int grams)
        {
            // convert fat grams to calories and return int value
            int result = grams * 9;

            return result;
        }

        // fat calories conversion if user enters a double
        public static double fatCalories(double grams)
        {
            // convert fat grams to calories and return double value
            double result = grams * 9;

            return result;
        }

        // carb calories conversion if user enters an int
        public static int carbCalories(int grams)
        {
            // convert carb grams to calories and return int value
            int result = grams * 4;

            return result;
        }

        // carb calories conversion if user enters a double
        public static double carbCalories(double grams)
        {
            // convert carb grams to calories and return double value
            double result = grams * 4;

            return result;
        }
    }
}
