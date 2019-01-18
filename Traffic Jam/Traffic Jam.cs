using System;
using System.Collections.Generic;
using System.Linq;
namespace Traffic_Jam
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            Queue<string> storeQuene = new Queue<string>();
            int tempCount = 0;
            int totalCar = 0;
            while (true)
            {
                string inputString = Console.ReadLine();

                if (inputString== "end")
                {
                    break;
                }
                if (inputString== "green")
                {
                    while (storeQuene.Any()&&tempCount<count)
                    {
                        Console.WriteLine($"{storeQuene.Dequeue()} passed!");
                        tempCount++;
                        totalCar++;
                    }
                    tempCount = 0;
                }
                else
                {
                    storeQuene.Enqueue(inputString);
                }
            }
            Console.WriteLine($"{totalCar} cars passed the crossroads.");
        }
    }
}
