using System.Collections.Generic;
using System.Linq;

namespace ProjectWithTDD
{
    public class ConverterRomanNumbers
    {
        //private static Dictionary<char, int> isRomanNumbers;
        //private static string[,] romanNumbers = { {"I", "1"}, {"V", "5"}, {"X", "10"}, {"L", "50"}, {"C", "100"}, {"D", "500"}, {"M", "1000"} };
        private static char[] romanNumbers = { 'I', 'V', 'X', 'L', 'C', 'D', 'M' };
        private static List<int> listNumbers;

        public static int Convert(string inputNumber)
        {
            int numberResult = 0, currentNumber, lastNumber = FromRomanToNumber(inputNumber[0]);

            if (IsRomanNumber(inputNumber))
            {
                foreach (var n in inputNumber)
                {
                    currentNumber = FromRomanToNumber(n);

                    if (currentNumber > lastNumber)
                    {
                        currentNumber -= lastNumber;
                        numberResult -= lastNumber;
                    }

                    numberResult += currentNumber;
                    lastNumber = currentNumber;
                }
            }

            return numberResult;
        }

        // X
        private static bool IsRomanNumber(string inputNumber)
        {
            listNumbers = new List<int>();

            bool isLargerNumber = false;
            int currentNumber, countEquals = 0;
            int? lastNumber = null; 

            foreach (var n in inputNumber)
            {
                currentNumber = FromRomanToNumber(n);
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

            return IsRepeatedNumber(listNumbers);
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
/* switch (n)
                {
                    case 'I':
                        numberResult += 1;
                        break;
                    case 'V':
                        numberResult += 5;
                        break;
                    case 'X':
                        numberResult += 10;
                        break;
                    case 'L':
                        numberResult += 50;
                        break;
                    case 'C':
                        numberResult += 100;
                        break;
                    case 'D':
                        numberResult += 500;
                        break;
                    case 'M':
                        numberResult += 1000;
                        break;
                }*/

//switch (n)
//{
//    case 'I':
//        isRomanNumbers['I'] += 1;
//        break;
//    case 'V':
//        isRomanNumbers['V'] += 1;
//        break;
//    case 'X':
//        isRomanNumbers['X'] += 1;
//        break;
//    case 'L':
//        isRomanNumbers['L'] += 1;
//        break;
//    case 'C':
//        isRomanNumbers['C'] += 1;
//        break;
//    case 'D':
//        isRomanNumbers['D'] += 1;
//        break;
//    case 'M':
//        isRomanNumbers['M'] += 1;
//        break;
//}