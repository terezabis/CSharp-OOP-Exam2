using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exam_10_July_2016
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Sistem> sistem = new List<Sistem>();
            while (input != "System Split")
            {
                try
                {
                    Sistem entity = SistemFactory.CreateSistem(input);
                    sistem.Add(entity);
                }
                catch (Exception)
                {
                }

                if (input == "ReleaseSoftwareComponent")
                {
                    string pattern = @"[A-Z][A-Za-z]+\((.+)\)";
                    Regex regex = new Regex(pattern);
                    MatchCollection matches = regex.Matches(input);
                    if (regex.IsMatch(input))
                    {
                        string[] hardwareAndSoftware = matches[0].Groups[1].Value.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                            .ToArray();
                        //sistem =  sistem.RemoveComponent(hardwareAndSoftware[0], hardwareAndSoftware[1]);
                    }
                }
                else if (input == "Analyze()")
                {
                    Console.WriteLine("System Analysis");
                    Console.WriteLine($"Hardware Components: {sistem.Sum(x => x.HardwareComponents)}");
                    Console.WriteLine($"Software Components: {sistem.Sum(x => x.SoftwareComponents)}");
                    Console.WriteLine($"Total Operational Memory: {sistem.Sum(x => x.TotalMemoryTaken)} / {sistem.Sum(x => x.TotalMemory)}");
                    Console.WriteLine($"Total Capacity Taken: {sistem.Sum(x => x.TotalCapacityTaken)} / {sistem.Sum(x => x.TotalCapacity)}");
                }

                input = Console.ReadLine();
            }

            foreach (var component in sistem)
            {
                
            }
        }
    }
}
