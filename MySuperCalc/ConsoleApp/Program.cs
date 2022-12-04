using ConsoleCalc;
using System;

namespace ConsoleCalc // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start");
            //Строка на входе
            string input = "2.956+(20.0*2.5+5**3)*sin45";

            //стек для чисел и стек для операций
            Stack<Element> numbers = new Stack<Element>();
            Stack<Element> operations = new Stack<Element>();

            string tmp = "";


            //проходим по строке и собираем стек чисел
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] >= '0' && input[i] <= '9' || input[i] == '.' || input[i] == ',')
                {
                    tmp += input[i];
                }
                else
                {
                    if (tmp.Length > 0)
                    {
                        var e = new Element() { type = (int)ElementType.Number, value = double.Parse(tmp, System.Globalization.CultureInfo.InvariantCulture) };
                        numbers.Push(e);
                        tmp = "";
                    }               
                }
            }
            

            //проверка
            Console.WriteLine($"input string: {input}");

            foreach (var item in numbers)
            {
                Console.WriteLine(item.value);
            }


        }
    }
}