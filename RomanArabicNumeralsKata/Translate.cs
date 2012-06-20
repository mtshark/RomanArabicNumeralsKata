using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RomanArabicNumeralsKata {
    public class Translate {

        private static SortedList<int, string> GetArabicNumeralCorrespond() {
            SortedList<int, string> equivalants = new SortedList<int, string>();
            equivalants.Add(1, "I");
            equivalants.Add(5, "V");
            equivalants.Add(10, "X");
            equivalants.Add(50, "L");
            equivalants.Add(100, "C");
            equivalants.Add(500, "D");
            equivalants.Add(1000, "M");
            return equivalants;
        }

        public static bool IsArabic(string pInputArg) {
            int result;
            return int.TryParse(pInputArg, out result);
        }

        internal static string ToArabic(string pInputArg) {
            SortedList<int, string> equivalants = GetArabicNumeralCorrespond();
            int returnValue = 0;
            int i = 0;
            int previousNumber = 0;
            char[] inputValue = pInputArg.ToCharArray();
            int[] numbers = new int[inputValue.Length];
            foreach (char c in inputValue) {
                if (!int.TryParse(equivalants.ToList()[equivalants.IndexOfValue(c.ToString())].Key.ToString(), out numbers[i])) {
                    throw new Exception("There was an issue with the numbers");
                }
                i++;
            }

            foreach (int number in numbers) {
                if (number <= previousNumber) {
                    returnValue += number;
                }
                else {
                    returnValue += number - previousNumber - previousNumber;
                }
                previousNumber = number;
            }
            return returnValue.ToString();
        }

        internal static string ToRoman(string pInputArg) {
            int inputArgument;
            int fiveHundred = 0;
            int fifty = 0;
            int five = 0;
            StringBuilder outputString = new StringBuilder();
            int.TryParse(pInputArg, out inputArgument);

            int thousands = Math.DivRem(inputArgument, 1000, out inputArgument);
            int hundreds = Math.DivRem(inputArgument, 100, out inputArgument);
            if (hundreds < 9)
                fiveHundred = Math.DivRem(hundreds, 5, out hundreds);
            int tens = Math.DivRem(inputArgument, 10, out inputArgument);
            if (tens < 9)
                 fifty = Math.DivRem(tens, 5, out tens);
            int ones = Math.DivRem(inputArgument, 1, out ones);
            if (ones < 9)
                 five = Math.DivRem(ones, 5, out ones);
            outputString.Append(GetValue("1000", thousands, false));
            outputString.Append(GetValue("500", fiveHundred, true));
            outputString.Append(GetValue("100", hundreds, true));
            outputString.Append(GetValue("50", fifty, true));
            outputString.Append(GetValue("10", tens, true));
            outputString.Append(GetValue("5", five, true));
            outputString.Append(GetValue("1", ones, true));
            return outputString.ToString();
        }

        private static StringBuilder GetValue(string pInputArg, int pNumber, bool pCanBeNextMinusThis) {
            SortedList<int, string> equivalants = GetArabicNumeralCorrespond();
            StringBuilder outputString = new StringBuilder();
            if (pCanBeNextMinusThis && (pNumber == 4||pNumber == 9)) {
                string returnValue;
                equivalants.TryGetValue(Convert.ToInt32(pInputArg), out returnValue);
                outputString.Append(returnValue);
                outputString.Append(equivalants.ToList()[equivalants.IndexOfKey(Convert.ToInt32(pInputArg)) + (pNumber/4)].Value);
            }
            else {
                for (int i = 0; i < pNumber; ++i) {
                    string returnValue;
                    equivalants.TryGetValue(Convert.ToInt32(pInputArg), out returnValue);
                    outputString.Append(returnValue);
                }
            }
            return outputString;
        }
    }
}
