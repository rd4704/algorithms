using System;
namespace DesignPatterns.Strategy
{
    public class CanFly : IFlys
    {
        public string Fly()
        {
            return "Flying high :)";
        }
    }
}
