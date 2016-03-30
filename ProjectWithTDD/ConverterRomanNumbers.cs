using System.Collections.Generic;

namespace ProjectWithTDD
{
    public class ConverterRomanNumbers
    {
        private static string[] invalidNumbers = { "IL", "IC", "ID", "IM", "LC", "LD", "LM", "VX", "DM" };
        private static List<int> listNumbers;

        public static int Convert(string inputNumber)
        {
            if (!IsRomanNumber(inputNumber))
                return 0;

            int numberResult = 0, currentNumber, lastNumber = listNumbers[0];

            foreach (var number in listNumbers)
            {
                currentNumber = number;

                if (currentNumber > lastNumber)
                {
                    currentNumber -= lastNumber;
                    numberResult -= lastNumber;
                }

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
                currentNumber = FromRomanToNumber(n);
                listNumbers.Add(currentNumber);

                //Isn't permitted have more that one number before larger number
                if (currentNumber == lastNumber)
                    countEquals++;
                if (currentNumber > lastNumber)
                    isLargerNumber = true;
                if (isLargerNumber && countEquals > 1)
                   return false;
                lastNumber = currentNumber;
            }

            return IsRepeatedNumber(listNumbers);
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

        private static bool IsRepeatedNumber(List<int> numbers)
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

        private static int FromRomanToNumber(char n)
        {
            switch (n)
            {
                case 'I':
                    return 1;
                case 'V':
                    return 5;
                case 'X':
                    return 10;
                case 'L':
                    return 50;
                case 'C':
                    return 100;
                case 'D':
                    return 500;
                case 'M':
                    return 1000;
            }
            return 0;
        }
    }
}