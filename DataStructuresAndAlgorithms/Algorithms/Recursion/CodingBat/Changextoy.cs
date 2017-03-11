using System;
using System.Text;

namespace DataStructuresAndAlgorithms.Algorithms.Recursion.CodingBat
{
    public static class Changextoy
    {
        public static string ChangeAllxToy(string input)
        {
            if (input.Length == 0)
                return String.Empty;

            StringBuilder output = new StringBuilder();
            ChangeAllxToyUtil(input, output, 0);
            return output.ToString();
        }

        public static void ChangeAllxToyUtil(string input, StringBuilder output, int currentPosition)
        {
            if (currentPosition == input.Length)
                return;

            if (input[currentPosition] == 'x')
                output.Append('y');
            else
                output.Append(input[currentPosition]);

            ChangeAllxToyUtil(input, output, currentPosition + 1);
        }
    }
}
