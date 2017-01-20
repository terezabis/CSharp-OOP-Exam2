using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exam_10_July_2016
{
    public class ExpressSoftware : Software
    {
        private const string Type = "Express";

        public ExpressSoftware(string nameOfHardware, string name, string type, int capacityConsumption, int memoryConsumption) 
            : base(nameOfHardware, name, Type, capacityConsumption, memoryConsumption)
        {
        }

        public override int Memory
        {
            get
            {
                return this.MemoryConsumption * 2;
            }
        }
    }
}