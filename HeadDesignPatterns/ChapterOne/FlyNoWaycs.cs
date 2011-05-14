using System;

namespace HeadFirstDesignPatterns.ChapterOne
{
    public class FlyNoWaycs : IFlyBehavior
    {
        public void Fly()
        {
            Console.Out.WriteLine("I can't fly!");
        }
    }
}
