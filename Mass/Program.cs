using System.Runtime.Serialization.Formatters;
using System.Security.Cryptography.X509Certificates;

namespace Mass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число n:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[n, n];
            int positive_numbers = 0;
            int negative_numbers = 0;
            Console.WriteLine("Введите элементы массива:");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }
            foreach (int number in array) {
                if (number > 0) positive_numbers++;
                else if(number < 0) negative_numbers++;
            }
            int[] array1 = new int[positive_numbers];
            int[] array2 = new int[negative_numbers];
            int positive_pos = 0;
            int negative_pos = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > 0)
                    {
                        array1[positive_pos] = array[i, j];
                        positive_pos++;
                    }
                    else if (array[i, j] < 0)
                    {
                        array2[negative_pos] = array[i, j];
                        negative_pos++;
                    }
                }
            }
            Console.WriteLine("Массив содержащий положительные числа: ");
            foreach (int i in array1)
                Console.Write($"{i} ");

            Console.WriteLine();
            Console.WriteLine("Массив содержащий отрицательыне числа: ");
            foreach (int i in array2)
                Console.Write($"{i} ");
        }
    }
}
