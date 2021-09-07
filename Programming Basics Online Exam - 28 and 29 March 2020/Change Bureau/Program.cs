using System;

namespace Change_Bureau
{
    class Program
    {
        static void Main(string[] args)
        {
            int bitcoins = int.Parse(Console.ReadLine());
            double uans = double.Parse(Console.ReadLine());
            double commission = double.Parse(Console.ReadLine());

            double bitcoinKurs = 1168;
            double dolarKurs = 1.76;
            double uanKurs = 0.15 * dolarKurs;
            double euroKurs = 1.95;

            double totalInLeva = bitcoins * bitcoinKurs + uans * uanKurs;
            double totalEuros = totalInLeva / euroKurs;

            totalEuros -= commission * totalEuros / 100;

            Console.WriteLine($"{totalEuros:f2}");



        }
    }
}
