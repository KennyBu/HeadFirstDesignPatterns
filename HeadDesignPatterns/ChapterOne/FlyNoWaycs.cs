using System;

namespace HeadFirstDesignPatterns.ChapterOne
{
    public class FlyNoWaycs : IFlyBehavior
    {
        public void fly()
        {
            Console.Out.WriteLine("I can't fly!");
        }
    }
}
