using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Магический_квадрат
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
                int count2 = 0;
                int count3 = 0;
                int count4 = 0;
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
                            if (count > 3)
                                {
                                    count4++;
                                }
                            else if (count > 2)
                            {
                                count3++;
                            }
                            else if (count > 1)
                            {
                                count2++;
                            }
                            
                            //else
                            //{
                            //    //Console.WriteLine(open[whatstruct] + " " + count);
                            //    open[whatstruct] = "Erorr";
                            //    continue;
                            //}
                            count = 0;
                            
                        }
                        
                        whatstruct++;
                    }
                    if (count3 >= 4 && count4 >= 1 && count2 >= 4)
                    {
                        return open;
                    }
                    count2 = 0;
                    count3 = 0;
                    count4 = 0;
                    whatstruct = 0;
                }
                return null;
            }
            void WriteMagicalCube(string[] Cube, int value)
            {
                Console.WriteLine("Summa is " + value + "\n----------------------------------\n");
                foreach (var item in Cube)
                    if(item != "Erorr" && item != "")
                    { Console.WriteLine(item);
                      Console.ReadLine();}    
                        
                Console.WriteLine("\n----------------------------------\n");
            }

            Dictionary<int, string> AllCubes = GetCube();
            /*foreach (var item in AllCubes)
            {
                if (item.Value.Length > 6 * 6 - 1)
                {
                    string[] CubeAnswer = GetMagicalCube(item.Value);
                    Console.WriteLine(item.Value);
                    WriteMagicalCube(CubeAnswer, item.Key);
                }
            }*/

            WriteMagicalCube(GetMagicalCube("44 74 9|77 63 9|90 81 86|44 74 3|77 63 9|90 81 86|44 83 86|3 63 90|44 63 2"), 9999);






            Console.WriteLine("Vse");
            Console.ReadLine();
        }
    }
}
/*
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
                    if (a.Length == 3) {joker++; }
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
                            //Console.WriteLine(open[whatstruct] + " " + count);
                            open[whatstruct] = "Erorr";
                            continue;
                        }
                        count = 0;
                    }
                    whatstruct++;
                }
                whatstruct = 0;
            }
                return open;
            }
            
            */