using System;

namespace HeadFirstDesignPatterns.ChapterOne
{
    public class Quack : IQuackBehavior
    {
        public void quack()
        {
            Console.Out.WriteLine("QUACK!");
        }
    }
}
