using Tyuiu.TashovVD.Sprint1.Task2.V12.Lib;

namespace Tyuiu.TashovVD.Sprint1.Task2.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            int x, y, z;
            x = 2;
            y = 15;
            z = 33;
            DataService ds = new DataService();
            var res = ds.CalculateParallelepipedVolume(x, y, z);
            Assert.AreEqual(990, res);
        }
    }
}
