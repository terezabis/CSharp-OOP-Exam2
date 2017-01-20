using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exam_10_July_2016
{
    public class PowerHardware : Hardware
    {
        const string Type = "Power";

        public PowerHardware(string name, string type, int maxCapacity, int maxMemory) 
            : base(name, Type, maxCapacity, maxMemory)
        {
        }

        public override int Capacity
        {
            get
            {
                return this.MaxCapacity - ((this.MaxCapacity * 3) /4);
            }
        }

        public override int Memory
        {
            get
            {
                return this.MaxMemory + ((this.MaxMemory * 3) / 4);
            }
        }
    }
}