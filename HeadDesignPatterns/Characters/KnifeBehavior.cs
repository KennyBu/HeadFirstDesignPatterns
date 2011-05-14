using System;

namespace HeadFirstDesignPatterns.Characters
{
    public class KnifeBehavior : IWeaponBehavior
    {
        public void UseWeapon()
        {
            Console.WriteLine("Using a knife 1D4 damage!");
        }
    }
}