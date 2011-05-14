using System;

namespace HeadFirstDesignPatterns.Characters
{
    public class AxeBehavior : IWeaponBehavior
    {
        public void UseWeapon()
        {
            Console.WriteLine("Using an axe 1D6 damage!");
        }
    }
}