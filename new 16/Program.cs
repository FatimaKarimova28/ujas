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


            //int sum = 0;
            //int[,] arr = new int[2, 2]
            //{
            //    {1, -5 },
            //    {2, 6}
            //};

            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {

            //        sum += arr[i, j];
            //        Console.WriteLine($"Yerlesir {i}{j} indexsinde");
            //    }

            //}
            //Console.WriteLine(sum);

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

            //int sum = 0;
            //int[,] arr = new int[3, 2]
            //{
            //    {1, 2 },
            //    {3, 4 },
            //    {5, 6 }
            //};
            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    sum += arr[i, 0];
            //}
            //Console.WriteLine(sum);


            //int[,] arr = new int[3, 3]
            //{
            //{1, 2, -3 },
            //{ -4, 5, 6 },
            //{ 7, -8, 9}
            //};
            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int K = 0; K < arr.GetLength(1); K++)
            //    {
            //        if (arr[i, K] <0)
            //        {
            //            Console.WriteLine(arr[i, K]);
            //        }
            //    }
            //}

         
            int[,] arr = new int[2, 2]
            {
                {1, 2 },
                {3, 4 }
            };
            int max = arr[0, 0];

            int min = arr[0, 0];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] < min)
                    {
                        min = arr[i, j];
                        
                    }
                    if (arr[i, j] > max)
                    {
                        max = arr[i, j];

                    }
                }
            }
            //Console.WriteLine($"max {max} and min {min}");
            Console.WriteLine("max "+max+" min "+min);
        }
    }
}
