using System;
namespace Tyuiu.MutafRA.Sprint0.Task7.V0.Lib
{
    public class DataService
    {
        public static int[] AdditionArrays(int[] numOne, int[] numTwo)
        {
            int[] resultarray = new int[5];
            for (var i = 0; i < numOne.Length; i++)
            {
                resultarray[i] = numOne[i] + numTwo[i];
            }
            return resultarray;
        }
    }
}
