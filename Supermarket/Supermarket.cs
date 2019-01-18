using System;
using System.Collections.Generic;
using System.Linq;
namespace Supermarket
{
    class Supermarket
    {
        static void Main(string[] args)
        {
            Queue<string> storeQuene = new Queue<string>();
            while (true)
            {
                string inputString = Console.ReadLine();

                if (inputString=="End")
                {
                    Console.WriteLine($"{storeQuene.Count()} people remaining.");
                    break;
                }
                if (inputString== "Paid")
                {
                    while (storeQuene.Any())
                    {
                        Console.WriteLine( storeQuene.Dequeue());
                    }
                }
                else
                {
                    storeQuene.Enqueue(inputString);
                }

            }

        }
    }
}
