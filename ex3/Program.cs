using System;

namespace ex3
{
    class Program
    {
        static void shellSort(int[] arr, int n)
        {
            int i, j, pos, temp;
            pos = 3;
            while (pos > 0)
            {
                for (i = 0; i < n; i++)
                {
                    j = i;
                    temp = arr[i];
                    while ((j >= pos) && (arr[j - pos] > temp))
                    {
                        arr[j] = arr[j - pos];
                        j = j - pos;
                    }
                    arr[j] = temp;
                }
                try
                {
                    if (pos / 2 != 0)
                        pos = pos / 2;
                    else if (pos == 1)
                        pos = 0;
                    else
                        pos = 1;
                }
                catch
                {
                    Console.WriteLine("An exception");
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter lenth of array: ");
            int lenth = Convert.ToInt32(Console.ReadLine());
            int[] myArray = new int[lenth];
            Random rand = new Random();

            for (int x = 0; x < myArray.Length; x++)
            {
                myArray[x] = rand.Next(100);
                Console.WriteLine("Array element value: " + x + " = " + myArray[x]);
            }
            int n = myArray.Length;
            int i;
            Console.WriteLine("Shell Sort");
            Console.Write("Initial array is: ");
            for (i = 0; i < n; i++)
            {
                Console.Write(myArray[i] + " ");
            }
            shellSort(myArray, n);
            Console.Write("\nSorted Array is: ");
            for (i = 0; i < n; i++)
            {
                Console.Write(myArray[i] + " ");
            }

            Console.ReadKey();
        }
    }
}
