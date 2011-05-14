using System;

namespace HeadFirstDesignPatterns.ChapterOne
{
    public class Quack : IQuackBehavior
    {
        public void PerformQuack()
        {
            Console.Out.WriteLine("QUACK!");
        }
    }
}
