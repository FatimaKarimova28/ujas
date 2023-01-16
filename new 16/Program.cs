using System;

namespace new_16
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[,] arr = new int[3, 2]
            //{
            //    {2, 5 },
            //    {4, 8 },
            //    {7, 1 }
            //};
            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        Console.Write(arr[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}


            int sum = 0;
            int[,] arr = new int[2, 2]
            {
                {1, -5 },
                {2, 6}
            };

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {

                    sum += arr[i, j];
                    Console.WriteLine($"Yerlesir {i}{j} indexsinde");
                }

            }
            Console.WriteLine(sum);

            //int sum = 0;
            //int[,] arr = new int[3, 3]
            //{
            //    {1, 2, 3 },
            //    {4, 5, 6 },
            //    {7, 8, 9 }
            //};
            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    sum += arr[i, 0];
            //}
            //Console.WriteLine(sum);
            
       
        }
    }
}
