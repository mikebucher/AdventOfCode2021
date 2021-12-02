using System;
using System.Collections.Generic;
using System.IO;

namespace Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Users\miked\source\repos\AdventOfCode2021\Day2\input.txt";
            var instructions = File.ReadAllLines(path);
            var instructionlist = new List<string>(instructions);

            int depth = 0;
            int aim = 0;
            int pos = 0;

            foreach (var item in instructionlist)
            {
                var ins = item.Split(' ');

                switch (ins[0])
                {
                    case "forward":
                        pos += Convert.ToInt32(ins[1]);
                        depth += (aim * Convert.ToInt32(ins[1]));
                        break;
                    case "up":
                        aim -= Convert.ToInt32(ins[1]);
                        break;
                    case "down":
                        aim += Convert.ToInt32(ins[1]);
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine($"Result Day2: {depth * pos}");
            Console.ReadKey();

        }
    }
}
