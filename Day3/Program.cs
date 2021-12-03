using System;
using System.Collections.Generic;
using System.IO;

namespace Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Users\miked\source\repos\AdventOfCode2021\Day3\input.txt";
            var report = File.ReadAllLines(path);
            var o2list = new List<string>(report);
            var co2list = new List<string>(report);
            var toberemoved = new List<string>();

            var gamma = 0;

            for (int i = 0; i < report[0].Length; i++)
            {
                foreach (var item in o2list)
                {
                    if (item[i] == '1') gamma++;
                    else gamma--;
                }
                if (gamma > 0) 
                {
                    foreach (var item in o2list)
                    {
                        if (item[i] == '0') toberemoved.Add(item);
                    }
                }
                else if(gamma == 0)
                {
                    foreach (var item in o2list)
                    {
                        if (item[i] == '0') toberemoved.Add(item);
                    }
                }
                else
                {
                    foreach (var item in o2list)
                    {
                        if (item[i] == '1') toberemoved.Add(item);
                    }
                }
                foreach (var item in toberemoved)
                {
                    o2list.Remove(item);
                }
                toberemoved = new List<string>();
                gamma = 0;
            }

            int value1 = Convert.ToInt32(o2list[0], 2);


            for (int i = 0; i < report[0].Length; i++)
            {
                foreach (var item in co2list)
                {
                    if (item[i] == '1') gamma++;
                    else gamma--;
                }
                if (gamma > 0)
                {
                    foreach (var item in co2list)
                    {
                        if (item[i] == '1') toberemoved.Add(item);
                    }
                }
                else if (gamma == 0)
                {
                    foreach (var item in co2list)
                    {
                        if (item[i] == '1') toberemoved.Add(item);
                    }
                }
                else
                {
                    foreach (var item in co2list)
                    {
                        if (item[i] == '0') toberemoved.Add(item);
                    }
                }
                foreach (var item in toberemoved)
                {
                    co2list.Remove(item);
                }
                toberemoved = new List<string>();
                gamma = 0;
                if (co2list.Count == 1) break;
            }

            int value2 = Convert.ToInt32(co2list[0], 2);

            Console.WriteLine($"Result Day3: {value1 * value2}");
            Console.ReadKey();
        }
    }
}
