using System;
namespace DesignPatterns.Strategy
{
    public class Animal
    {
        public IFlys FlyingType;

        public string TryToFly() 
        {
            return FlyingType.Fly();
        }

        public void SetFlyingType(IFlys newFlyingType) 
        {
            FlyingType = newFlyingType;
        }
    }
}
