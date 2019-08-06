using System;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            //MULTIPLICATION TABLE
            int[,] multTable = new int[10, 10];
            for (int i = 1; i < 10; i++)
                {
                for (int j = 1; j < 10; j++)
                {
                    multTable[i,j] = i*j;
                    Console.Write(multTable[i,j]+ " ");
                }
                Console.WriteLine();
            }
        }
    }
}
