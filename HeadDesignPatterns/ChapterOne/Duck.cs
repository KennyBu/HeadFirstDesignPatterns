using System;

namespace HeadFirstDesignPatterns.ChapterOne
{
    public abstract class Duck
    {
        public IQuackBehavior QuackBehavior;
        public IFlyBehavior FlyBehavior;        

        public void performQuack()
        {
            QuackBehavior.quack();
        }

        public void setFlyBehavior(IFlyBehavior flyBehavior)
        {
            FlyBehavior = flyBehavior;
        }

        public void setQuackBehavior(IQuackBehavior quackBehavior)
        {
            QuackBehavior = quackBehavior;
        }

        public void performFly()
        {
            FlyBehavior.fly();
        }

        public void Swim()
        {
            Console.Out.WriteLine("All ducks float, even decoys!");
        }
    }
}
