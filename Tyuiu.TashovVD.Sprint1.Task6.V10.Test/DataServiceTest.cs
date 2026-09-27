using Tyuiu.TashovVD.Sprint1.Task6.V10.Lib;

namespace Tyuiu.TashovVD.Sprint1.Task6.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            string str = "Всем привет, меня зовут Саша, я диктор канала мастерская настроения.";
            DataService ds = new DataService();
            var res = ds.DeleteMiddleLetter(str);
            string wait = "Всем привет меня зоут Саша я диктор канала мастерская настроения";
            Assert.AreEqual(wait, res);
        }
    }
}
