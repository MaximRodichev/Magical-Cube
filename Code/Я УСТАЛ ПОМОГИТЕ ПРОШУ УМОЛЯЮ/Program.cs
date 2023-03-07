using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Я_УСТАЛ_ПОМОГИТЕ_ПРОШУ_УМОЛЯЮ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1st Task
            int[] home = new int[8];
            for (int i = 0; i < home.Length; i++)
            {
                Console.Write($"home[{i}] == ");
                home[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Your array!");
            foreach (int i in home)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("End");
            Console.ReadLine();

            //2nd Task
            int n = 10;
            float[] mass = new float[n];
            Random rand = new Random();
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = rand.Next(-100, 100);
            }
            Console.WriteLine("Array will be generated\nYour massive with only positivi numbers");
            foreach (var i in mass)
                if (i > 0)
                {
                    Console.WriteLine(i);
                }

            Console.WriteLine("All");
            Console.ReadLine();

            //3rd task
            int[] numbers = { -7, 10, 5, 16, -4, 18 };
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                Console.WriteLine($"On index {i} mass have == {numbers[i]}");
            }
            Console.ReadLine();

            //4th task
            int k = 12;
            int[] height = new int[k];
            Random randHeight = new Random();
            for (int i = 0; i < height.Length; i++)
            {
                height[i] = randHeight.Next(163, 190);
            }
            Console.WriteLine($"All Heights of {k} people\n");
            foreach (int i in height)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("ITS ALL TASKS");
            Console.ReadLine();
        }
    }
}
