using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.PisarevMA.Sprint3.Task1.V24.Lib
{
    public class DataService : ISprint3Task1V24
    {
        public double GetSumSeries(int value, int startValue, int stopValue)
        {
            double sumSeries = 0;
            int i;
            for (i = startValue; i <= stopValue; i++)
            {
                sumSeries = sumSeries + (Math.Pow(2 / (6 + (Math.Pow(value, i))), i));
            }
            return Math.Round(sumSeries, 3);
        }
    }
}
