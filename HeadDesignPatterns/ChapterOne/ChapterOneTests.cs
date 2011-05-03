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
            mallard.performQuack();
            mallard.performFly();

            Duck model = new ModelDuck();
            model.performFly();
            model.setFlyBehavior(new FlyRocketPowered());
            model.performFly();
        }
    }
}
