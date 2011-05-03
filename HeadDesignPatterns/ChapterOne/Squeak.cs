using System;

namespace HeadFirstDesignPatterns.ChapterOne
{
    public class Squeak : IQuackBehavior
    {
        public void quack()
        {
            Console.Out.WriteLine("Squeak!");
        }
    }
}
