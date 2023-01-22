using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> GetCube()
            {
                int answer = 0; int n = 100;
                Dictionary<int, string> answers = new Dictionary<int, string>();
                for (int i = 0; i < n; i++)
                {
                    for (int j = i + 1; j < n; j++)
                    {
                        for (int k = j + 1; k < n; k++)
                        {
                            answer = k * k + j * j + i * i;
                            string answ = $"{i} {j} {k}|";
                            if (answers.ContainsKey(answer))
                            {
                                answers[answer] += answ;
                            }
                            else
                            {
                                answers.Add(answer, answ);
                            }
                        }
                    }
                }
                return answers;
            }
            string[] GetMagicalCube(string Cube)
            {
                string[] open = Cube.Split('|');
                int count = 0;
                int whatstruct = 0;
                int y = 0;
                int joker = 7;
                int iter = 0;
                while (joker != 6 && iter < 4)
                {
                    iter++;
                    joker = 0;
                    foreach (var x in open)
                    {
                        string[] a = x.Split(' ');
                        if (a.Length == 1) { whatstruct++; continue; }
                        if (a.Length == 3) { joker++; }
                        for (int i = 0; i < a.Length; i++)
                        {
                            for (y = 0; y < open.Length - 1; y++)
                            {
                                if (open[y] == "Erorr")
                                { continue; }
                                int[] Masha = open[y].Split(' ').Where(h => !string.IsNullOrWhiteSpace(h)).Select(h => int.Parse(h)).ToArray();
                                for (int t = 0; t < Masha.Length; t++)
                                {
                                    if (Masha[t] == int.Parse(a[i]))
                                    {
                                        count++;
                                    }
                                }
                            }
                            if (count < 2)
                            {
                                open[whatstruct] = "Erorr";
                                continue;
                            }
                            count = 0;
                        }
                        whatstruct++;
                    }
                    whatstruct = 0;
                }

                return open.Where(x => x != "Erorr").ToArray();
            }
            void WriteMagicalCube(string[] Cube, int value)
            {
                if (Cube.GetLength(0) >= 6)
                {
                    Console.WriteLine("Summa is " + value + "\n----------------------------------");
                    foreach (var item in Cube)
                    {
                        Console.WriteLine(item);

                        if (item == "")
                        {
                            Console.ReadLine();
                        }

                    }
                    Console.WriteLine("\n----------------------------------\n");
                }


            }

            foreach (var item in GetCube())
            {
                WriteMagicalCube(GetMagicalCube(item.Value), item.Key);
            }

            Console.WriteLine("It's all");
            Console.ReadLine();
        }
    }
}
