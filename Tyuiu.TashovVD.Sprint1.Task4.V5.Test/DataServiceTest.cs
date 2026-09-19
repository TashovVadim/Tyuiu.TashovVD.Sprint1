using Tyuiu.TashovVD.Sprint1.Task4.V5.Lib;

namespace Tyuiu.TashovVD.Sprint1.Task4.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            double x, y;
            x = 5;
            y = 4;
            double wait = 0.143;
            DataService ds = new DataService();
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
