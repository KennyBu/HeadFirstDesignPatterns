using System;

namespace HeadFirstDesignPatterns.ChapterOne
{
    public class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.Out.WriteLine("I'm flying!");
        }
    }
}
