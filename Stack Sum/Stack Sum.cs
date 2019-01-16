using System;
using System.Collections.Generic;
using System.Linq;
namespace Stack_Sum
{
    class Program
    {
        static  Stack<int> Add(Stack<int> tempStack, int firstNumber, int secondNumber)
        {
            tempStack.Push(firstNumber);
            tempStack.Push(secondNumber);
            return tempStack;
        }
        static Stack<int> Remove(Stack<int> tempStack, int countToRemove)
        {
            if (tempStack.Count>=countToRemove)
            {
                for (int i = 0; i < countToRemove; i++)
                {
                    tempStack.Pop();
                } 
            }
            return tempStack;
        }
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            int[] inputNumrerArray = inputString.Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Stack<int> stackCollection = new Stack<int>();
            foreach (var numberItem in inputNumrerArray)
            {
                stackCollection.Push(numberItem);
            }
            while (true)
            {
                string[] inputCommand = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.None ).ToArray();
                string command = inputCommand[0].ToLower();
                if (command=="end")
                {
                    break;

                }
                int firstNumber;

                switch (command)
                {
                    case "add":
                        firstNumber = int.Parse(inputCommand[1]);
                        int secondNumber = int.Parse(inputCommand[2]);
                        stackCollection = Add(stackCollection, firstNumber, secondNumber);
                        break;
                    case "remove":
                        firstNumber = int.Parse(inputCommand[1]);
                        stackCollection = Remove(stackCollection, firstNumber);
                        break;

                    default:
                        break;
                }
            }
            int sum = 0;
            while (stackCollection.Any())
            {

                sum += stackCollection.Pop();
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
