using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.TashovVD.Sprint1.Task5.V5.Lib
{
    public class DataService : ISprint1Task5V5
    {
        public int Calculate(double x)
        {
            int res = Convert.ToInt32(Math.Floor((x * 10) % 10));
            return res;
        }
    }
}
