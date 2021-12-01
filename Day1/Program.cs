using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace ConsoleApp1
{
    class Day1
    {
        //part 1
        //static void Main(string[] args)
        //{
        //    var path = @"C:\Users\miked\source\repos\AdventOfCode2021\ConsoleApp1\input.txt";
        //    var depths = File.ReadAllLines(path);
        //    var depthlist = depths.Select(int.Parse).ToList();

        //    int result = 0;

        //    for (int i = 0; i < depthlist.Count - 1; i++)
        //    {
        //        if (depthlist[i] < depthlist[i + 1]) result++;
        //    }

        //    Console.WriteLine($"Result Part1: {result}");
        //    Console.ReadKey();
        //}

        //part 2
        static void Main(string[] args)
        {
            var path = @"C:\Users\miked\source\repos\AdventOfCode2021\ConsoleApp1\input.txt";
            var depths = File.ReadAllLines(path);
            var depthlist = depths.Select(int.Parse).ToList();

            int result = 0;

            for (int i = 0; i < depthlist.Count - 3; i++)
            {
                if (depthlist[i] + depthlist[i + 1] + depthlist[i + 2] < depthlist[i + 1] + depthlist[i + 2] + depthlist[i + 3]) result++;
            }

            Console.WriteLine($"Result Part2: {result}");
            Console.ReadKey();
        }
    }
}
