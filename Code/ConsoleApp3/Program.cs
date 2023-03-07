using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1st
            //    int[] numbers = new int[6];
            //    Random rand = new Random();
            //    for (int i = 0; i < numbers.Length; i++)
            //    {
            //        numbers[i] = rand.Next(0, 3);
            //        if (numbers[i] == numbers[0] && i>0)
            //        {
            //            Console.WriteLine($"Po index {i} nahoditsya element == pervomy, eto ({numbers[i]} and {numbers[0]})");
            //        }
            //    }
            //    foreach (int i in numbers)
            //        Console.WriteLine(i);
            //    Console.WriteLine("1st task done");
            //    Console.ReadLine();

            //// 2nd task
            //int[] mass = new int[10];
            //Random random = new Random();
            //for (int i = 0; i < mass.Length; i++)
            //    mass[i] = random.Next(-100,200);

            //Console.WriteLine("All non negative numbers");
            //for (int i = 0; i < mass.Length; i++)
            //{
            //    if (mass[i] > 0)
            //    {
            //        Console.WriteLine(mass[i]);
            //    }
            //}
            //Console.WriteLine("All numbers below than 100");
            //for (int i = 0; i < mass.Length; i++)
            //{
            //    if (mass[i] < 100)
            //    {
            //        Console.WriteLine(mass[i]);
            //    }
            //}
            //Console.WriteLine("All 2n numbers");
            //for (int i = 0; i < mass.Length; i++)
            //{
            //    if (mass[i] % 2 == 0)
            //    {
            //        Console.WriteLine(mass[i]);
            //    }
            //}
            //Console.WriteLine("task 2 end");

            ////3rd
            //int[] num = { 5, -3, 4, -8, -9, 1, 9, 6, -3, 4, 8, 2 };
            //int iter=0;
            //for(int i = 0; i < num.Length; i++)
            //    if (num[i] < 0)
            //        iter += 1;

            //Console.WriteLine($"In mass {iter} negatibe numbers");
            //Console.WriteLine("task 3 end");

            ////4th task
            //int[] mass = new int[10];
            //Random random = new Random();
            //int sum = 0;
            //int iter = 0;
            //for (int i = 0; i < mass.Length; i++)
            //{ mass[i] = random.Next(-10, 10);
            //    if (mass[i] < 0)
            //        iter++;
            //        sum += mass[i];
            //        }
            //foreach (int i in mass)
            //    Console.WriteLine(i);
            //Console.WriteLine($"Summ of elements it {sum}\nTotal numbers - {iter}\nAverage == {(double)sum/iter:f2}");

            ////5th
            //int[] mass = new int[10];
            //Random random = new Random();
            //for (int i = 0; i < mass.Length; i++)
            //{
            //    mass[i] = random.Next(-10, 10);
            //    Console.WriteLine($"Old == {mass[i]}\nNew =={mass[i]*5}" );
            //    mass[i] = mass[i] * 5;
            //}

            Console.ReadLine();
        }
    }
}
