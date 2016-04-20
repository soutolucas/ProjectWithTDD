using System.Collections.Generic;

namespace ProjectWithTDD
{
    public class ConverterRomanNumbers
    {
        private static string[] invalidNumbers = { "IL", "IC", "ID", "IM", "LC", "LD", "LM", "VX", "DM" };
        private static List<int> listNumbers;
        private static Dictionary<char, int> romanNumbers = new Dictionary<char, int>() {
                {'I', 1},
                {'V', 5},
                {'X', 10},
                {'L', 50},
                {'C', 100},
                {'D', 500},
                {'M', 1000}
            };

        public static int Convert(string inputNumber)
        {
            if (!IsRomanNumber(inputNumber))
                return 0;

            int numberResult = 0, currentNumber, lastNumber = listNumbers[0];

            foreach (var number in listNumbers)
            {
                currentNumber = number;

                if (currentNumber > lastNumber)
                    currentNumber -= lastNumber * 2;

                numberResult += currentNumber;
                lastNumber = currentNumber;
            }

            return numberResult;
        }

        private static bool IsRomanNumber(string inputNumber)
        {
            if (!IsConsistentNumber(inputNumber))
                return false;

            listNumbers = new List<int>();

            bool isLargerNumber = false;
            int currentNumber, countEquals = 0;
            int? lastNumber = null; 

            foreach (var n in inputNumber)
            {
                currentNumber = romanNumbers[n];
                listNumbers.Add(currentNumber);

                //Don't is permitted have more that one number before larger number
                if (currentNumber == lastNumber)
                    countEquals++;
                if (currentNumber > lastNumber)
                    isLargerNumber = true;
                if (isLargerNumber && countEquals > 1)
                   return false;
                lastNumber = currentNumber;
            }

            return NotRepeatedNumber(listNumbers);
        }

        private static bool IsConsistentNumber(string inputNumber)
        {
            foreach (var notNumber in invalidNumbers)
            {
                //If the number contains a invalid number it's not a number Roman
                if (inputNumber.Contains(notNumber))
                    return false;
            }

            return true;
        }

        private static bool NotRepeatedNumber(List<int> numbers)
        {
            int count = 0;
            foreach (var l in listNumbers)
            {
                foreach (var i in listNumbers)
                {
                    if (l == i) count++;
                }

                //If a number is repeated more that three times it's not number Roman
                if (count > 3)
                    return false;
                count = 0;
            }

            return true;
        }
    }
}