using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exam_10_July_2016
{
    public class LightSoftware : Software
    {
        private const string Type = "Light";

        public LightSoftware(string nameOfHardware, string name, string type, int capacityConsumption, int memoryConsumption) 
            : base(nameOfHardware, name, Type, capacityConsumption, memoryConsumption)
        {
        }

        public override int Capacity
        {
            get
            {
                return this.CapacityConsumption + (this.CapacityConsumption * 2);
            }
        }

        public override int Memory
        {
            get
            {
                return this.MemoryConsumption - (this.MemoryConsumption / 2);
            }
        }
    }
}