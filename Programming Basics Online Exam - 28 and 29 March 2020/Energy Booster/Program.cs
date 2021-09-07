using System;

namespace Energy_Booster
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Плод - текст с възможности: "Watermelon", "Mango", "Pineapple" или "Raspberry"
            //2.Размерът на сета -текст с възможности: "small" или "big"
            //3.Брой на поръчаните сетове - цяло число в интервала[1 … 10000]

            string fruit = Console.ReadLine();
            string sizeSets = Console.ReadLine();
            int numSets = int.Parse(Console.ReadLine());

            double pricePerSet = 0;
            double totalSum = 0;

            switch (fruit)
            {
                case "Watermelon":
                    switch (sizeSets)
                    {
                        case "small":
                            pricePerSet = 56 * 2;
                            break;
                        case "big":
                            pricePerSet = 28.70 * 5;
                            break;
                    }
                    break;
                case "Mango":
                    switch (sizeSets)
                    {
                        case "small":
                            pricePerSet = 36.66 * 2;
                            break;
                        case "big":
                            pricePerSet = 19.60 * 5;
                            break;
                    }
                    break;
                case "Pineapple":
                    switch (sizeSets)
                    {
                        case "small":
                            pricePerSet = 42.10 * 2;
                            break;
                        case "big":
                            pricePerSet = 24.80 * 5;
                            break;
                    }
                    break;
                case "Raspberry":
                    switch (sizeSets)
                    {
                        case "small":
                            pricePerSet = 20 * 2;
                            break;
                        case "big":
                            pricePerSet = 15.20 * 5;
                            break;
                    }
                    break;
            }

            totalSum = numSets * pricePerSet;

            if (totalSum >= 400 && totalSum <= 1000)
            {
                totalSum *= 0.85;
            }
            else if (totalSum > 1000)
            {
                totalSum *= 0.50;
            }

            Console.WriteLine($"{totalSum:f2} lv.");
        }
    }
}
