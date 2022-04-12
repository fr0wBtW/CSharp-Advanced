using System;
using System.Collections.Generic;
using System.Linq;

namespace ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> carPlate = new HashSet<string>();

            while (true)
            {
                var input = Console.ReadLine().Split(',');
                if (input[0] == "END")
                {
                    break;
                }
                string inOrOut = input[0];
                string numberPlate = input[1];

                if (inOrOut == "IN")
                {
                    carPlate.Add(numberPlate);
                }
                else if (inOrOut == "OUT")
                {
                    carPlate.Remove(numberPlate);
                }
            }
            if (carPlate.Count > 0)
            {
                foreach (var car in carPlate)
                {
                    Console.WriteLine(car);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
