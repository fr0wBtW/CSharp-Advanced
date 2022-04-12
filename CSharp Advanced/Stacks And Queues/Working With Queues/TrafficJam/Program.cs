using System;
using System.Collections.Generic;

namespace TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<string> carList = new Queue<string>();
            int passedCars = 0;
            while (true)
            {
                string cars = Console.ReadLine();

                if (cars != "green")
                {
                    carList.Enqueue(cars);
                }
                else if (cars == "green")
                {
                    if (carList.Count >= n)
                    {
                        for (int i = 1; i <= n; i++)
                        {
                            Console.WriteLine("{0} passed!", carList.Dequeue());
                            passedCars++;
                        }
                    }
                    else
                    {
                        for (int i = 0; i <= carList.Count; i++)
                        {
                            Console.WriteLine("{0} passed!", carList.Dequeue());
                            passedCars++;
                        }
                    }
                }
                if (cars == "end")
                {
                    Console.WriteLine("{0} cars passed the crossroads.", passedCars);
                    break;
                }
            }
        }
    }
}
