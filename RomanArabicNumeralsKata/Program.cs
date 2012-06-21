using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RomanArabicNumeralsKata {
    class Program {
        static void Main(string[] args) {
            string numericInput;
            Console.WriteLine("Please Enter a number, either in roman or arabic format");
            numericInput = Console.ReadLine();
            if (Translate.IsArabic(numericInput)) {
                Console.WriteLine(Translate.ToRoman(numericInput));
            }
            else {
                Console.WriteLine(Translate.ToArabic(numericInput));
            }
            numericInput = Console.ReadLine();

        }
    }
}
