using System;

namespace HeadFirstDesignPatterns.ChapterOne
{
    public class MuteQuack : IQuackBehavior
    {
        public void PerformQuack()
        {
            Console.Out.WriteLine("<Silence>");
        }
    }
}
