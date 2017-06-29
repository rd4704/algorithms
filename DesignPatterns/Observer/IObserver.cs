using System;
namespace DesignPatterns.Observer
{
    public interface IObserver
    {
        void Update(double[] priceList);
    }
}
