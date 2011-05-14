using System;

namespace HeadFirstDesignPatterns.Characters
{
    public class Knight : Character
    {
        public Knight()
        {
             WeaponBehavior = new SwordBehavior();
        }

        public override void Fight()
        {
            Console.WriteLine("Knight Fighting...");
            base.Fight();
        }
        
    }
}