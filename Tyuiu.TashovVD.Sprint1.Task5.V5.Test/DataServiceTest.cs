using Tyuiu.TashovVD.Sprint1.Task5.V5.Lib;

namespace Tyuiu.TashovVD.Sprint1.Task5.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int res = ds.Calculate(32.597);
            int wait = 5;
            Assert.AreEqual(wait, res);
        }
    }
}
