using System;

namespace HeadFirstDesignPatterns.ChapterOne
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            QuackBehavior = new Quack();
            FlyBehavior = new FlyWithWings();
        }

        public void Display()
        {
            Console.Out.WriteLine("I'm a real Mallard Duck");
        }

    }
}
