using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HeadFirstDesignPatterns.ChapterOne
{
    [TestClass]
    public class ChapterOneTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Duck mallard = new MallardDuck();
            mallard.PerformQuack();
            mallard.PerformFly();

            Duck model = new ModelDuck();
            model.PerformFly();
            model.SetFlyBehavior(new FlyRocketPowered());
            model.PerformFly();
        }
    }
}
