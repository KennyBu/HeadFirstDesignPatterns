using System;

namespace HeadFirstDesignPatterns.Characters
{
    public class SwordBehavior : IWeaponBehavior
    {
        public void UseWeapon()
        {
            Console.WriteLine("Using a long sword 1D8 damage!");
        }
    }
}