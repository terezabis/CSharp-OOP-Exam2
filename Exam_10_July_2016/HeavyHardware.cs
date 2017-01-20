using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exam_10_July_2016
{
    public class HeavyHardware : Hardware
    {
        private const string Type = "Heavy";

        public HeavyHardware(string name, string type, int maxCapacity, int maxMemory)
            : base(name, Type, maxCapacity, maxMemory)
        {
        }

        public override int Capacity
        {
            get
            {
                return this.MaxCapacity * 2;
            }
        }

        public override int Memory
        {
            get
            {
                return this.MaxMemory - (this.MaxMemory / 4);
            }
        }
    }
}