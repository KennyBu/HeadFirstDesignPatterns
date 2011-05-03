using System;

namespace HeadFirstDesignPatterns.ChapterOne
{
    public class FlyRocketPowered : IFlyBehavior
    {
        public void fly()
        {
            Console.Out.WriteLine("I'm flying with a rocket!");
        }
    }
}
