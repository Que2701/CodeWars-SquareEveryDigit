using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateSquareRoot
{
    public class CalculateRoot
    {
        public static int SquareDigits(int number)
        {
            var results = default(string);
            var squareResults = default(int);
            // convert the number into an array
            List<int> numbersArray = number.ToString()
                .Select(n => Convert.ToInt32(char.GetNumericValue(n))).ToList<int>();
            numbersArray.ForEach(x =>
            {
                results += x * x;
            });
            squareResults = int.Parse(results);
            return squareResults;
        }

        public static int NGreenWood(int number)
        {
            string output = default(string);
            foreach (char c in number.ToString())
            {
                int square = Convert.ToInt32(char.GetNumericValue(c));
                output += square * square;
            }
            return int.Parse(output);
        }

        public static int Goughfeet(int number)
        {
            return int.Parse(String.Concat(number.ToString().Select(n => (int)Math.Pow(char.GetNumericValue(n), 2))));
        }
    }
}
