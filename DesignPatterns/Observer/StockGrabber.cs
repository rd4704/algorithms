using System;
using System.Collections.Generic;

namespace DesignPatterns.Observer
{
    public class StockGrabber : ISubject
    {
        List<IObserver> listObserver;
        private double[] prices;

        public StockGrabber()
        {
            listObserver = new List<IObserver>();
        }

        public void NotifyObserver()
        {
            foreach (var observer in listObserver) {
                observer.Update(prices);
            }
        }

        public void Register(IObserver o)
        {
            listObserver.Add(o);
        }

        public void Unregister(IObserver o)
        {
            listObserver.Remove(o);
            Console.WriteLine(string.Format("Observer {0} deleted", listObserver.FindIndex(x=> x.Equals(o)) + 1));
        }

        public void SetPrices(double[] prices) {
            this.prices = prices;
            NotifyObserver();
        }
    }
}
