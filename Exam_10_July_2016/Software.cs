using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exam_10_July_2016
{
    public abstract class Software : Sistem
    {
        private string nameOfHardware;
        private string name;
        private string type;

        public Software(string nameOfHardware, string name, string type, int capacityConsumption, int memoryConsumption)
            : base(capacityConsumption, memoryConsumption)
        {
            this.nameOfHardware = nameOfHardware;
            this.name = name;
            this.type = type;
            this.CapacityConsumption = capacityConsumption;
            this.MemoryConsumption = memoryConsumption;
        }

        public virtual int CapacityConsumption
        {
            get; set;
        }

        public virtual int MemoryConsumption
        {
            get; set;
        }

        public override int SoftwareComponents
        {
            get
            {
                return 1 + base.SoftwareComponents;
            }
        }

        public override int TotalCapacityTaken
        {
            get
            {
                return base.TotalCapacityTaken - this.CapacityConsumption;
            }
        }

        public override int TotalMemoryTaken
        {
            get
            {
                return base.TotalMemoryTaken - this.MemoryConsumption;
            }
        }

    }
}