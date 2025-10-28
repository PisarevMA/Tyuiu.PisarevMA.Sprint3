using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.PisarevMA.Sprint3.Task6.V9.Lib
{
    public class DataService : ISprint3Task6V9
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int count1 = 0;
            int x;
            for (x = startValue; x <= stopValue; x++)
            {
                for (int d = 1; d <= x; d++)
                {
                    if (x % d == 0)
                    {
                        count1++;
                    }
                }
            }
            return count1;
        }
    }
}
