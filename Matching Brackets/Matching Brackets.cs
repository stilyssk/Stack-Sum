using System;
using System.Collections.Generic;
using System.Linq;
namespace Matching_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            string[] arrayOfInputString = inputString.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            Stack<int> calculationStack = new Stack<int>();
            for (int i = 0; i <inputString.Length; i++)
            {
                
                if (inputString[i]=='(')
                {
                    calculationStack.Push(i);
                }
                if (inputString[i] == ')')
                {
                    int firstAddres = calculationStack.Pop();
                    Console.WriteLine(inputString.Substring(firstAddres, i-firstAddres+1));
                }

            }
        }
    }
}
