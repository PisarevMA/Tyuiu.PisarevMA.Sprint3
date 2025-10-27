using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.PisarevMA.Sprint3.Task5.V30.Lib
{
    public class DataService : ISprint3Task5V30
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double SumSumSeries = 0;
            int i;
            int k;
            for (i = startValue1; i <= stopValue1; i++)
            {
                for (k = startValue2; k <= stopValue2; i++)
                {
                    SumSumSeries = SumSumSeries + ((Math.Pow(x, 3) - k ) + x);
                }
            }
            return Math.Round(SumSumSeries, 3);
        }
    }
}
