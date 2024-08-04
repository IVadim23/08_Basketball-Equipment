using System;

namespace _08._Basketball_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tax per year:");
            int taxPerYear = int.Parse(Console.ReadLine());
            double shoesPrice = taxPerYear - taxPerYear * 40 / 100.0;
            double outfitPrice = shoesPrice - shoesPrice * 20 / 100;
            double ballPrice = outfitPrice / 4;
            double accPrice = ballPrice / 5;
            double sum = taxPerYear + shoesPrice + outfitPrice + ballPrice + accPrice;
            Console.WriteLine("The final sum is:\n{0:f2}",sum);
        }
    }
}
