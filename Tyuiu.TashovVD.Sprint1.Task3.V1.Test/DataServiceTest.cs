using Tyuiu.TashovVD.Sprint1.Task3.V1.Lib;

namespace Tyuiu.TashovVD.Sprint1.Task3.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            double x, y;
            x = 6;
            y = 7;
            double wait = Math.PI * 6 * 6 * 7;
            DataService ds = new DataService();
            var res = ds.CylinderVolume(x, y);

            Assert.AreEqual(wait, res);

        }
    }
}
