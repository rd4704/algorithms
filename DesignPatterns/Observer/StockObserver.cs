using System;
namespace DesignPatterns.Observer
{
    public class StockObserver : IObserver
    {
        
        static int observerIdTracker;
        double[] prices;
        int observerId;

        ISubject stockGrabber;

        public StockObserver(ISubject newStockGrabber) {
            stockGrabber = newStockGrabber;
            observerId = ++observerIdTracker;

            Console.WriteLine(string.Format("New Observer {0} created", this.observerId));

            stockGrabber.Register(this);
        }

        public void Update(double[] priceList)
        {
            prices = priceList;
            printPrices();
        }

        void printPrices() {
            int c = 0;
            foreach(var v in prices) {
                Console.WriteLine("Price for Stock" + ++c + " " + v);
            }
        }
    }
}
