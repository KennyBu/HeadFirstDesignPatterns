using System;

namespace HeadFirstDesignPatterns.Characters
{
    public class King : Character
    {
        public King()
        {
            WeaponBehavior = new KnifeBehavior();
        }

        public override void Fight()
        {
            Console.WriteLine("King Fighting...");
            base.Fight();
        }
    }
}