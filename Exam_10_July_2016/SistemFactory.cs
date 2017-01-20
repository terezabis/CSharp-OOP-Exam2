using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exam_10_July_2016
{
    class SistemFactory
    {
        public static Sistem CreateSistem(string input)
        {
            string pattern = @"(Register)([A-Z][a-z]+)([A-Z][a-z]+)\((.+)\)";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);

            if (regex.IsMatch(input))
            {
                string sistemComponentType = matches[0].Groups[2].Value;

                if (sistemComponentType == "Power")
                {
                    return RegisterPowerHardware(matches);
                }
                else if (sistemComponentType == "Heavy")
                {
                    return RegisterHeavyHardware(matches);
                }
                else if (sistemComponentType == "Express")
                {
                    return RegisterExpressSoftware(matches);
                }
                else if (sistemComponentType == "Light")
                {
                    return RegisterLightSoftware(matches);
                }
                else
                {
                    throw new ArgumentException();
                }
            }
            throw new ArgumentException("Invalid household.");
        }

        private static Sistem RegisterLightSoftware(MatchCollection matches)
        {
            string[] characteristics = matches[0].Groups[4].Value.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            return new LightSoftware(characteristics[0], characteristics[1], matches[0].Groups[2].Value, int.Parse(characteristics[2]), int.Parse(characteristics[3]));
        }

        private static Sistem RegisterExpressSoftware(MatchCollection matches)
        {
            string[] characteristics = matches[0].Groups[4].Value.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            return new ExpressSoftware(characteristics[0], characteristics[1], matches[0].Groups[2].Value, int.Parse(characteristics[2]), int.Parse(characteristics[3]));
        }

        private static Sistem RegisterPowerHardware(MatchCollection matches)
        {
            string[] characteristics = matches[0].Groups[4].Value.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            return new PowerHardware(characteristics[0], matches[0].Groups[2].Value, int.Parse(characteristics[1]), int.Parse(characteristics[2]));
        }

        private static Sistem RegisterHeavyHardware(MatchCollection matches)
        {
            string[] characteristics = matches[0].Groups[4].Value.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            return new HeavyHardware(characteristics[0], matches[0].Groups[2].Value, int.Parse(characteristics[1]), int.Parse(characteristics[2]));
        }
    }
}
