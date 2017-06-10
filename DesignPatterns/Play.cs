using System;
using DesignPatterns.Strategy;
using DesignPatterns.Observer;

namespace DesignPatterns
{
    class Play
    {
        static void Main(string[] args)
        {
            //RunStrategy();
            RunObserver();
        }

        static void RunStrategy()
        {
			Animal sparky = new Dog();
			Animal tweety = new Bird();

			Console.WriteLine("Dog Sparky : " + sparky.TryToFly());
			Console.WriteLine("Bird Tweety : " + tweety.TryToFly());
        }

        static void RunObserver()
        {
            StockGrabber subject = new StockGrabber();
            StockObserver observer = new StockObserver(subject);

            double[] pricesNow = { 200.0, 300.0, 400.0 };
            subject.SetPrices(pricesNow);
        }
    }
}
