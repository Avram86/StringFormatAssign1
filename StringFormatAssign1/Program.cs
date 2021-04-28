using System;

namespace StringFormatAssign1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose a character as a separator:");

        Here:

            string separator = Console.ReadLine();
            if(char.TryParse(separator, out char result))
            { 
                string[] text1 = ReadFormKeyboard(result);
                string[] text2 = ReadFormKeyboard(result);
                string[] text3 = ReadFormKeyboard(result);

                Console.WriteLine($"{"Prod",-10}{"UM",-10}{"Cant.",-10}");
                PrintFormatted(text1);
                PrintFormatted(text2);
                PrintFormatted(text3);
            }
            else
            {
                Console.WriteLine("Please write a single character");
                goto Here;
            }
            

            
        }
        private static string[] ReadFormKeyboard(char x)
        {
            Console.WriteLine($"Please write a product, a unit of measure and a quantity using {x} as separator");
            string text = Console.ReadLine();

            if(string.IsNullOrWhiteSpace(text))
            {
             Console.WriteLine("Please enter a valid text!");
            }

            string[] textArray = text.Split($"{x}");
            return textArray;

        }
        private static void PrintFormatted(string[] input)
        {
            Console.WriteLine($"{input[0],-10}{input[1],-10}{input[2],-10}");
        }
    }
}
