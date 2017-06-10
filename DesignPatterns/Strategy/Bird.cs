using System;
namespace DesignPatterns.Strategy
{
    public class Bird : Animal
    {
        public Bird()
        {
            FlyingType = new CanFly();
        }
    }
}
