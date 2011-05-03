using System;

namespace HeadFirstDesignPatterns.ChapterOne
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            FlyBehavior = new FlyNoWaycs();
            QuackBehavior = new Quack();
        }

        public void Display()
        {
            Console.Out.WriteLine("I'm a model duck");
        }
    }
}
