using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.TashovVD.Sprint1.Task3.V1.Lib
{
    public class DataService : ISprint1Task3V1
    {
        public double CylinderVolume(double r, double h)
        {
            const double Pi = Math.PI;

            return Pi * r * r * h;
        }
    }
}
