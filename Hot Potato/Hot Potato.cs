using System;
using System.Collections.Generic;
using System.Linq;

namespace Hot_Potato
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            string[] arrayOfInputString = inputString.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            Queue<string> storeQuene = new Queue<string>();
            foreach (var item in arrayOfInputString)
            {
                storeQuene.Enqueue(item);
            }
            int count = int.Parse(Console.ReadLine());
            int tempCount = 1;
            while (storeQuene.Any())
            {
                if (tempCount == count)
                {
                    tempCount = 1;
                    if (storeQuene.Count==1)
                    {
                        Console.WriteLine($"Last is {storeQuene.Dequeue()}");

                    }
                    else
                    {
                        Console.WriteLine($"Removed {storeQuene.Dequeue()}");
                    }
                }
                else
                {
                    tempCount++;
                    storeQuene.Enqueue(storeQuene.Dequeue());
                }
            }
        }
    }
}
