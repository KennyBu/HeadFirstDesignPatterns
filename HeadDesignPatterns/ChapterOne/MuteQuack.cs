using System;

namespace HeadFirstDesignPatterns.ChapterOne
{
    public class MuteQuack : IQuackBehavior
    {
        public void quack()
        {
            Console.Out.WriteLine("<Silence>");
        }
    }
}
