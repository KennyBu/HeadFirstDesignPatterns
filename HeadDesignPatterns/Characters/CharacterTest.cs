using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HeadFirstDesignPatterns.Characters
{
    [TestClass]
    public class CharacterTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var king = new King();
            king.Fight();

            var knight = new Knight();
            knight.Fight();

            knight.SetWeaponBehavior(new AxeBehavior());
            knight.Fight();

        }
    }
}