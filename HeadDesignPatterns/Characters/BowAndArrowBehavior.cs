using System;

namespace HeadFirstDesignPatterns.Characters
{
    public class BowAndArrowBehavior : IWeaponBehavior
    {
        public void UseWeapon()
        {
            Console.WriteLine("Using a bow 1D6 damage!");
        }
    }
}