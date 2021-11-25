using System;
namespace Lib_7
{
    public class ProgrammModules
    {
        public static void NumbersBelowZeroToPower(int [,] numbers, out int[,] processedArray)
        {
            processedArray = new int[numbers.GetLength(0),numbers.GetLength(1)];
            for (int i=0;i<numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1);j++)
                {
                    processedArray[i,j] = numbers[i,j];
                    if (numbers[i,j] < 0)
                    {
                        processedArray[i,j] = (int)Math.Pow(numbers[i,j], 2);
                    }
                }
            }
        }
    }
}
