using ConsoleCalc;
using System;

namespace ConsoleCalc // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Строка на входе
            string input = "2.95+(20*2+5**3)*sin45";


            Stack<Element> numbers = new Stack<Element>();
            Stack<Element> operations = new Stack<Element>();

            string n = "";
            string s = "";

            foreach (var ch in input)
            {
                if (ch >= '0' && ch <= '9' || ch == '.' || ch == ',')
                {
                    //Console.WriteLine($"number {ch}");
                    n += ch;
                    s += ' ';

                }
                else
                {
                    //Console.WriteLine($"symbol {ch}");
                    s += ch;
                    n += ' ';
                }
            }

            Console.WriteLine($"numbers: {n}");
            Console.WriteLine($"symbols: {s}");

            string[] n2 = n.Split(' ');
            foreach (var item in n2)
            {
                Console.WriteLine($"{item}");
            }


        }


    }
}