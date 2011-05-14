namespace HeadFirstDesignPatterns.Characters
{
    public abstract class Character
    {
        protected IWeaponBehavior WeaponBehavior;

        public void SetWeaponBehavior(IWeaponBehavior weaponBehavior)
        {
            WeaponBehavior = weaponBehavior;
        }

        public virtual void Fight()
        {
            WeaponBehavior.UseWeapon();
        }
    }
}