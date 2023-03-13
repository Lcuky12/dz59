using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp57
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int minNumber = 1;
            int maxNumber = 100;
            int number = 2;
            int numberRandom;
            int degreeNumber = 0;
            int degree = 1;

            numberRandom = random.Next(minNumber, maxNumber + 1);

            while (numberRandom >= degree)
            {
                degreeNumber++;
                degree *= number;
            }

            Console.WriteLine($"Рандомное число {numberRandom} будет {number} в степени {degreeNumber} то есть {degree} которое больше рандомного числа {numberRandom} ");
        }
    }
}