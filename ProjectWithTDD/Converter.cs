using System.Collections.Generic;
using System.Linq;

namespace ProjectWithTDD
{
    public static class Converter
    {
        static char[] numbers = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        public static bool TryParseInt(string valueInput, out int result)
        {
            result = 0;
            if (string.IsNullOrWhiteSpace(valueInput)) return false;
            
            bool isNumber;
            foreach (var item in valueInput)
            {
                isNumber = false;
                foreach (var n in numbers)
                {
                    if (item == n)
                    {
                        isNumber = true;
                        break;
                    }
                }

                if (!isNumber)
                    return false;
            }

            result = int.Parse(valueInput);
            return true;
        }

        public static bool TryParseInt2(string valueInput, out int result)
        {
            result = 0;
            if (string.IsNullOrWhiteSpace(valueInput)) return false;

            bool isNumber;
            foreach (var item in valueInput)
            {
                isNumber = false;

                for (int i = 0; i < 10; i++)
                {
                    if (item.ToString() == i.ToString())
                    {
                        isNumber = true;
                        break;
                    }
                }

                if (!isNumber)
                    return false;
            }

            result = int.Parse(valueInput);
            return true;
        }

    }
}
