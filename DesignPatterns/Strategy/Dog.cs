using System;
namespace DesignPatterns.Strategy
{
    public class Dog : Animal
    {
        public Dog()
        {
            FlyingType = new CantFly();
        }
    }
}
