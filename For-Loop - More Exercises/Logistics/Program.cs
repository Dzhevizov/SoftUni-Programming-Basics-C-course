using System;

namespace Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int numCargo = int.Parse(Console.ReadLine());

            double tonPriceMinibus = 200;
            double tonPriceTruck = 175;
            double tonPriceTrain = 120;

            int cargoMinibus = 0;
            int cargoTruck = 0;
            int cargoTrain = 0;
            int totalCargo = 0;

            double averagePrice = 0;
            double percentCargoMinibus = 0;
            double percentCargoTruck = 0;
            double percentCargoTrain = 0;

            for (int countCargo = 1; countCargo <= numCargo; countCargo++)
            {
                int weightNextCargo = int.Parse(Console.ReadLine());
                totalCargo += weightNextCargo;
                if (weightNextCargo <= 3)
                {
                    cargoMinibus += weightNextCargo;
                }
                else if (weightNextCargo <= 11)
                {
                    cargoTruck += weightNextCargo;
                }
                else
                {
                    cargoTrain += weightNextCargo;
                }
            }

            averagePrice = (cargoMinibus * tonPriceMinibus + cargoTruck * tonPriceTruck + cargoTrain * tonPriceTrain) / totalCargo;
            percentCargoMinibus = (double)cargoMinibus * 100 / totalCargo;
            percentCargoTruck = (double)cargoTruck * 100 / totalCargo;
            percentCargoTrain = (double)cargoTrain * 100 / totalCargo;

            Console.WriteLine($"{averagePrice:f2}");
            Console.WriteLine($"{percentCargoMinibus:f2}%");
            Console.WriteLine($"{percentCargoTruck:f2}%");
            Console.WriteLine($"{percentCargoTrain:f2}%");

        }
    }
}
