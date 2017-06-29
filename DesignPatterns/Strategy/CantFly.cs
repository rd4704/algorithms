using System;
namespace DesignPatterns.Strategy
{
    public class CantFly : IFlys
    {
        public string Fly()
        {
            return "Can't Fly :(";
        }
    }
}
