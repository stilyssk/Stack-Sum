using System;
using System.Collections.Generic;
using System.Linq;

namespace Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            string[] arrayOfInputString = inputString.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            Stack<string> calculationStack = new Stack<string>();
            for (int i = arrayOfInputString.Length-1; i>=0;i--)
            {
                calculationStack.Push(arrayOfInputString[i]);

            }
            int sum =int.Parse(calculationStack.Pop());
             
            while(calculationStack.Any())
            {
                switch (calculationStack.Pop())
                {
                    case "+":
                        sum += int.Parse(calculationStack.Pop());
                        break;
                    case "-":
                        sum -= int.Parse(calculationStack.Pop());
                        break;

                    default:
                        break;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
