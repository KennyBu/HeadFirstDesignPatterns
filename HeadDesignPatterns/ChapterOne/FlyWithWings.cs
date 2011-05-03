using System;

namespace HeadFirstDesignPatterns.ChapterOne
{
    public class FlyWithWings : IFlyBehavior
    {
        public void fly()
        {
            Console.Out.WriteLine("I'm flying!");
        }
    }
}
