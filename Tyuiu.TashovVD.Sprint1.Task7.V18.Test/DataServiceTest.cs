using Tyuiu.TashovVD.Sprint1.Task7.V18.Lib;

namespace Tyuiu.TashovVD.Sprint1.Task7.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double result = ds.Calculate(90, 0);
            double wait = 90.02;
            Assert.AreEqual(wait, result);
        }
    }
}
