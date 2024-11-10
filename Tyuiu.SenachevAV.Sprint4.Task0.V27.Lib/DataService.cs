using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.SenachevAV.Sprint4.Task0.V27.Lib
{
    public class DataService : ISprint4Task0V27
    {
        public int GetMultOddArrEl(int[] array)
        {
            int res = 1;
            foreach (int numbers in array)
            {
                if (numbers % 2 == 1)
                {
                    res *= numbers;
                }
            }
            return res;
        }
    }
}
