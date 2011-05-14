using System;

namespace HeadFirstDesignPatterns.ChapterOne
{
    public class Squeak : IQuackBehavior
    {
        public void PerformQuack()
        {
            Console.Out.WriteLine("Squeak!");
        }
    }
}
