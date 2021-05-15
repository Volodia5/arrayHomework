using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minimumNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            Random random = new Random();
            int min = int.MaxValue;
            int minIndex = 0;
            int position = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(0, 99 + 1);
                Console.Write(numbers[i] + " ");
                if (min > numbers[i])
                {
                    min = numbers[i];
                    minIndex = i;
                    position = i;
                }
            }
            Console.WriteLine();
            int temp = numbers[minIndex];
            Console.WriteLine($"Минимальное число {numbers[minIndex]} , которое стоит на {position + 1} месте");
            Console.ReadKey();
        }
    }
}

