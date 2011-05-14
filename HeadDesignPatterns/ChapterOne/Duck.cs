using System;

namespace HeadFirstDesignPatterns.ChapterOne
{
    public abstract class Duck
    {
        public IQuackBehavior QuackBehavior;
        public IFlyBehavior FlyBehavior;        

        public void PerformQuack()
        {
            QuackBehavior.PerformQuack();
        }

        public void SetFlyBehavior(IFlyBehavior flyBehavior)
        {
            FlyBehavior = flyBehavior;
        }

        public void SetQuackBehavior(IQuackBehavior quackBehavior)
        {
            QuackBehavior = quackBehavior;
        }

        public void PerformFly()
        {
            FlyBehavior.Fly();
        }

        public void Swim()
        {
            Console.Out.WriteLine("All ducks float, even decoys!");
        }
    }
}
